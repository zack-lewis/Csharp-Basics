﻿using System;

namespace Csharp_Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            // DECLARATIONS
            // Declare a constant of type byte named sample1 with an initial value of 0x3A
            const byte sample1 = 0x3a;
            //Console.WriteLine($"sample1: {sample1} -> {sample1.GetType()}");

			// Declare a variable of type byte named sample2 with an initial value of 58
            byte sample2 = 58;
            //Console.WriteLine($"sample2: {sample2} -> {sample2.GetType()}");

			// Declare a variable of type int named heartRate with an initial value of 85
            int heartRate = 85;
            //Console.WriteLine($"heartRate: {heartRate} -> {heartRate.GetType()}");

			// Declare a variable of type double named deposits that has an initial value of 135002796
            double deposits = 135002796;
            //Console.WriteLine($"deposits: {deposits} -> {deposits.GetType()}");

			// Declare a constant float named acceleration that has an initial value of 9.800
            const float acceleration = 9.800F;
            //Console.WriteLine($"acceleration: {acceleration} -> {acceleration.GetType()}");

			// Declare a variable float named mass that has an initial value of 14.6
            float mass = 14.6F;
            //Console.WriteLine($"mass: {mass} -> {mass.GetType()}");

			// Declare a variable double named distance that has an initial value of 129.763001
            double distance = 129.763001;
            //Console.WriteLine($"distance: {distance} -> {distance.GetType()}");

			// Declare a variable bool named lost that has an initial value of true
            bool lost = true;
            //Console.WriteLine($"lost: {lost} -> {lost.GetType()}");

			// Declare a variable bool named expensive that has an initial value of true
            bool expensive = true;
            //Console.WriteLine($"expensive: {expensive} -> {expensive.GetType()}");

			// Declare a variable int named choice with an initial value of 2
            int choice = 2;
            //Console.WriteLine($"choice: {choice} -> {choice.GetType()}");

			// Declare a constant of type char named integral that has a value of \u222B
            const char integral = '\u222B';
            //Console.WriteLine($"integral: {integral.ToString()} -> {integral.GetType()}");

			// Create a constant String named greeting that has an initial value of “Hello”
            const string greeting = "Hello";
            //Console.WriteLine($"greeting: {greeting} -> {greeting.GetType()}");

			// Create a variable String named name that has an initial value of “Karen”
            string name = "Karen";
            //Console.WriteLine($"name: {name} -> {name.GetType()}");


			// Compare sample1 to sample2 and if they are equal display “The samples are equal.” otherwise display “The samples are not equal.”
            if(sample1==sample2) {
                Console.WriteLine("The samples are equal.");
            }
            else {
                Console.WriteLine("The samples are not equal.");
            }

			// If heartRate is greater than equal to 40 and less than equal to 80 display “Heart rate is normal.” otherwise display “Heart rate is not normal.”
            if(heartRate>=40 && heartRate<=80){
                Console.WriteLine("Heart rate is normal.");
            }
            else {
                Console.WriteLine("Heart rate is not normal.");
            }

			// If deposits is greater than or equal to 100000000 display “You are exceedingly wealthy.” otherwise display “Sorry you are so poor.”
            if(deposits>=100000000) {
                Console.WriteLine("You are exceedingly wealthy.");
            }
            else {
                Console.WriteLine("Sorry you are so poor.");
            }

			// Declare a variable called force that is assigned to the mass times the acceleration. The force variable must be of the same type as the type that results from the multiplication of mass and acceleration.
            float force = mass * acceleration;

			// Display the calculated force preceded by the string “force = ”. The output should look like the following (actual value will be different): force = 2.345
            Console.WriteLine($"force = {force}");

			// Display the value of distance followed by “ is the distance.”
            Console.WriteLine($"{distance} is the distance.");

			// Using lost and expensive display “I am really sorry! I will get the manager.” if lost and expensive are both true and “Here is coupon for 10% off.” if lost is true and expensive is false.
            if (lost){ 
                if(expensive) {
                    Console.WriteLine("I am really sorry! I will get the manager.");
                }
                else {
                    Console.WriteLine("Here is coupon for 10% off.");
                }
            }

			// Use switch/case and the variable choice to display “You chose 1.” if choice is 1, “You chose 2.” if choice is 2, “You chose 3.” if choice is 3, and “You made an unknown choice.” if choice is something other than 1, 2, or 3.
            switch(choice) {
                case 1:
                    Console.WriteLine("You chose 1.");
                    break;
                case 2:
                    Console.WriteLine("You chose 2.");
                    break;
                case 3:
                    Console.WriteLine("You chose 3.");
                    break;
                default:
                    Console.WriteLine("You did not choose a valid option.");
                    break;
            }

			// Using the char constant integral, display the character in integral followed by the string “ is an integral.”
            // DEV NOTE: This does not show the symbol. Not sure why. 
            Console.WriteLine($"{integral} is an integral.");
            //Console.WriteLine(integral + " is an integral.");

			// Using a “for” loop count from 5 to 10 (inclusive of start and end) using an int variable i. Inside the loop display each value of i with a line that is “i = ” followed by the value of i as in:
			// i = 5
			// i = 6
			// i = 7
			// i = 8
			// i = 9
			// i = 10
            for(int i = 5; i <= 10; i++){
                Console.WriteLine($"i = {i}"); 
            }

			// Declare an int variable age with an initial value of 0. Using a “while” loop that continues while age is less than 6 display the value of age in a line that begins with “age = ” and is followed by the value of age. (Example: age = 3) After the age line is displayed increment the value of age by 1.
            int age = 0;
            while (age < 6) {
                Console.WriteLine($"age = {age}");
                age++;
            }

			// Display a line that contains the greeting String followed by a space followed by the name String.
            Console.WriteLine($"{greeting} {name}");

        }
    }
}
