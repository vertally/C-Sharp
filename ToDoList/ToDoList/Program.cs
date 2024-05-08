Console.WriteLine("Hello!");
Console.WriteLine("[S]ee all TODOs.");
Console.WriteLine("[A]dd a TODO.");
Console.WriteLine("[R]emove a TODO.");
Console.WriteLine("[E]xit.");

// READING USER INPUT
Console.WriteLine("Type:");
string userChoice = Console.ReadLine();
Console.WriteLine("User input: " + userChoice);

// USER PRESSES ANY KEY TO CONTINUE RUNNING THE CODE
Console.ReadKey();

// VARIABLE DECLARATION AND INITIALIZATION
string userInput = "A";
Console.WriteLine(userInput);

// OPERATORS
int a = 2;
int b = 5;

Console.WriteLine("Addition: " + (a + b));
Console.WriteLine("Subtraction: " + (a - b));
Console.WriteLine("Multiplication: " + a * b);
Console.WriteLine("Division: " + a / b);

// TO INCREMENT VALUES BY ONE:
++a;
--b;
Console.WriteLine(a);
Console.WriteLine(b);

// EXPLICIT VARIABLES
string word = "ABC";
int number = 5;

// IMPLICIT VARAIABLES
var wordVar = "ABC";
var numberVar = 5;
