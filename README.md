# UserManagementAPI

A simple **ASP.NET Core Web API** for managing users with full CRUD operations, validation, and custom middleware.  
This project was built as part of the **“Building a Simple API with Copilot”** assignment.

---

## 🚀 Features

### ✅ CRUD User Management
The API provides full CRUD functionality for user management:

- **GET** `/users` – Retrieve all users  
- **GET** `/users/{id}` – Retrieve a user by ID  
- **POST** `/users` – Create a new user  
- **PUT** `/users/{id}` – Update an existing user  
- **DELETE** `/users/{id}` – Delete a user  

---

### ✅ Input Validation
- Ensures required fields such as **Name** and **Email** are provided  
- Prevents invalid or empty user data from being processed  
- Returns clear and consistent error messages  

---

### ✅ Custom Middleware
The application includes multiple custom middleware components:

- **ErrorHandlingMiddleware**  
  Catches unhandled exceptions and returns consistent JSON error responses

- **AuthMiddleware**  
  Validates a simple Bearer token from the `Authorization` header

- **LoggingMiddleware**  
  Logs HTTP method, request path, response status code, and request duration

**Middleware execution order:**
1. Error handling  
2. Authentication  
3. Logging  

---

### ✅ Authentication
Simple token-based authentication using the `Authorization` header.

Example:
```http
Authorization: Bearer dev-token
```

---

## 🧪 Testing
- Endpoints tested using **Swagger UI**, **curl**, and **Postman**
- Swagger is enabled in **Development** mode

---

## 🛠 Technologies Used
- ASP.NET Core Web API
- .NET SDK (8 / 10)
- C#
- Swagger / OpenAPI
- In-memory data store
- Microsoft Copilot

---

## ▶️ Getting Started

### Prerequisites
- .NET SDK installed
- Visual Studio or VS Code

### Run the Application
```bash
dotnet restore
dotnet run
```

Swagger UI:
```
http://localhost:{port}/swagger
```

---

## 🤖 Copilot Usage

Microsoft Copilot was actively used during development to:

- Scaffold CRUD endpoints
- Suggest validation improvements
- Assist with debugging runtime and compile-time errors
- Help implement custom middleware (logging, authentication, error handling)
- Improve overall code structure and readability

---

## 📂 Project Structure
```
UserManagementAPI/
├── Controllers/
├── Middleware/
│   ├── ErrorHandlingMiddleware.cs
│   ├── AuthMiddleware.cs
│   └── LoggingMiddleware.cs
├── Models/
│   └── User.cs
├── Services/
│   ├── IUserStore.cs
│   └── InMemoryUserStore.cs
├── Program.cs
├── UserManagementAPI.csproj
└── README.md
```

---

## ✅ Assignment Checklist (25/25)

- ✔ GitHub repository created  
- ✔ CRUD endpoints implemented  
- ✔ Copilot used for debugging  
- ✔ Input validation included  
- ✔ Custom middleware implemented  



## Copilot usage
Microsoft Copilot was used to scaffold CRUD endpoints, suggest validation improvements, and help implement middleware (logging, error handling, and token authentication).
