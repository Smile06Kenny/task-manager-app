\# Task Manager Application



This project implements a simple task management system composed of a mobile application and a backend API.



The system allows users to:



\- View tasks

\- Filter tasks by status and priority

\- View task details



---



\# Technologies



\## Backend

\- .NET 8 Web API

\- Dapper

\- PostgreSQL

\- NLog



\## Mobile

\- React Native

\- Axios

\- React Navigation



---



\# Project Structure

task-manager-app

│

├── backend

│ └── Tasks.API

│

├── mobile

│ └── TaskApp

│

├── database

│ └── schema.sql

│

├── docs

│ └── architecture.md

│

└── README.md



\# Setup Instructions



\## 1. Database Setup



Install PostgreSQL and execute the SQL script:
database/schema.sql
This script creates:

\- tasks table

\- sample data

\- stored function



---



\## 2. Backend Setup



Navigate to the backend folder:

cd backend/Tasks.API



Run the API:
donet run



The API will run on:

http://localhost:1048




---



\## 3. Mobile App Setup



Navigate to the mobile application folder:




---



\## 3. Mobile App Setup



Navigate to the mobile application folder:



Install dependencies: 
npm install



Run the Android app:

npx react-native run-Android



\# Architecture Documentation



Detailed architecture documentation is available at:

docs/architecture.md



