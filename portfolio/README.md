# IT ELECTIVE 2 - MVC PORTFOLIO

## Student Information

**Student Name:** Danielle-Allyne Marcos  
**Course:** Bachelor of Science in Information Technology  
**Section:** BSIT 31E3

---

## About the Project

This project is a modern personal portfolio created using ASP.NET Core MVC.

It showcases my projects, short project descriptions, GitHub repository links, and thumbnail images from the applications I created during my studies.

The portfolio also includes a hardcoded login system, project table of contents, individual project detail pages, and a comment section for each project.

---

## Technologies Used

- ASP.NET Core MVC
- C#
- .NET
- Razor Views
- HTML
- CSS
- Bootstrap
- JavaScript

---

## Features

- Hardcoded Login
- Session-based login
- Protected portfolio pages
- Modern portfolio interface
- Home page
- About Me page
- Projects page
- Project table of contents
- Project thumbnail images
- GitHub repository links
- Individual project detail pages
- Comment section for every project
- Responsive design

---

## Login Details

The application uses a hardcoded login for demonstration purposes.

**Username:** `dani`

**Password:** `Dani123`

---

## Projects

### 1. Prelim Quiz 1

A web-based project created for the IT Elective 2 preliminary activity.

**GitHub Repository:**  
https://github.com/daniellemarcos3/BSIT_31E3_PRELIM_Q1_MARCOS_DANIELLE-ALLYNE

---

### 2. Midterm Activity 1

An ASP.NET Core MVC project created as part of the IT Elective 2 midterm activities.

**GitHub Repository:**  
https://github.com/daniellemarcos3/IT_ELECTIVE_2_Midterm_A1_Marcos_Danielle-Allyne

---

### 3. Midterm Quiz 2

A web application project developed for the second midterm quiz.

**GitHub Repository:**  
https://github.com/daniellemarcos3/IT_ELECTIVE_2_MIDTERM_Q2_Marcos_DanielleAllyne

---

### 4. Midterm Quiz 3

An ASP.NET Core MVC application created for the third midterm quiz.

**GitHub Repository:**  
https://github.com/daniellemarcos3/IT_ELECTIVE_2_MIDTERM_Q3

---

### 5. Portfolio

A personal portfolio website created using ASP.NET Core MVC to showcase projects and skills.

**GitHub Repository:**  
https://github.com/daniellemarcos3/Portfolio

---

### 6. Point of Sales

A simple point-of-sale web application for managing products and shopping cart transactions.

**GitHub Repository:**  
https://github.com/daniellemarcos3/Point-of-Sales

---

## Project Structure

```text
Portfolio
│
├── Controllers
│   ├── AccountController.cs
│   ├── HomeController.cs
│   └── ProjectsController.cs
│
├── Models
│   ├── Project.cs
│   └── Comment.cs
│
├── Views
│   ├── Account
│   │   └── Login.cshtml
│   │
│   ├── Home
│   │   ├── Index.cshtml
│   │   └── About.cshtml
│   │
│   ├── Projects
│   │   ├── Index.cshtml
│   │   └── Details.cshtml
│   │
│   └── Shared
│       └── _Layout.cshtml
│
├── wwwroot
│   ├── css
│   ├── js
│   └── images
│
├── Program.cs
└── README.md

Purpose

The purpose of this project is to demonstrate my understanding of ASP.NET Core MVC by creating a functional portfolio application that organizes and presents my previous projects in one place.

It also demonstrates the use of MVC controllers, models, Razor views, session-based login, project details, comments, and responsive web design.

Security Note

The login credentials are hardcoded because this is a school project requirement.

Session-based authentication is used to prevent access to the portfolio pages without logging in.

This authentication approach is intended for demonstration purposes and should not be used for a production application.

Author

Danielle Allyne O. Marcos
BSIT 31E3