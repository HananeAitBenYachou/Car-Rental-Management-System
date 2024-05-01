# Car-Rental-Management-System

## Overview:
The Car Rental Management System is a comprehensive application designed to streamline the operations of a car rental business. 

Developed using C#.NET Framework, this system leverages a SQL Server database and ADO.NET to efficiently manage all aspects of car rentals, from customer information to vehicle inventory and rental transactions.

## Key Features:

### Customer Management:
- Store and manage detailed customer information: name, contact details, and driver's license number.
- Allow staff to access customer profiles and rental history , as well as transaction history for efficient service.

### Vehicles Management:
- Maintain up-to-date information of available vehicles, including make, model, year, mileage, rental rates, fuel type (gasoline, diesel, electric, hybrid), plate number, and vehicle category (4x4, sedan, etc.).
- Implement detailed search and filtering by make, model, fuel type, category, and more for quick and efficient vehicle selection.
- Tracks the maintenance history for each vehicle, including service records, repair details, and costs.
- Stores the booking history for each vehicle, including rental periods, customer information, and mileage details.

### Vehicle Booking:
- Log booking information such as the customer who rented the vehicle, rental start and end dates, pickup and drop-off locations, initial rental days, initial total due amount ...
- Enable efficient management of bookings, including easy access to reservation details.

### Rental Transaction:
- Record payment details and initial paid amount for rental transactions.
- Track payment status and log all rental transactions for auditing and reference.

### Vehicle Return:
- Calculate and record the actual return date, actual rental days, final vehicle check notes, and any additional charges.
- Updates the original rental transaction to reflect the actual details, including the final amount due and any remaining balance or refund owed to the customer.
- Calculate the consumed mileage during the rental period and update the current mileage in the system.
- Manage refunds or additional charges as needed.

### Reporting:
- Generates reports for:
   - Vehicle list.
   - Customer list.
   - Monthly revenue for the current year.
   - Rental bookings, transactions, vehicle returns, and vehicle maintenances within a specified date range.
   - Profit analysis within a specified date range.

## Technology Stack:
- C# .NET Framework
- SQL Server
- ADO.NET
- WinForms (Desktop Interface)
