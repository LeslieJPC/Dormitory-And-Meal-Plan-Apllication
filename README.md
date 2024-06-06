# Dormitory and Meal Plan Application

## Overview
The **Dormitory and Meal Plan Application** is a Windows Forms application designed to assist students in selecting dormitory accommodations and meal plans. The application calculates the total cost based on the selected dormitory and meal plan.

## Features
- ListBox for selecting dormitory options.
- ListBox for selecting meal plan options.
- Calculation of total cost including dormitory and meal plan.
- Buttons to add dormitory, view meal plan, reset selections, and exit the application.

## Code Structure
The application is developed in C# using Windows Forms and consists of two forms: `Form1` and `Form2`.

### Form1
`Form1` is the main form where users select their dormitory and view the selected meal plan cost.

#### Variables
- `dormitory`: Stores the cost of the selected dormitory.
- `meal`: Stores the cost of the selected meal plan.
- `total`: Stores the total cost of the dormitory and meal plan.

#### Methods
- `Form1()`: Constructor to initialize components and set the start position of the form.
- `button1_Click()`: Event handler for the "Add Desired Dormitory" button.
  - Retrieves the selected dormitory cost and displays it.
- `button2_Click()`: Event handler for the "View Meal Plan" button.
  - Opens `Form2` to select a meal plan.
  - Updates the meal cost and displays the total cost.
- `UpdateMeal(int SelectedMealCost)`: Updates the meal cost and displays it.
- `DisplayTotal()`: Calculates and displays the total cost.
- `button3_Click()`: Event handler for the "Reset" button.
  - Resets all selections and displays.
- `Reset()`: Resets the ListBox selections and labels.
- `button4_Click()`: Event handler for the "Exit" button.
  - Displays a message and exits the application.
- `Exit()`: Exits the application.

### Form2
`Form2` is the secondary form where users select their meal plan.

#### Variables
- `MealPlanCost`: Property to store the selected meal plan cost.
- `meal`: Stores the cost of the selected meal plan.

#### Methods
- `Form2()`: Constructor to initialize components and set the start position of the form.
- `button1_Click()`: Event handler for the "Add Desired Meal Plan" button.
  - Retrieves the selected meal plan cost and closes the form.

## Getting Started

### Prerequisites
- .NET Framework (version 4.7.2 or higher)
- Visual Studio (or any C# compatible IDE)

### Installation
1. Clone the repository:
    ```sh
    git clone https://github.com/LeslieJPC/Dormitory-Meal-Plan-Application.git
    ```
2. Open the project in Visual Studio.
3. Build the solution to restore dependencies and compile the application.
4. Run the application.

### Usage
1. Select the desired dormitory from the ListBox on `Form1`.
2. Click the "Add Desired Dormitory" button to display the dormitory cost.
3. Click the "View Meal Plan" button to open `Form2` and select a meal plan.
4. Click the "Add Desired Meal Plan" button on `Form2` to return to `Form1` and display the meal plan cost.
5. The total cost will be automatically calculated and displayed.
6. To reset selections, click the "Reset" button.
7. To exit the application, click the "Exit" button.

## License
This project is licensed under the MIT License. See the `LICENSE` file for more details.

## Author
- Leslie

Feel free to reach out for any questions or contributions. Happy coding!

---

### Note
This application is a sample project intended for learning and demonstration purposes. It may require further enhancements and testing for production use.
