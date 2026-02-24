# 🚗 Garage Management System – Console (C#)

A console-based garage management system written in C#, focusing on clean Object-Oriented design, inheritance & polymorphism, collections, exceptions, and separation between UI and business logic.

Developed as part of an OOP course in .NET.

---

## 🚀 Project Overview

The system manages a garage that supports multiple vehicle types (fuel & electric) and allows the user to perform common garage operations through a console menu.

The solution is built with **two projects**:
- **GarageLogic** (Class Library / DLL) – the domain model and business logic
- **ConsoleUI** (EXE) – the user interface (console menu + input/output)

---

## 🏗 Solution Structure

- `Ex03.GarageLogic`  
  Business layer and object model (no console I/O)

- `Ex03.ConsoleUI`  
  Console interface, menu handling, user input validation, and interaction with the logic layer

---

## 🚘 Supported Vehicle Types

The garage supports five vehicle types:

- Fuel Motorcycle  
- Electric Motorcycle  
- Fuel Car  
- Electric Car  
- Truck  

Each vehicle contains:
- Model name
- License number
- Remaining energy percentage
- Wheels collection (manufacturer + current/max air pressure)

Additional properties per type:
- Motorcycle: license type, engine volume (cc)
- Car: color, number of doors
- Truck: hazardous materials flag, cargo volume

---

## ✨ Main Features (Console Menu)

1. Load vehicles data from file (VehiclesDB)
2. Insert a new vehicle into the garage  
   - If the vehicle already exists → set status to “In Repair”
3. Display license numbers (with optional filter by status)
4. Change a vehicle status (In Repair / Repaired / Paid)
5. Inflate wheels to maximum pressure
6. Refuel a fuel-based vehicle (with fuel type validation)
7. Charge an electric vehicle (minutes → hours conversion)
8. Show full vehicle details by license number

---

## 🧠 Technical Highlights

### ✅ OOP & Polymorphism
- Vehicle hierarchy designed for extensibility
- Adding a new vehicle type should require minimal changes

### ✅ Separation of Concerns (Logic vs UI)
- `GarageLogic` is UI-agnostic (no Console usage)
- `ConsoleUI` handles presentation and interacts with the logic layer only

### ✅ Collections
- Uses `Dictionary<K,V>` and/or `List<T>` for storage and querying

### ✅ Exception Handling
Includes strict input validation and uses:
- `FormatException` – invalid parsing/input format  
- `ArgumentException` – invalid logical input (e.g., wrong fuel type)
- `ValueRangeException` – custom exception for out-of-range values (min/max constraints)

### ✅ Vehicles Factory Constraint
Vehicle objects are created only via the provided `VehiclesCreator` class (as required by the assignment).

---

## 🛠 Technologies Used

- C#
- .NET Framework
- Console Application
- Class Library (DLL)
- Inheritance & Polymorphism
- Collections
- Custom Exceptions

---

## 📚 Academic Context

Built for an Object-Oriented Programming course in .NET, emphasizing:
- Clean architecture (UI vs Logic)
- Polymorphism & extensibility
- Exception-based validation
- Multi-project solution structure

---

## 👩‍💻 Author

Lotem Kimchi
