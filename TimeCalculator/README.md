# Time Calculator

This is a time calculator web application built using ASP.NET Core MVC. It allows users to input hours, minutes, and seconds, and calculates the total time in seconds.

## Project Structure

- `TimeCalculator/Controllers/TimeCalculatorController.cs`: Contains the `TimeCalculatorController` with GET and POST methods for the time calculator.
- `TimeCalculator/Views/TimeCalculator/TimeCalculator.cshtml`: The view for the time calculator input form.
- `TimeCalculator/Views/TimeCalculator/TimeCalculatorResult.cshtml`: The view for displaying the calculation result.
- `TimeCalculator/Program.cs`: Configures and runs the ASP.NET Core application.

## Getting Started

### Prerequisites

- [.NET 6 SDK](https://dotnet.microsoft.com/download/dotnet/6.0)
- [Visual Studio](https://visualstudio.microsoft.com/) or [JetBrains Rider](https://www.jetbrains.com/rider/)

### Running the Application

1. Navigate to the `TimeCalculator` directory:
    ```sh
    cd TimeCalculator
    ```

2. Build and run the application:
    ```sh
    dotnet build
    dotnet run
    ```

3. Open a web browser and navigate to `http://localhost:5255/timecalculator/timecalculator` to use the time calculator. Port can be different for you.

## Usage

- Enter hours, minutes, and seconds in the provided text boxes.
- Click on the "Calculate time" button to perform the calculation.
- The result will be displayed on a result page.

## License

This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for details.