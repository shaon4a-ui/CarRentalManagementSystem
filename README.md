# Car Rental Management System

## Project Overview

The Car Rental Management System is a Windows desktop application developed using C# Windows Forms and SQL Server.

The system allows customers to browse available vehicles, view vehicle details, make bookings, and complete payments. Vehicle owners can manage their own vehicles and view booking and earnings information. Administrators can manage users, vehicles, and bookings.

The project follows Object-Oriented Programming (OOP) principles and uses a role-based system for Admin, Owner, and Customer users.

---

## Technologies Used

- C#
- Windows Forms
- .NET 10.0 LTS
- SQL Server
- SQL Server Management Studio (SSMS)
- Microsoft.Data.SqlClient
- Visual Studio
- Git and GitHub

---

## User Roles

### Customer

Customers can:

- Log in and create an account
- Browse available cars
- Search for vehicles
- Filter vehicles
- View vehicle details
- Make bookings
- Complete payments
- View their bookings
- Change their password
- Delete their account when permitted
- Log out

### Owner

Owners can:

- Log in and create an owner account
- Add vehicles
- Edit vehicles
- Manage their own vehicles
- View bookings for their vehicles
- View vehicle availability
- View total earnings
- Log out

### Admin

Administrators can:

- View and manage users
- View and manage all vehicles
- View and manage all bookings
- Log out

---

## Main Features

### Authentication

- User registration
- User login
- Role-based access
- Password hashing
- Login validation
- Duplicate username checking
- Change password
- Account deletion for eligible customers

### Vehicle Management

- Add vehicles
- Edit vehicles
- Vehicle availability management
- Vehicle search
- Vehicle filtering
- Vehicle details
- Vehicle images

### Vehicle Types

The system uses different vehicle subclasses:

- Sedan
- SUV
- Van
- Luxury

Each vehicle type can contain type-specific information.

For example:

- Sedan -> Transmission Type
- SUV -> Drive Type and Ground Clearance
- Van -> Sliding Doors and Luggage Capacity
- Luxury -> General luxury vehicle information

### Booking

Customers can select available vehicles and create bookings by specifying rental dates.

The system calculates the total booking amount based on the rental period and vehicle price.

### Payment

The payment system records:

- Booking ID
- Payment amount
- Payment method
- Payment status
- Transaction date

After a successful payment, the booking status is changed to Confirmed.

### Owner Earnings

The Owner Dashboard calculates total earnings from paid and confirmed bookings belonging to the logged-in owner.

### Search and Filtering

Customers can search and filter vehicles using controls such as:

- Brand
- Vehicle Type
- Number of Seats
- Maximum Price
- Location

---

# Object-Oriented Programming

The project explicitly uses OOP principles.

## Abstraction

`User` and `Vehicle` are abstract base classes.

They provide common properties and behavior for their derived classes while preventing direct creation of generic User or Vehicle objects.

Example:

```csharp
public abstract class User
{
    public int UserID { get; set; }
    public string Username { get; set; }
    public string FullName { get; set; }
    public string Role { get; set; }
}
```

```csharp
public abstract class Vehicle
{
    public int VehicleID { get; set; }
    public int OwnerID { get; set; }
    public string Brand { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
    public decimal PricePerDay { get; set; }
}
```

## Inheritance

The project uses inheritance to represent specialized users and vehicles.

User hierarchy:

```text
User
├── Customer
├── Owner
└── Admin
```

Vehicle hierarchy:

```text
Vehicle
├── Sedan
├── SUV
├── Van
└── Luxury
```

## Encapsulation

Data is organized inside classes using properties and class-specific methods.

For example, vehicle-specific information is stored inside the appropriate vehicle subclass.

## Polymorphism

The system works with the common `Vehicle` type while allowing different subclasses such as `Sedan`, `SUV`, `Van`, and `Luxury` to provide their own specialized data.

This allows the application to process different vehicle types through the common vehicle abstraction.

---

# Project Structure

```text
CarRentalManagementSystem
│
├── Admin
│   ├── AdminDashboardForm.cs
│   ├── ManageUsersForm.cs
│   ├── ManageAllCarsForm.cs
│   └── ManageAllBookingsForm.cs
│
├── Customer
│   ├── CustomerDashboardForm.cs
│   ├── BrowseCarsForm.cs
│   ├── CarDetailsForm.cs
│   ├── BookingForm.cs
│   ├── PaymentForm.cs
│   └── MyBookingsForm.cs
│
├── Database
│   └── DatabaseHelper.cs
│
├── Forms
│   ├── LoginForm.cs
│   └── SignUpForm.cs
│
├── Images
│
├── Models
│   ├── User.cs
│   ├── Customer.cs
│   ├── Owner.cs
│   ├── Admin.cs
│   ├── Vehicle.cs
│   ├── Sedan.cs
│   ├── SUV.cs
│   ├── Van.cs
│   ├── Luxury.cs
│   ├── Booking.cs
│   └── Payment.cs
│
├── Owner
│   ├── OwnerDashboardForm.cs
│   ├── MyCarsForm.cs
│   ├── AddEditCarForm.cs
│   └── OwnerBookingsForm.cs
│
├── Program.cs
├── PROJECT_WORKFLOW.md
├── README.md
└── CarRentalManagementSystem.csproj
```

---

# Application Flow

## Login Flow

```text
Program.cs
    |
    v
LoginForm
    |
    v
Validate Username and Password
    |
    v
Check User Role
    |
    +---- Customer ----> CustomerDashboardForm
    |
    +---- Owner --------> OwnerDashboardForm
    |
    +---- Admin --------> AdminDashboardForm
```

## Customer Flow

```text
Customer Dashboard
        |
        +---- Browse Cars
        |       |
        |       +---- Search / Filter
        |       |
        |       +---- View Details
        |       |
        |       +---- Booking
        |               |
        |               v
        |           Payment
        |               |
        |               v
        |          Confirmed Booking
        |
        +---- My Bookings
        |
        +---- Change Password
        |
        +---- Delete Account
        |
        +---- Logout
```

## Owner Flow

```text
Owner Dashboard
      |
      +---- My Cars
      |       |
      |       +---- Add Vehicle
      |       |
      |       +---- Edit Vehicle
      |
      +---- Owner Bookings
      |
      +---- Total Earnings
      |
      +---- Logout
```

## Admin Flow

```text
Admin Dashboard
      |
      +---- Manage Users
      |
      +---- Manage All Cars
      |
      +---- Manage All Bookings
      |
      +---- Logout
```

---

# Database

The application uses SQL Server as its database.

Main tables:

```text
Users
Vehicles
Bookings
Payments
```

## Users

Stores user account and role information.

Important fields include:

- UserID
- Username
- PasswordHash
- Email
- FullName
- Role
- CreatedAt

## Vehicles

Stores vehicle information.

Important fields include:

- VehicleID
- OwnerID
- Brand
- Model
- Year
- VehicleType
- PricePerDay
- AvailabilityStatus
- Description
- ImagePath
- Seats
- Location
- TransmissionType
- DriveType
- LuggageCapacity
- SlidingDoors
- GroundClearance

## Bookings

Stores rental booking information.

Important fields include:

- BookingID
- CustomerID
- VehicleID
- StartDate
- EndDate
- TotalAmount
- BookingStatus
- CreatedAt

## Payments

Stores payment information.

Important fields include:

- PaymentID
- BookingID
- Amount
- PaymentMethod
- PaymentStatus
- TransactionDate

---

# Database Relationships

The main relationships are:

```text
Users
  |
  | OwnerID
  v
Vehicles
  |
  | VehicleID
  v
Bookings
  |
  | BookingID
  v
Payments
```

A user with the Owner role can own multiple vehicles.

A customer can have multiple bookings.

A vehicle can have multiple bookings over time.

A booking can have an associated payment.

---

# SQL and Data Access

The application uses `Microsoft.Data.SqlClient` to communicate with SQL Server.

Database connections are handled through:

```text
Database/DatabaseHelper.cs
```

Parameterized SQL commands are used for database operations.

Example of an owner earnings query:

```sql
SELECT ISNULL(SUM(p.Amount), 0) AS TotalEarnings
FROM Payments AS p
INNER JOIN Bookings AS b
    ON p.BookingID = b.BookingID
INNER JOIN Vehicles AS v
    ON b.VehicleID = v.VehicleID
WHERE v.OwnerID = @OwnerID
  AND p.PaymentStatus = 'Paid'
  AND b.BookingStatus = 'Confirmed';
```

This query joins Payments, Bookings, and Vehicles to calculate the total earnings for a particular vehicle owner.

---

# Validation

The application contains validation for important user actions.

Examples include:

- Required field validation
- Password length validation
- Confirm password validation
- Email validation
- Duplicate username checking
- Vehicle information validation
- Booking date validation
- Payment validation
- Account deletion password verification

Error messages are displayed to users when invalid information is entered.

---

# Security

The application does not store user passwords as plain text.

Passwords are hashed before being stored in the database.

Database operations use parameters such as:

```text
@Username
@PasswordHash
@OwnerID
@BookingID
```

This helps avoid directly concatenating user input into SQL statements.

---

# User Interface

The application uses a consistent Windows Forms design.

The main UI uses:

- Consistent colour scheme
- Consistent typography
- Consistent button styling
- Dashboard navigation
- DataGridView controls for data lists
- ComboBox controls for filtering
- Form titles
- Validation and error messages
- Vehicle images and card-style presentation

The Customer Browse Cars screen provides search and filtering functionality and displays vehicle information with images.

---

# Running the Project

## Requirements

Install:

- Visual Studio
- .NET 10.0 SDK
- SQL Server / SQL Server Express or LocalDB
- SQL Server Management Studio

## Database Setup

1. Create the `CarRentalDB` database in SQL Server.
2. Create the required tables.
3. Make sure the database contains the required columns.
4. Update the SQL Server instance name in:

```text
Database/DatabaseHelper.cs
```

The connection string format is:

```text
Server=YOUR_SERVER_NAME;Database=CarRentalDB;Trusted_Connection=True;TrustServerCertificate=True;
```

Replace `YOUR_SERVER_NAME` with the SQL Server instance installed on the computer.

## Run

1. Open the solution in Visual Studio.
2. Make sure the database connection string is correct.
3. Build the solution.
4. Run the application.
5. The Login form will appear first.

---

# Testing

The application was tested for the main system functions, including:

- User registration
- User login
- Role-based dashboard navigation
- Customer vehicle browsing
- Vehicle search
- Vehicle filtering
- Vehicle details
- Vehicle management
- Booking
- Payment
- Owner booking management
- Owner earnings
- Admin management functions
- Change password
- Customer account deletion
- Logout
- SQL Server database connectivity

---

# Project Purpose

The purpose of this project is to provide a desktop-based car rental management system that demonstrates practical application of:

- Object-Oriented Programming
- C# programming
- Windows Forms development
- SQL Server database management
- CRUD operations
- Authentication
- Role-based access
- Search and filtering
- Booking and payment processing
- Relational database design

---

# Author

Car Rental Management System

Developed as an OOP2 Final Project.

GitHub Repository:

https://github.com/shaon4a-ui/CarRentalManagementSystem
