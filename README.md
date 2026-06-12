# 🚗 VehicleManager

VehicleManager is a commercial desktop application developed as a freelance project for a client to manage vehicles and related operational data efficiently.

The system is built using C#, Windows Forms, and SQL Server, following a clean 3-tier architecture to ensure scalability, maintainability, and performance.

---

## 📌 Project Purpose

This application was designed to replace manual tracking systems with a reliable digital solution for managing:

- Vehicle records
- Operational and business data
- Structured database management
- Fast search and filtering operations

The main goal was to improve data accuracy, accessibility, and operational efficiency.

---

## ⚙️ Key Features

### 🚘 Vehicle Management
- Add, update, and delete vehicle records
- View detailed vehicle information
- Fast search and filtering system

---

### 🗂 Data Management
- Centralized SQL Server database
- Secure CRUD operations
- Relational database structure

---

### 🧾 Business Logic
- Validation layer to ensure data integrity
- Separation of business rules from UI
- Clean and maintainable logic layer

---

### 🖥 User Interface
- Simple and intuitive Windows Forms UI
- DataGridView-based management system
- Fast and responsive interactions

---

## 🏗️ Architecture

The project follows a **3-Tier Architecture**:

- **Presentation Layer (UI):** Windows Forms interface for user interaction  
- **Business Layer (BL):** Business rules, validation, and processing logic  
- **Data Access Layer (DAL):** SQL Server communication and data operations  

This architecture ensures:
- Clean separation of concerns
- Easy maintenance and debugging
- Scalability for future enhancements

---

## 🛠️ Tech Stack

- **Language:** C#
- **Framework:** .NET Windows Forms
- **Database:** Microsoft SQL Server
- **Architecture:** 3-Tier Architecture (Presentation / Business / Data Access)

---

## 📂 Project Structure

```plaintext
VehicleManager/
│
├── PresentationLayer/   # Windows Forms UI
├── BusinessLayer/       # Business logic and validation
├── DataAccessLayer/     # Database operations (DAL)
├── Models/              # Domain models
└── Database/            # SQL scripts (if available)
