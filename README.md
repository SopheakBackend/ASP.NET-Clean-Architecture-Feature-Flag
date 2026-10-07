# ASP.NET Clean Architecture & Feature Flags

A clean, modular RESTful API built with **.NET 8** following **Clean Architecture** principles and integrated with **Microsoft Feature Management** for feature flagging.

---

##  Architecture Overview

The solution is structured into four isolated layers following the **Dependency Inversion Principle**:

* **`LaptopApi.Api` (Presentation):** ASP.NET Core Web API controllers, HTTP routing, and request/response handling.
* **`LaptopApi.Application`:** Application workflows, use cases, DTOs, and interface definitions for application services.
* **`LaptopApi.Domain`:** Core business entities (`Laptop.cs`) and repository interfaces (`ILaptopRepository.cs`). Contains zero external dependencies.
* **`LaptopApi.Infrastructure`:** External concerns, data access implementations (`InMemoryLaptopRepository.cs`), and persistence code.

```text
[ Client / Browser ] ──► [ API Layer ] ──► [ Application Layer ] ──► [ Domain Layer ]
                                                  │                        ▲
                                                  └──────► [ Infrastructure ] ┘
```
##  Testing the API (Without Postman)

You can easily test the API directly inside VS Code using the `.http` file without needing external tools like Postman:

1. **Install the Extension:** Install the **[REST Client](https://marketplace.visualstudio.com/items?itemName=humao.rest-client)** extension in VS Code.
2. **Open the HTTP File:** Navigate to `LaptopApi.Api/LaptopApi.Api.http` in your file explorer.
3. **Send Requests:** Click the **`Send Request`** link that appears directly above any endpoint (e.g., `GET {{LaptopApi.Api_HostAddress}}/api/laptops`) to run the request and view the JSON response right inside your editor!
