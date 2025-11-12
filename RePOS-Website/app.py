from flask import Flask, render_template, request, redirect, url_for, session, jsonify
from datetime import datetime, timedelta
import json
import os

app = Flask(__name__)
app.secret_key = 'your-secret-key-change-this-in-production'

# Mock data storage (in production, use a database)
users = {}
system_status = "STOPPED"
selected_pos = None
system_logs = []
history_data = {}

# Check if logo exists
def check_logo_exists():
    logo_extensions = ['png', 'jpg', 'jpeg', 'svg', 'gif']
    for ext in logo_extensions:
        logo_path = os.path.join(app.static_folder, f'logo.{ext}')
        if os.path.exists(logo_path):
            return f'logo.{ext}'
    return None

@app.route('/')
def index():
    if 'user' in session:
        return redirect(url_for('dashboard'))
    return redirect(url_for('login'))

@app.route('/login', methods=['GET', 'POST'])
def login():
    logo_file = check_logo_exists()
    if request.method == 'POST':
        email = request.form.get('email')
        password = request.form.get('password')
        remember = request.form.get('remember')
        
        # Simple authentication (in production, use proper authentication)
        if email in users and users[email]['password'] == password:
            session['user'] = email
            if remember:
                session.permanent = True
            return redirect(url_for('dashboard'))
        else:
            return render_template('login.html', error='Invalid email or password', logo_file=logo_file, logo_exists=logo_file is not None)
    
    return render_template('login.html', logo_file=logo_file, logo_exists=logo_file is not None)

@app.route('/signup', methods=['GET', 'POST'])
def signup():
    logo_file = check_logo_exists()
    if request.method == 'POST':
        full_name = request.form.get('full_name')
        email = request.form.get('email')
        business_name = request.form.get('business_name')
        password = request.form.get('password')
        confirm_password = request.form.get('confirm_password')
        terms = request.form.get('terms')
        
        if password != confirm_password:
            return render_template('signup.html', error='Passwords do not match', logo_file=logo_file, logo_exists=logo_file is not None)
        
        if not terms:
            return render_template('signup.html', error='You must agree to the terms', logo_file=logo_file, logo_exists=logo_file is not None)
        
        if email in users:
            return render_template('signup.html', error='Email already registered', logo_file=logo_file, logo_exists=logo_file is not None)
        
        users[email] = {
            'full_name': full_name,
            'email': email,
            'business_name': business_name,
            'password': password
        }
        
        session['user'] = email
        return redirect(url_for('dashboard'))
    
    return render_template('signup.html', logo_file=logo_file, logo_exists=logo_file is not None)

@app.route('/logout')
def logout():
    session.pop('user', None)
    return redirect(url_for('login'))

@app.route('/dashboard')
def dashboard():
    if 'user' not in session:
        return redirect(url_for('login'))
    logo_file = check_logo_exists()
    return render_template('dashboard.html', 
                         system_status=system_status,
                         selected_pos=selected_pos,
                         logs=system_logs[-10:],
                         logo_file=logo_file,
                         logo_exists=logo_file is not None)

@app.route('/history')
def history():
    if 'user' not in session:
        return redirect(url_for('login'))
    logo_file = check_logo_exists()
    return render_template('history.html', history_data=history_data, logo_file=logo_file, logo_exists=logo_file is not None)

@app.route('/pos-selection')
def pos_selection():
    if 'user' not in session:
        return redirect(url_for('login'))
    logo_file = check_logo_exists()
    return render_template('pos_selection.html', selected_pos=selected_pos, logo_file=logo_file, logo_exists=logo_file is not None)

@app.route('/api/system/start', methods=['POST'])
def start_system():
    global system_status, system_logs
    system_status = "RUNNING"
    system_logs.append({
        'timestamp': datetime.now().strftime('%Y-%m-%d %H:%M:%S'),
        'status': 'SUCCESS',
        'message': 'System started successfully'
    })
    return jsonify({'status': 'success', 'system_status': system_status})

@app.route('/api/system/pause', methods=['POST'])
def pause_system():
    global system_status
    system_status = "PAUSED"
    return jsonify({'status': 'success', 'system_status': system_status})

@app.route('/api/system/stop', methods=['POST'])
def stop_system():
    global system_status
    system_status = "STOPPED"
    return jsonify({'status': 'success', 'system_status': system_status})

@app.route('/api/pos/select', methods=['POST'])
def select_pos():
    global selected_pos
    data = request.get_json()
    selected_pos = data.get('pos_system')
    return jsonify({'status': 'success', 'selected_pos': selected_pos})

@app.route('/api/history/<date>', methods=['GET'])
def get_history(date):
    if date in history_data:
        return jsonify(history_data[date])
    return jsonify([])

if __name__ == '__main__':
    app.run(debug=True, host='0.0.0.0', port=5000)

