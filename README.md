# Soleil et Soie

A Windows Forms database application for managing a luxury fashion house's operations—covering catalog, orders, collections, designers, and reporting.  
Built as a Database Course Project.

## Overview

Soleil et Soie models a growing fashion house transitioning from manual record‑keeping to a structured DBMS. The system supports multiple roles (admin, designer, customer), manages product and design lifecycles, tracks inventory and orders, and provides managerial reporting.

## Key Features

- Role‑based workflows for Admins, Designers, and Customers
- User authentication, profiles, and account management
- Product browsing, cart, and checkout
- Design submission, approval status, and collection assignment
- Inventory and vendor material management
- Feedback collection and admin review
- Sales trends and managerial reports

## Tech Stack

- C# .NET Framework 4.7.2 (Windows Forms)
- SQL Server (tested with SQL Server Express)
- ADO.NET for database access

## Database

The schema lives in:
- `schema sql\DB.sql`

Primary tables include:
- `Users`, `Products`, `Designs`, `Category`, `Collection`
- `Orders`, `ProductOrders`, `Feedback`
- `Materials`, `Vendor`, `ProductMaterial`, `Order_Vendor_Material`
- `CardDetails`

Seed data is included in `DB.sql` for demo users, categories, collections, and products.

## Getting Started

### Prerequisites

- Windows
- Visual Studio (with .NET desktop development workload)
- SQL Server / SQL Server Express

### Setup

1. Create the database and tables using:
   - `schema sql\DB.sql`
2. Update the connection string in:
   - `Soleil et Soie\DBManager.cs`
   
   The default is:
   ```
   Data Source=DESKTOP-DP92LNP\SQLEXPRESS;Initial Catalog=SoleiletSoie;Integrated Security=True;Encrypt=False
   ```

### Run

1. Open the solution:
   - `Soleil et Soie.sln`
2. Build and run. The entry point launches `LogIn`.

## Project Structure

- `Soleil et Soie\`  
  The Windows Forms application (UI + business logic)
- `schema sql\`  
  Database schema and seed data
- `src\`  
  Image assets used in the UI

## Notes

- Passwords in seed data are stored as SHA‑256 hashes.
- This is a course project and not hardened for production (e.g., SQL is built via string concatenation).
