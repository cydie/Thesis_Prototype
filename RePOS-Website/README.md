# RePOS - Predictive POS Maintenance System

A Flask-based web application for predictive maintenance of Point of Sale (POS) systems.

## Features

- **User Authentication**: Login and Sign Up pages with secure session management
- **Dashboard**: Real-time system monitoring with START/PAUSE/STOP controls
- **History**: Calendar-based event log viewer with date selection
- **POS Selection**: Choose from multiple POS system types
- **System Status**: Real-time status updates and resource monitoring (CPU/RAM)

## Installation

1. Install Python dependencies:
```bash
pip install -r requirements.txt
```

2. Place your logo image in the `static` folder (optional):
   - Supported formats: PNG, JPG, JPEG, SVG, GIF
   - Name it `logo.png`, `logo.jpg`, `logo.svg`, etc.
   - The application will automatically detect and use your logo
   - If no logo is found, it will display the text logo instead

3. Run the application:
```bash
python app.py
```

4. Open your browser and navigate to:
```
http://localhost:5000
```

## Project Structure

```
Thesis_Web/
├── app.py                 # Flask application and routes
├── requirements.txt       # Python dependencies
├── templates/            # HTML templates
│   ├── base.html
│   ├── login.html
│   ├── signup.html
│   ├── dashboard.html
│   ├── history.html
│   └── pos_selection.html
└── static/               # Static files
    ├── style.css         # Stylesheet
    └── script.js         # JavaScript functionality
```

## Usage

1. **Sign Up**: Create a new account with your email, business name, and password
2. **Login**: Access the dashboard with your credentials
3. **Select POS**: Choose your POS system type from the selection page
4. **Monitor**: Use the dashboard to start, pause, or stop system monitoring
5. **View History**: Check historical events and logs using the calendar

## Notes

- The application uses session-based authentication (in-memory storage)
- For production use, implement proper database storage and authentication
- Update the `secret_key` in `app.py` for production deployment
- All pages use fixed positioning with no scrolling required

## Customization

### Adding Your Logo
Simply place your logo file in the `static` folder with one of these names:
- `logo.png`
- `logo.jpg` or `logo.jpeg`
- `logo.svg`
- `logo.gif`

The application will automatically detect and use your logo on all pages. If no logo file is found, it will display the text-based logo instead.

