// Banson Sy
// 8/7/23
// Mini Challenge 2: Add 2 Numbers
// Tasked with creating a console project that adds two numbers.

// Peer Reviewer: Neng Lao. Gave specific notes on how to form the sentence at the end. Explained Convert.ToInt32. 

Console.WriteLine("For this challenge, add two numbers together.");

Console.WriteLine("Please enter the first number:");
int numberOne = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Please enter the second number:");
int numberTwo = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Your total number is" + " " + (numberOne + numberTwo) + ".");

// int total = numberOne + numberTwo;
// Banson Notes: At first within the total variation, it would concatenate. Neng's advice helped me figure it out. 