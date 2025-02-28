# Basic Amazon.sa Web Application - ASP.NET Core MVC

This project is a basic e-commerce web application built using ASP.NET Core MVC. It mimics the structure of a simple online store (similar to Amazon.sa) and includes features for displaying products, placing orders, and viewing order history.

## Project Overview

The project demonstrates the use of ASP.NET Core MVC architecture to implement a basic e-commerce platform. The application includes:
- Models for `User`, `Product`, `Order`, and `OrderDetails`.
- Views for displaying product lists, placing orders, and viewing order history.
- Controllers for handling data operations and user interactions.
- Attribute-based routing to create clean and user-friendly URLs.
- Basic input validation for forms.

## Features
- **Product List View**: Display a list of available products.
- **Order Form**: Allows users to place an order.
- **Order History View**: Shows order history for users.
- **Model Validation**: Ensures user input is valid when placing orders.
- **Routing**: Custom endpoints to fetch products and user order history.

---

## Project Setup

### Prerequisites

- **.NET SDK 8 or 9** (for creating the MVC application).
- A code editor like **Visual Studio** or **Visual Studio Code**.
- A browser to access the web application.

### Steps to Set Up

2. **Install Dependencies**:
   Navigate to the project folder and restore any required dependencies.
   ```bash
   cd amazon-sa-webapp
   dotnet restore
   ```

3. **Build the Project**:
   After restoring dependencies, build the project.
   ```bash
   dotnet build
   ```

4. **Run the Application**:
   Run the project to start the application.
   ```bash
   dotnet run
   ```

5. Open a browser and navigate to `http://localhost:5003` (or the specified port) to view the application.

---

## MVC Architecture Implementation

### 1. **Models**:
The following models have been defined:

- **User**: Represents a user in the system.
    - Properties: `UserId`, `Username`, `Email`, etc.
- **Product**: Represents a product available for sale.
    - Properties: `ProductId`, `Name`, `Description`, `Price`, `StockQuantity`.
- **Order**: Represents an order placed by a user.
    - Properties: `OrderId`, `UserId`, `OrderDate`, `TotalAmount`.
- **OrderDetails**: Represents details of the products in an order.
    - Properties: `OrderDetailsId`, `OrderId`, `ProductId`, `Quantity`, `Price`.

### 2. **Views**:
The following Razor Views have been created:

- **Product List View (`Views/Products/Index.cshtml`)**: Displays all available products.
- **Order Form View (`Views/Orders/Create.cshtml`)**: Form for users to place an order.
- **Order History View (`Views/Orders/Index.cshtml`)**: Displays the user's order history.

### 3. **Controllers**:
- **ProductController**:
    - `GET /Products`: Fetches and displays all products.
    - **Populating product data**: Dummy data for products is provided in the controller.
  
- **OrderController**:
    - `GET /Orders/{userId}`: Fetches and displays the order history for a specific user.
    - `POST /Orders`: Handles order placement based on user input.


## Routing and User Input Handling

### 1. **Custom Routes**:
- **GET /Products**: Displays all products.
- **GET /Orders/{userId}**: Fetches and displays the order history for a specific user.

Example of Attribute-Based Routing:
```csharp
[Route("Products")]
public IActionResult Index() { ... }

[Route("Orders/{userId}")]
public IActionResult Index(int userId) { ... }
```

### 2. **Model Validation**:
Model validation is performed on the order form to ensure that the user provides valid inputs.

Example of Order Model Validation:
```csharp
public class OrderDetails
{
    [Required(ErrorMessage = "User ID is required.")]
    public int UserId { get; set; }

    [Required(ErrorMessage = "Please select at least one product.")]
    public List<int> ProductIds { get; set; }

    [Range(1, 100, ErrorMessage = "Order quantity must be between 1 and 100.")]
    public int Quantity { get; set; }
}
```

---

## Folder Structure

```bash
/amazon-sa-webapp
│
├── /Controllers
│   ├── ProductController.cs
│   └── OrderController.cs
│
├── /Models
│   ├── Product.cs
│   ├── Order.cs
│   └── OrderDetails.cs
│   └── user.cs
│
├── /Views
│   ├── /Products
│   │   └── Index.cshtml
│   ├── /Orders
│   │   ├── Create.cshtml
│   │   └── History.cshtml
│
├── /wwwroot
│   └── (static files like CSS, JavaScript)
│
└── /appsettings.json (configuration file)
```

---

## Running the Application

1. **Run the application** by navigating to the project folder in the terminal and executing:
   ```bash
   dotnet run
   ```

2. **Access the application** by opening a browser and navigating to `http://localhost:5003`.

3. **Test the functionality** by:
   - Browsing the products at `/Products`.
   - Placing orders via `/Orders/Create`.
   - Viewing order history via `/Orders/{userId}`.

---

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.
