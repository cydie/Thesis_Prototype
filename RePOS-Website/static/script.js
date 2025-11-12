// Password visibility toggle
function togglePassword(inputId) {
    const input = document.getElementById(inputId);
    if (input.type === 'password') {
        input.type = 'text';
    } else {
        input.type = 'password';
    }
}

// System control functions
async function startSystem() {
    try {
        const response = await fetch('/api/system/start', {
            method: 'POST',
            headers: {
                'Content-Type': 'application/json'
            }
        });
        const data = await response.json();
        updateSystemStatus(data.system_status);
    } catch (error) {
        console.error('Error starting system:', error);
    }
}

async function pauseSystem() {
    try {
        const response = await fetch('/api/system/pause', {
            method: 'POST',
            headers: {
                'Content-Type': 'application/json'
            }
        });
        const data = await response.json();
        updateSystemStatus(data.system_status);
    } catch (error) {
        console.error('Error pausing system:', error);
    }
}

async function stopSystem() {
    try {
        const response = await fetch('/api/system/stop', {
            method: 'POST',
            headers: {
                'Content-Type': 'application/json'
            }
        });
        const data = await response.json();
        updateSystemStatus(data.system_status);
    } catch (error) {
        console.error('Error stopping system:', error);
    }
}

function updateSystemStatus(status) {
    const statusElement = document.getElementById('statusValue');
    const statusMessage = document.querySelector('.status-message');
    if (statusElement) {
        statusElement.textContent = status;
    }
    if (statusMessage) {
        statusMessage.textContent = `[SYSTEM STATUS] System is ${status.toLowerCase()}`;
    }
}

// POS Selection
async function selectPOS(posSystem) {
    // Update UI
    const posButtons = document.querySelectorAll('.pos-btn');
    posButtons.forEach(btn => {
        if (btn.textContent === posSystem) {
            btn.classList.add('selected');
        } else {
            btn.classList.remove('selected');
        }
    });
    
    // Update selected display
    const selectedDisplay = document.getElementById('selectedPOS');
    if (selectedDisplay) {
        selectedDisplay.innerHTML = `<button class="pos-selected-btn">${posSystem}</button>`;
    }
    
    // Send to server
    try {
        const response = await fetch('/api/pos/select', {
            method: 'POST',
            headers: {
                'Content-Type': 'application/json'
            },
            body: JSON.stringify({ pos_system: posSystem })
        });
        const data = await response.json();
        console.log('POS selected:', data);
    } catch (error) {
        console.error('Error selecting POS:', error);
    }
}

// Calendar functionality
let currentDate = new Date();
let currentMonth = currentDate.getMonth();
let currentYear = currentDate.getFullYear();

function generateCalendar() {
    const calendarGrid = document.getElementById('calendarGrid');
    if (!calendarGrid) return;
    
    const monthNames = ['January', 'February', 'March', 'April', 'May', 'June',
        'July', 'August', 'September', 'October', 'November', 'December'];
    
    const monthHeader = document.getElementById('calendarMonth');
    if (monthHeader) {
        monthHeader.textContent = `${monthNames[currentMonth]} ${currentYear}`;
    }
    
    const firstDay = new Date(currentYear, currentMonth, 1).getDay();
    const daysInMonth = new Date(currentYear, currentMonth + 1, 0).getDate();
    const daysInPrevMonth = new Date(currentYear, currentMonth, 0).getDate();
    
    calendarGrid.innerHTML = '';
    
    // Day headers
    const dayHeaders = ['Su', 'Mo', 'Tu', 'We', 'Th', 'Fr', 'Sa'];
    dayHeaders.forEach(day => {
        const dayHeader = document.createElement('div');
        dayHeader.className = 'calendar-day';
        dayHeader.style.fontWeight = 'bold';
        dayHeader.style.color = 'var(--primary-green)';
        dayHeader.textContent = day;
        calendarGrid.appendChild(dayHeader);
    });
    
    // Previous month days
    for (let i = firstDay - 1; i >= 0; i--) {
        const day = document.createElement('div');
        day.className = 'calendar-day other-month';
        day.textContent = daysInPrevMonth - i;
        calendarGrid.appendChild(day);
    }
    
    // Current month days
    for (let i = 1; i <= daysInMonth; i++) {
        const day = document.createElement('div');
        day.className = 'calendar-day';
        day.textContent = i;
        
        // Highlight specific dates (example: 14 and 17)
        if (i === 14) {
            day.classList.add('selected');
        }
        if (i === 17) {
            day.classList.add('highlighted');
        }
        
        day.addEventListener('click', function() {
            selectCalendarDate(i, this);
        });
        calendarGrid.appendChild(day);
    }
    
    // Next month days to fill grid
    const totalCells = calendarGrid.children.length;
    const remainingCells = 42 - totalCells; // 6 rows * 7 days
    for (let i = 1; i <= remainingCells; i++) {
        const day = document.createElement('div');
        day.className = 'calendar-day other-month';
        day.textContent = i;
        calendarGrid.appendChild(day);
    }
}

function changeMonth(direction) {
    currentMonth += direction;
    if (currentMonth < 0) {
        currentMonth = 11;
        currentYear--;
    } else if (currentMonth > 11) {
        currentMonth = 0;
        currentYear++;
    }
    generateCalendar();
}

function selectCalendarDate(day, element) {
    const calendarDays = document.querySelectorAll('.calendar-day:not(.other-month)');
    calendarDays.forEach(d => {
        if (!d.textContent.match(/^[A-Z]/)) { // Not a day header
            d.classList.remove('selected');
        }
    });
    
    // Select the clicked day
    if (element) {
        element.classList.add('selected');
    }
    
    // Load history for selected date
    const selectedDate = `${currentYear}-${String(currentMonth + 1).padStart(2, '0')}-${String(day).padStart(2, '0')}`;
    loadHistory(selectedDate);
}

function selectDate(dateString, element) {
    const dateButtons = document.querySelectorAll('.date-btn');
    dateButtons.forEach(btn => btn.classList.remove('active'));
    if (element) {
        element.classList.add('active');
    }
    
    loadHistory(dateString);
}

async function loadHistory(date) {
    try {
        const response = await fetch(`/api/history/${date}`);
        const events = await response.json();
        
        const eventLog = document.getElementById('eventLog');
        if (eventLog) {
            if (events.length === 0) {
                eventLog.innerHTML = '<div class="event-entry" style="color: var(--text-gray);">No events for this date</div>';
            } else {
                eventLog.innerHTML = events.map(event => `
                    <div class="event-entry ${event.type}">
                        <span class="event-time">${event.timestamp}</span> - ${event.type.toUpperCase()}: ${event.message}
                    </div>
                `).join('');
            }
        }
    } catch (error) {
        console.error('Error loading history:', error);
    }
}

// Initialize calendar on history page
if (document.getElementById('calendarGrid')) {
    generateCalendar();
}

// Update resource gauges (mock data)
function updateResourceGauges() {
    const cpuGauge = document.querySelectorAll('.gauge')[0];
    const ramGauge = document.querySelectorAll('.gauge')[1];
    
    if (cpuGauge) {
        const cpuFill = cpuGauge.querySelector('.gauge-fill');
        const cpuText = cpuGauge.querySelector('.gauge-text');
        const cpuPercent = 20;
        const circumference = 2 * Math.PI * 50;
        const offset = circumference - (cpuPercent / 100) * circumference;
        if (cpuFill) {
            cpuFill.style.strokeDashoffset = offset;
        }
        if (cpuText) {
            cpuText.textContent = `${cpuPercent}% CPU`;
        }
    }
    
    if (ramGauge) {
        const ramFill = ramGauge.querySelector('.gauge-fill');
        const ramText = ramGauge.querySelector('.gauge-text');
        const ramPercent = 40;
        const circumference = 2 * Math.PI * 50;
        const offset = circumference - (ramPercent / 100) * circumference;
        if (ramFill) {
            ramFill.style.strokeDashoffset = offset;
        }
        if (ramText) {
            ramText.textContent = `${ramPercent}% RAM`;
        }
    }
}

// Initialize gauges
if (document.querySelector('.gauge')) {
    updateResourceGauges();
}

