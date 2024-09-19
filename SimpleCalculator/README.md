# Simple Calculator

This is a simple calculator web application built using ASP.NET Core MVC. It allows users to perform basic arithmetic operations such as addition, subtraction, multiplication, and division.

## Project Structure

- `Layout/Controllers/HomeController.cs`: Contains the `HomeController` with various action methods.
- `SimpleCalculator/Controllers/SimpleCalculatorController.cs`: Contains the `SimpleCalculatorController` with GET and POST methods for the calculator.
- `SimpleCalculator/Views/SimpleCalculator/SimpleCalculator.cshtml`: The view for the simple calculator.
- `SimpleCalculator/Program.cs`: Configures and runs the ASP.NET Core application.
- `Program.cs`: Contains a simple console application demonstrating exception handling.

## Getting Started

### Prerequisites

- [.NET 6 SDK](https://dotnet.microsoft.com/download/dotnet/6.0)
- [Visual Studio](https://visualstudio.microsoft.com/) or [JetBrains Rider](https://www.jetbrains.com/rider/)

### Running the Application

1. Clone the repository:
    ```sh
    git clone https://github.com/mikkel-andersen/simple-calculator.git
    cd simple-calculator
    ```

2. Build and run the application:
    ```sh
    dotnet build
    dotnet run --project SimpleCalculator
    ```

3. Open a web browser and navigate to `https://localhost:5001` to use the simple calculator.

## Usage

- Enter two numbers in the provided text boxes.
- Click on one of the operator buttons (`+`, `-`, `*`, `/`) to perform the calculation.
- The result will be displayed below the form.

## License

This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for details.