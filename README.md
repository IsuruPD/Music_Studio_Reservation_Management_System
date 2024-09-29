# Standalone Reservation Management System

This project is a **Standalone Reservation Management System** developed using **C#** and **SQL**. It is designed to facilitate the staff of a music studio in managing various business operations such as handling customer reservations, purchases, inventory, and accounts. The system also implements **Role-Based Access Control**, ensuring that staff members have appropriate permissions based on their roles.

This project focuses on providing staff with a robust, standalone solution for managing all internal processes related to the studio's daily operations. The system allows staff to manage customer data, oversee reservations and hires, track inventory, manage staff records, and handle financial accounting—all in an intuitive desktop application.

## Features

### Key Features:
- **Reservation Management**: Manage studio reservations made by customers for sessions.
- **Instrument Hire Management**: Handle and track instruments hired by customers.
- **Inventory Management**: Add, update, and manage musical instruments available for hire.
- **Staff Management**: Manage staff records, assign roles, and control access to different parts of the system.
- **Account Management**: Manage financial operations, track invoices, and handle purchases.
- **Role-Based Access Control**: Different roles (e.g., Admin, Receptionist, Inventory Manger, Accountant) have varying levels of access to system functionalities.

## Technologies Used

- **Frontend**: Windows Forms (C#)
- **Backend**: C#/.NET Framework
- **Database Management**: SQL Server Management Studio (SSMS)

## Installation Guide

### Step 1: Install SQL Server and Management Studio
1. Download and install [Microsoft SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads) and [SQL Server Management Studio (SSMS)](https://learn.microsoft.com/en-us/sql/ssms/download-sql-server-management-studio-ssms?view=sql-server-ver16).
2. After installation, open SSMS and start your SQL Server instance.

### Step 2: Set up the Database
In **SSMS**, create a new database for the system. You can name it `MusicStudioDB`.

### Step 3: Configure the Database Connection in the Application
1. In the `<connectionStrings>` section, modify the connection string to match your SQL Server configuration:
    ```xml
    <connectionStrings>
        <add name="MusicStudioDB"
             connectionString="Data Source=YOUR_SERVER_NAME;Initial Catalog=MusicStudioDB;Integrated Security=True" 
             providerName="System.Data.SqlClient" />
    </connectionStrings>
    ```
   - Replace `YOUR_SERVER_NAME` with the name of your SQL Server instance.

### Step 4: Build and Run the Application
1. Open the `Music Studio.sln` solution file in **Visual Studio**.
2. Build the project by selecting `Build > Build Solution`.
3. Once the build succeeds, run the application by pressing `F5` or selecting `Debug > Start Debugging`.

### Step 5: Logging In
You can create a default user and change the credentials from the database via **SSMS**.

---

## Usage Guide

### Dashboard Overview
Upon login, users are directed to the dashboard, where they can access different sections of the system based on their roles.

### Key Functionalities:
- **Manage Reservations**: Receptionists can create, update, or delete reservations and track booking history.
- **Inventory Management**: Inventory Managers can add new instruments, edit existing records, and track stock levels.
- **Manage Instrument Hiring**: Assign instruments to hire, track and generate invoices.
- **Accounts and Billing**: Accountants can manage and track financial operations, including viewing and generating reports on reservations.
- **Staff Management**: Admins can add, update, or remove staff records and assign roles with different permission levels.
