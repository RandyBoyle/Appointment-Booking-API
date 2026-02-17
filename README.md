# Appointment-Booking-API
A simple **.NET 8 Minimal API** for managing appointment bookings.  
Built as a small, real-world example using **feature-based structure** and clean, readable code.

## 🚀 Features
- Create appointments
- View all appointments
- View a single appointment by ID
- Delete appointments

## 🛠 Tech Stack
- .NET 8
- ASP.NET Core Minimal APIs
- In-memory data store (for simplicity)

## ▶️ Running the API
1. Clone the repository
2. Open the solution in Visual Studio or VS Code
3. Run the project
4. The API will be available at:

http://localhost:5251

## 📌 Example Endpoints
```http
GET    /appointments
GET    /appointments/{id}
POST   /appointments
DELETE /appointments/{id}

## 📄 Sample Request — POST /appointments

{
  "customerName": "John Doe",
  "appointmentTime": "2026-02-01T10:00:00",
  "notes": "Initial consultation"
}

## 📄 Sample Response — POST /appointments

{
  "id": "b3c2f2e4-9f3a-4b6a-9c21-4d9c7c8a1a23",
  "customerName": "John Doe",
  "appointmentTime": "2026-02-01T10:00:00",
  "notes": "Initial consultation",
  "status": "Scheduled",
  "createdAt": "2026-01-22T15:30:00Z"
}

```

## 🎯 Purpose
This project is intentionally kept small and simple to demonstrate:
- Practical Minimal API usage
- Feature-based organization
- Readable, maintainable API design
