# Windows Desktop Application for Submission Management

This Windows desktop application allows users to create new submissions with name, email, phone number, GitHub link, and a stopwatch feature. It also provides functionality to view, edit, delete, and search submissions stored on a backend server.

## Table of Contents

- [Features](#features)
- [Getting Started](#getting-started)
  - [Prerequisites](#prerequisites)
  - [Installation](#installation)
- [Usage](#usage)
  - [Creating Submissions](#creating-submissions)
  - [Viewing Submissions](#viewing-submissions)
- [Keyboard Shortcuts](#keyboard-shortcuts)
- [Contributing](#contributing)
- [License](#license)

## Features

- **Create New Submission:**
  - Input fields for Name, Email, Phone Number, GitHub link.
  - Stopwatch functionality to track time spent.
  - Submit button to send data to the backend.

- **View Submissions:**
  - Navigation through submitted forms using "Previous" and "Next" buttons.
  - Edit and delete functionalities for submitted forms.
  - Search submissions by email.

## Getting Started

### Prerequisites

To run this application, you need to have the following installed:

- Visual Studio (version)
- .NET Framework (version)
- Node.js and npm (for backend server)

### Installation
2. **Open the project in Visual Studio:**

- Navigate to the project folder and open the solution file (.sln) in Visual Studio.

3. **Build and Run:**

- Build the solution to restore packages and resolve dependencies.
- Start the application from Visual Studio.

4. **Start the Backend Server:**

- Navigate to the `backend` directory in the cloned repository.
- Install dependencies:

  ```
  npm install
  ```

- Start the server:

  ```
  npm start
  ```

Ensure the backend server is running at `http://localhost:3000`.

## Usage

### Creating Submissions

1. Launch the application.
2. Click on "Create New Submission" or use the shortcut Ctrl + N.
3. Fill in all required fields (Name, Email, Phone Number, GitHub link).
4. Toggle the stopwatch with Ctrl + T to track time.
5. Submit the form with Ctrl + S.

### Viewing Submissions

1. Click on "View Submissions" or use the shortcut Ctrl + V.
2. Navigate through submissions using "Previous" (Ctrl + P) and "Next" (Ctrl + N) buttons.
3. Edit a submission with Ctrl + E, delete with Ctrl + D, or search by email with Ctrl + F.

## Keyboard Shortcuts

- **Global Shortcuts:**
- Ctrl + N: Create New Submission
- Ctrl + V: View Submissions

- **Create Submission Form:**
- Ctrl + S: Submit Form
- Ctrl + T: Toggle Stopwatch

- **View Submissions Form:**
- Ctrl + P: Previous Submission
- Ctrl + N: Next Submission
- Ctrl + D: Delete Submission
- Ctrl + E: Edit Submission
- Ctrl + F: Search by Email

## Contributing

Contributions are welcome! Please follow these steps to contribute:

1. Fork the repository.
2. Create your feature branch (`git checkout -b feature/NewFeature`).
3. Commit your changes (`git commit -am 'Add new feature'`).
4. Push to the branch (`git push origin feature/NewFeature`).
5. Create a new Pull Request.

Please ensure to follow coding standards, write clear commit messages, and document any significant changes.

## License

This project is licensed under the [MIT License](LICENSE).


Follow these steps to install and run the application:

1. **Clone the repository:**

git clone https://github.com/your-username/repository-name.git
