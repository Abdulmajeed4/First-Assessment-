// Prompt the user to enter the first number and read the input
Console.Write("Enter The first number: ");
if (!double.TryParse(Console.ReadLine(), out double first_number))
{
    // If the input is not a valid double, display an error message and exit
    Console.WriteLine("Error!: Invalid input for the first number, Please enter a valid decimal number for the first number.");
    return;
}

// Prompt the user to enter the second number and read the input
Console.Write("Enter the second number: ");
if (!double.TryParse(Console.ReadLine(), out double second_number))
{
    // If the input is not a valid double, display an error message and exit
    Console.WriteLine("Error!: Invalid input for the second number, Please enter a valid decimal number for the second number.");
    return;
}

// Prompt the user to choose an operation and read the input
Console.Write("Choose an operation ( + or - or * or / ): ");
string? operationInput = Console.ReadLine();

// Check if the input contains more than one operation character
if (operationInput != null && operationInput.Count(char.IsPunctuation) > 1)
{
    // If multiple operation characters are found, display an error message and exit
    Console.WriteLine("Error: You cannot choose multiple operation characters.");
    return;
}

// Try to parse the operation input as a character
if (!char.TryParse(operationInput, out char operation))
{
    // If the input is not a valid character, display an error message and exit
    Console.WriteLine("Error: Invalid input for the operation, Please enter one of the operations above ( + or - or * or / )");
    return;
}

// Check if the operation is valid (+, -, *, or /)
if (operation == '+' || operation == '-' || operation == '*' || operation == '/')
{
    // Perform the calculation based on the chosen operation
    if (operation == '-')
    {
        double result = first_number - second_number;
        Console.WriteLine("the result is: " + first_number + " - " + second_number + " = " + result);
    }
    else if (operation == '+')
    {
        double result = first_number + second_number;
        Console.WriteLine("the result is: " + first_number + " + " + second_number + " = " + result);
    }
    else if (operation == '/')
    {
        double result = first_number / second_number;
        Console.WriteLine("the result is: " + first_number + " / " + second_number + " = " + result);
    }
    else if (operation == '*')
    {
        double result = first_number * second_number;
        Console.WriteLine("the result is: " + first_number + " * " + second_number + " = " + result);
    }
}
else
{
    // If the operation is invalid, display an error message
    Console.WriteLine("Error!: Invalid input, Please enter one of the operations above ( + or - or * or / )");
}