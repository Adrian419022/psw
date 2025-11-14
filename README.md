# Avalonia Calculator App

This repository contains a simple Avalonia desktop calculator built with .NET. Follow the steps below to open it in Visual Studio Code and run it locally.

## Prerequisites
- [Visual Studio Code](https://code.visualstudio.com/) with the **C# Dev Kit** or **C#** extension installed.
- [.NET 8 SDK](https://dotnet.microsoft.com/download) (the project targets `net8.0`).

## Opening the project in VS Code
1. Clone or download this repository to a local folder.
2. Start VS Code and choose **File → Open Folder...**.
3. Select the folder that contains this repository (the one with the `CalculatorApp` directory and this `README.md`).
4. When prompted, allow VS Code to restore build assets and load the C# workspace.

## Running the calculator
1. Open the integrated terminal in VS Code (**View → Terminal**).
2. Run `cd CalculatorApp` to enter the project directory.
3. Execute `dotnet run` to build and start the Avalonia desktop application.
4. The calculator window will appear; enter numbers, use the operation buttons, and clear with the **Wyczyść** button.

## Project structure
- `CalculatorApp/MainWindow.axaml` – XAML layout describing the UI.
- `CalculatorApp/MainWindow.axaml.cs` – C# code-behind that validates input, performs arithmetic, and shows errors.
- `CalculatorApp/App.axaml` & `App.axaml.cs` – Avalonia application setup.
- `CalculatorApp/Program.cs` – Application entry point.

Feel free to modify the UI or logic within these files and re-run `dotnet run` to see the changes in VS Code.
