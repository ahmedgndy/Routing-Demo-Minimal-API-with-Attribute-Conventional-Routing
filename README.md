# 📍 Routing Demo -- Minimal API with Attribute Routing

This project demonstrates ASP.NET Core Routing concepts using .NET 7/8
Minimal APIs and Controllers.

------------------------------------------------------------------------

## 🚀 Features

-   ✅ Attribute Routing with Controllers\
-   ✅ Minimal API Routing (MapGet, MapPut)\
-   ✅ Route Parameters & Constraints\
-   ✅ Link Generation using LinkGenerator\
-   ✅ Custom Route Constraints (example: MonthConstraints)\
-   ✅ HATEOAS-style responses

------------------------------------------------------------------------

## 📂 Project Structure

    RoutingDemo/
    │
    ├── Program.cs                 # Main application entry point
    ├── Controllers/
    │   ├── ProductsController.cs  # Products API controller
    │   └── OrdersController.cs    # Orders API controller
    ├── Constraints/
    │   └── MonthConstraint.cs     # Custom route constraint
    ├── Models/
    │   └── Order.cs              # Order model with HATEOAS support
    ├── appsettings.json          # Application configuration
    └── README.md                 # Project documentation

------------------------------------------------------------------------

## 📌 Endpoints

  Method   Route                  Description
  -------- ---------------------- ---------------------------
  GET      /api/products/all      Get all products
  GET      /api/products/{id}     Get product by ID
  GET      /api/orders/{id}       Get order by ID
  GET      /health                Health check
  GET      /generate/order/{id}   Generate order with links
  PUT      /order/{id}            Update order by ID

------------------------------------------------------------------------

## 📥 Example Requests & Responses

### ✅ Get All Products

**Request:**

    GET /api/products/all

**Response:**

``` json
["Laptop", "Phone", "Tablet"]
```

### ✅ Get Product by ID

**Request:**

    GET /api/products/1

**Response:**

``` json
"Product 1"
```

### ✅ Get Order by ID

**Request:**

    GET /api/orders/123

**Response:**

``` json
"Order 123"
```

### ✅ Generate Order with HATEOAS

**Request:**

    GET /generate/order/10

**Response:**

``` json
{
  "OrderId": 10,
  "ProductName": "Sample Product",
  "Quantity": 1,
  "_links": {
    "self": { "href": "/generate/order/10" },
    "edit": { "href": "http://localhost:5000/order/10" }
  }
}
```

### ✅ Update Order

**Request:**

    PUT /order/10

**Response:**

``` json
"Order 10 updated"
```

### ✅ Health Check

**Request:**

    GET /health

**Response:**

``` json
"API is running..."
```

------------------------------------------------------------------------

## 🛠️ Setup Instructions

1.  Clone the repository\

2.  Restore dependencies:

    ``` bash
    dotnet restore
    ```

3.  Run the application:

    ``` bash
    dotnet run
    ```

4.  Access the API at:

    -   https://localhost:7000\
    -   http://localhost:5000

------------------------------------------------------------------------

## 📝 Requirements

-   .NET 7 or .NET 8 SDK\
-   Your favorite IDE (Visual Studio, VS Code, Rider)

------------------------------------------------------------------------

## 📄 License

This project is licensed under the **MIT License**.

------------------------------------------------------------------------

## 🤝 Contributing

1.  Fork the project\
2.  Create your feature branch\
3.  Commit your changes\
4.  Push to the branch\
5.  Open a Pull Request

------------------------------------------------------------------------

