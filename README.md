# Sales Date Prediction - Backend API

Este proyecto es parte de una prueba técnica para el rol de desarrollador .NET.  
El objetivo es construir una API REST que permita predecir la próxima orden por cliente, visualizar órdenes, empleados, productos y crear nuevas órdenes en una base de datos relacional.

---

## Tecnologías utilizadas

- **.NET 7 / .NET 6** – Web API
- **Entity Framework Core** – Acceso a base de datos
- **SQL Server** – Base de datos relacional
- **Swagger / Swashbuckle** – Documentación interactiva de API
- **Clean Architecture (simplificada)** – Separación por capas (Controllers, Services, DTOs, Data)
- **LINQ / SQL Raw Queries** – Consultas personalizadas con EF

---

## Estructura del backend

SalesPrediction.Api/
├── Controllers/ # Endpoints HTTP
├── Services/ # Lógica de negocio
├── Data/ # DbContext y configuración EF
├── Models/ # Entidades y DTOs
├── appsettings.json # Configuración de conexión
└── Program.cs # Bootstrap de la API



---

## Funcionalidades implementadas

| Endpoint                          | Descripción                                      | Estado |
|----------------------------------|--------------------------------------------------|--------|
| `GET /api/prediction`            | Predicción de próxima orden por cliente         | ✅     |
| `GET /api/orders/client/{id}`    | Listar órdenes por cliente                      | ✅     |
| `GET /api/employees`             | Listar empleados                                | ✅     |
| `GET /api/shippers`              | Listar transportistas                           | ✅     |
| `GET /api/products`              | Listar productos                                | 🔜     |
| `POST /api/orders`               | Crear nueva orden con detalle de producto       | 🔜     |

---

## Configuración del entorno

### 1. Requisitos

- Visual Studio 2022 / VS Code
- .NET 6 o 7 SDK
- SQL Server o LocalDB
- Git

### 2. Clonar repositorio

```bash
git clone https://github.com/usuario/sales-prediction-api.git
cd sales-prediction-api
```

### 3. Configurar Base de Datos

"ConnectionStrings": {
  "DefaultConnection": "Server=(localdb)\\MSSQLLocalDB;Database=StoreSample;Trusted_Connection=True;"
}

## Ejecución del proyecto

dotnet build
dotnet run

## Revisión del Backend

https://localhost:{puerto}/swagger

## Autor
Desarrollado por: Johan Martínez
Prueba técnica – Sales Date Prediction API – 2025



