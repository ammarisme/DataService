
# Relational Database Service (C#)
This project is a backend system written in C# that allows querying a database directly from the frontend by manipulating the GET and POST parameters. The system is designed to handle various types of database queries and provides a flexible API for frontend interaction.

---

## Features

### 1. Database Interaction
   - **Direct Query Execution**: Allows direct execution of SQL queries through GET and POST requests.
   - **Parameterized Queries**: Supports parameterized queries to prevent SQL injection and ensure security.
   - **Query Types**: Handles SELECT, INSERT, UPDATE, and DELETE operations.

### 2. API Endpoints
   - **Flexible Endpoints**: Provides flexible API endpoints for different types of database operations.
   - **GET Requests**: Fetch data from the database using GET requests with query parameters.
   - **POST Requests**: Insert, update, or delete data using POST requests with JSON payloads.

### 3. Error Handling
   - **Detailed Error Responses**: Returns detailed error messages and status codes for various failure scenarios.
   - **Validation**: Validates input parameters to ensure they meet the required criteria before executing queries.

### 4. Security
   - **SQL Injection Prevention**: Implements mechanisms to prevent SQL injection attacks.
   - **Authentication and Authorization**: Can be integrated with authentication and authorization systems to restrict access to the API.

### 5. Logging
   - **Request and Response Logging**: Logs incoming requests and outgoing responses for monitoring and debugging purposes.
   - **Error Logging**: Logs errors with detailed stack traces to aid in troubleshooting.

### 6. Configuration
   - **Configurable Database Connections**: Supports configuration of database connections through a configuration file.
   - **Environment-Specific Settings**: Allows different configurations for different environments (development, staging, production).

### 7. Documentation
   - **API Documentation**: Provides documentation for the API endpoints, including usage examples and parameter descriptions.
   - **Code Comments**: Includes inline comments and documentation to explain the code functionality.

---

## Directory Structure

```plaintext
|-- .gitattributes
|-- App.config
|-- CV19Net.ipynb
|-- CV19_Dataset.ipynb
|-- CV19_result_analysis.ipynb
|-- Common
|   |-- Attributes.cs
|   |-- DataAccessObject.cs
|   |-- DbConnection.cs
|   |-- Response.cs
|   |-- ServiceAccess.cs
|-- Domain
|   |-- AlcoholoMetric.cs
|   |-- BottleType.cs
|   |-- BottlingBatch.cs
|   |-- Container.cs
|   |-- ContainerCalculation.cs
|   |-- ContainerType.cs
|   |-- Distillation.cs
|   |-- GaugedVat.cs
|   |-- LiquidInput.cs
|   |-- LiquidTransfer.cs
|   |-- LiquidType.cs
|   |-- Location.cs
|   |-- LocationTransfer.cs
|   |-- Machine.cs
|   |-- MachineContainerTransfer.cs
|   |-- MachineType.cs
|   |-- Plant.cs
|   |-- Solute.cs
|   |-- Solution.cs
|   |-- User.cs
|   |-- VatRoom.cs
|   |-- Vehicle.cs
|-- Properties
|   |-- AssemblyInfo.cs
|-- README.md
|-- SFA_Library.csproj
|-- SFA_Library.csproj.user
|-- bin
|   |-- Debug
|   |   |-- SFALibrary.dll
|   |   |-- SFALibrary.dll.config
|   |   |-- SFALibrary.pdb
|   |-- Release
|       |-- SFALibrary.dll
|       |-- SFALibrary.dll.config
|       |-- SFALibrary.pdb
|-- obj
|   |-- Debug
|   |   |-- DesignTimeResolveAssemblyReferencesInput.cache
|   |   |-- SFALibrary.dll
|   |   |-- SFALibrary.pdb
|   |   |-- SFA_Library.csproj.FileListAbsolute.txt
|   |   |-- SFA_Library.csprojResolveAssemblyReference.cache
|   |-- Release
|       |-- DesignTimeResolveAssemblyReferencesInput.cache
|       |-- SFALibrary.dll
|       |-- SFALibrary.pdb
|       |-- SFA_Library.csproj.FileListAbsolute.txt
|       |-- SFA_Library.csprojResolveAssemblyReference.cache
```

---

### Detailed Explanation

#### **Common**

- **Attributes.cs**: Defines custom attributes for the project.
- **DataAccessObject.cs**: Contains methods for interacting with the database.
- **DbConnection.cs**: Manages database connections.
- **Response.cs**: Structures for standardizing API responses.
- **ServiceAccess.cs**: Provides services for accessing various parts of the application.

#### **Domain**

- **Entities**: Defines various domain entities like `AlcoholoMetric.cs`, `BottleType.cs`, `BottlingBatch.cs`, `Container.cs`, `ContainerCalculation.cs`, `ContainerType.cs`, `Distillation.cs`, `GaugedVat.cs`, `LiquidInput.cs`, `LiquidTransfer.cs`, `LiquidType.cs`, `Location.cs`, `LocationTransfer.cs`, `Machine.cs`, `MachineContainerTransfer.cs`, `MachineType.cs`, `Plant.cs`, `Solute.cs`, `Solution.cs`, `User.cs`, `VatRoom.cs`, and `Vehicle.cs`.

#### **Configuration Files**

- **App.config**: Contains configuration settings for the application, including database connection strings and other settings.

#### **Project Files**

- **SFA_Library.csproj**: The project file for the C# project.
- **SFA_Library.csproj.user**: User-specific project settings.

#### **Build Directories**

- **bin/Debug and bin/Release**: Contains compiled binaries and configuration files for the debug and release builds.
- **obj/Debug and obj/Release**: Intermediate files generated during the build process.
