\# Technical Architecture



\## System Overview



The system consists of a mobile application built with React Native that communicates with a .NET Web API backend. The backend retrieves and manages data stored in a PostgreSQL database.



Mobile App (React Native)

│

Backend API (.NET 8 Web API)

│

Database (PostgreSQL)

---



\# Backend Architecture



The backend follows a layered architecture to separate responsibilities and maintain clean code organization.



Controller Layer

|

Application Layer

│

Infrastructure Layer

|

Database (PostgreSQL)



\### Layers Description



\*\*Controllers\*\*

\- Expose REST API endpoints

\- Handle HTTP requests and responses

\- Return standardized API responses



\*\*Application Layer\*\*

\- Contains interfaces and DTOs

\- Defines contracts between layers



\*\*Infrastructure Layer\*\*

\- Implements repositories

\- Handles database access using Dapper



\*\*Database\*\*

\- PostgreSQL database

\- Uses stored functions for querying tasks



---



\# Communication Flow



The communication between components works as follows:

React Native App

│

│ HTTP Requests (Axios)

.NET Web API

│

│ Dapper Queries

PostgreSQL Database



Example flow for retrieving tasks:



1\. Mobile app calls the API endpoint `/api/tasks`

2\. The controller receives the request

3\. The repository queries the database

4\. PostgreSQL executes the stored function

5\. The API returns a standardized response



---



\# Technical Decisions



\## .NET 8 Web API

Chosen for its performance, scalability, and strong ecosystem for building RESTful services.



\## PostgreSQL

Selected for its reliability, strong SQL support, and compatibility with modern backend frameworks.



\## React Native

Allows building cross-platform mobile applications using a single codebase.







