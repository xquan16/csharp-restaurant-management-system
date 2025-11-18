# 🍣 ApexOn Sushi Management System (IOOP Project)

This is a multi-user restaurant management system for "ApexOn Sushi," developed as the group coursework for the "Introduction to Object-Oriented Programming (IOOP)" module.

The system is built using **C#** with **.NET Windows Forms** (WinForms) for the frontend and connects to a **Microsoft SQL Server** database for the backend.

The application supports five distinct user roles, each with specific permissions to manage the restaurant's operations.

## 🔑 Key Features by Role

### 1. Administrator
Responsible for system-wide user management and oversight.
* **User Management**: Full CRUD (Add, Edit, Delete) for all user accounts (Manager, Chef, etc.).
* **View Customer Feedback**: Reviews feedback submitted by customers.
* **View Sales Report**: Accesses sales reports, with filters for month, category, and chef.
* **Update Profile**: Manages their own administrator account credentials.

### 2. Manager 
Responsible for managing the restaurant's menu, pricing, and reservation infrastructure.
* **Menu Management**: Full CRUD (Add, Edit, Delete, Search) for all menu items and categories (e.g., Sashimi, Nigiri, Sushi).
* **Hall Management**: Full CRUD (Add, Edit, Delete) for managing restaurant hall details, capacity, and party types.
* **View Reservation Report**: Generates and views reservation reports, with filters by month and reservation type.
* **Update Profile**: Manages their own manager account credentials.

### 3. Chef 
Responsible for kitchen operations, including order processing and inventory.
* **Order Management**: Views incoming customer orders and updates their status (e.g., "Mark as in progress," "Mark as complete").
* **Inventory Management**: Full CRUD (Add, Edit, Delete, Search) for managing ingredient inventory, quantities, and prices.
* **Update Profile**: Manages their own administrator account credentials.

### 4. Reservation Coordinator
Responsible for managing all customer reservation requests.
* **Process Reservations**: Handles new reservation requests from customers.
* **Manage Reservations**: Edits and updates the status of existing reservations.
* **View Customer Requests**: Views all pending and confirmed reservation requests.
* **Update Profile**: Manages their own coordinator account credentials.

### 5. Customer 
The public-facing role for restaurant patrons.
* **Browse & Order**: Browses the menu by category, selects items, and places an order.
* **Submit Feedback**: Provides dining feedback after an order.
* **Make Reservation**: Submits a request to reserve a private dining room.
* **Check Status**: Checks the status of their pending or confirmed reservations.
* **Update Profile**: Manages their own customer account credentials.

## 💻 Tech Stack

* **Language**: C#
* **Framework**: .NET Windows Forms
* **Database**: Microsoft SQL Server
* **IDE**: Visual Studio
