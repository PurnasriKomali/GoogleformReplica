# GoogleformReplica
## To create a Desktop App using Visual Basic language and Backend using Express and Typescript to replicate the functionality of Google forms.
## This project is a Google Forms-like application that consists of a Windows Desktop application built using Visual Basic and a backend server built with Node.js and TypeScript. The application allows users to create new submissions and view existing submissions.
### Prerequisites
To run this project, you need the following:

Node.js (v14, v16, or v18 recommended)
npm (Node package manager)
Visual Studio (not Visual Studio Code) with Visual Basic support
.NET Framework
## Backend Setup
### Clone the Repository:
First, clone the repository to your local machine and navigate to the project directory:
git clone https://github.com/yourusername/GoogleFormsReplica-Backend.git
cd GoogleFormsReplica-Backend
### Install Dependencies:
Install the required npm packages by running:
npm install
### Create tsconfig.json:
Initialize the TypeScript configuration file with the command:
npx tsc --init
### Configure tsconfig.json:
Open the tsconfig.json file and update it with the following configuration:
{
  "compilerOptions": {
    "target": "ES6",
    "module": "commonjs",
    "outDir": "./dist",
    "rootDir": "./src",
    "strict": true,
    "esModuleInterop": true
  }
}
### Create src Directory and index.ts File:
Create the source directory and an initial TypeScript file by running:
mkdir src
cd src
echo > index.ts
### Implement API Endpoints:
Implement the necessary API endpoints in the src/index.ts file.
### Create db.json File:
In the root directory of the backend project, create a db.json file with the following initial content:
[]
### Compile and Run the Server:
Compile the TypeScript files and start the server by running:
- npx tsc
- node dist/index.js
## Frontend Setup
Open Visual Studio:
Ensure you have Visual Studio installed with Visual Basic support. Create a new Windows Forms App (.NET Framework) project in Visual Basic.

Design the Forms:

Main Form (Form1):
Add two buttons: btnViewSubmissions with the text "View Submissions" and btnCreateNewSubmission with the text "Create New Submission".

CreateSubmissionForm:
Add TextBox controls for Name, Email, Phone, and GitHub Link. Add a Button named btnStopwatch with the text "Toggle Stopwatch". Add a Label to display stopwatch time. Add a Button named btnSubmit with the text "Submit".

ViewSubmissionsForm:
Add TextBox controls to display Name, Email, Phone, GitHub Link, and Stopwatch Time. Add two buttons: btnPrevious with the text "Previous" and btnNext with the text "Next".

Add Event Handlers:
Implement the logic for the stopwatch and form submissions in CreateSubmissionForm. Implement the logic for viewing submissions in ViewSubmissionsForm.

Ensure the following features work:

Create new submissions and view existing submissions.
Keyboard shortcuts for buttons:
Alt + P for Previous
Alt + N for Next
Ctrl + S for Submit
Running the Application
Start the Backend Server:
Navigate to the backend project directory, compile the TypeScript files, and run the server:

bash
Copy code
npx tsc
node dist/index.js
Run the Windows Forms Application:
Open the frontend project in Visual Studio. Build and run the project.

API Endpoints
/ping (GET): Health check endpoint that returns true.
/submit (POST): Submits a new form entry with parameters name, email, phone, github_link, and stopwatch_time.
/read (GET): Retrieves a form entry based on the index parameter.
