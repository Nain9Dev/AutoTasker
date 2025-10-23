(Answering in English, per your request).

Here is a practical and professional `README.md` template for your `AutoTasker` project. This is your project's "front door." It should be clean, clear, and show what skills you are using.

Copy and paste this directly into the `README.md` file in the root of your `AutoTasker` solution.

-----

````markdown
# AutoTasker API

A .NET 8 REST API for automating and scheduling rotating on-call duties and recurring team tasks. This project is built to demonstrate modern backend development practices, including Clean Architecture, Domain-Driven Design (DDD), and secure external API integration.

This API is the backend for the AutoTasker system, designed to be consumed by any front-end client or service.

---

## 🚀 Tech Stack

* **Framework:** .NET 8
* **Language:** C#
* **Architecture:** Clean Architecture (Domain, Application, Infrastructure, WebAPI layers)
* **Design Patterns:** Domain-Driven Design (DDD), Repository Pattern, Unit of Work
* **Database:** SQL Server (via Entity Framework Core)
* **Authentication:** Auth0 (using JWT Bearer Tokens)
* **Notifications:** SendGrid (for automated email notifications)
* **Calendar:** Google Calendar API (for scheduling assignments)
* **API Documentation:** Swagger / OpenAPI

---

## ✨ Core Features

* **Task Management:** Create, update, and delete recurring tasks (e.g., "Weekly On-Call Support").
* **Member Management:** Add and remove team members from task rotations.
* **Automatic Scheduling:** A background service automatically assigns tasks based on fair, configurable rotation rules (e.g., "do not assign the same user twice in a row").
* **Authentication & Authorization:** Secure endpoints using Auth0. Implements role-based access control (Admin vs. Member) for specific operations.
* **Email Notifications:** Integrates with **SendGrid** to automatically notify members when they have been assigned a new task.
* **Calendar Integration:** Automatically creates events in the assigned member's **Google Calendar** for their scheduled task.

---

## 🔧 Getting Started

How to get a local copy up and running for development and testing.

### Prerequisites

* [.NET 8 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/8.0)
* [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads) (LocalDB, Express, or Docker version)
* An [Auth0](https://auth0.com/) Account (for API secrets)
* A [SendGrid](https://sendgrid.com/) Account (for API secrets)
* [Google Cloud](https://cloud.google.com/) Account (for Google Calendar API credentials)

### 1. Clone the Repository

```bash
git clone [https://github.com/NainDev/AutoTasker.git](https://github.com/NainDev/AutoTasker.git)
cd AutoTasker
````

### 2\. Configure Secrets

This project uses `appsettings.Development.json` for local development.

1.  In the `AutoTasker.WebAPI` project, open `appsettings.Development.json`.
2.  Update the following sections with your own keys and connection strings:

<!-- end list -->

```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=(localdb)\\mssqllocaldb;Database=AutoTaskerDb;Trusted_Connection=True;"
  },
  "Auth0": {
    "Domain": "YOUR_AUTH0_DOMAIN",
    "Audience": "YOUR_AUTH0_API_AUDIENCE"
  },
  "SendGrid": {
    "ApiKey": "YOUR_SENDGRID_API_KEY"
  },
  "GoogleCalendar": {
    "ClientId": "YOUR_GOOGLE_CLIENT_ID",
    "ClientSecret": "YOUR_GOOGLE_CLIENT_SECRET"
  }
}
```

### 3\. Run the Database Migrations

Use the .NET CLI to create and apply the database migrations.

```bash
# Navigate to the project with the DbContext (Infrastructure)
cd AutoTasker.Infrastructure

# Apply the migrations (this will create the database)
dotnet ef database update --startup-project ../AutoTasker.WebAPI
```

### 4\. Run the API

```bash
# Navigate back to the WebAPI project
cd ../AutoTasker.WebAPI

# Run the project
dotnet watch run
```

The API will now be running at `https://localhost:XXXX`.

-----

## 📖 API Documentation

Once the API is running, full interactive documentation for all endpoints is available via Swagger UI.

Navigate to: **`https://localhost:XXXX/swagger`**

You can test all endpoints here, and you can authenticate by pasting a JWT from Auth0 into the "Authorize" dialog.

-----

## 👤 Author

**Aitor Nain Mendoza Vallejo**

  * **GitHub:** [NainDev]([https://github.com/NainDev](https://github.com/Nain9Dev))
  * **LinkedIn:** `https://www.linkedin.com/in/aitor-nain-mendoza-vallejo/`

<!-- end list -->
