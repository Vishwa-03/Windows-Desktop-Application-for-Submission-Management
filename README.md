# Windows Desktop Application for Submission Management (Slidely Task 2 - FrontEnd)

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

## Features
-![main form](https://github.com/Vishwa-03/Slidely-Task-2-FrontEnd/assets/103726736/95c07bf7-2479-41b3-9777-447d39e4ef4b)

- **Create New Submission:**
  - Input fields for Name, Email, Phone Number, GitHub link.
  - Stopwatch functionality to track time spent.
  - Submit button to send data to the backend.
  - ![create submission form](https://github.com/Vishwa-03/Slidely-Task-2-FrontEnd/assets/103726736/96e2a214-da04-46e3-bdba-71f7112152f4)


- **View Submissions:**
  - Navigation through submitted forms using "Previous" and "Next" buttons.
  - Edit and delete functionalities for submitted forms.
  - Search submissions by email.
  - ![view submission form](https://github.com/Vishwa-03/Slidely-Task-2-FrontEnd/assets/103726736/fece4f33-8c38-4bb6-b45d-fe7f25086cf4)

    

## Getting Started

### Prerequisites

To run this application, you need to have the following installed:

- Visual Studio (version)
- .NET Framework (version)

### Installation

Follow these steps to install and run the application:

1. **Clone the repository:**

git clone https://github.com/Vishwa03/Slidely-Task-2-FrontEnd

2. **Open the project in Visual Studio:**

- Navigate to the project folder and open the solution file (.sln) in Visual Studio.

3. **Build and Run:**

- Build the solution to restore packages and resolve dependencies.
- Start the application from Visual Studio.

4. **Start the Backend Server:**

- Clone the backend repository from [Backend Repository](https://github.com/Vishwa-03/Slidely-task-2-backend).
- Follow the backend README for installation and startup instructions.

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
