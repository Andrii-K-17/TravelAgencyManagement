## Travel Agency Management System

##### University course project

##### Desktop app for travel agency management.

### ⚙ Tech stack

- .NET 10.0
- Windows Forms
- Oracle Database 21c XE
- Entity Framework Core 9.0

### ⚡ Features

- CRUD Operations: full management cycle for clients, tours, and employees.
- Reporting dashboard: view booking statistics and financial summaries.
- CSV export: one-click data export for external analysis.
- Data validation: input validation for forms (email, phone formats).

### 🏗 Architecture
The project follows a 3-tier architecture to ensure separation of concerns and maintainability.

#### 1. App.Core (Domain layer)
- Entities/: POCO classes representing database tables.
1.2 DTOs/: Data Transfer Objects for flattened views.
- Interfaces/: Repository contracts.

#### 2. App.Infrastructure.Oracle (Data access layer)
- Data/TourAgencyDbContext.cs: EF Core context configuration.
- Repositories/: Concrete implementations of data access logic.

#### 3. App.Presentation.WinForms (UI layer)
- Views/: User interface forms.
- Program.cs: Composition root and DI container configuration.

### 🚀 Getting started

#### Step 1: Clone repository
```bash
git clone [https://github.com/Andrii-K-17/TravelAgencyManagement.git](https://github.com/YOUR_USERNAME/travel-agency-management.git)
cd travel-agency-management
```

#### Step 2: Database setup
[`database/README.md`](database/README.md)

#### Step 3: Configure connection
Update App.Presentation.WinForms/appsettings.json:
```json
"ConnectionStrings": {
  "OracleConnection": "User Id=TOUR_MANAGEMENT;Password=TrMgmt_Pass;Data Source=localhost:1521/XEPDB1"
}
```

#### Step 4: Build and run
```bash
dotnet build
dotnet run --project App.Presentation.WinForms
```

### 📄 License
This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.
