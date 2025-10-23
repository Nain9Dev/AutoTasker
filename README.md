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
