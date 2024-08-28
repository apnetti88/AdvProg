// See https://aka.ms/new-console-template for more information
Console.WriteLine("What's up?");

//This is declaring the variables then initializing it to zero. 


float num1 = 0;   float num2 = 0;

// Display the title as the C# console calculator app. 

Console.WriteLine("Console Calculator in C#\r");
Console.WriteLine("------------------------\n");




// Ask the user to give some random number 
Console.WriteLine(" Type a number, to add subtract or do whatever");
num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Choose another number to add subtract or do whatever"); 
num2 = Convert.ToInt32(Console.ReadLine()); 




//Ask the user to choose some random number or whatever

Console.WriteLine("Choose an option from the following list:");
Console.WriteLine("\ta - Add");
Console.WriteLine("\ts - Subtract");
Console.WriteLine("\tm - Multiply");
Console.WriteLine("\td - Divide");
Console.Write("You'r option?"); 


//Using a switch statement to do the math 

switch (Console.ReadLine())
{
    case "a":
        Console.WriteLine($"Your result: {num1} + {num2} = " +(num1 +num2));
        break;
    case "s":
         Console.WriteLine($"Your result: {num1} - {num2} = " + (num1 - num2));
        break;
    case "m":
        Console.WriteLine($"Your result: {num1} * {num2} = " + (num1 * num2));
        break;
    case "d":
        Console.WriteLine($"Your result: {num1} / {num2} = " + (num1 / num2));
        break;

}

//Waut for the user to respond before closing

Console.Write("Press any key to close the Calculator console app..."); 
Console.ReadKey();