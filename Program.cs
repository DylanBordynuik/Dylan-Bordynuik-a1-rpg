/*
 * Program Name: Forest Escape
 * Program Purpose: To create a simple text based adventure game using the console
 * Program Creator: Dylan Bordynuik
 */

using System;

public class Escape
{
    static void Main()
    {

        Console.WriteLine("You find yourself in a forest, unsure of which way is home.");
        Console.WriteLine("Choose a cardinal direction to head toward:");

        string input = Console.ReadLine();
        input = input.ToLower();

        if (input == "north")
        {
            Console.Clear();
            Console.WriteLine("You find yourself in front of an old hut, Do you knock or take a peek through an open window?");

            string input2 = Console.ReadLine();
            input2 = input2.ToLower();

            if (input2 == "knock")
            {

                Console.Clear();

                Console.WriteLine("The door swings open and you are greeted by the local witch,");
                Console.WriteLine("as you politely knocked, she offeres to show you the way home");

                Console.WriteLine("------------- GOOD END -------------");

                Console.ReadLine();

            }
            else if (input2 == "peek")
            {

                Console.Clear();

                Console.WriteLine("You peek through the window and are caught by the witch that lives here,");
                Console.WriteLine("I hope you enjoy living as a frog!");
                Console.WriteLine("------------- BAD END -------------");

                Console.ReadLine();

            }
        }
        else if(input == "south")
        {

            Console.Clear();

            Console.WriteLine("You find yourself at a clearing with a great tree in the middle.");
            Console.WriteLine("You are quite exhausted, do you take a nap or climb the tree for a better view?");

            string input3 = Console.ReadLine();
            input3 = input3.ToLower();

            if (input3 == "nap")
            {

                Console.Clear();

                Console.WriteLine("You slept too long and wasted too much time!");
                Console.WriteLine("The Vampires have reached the village!");
                Console.WriteLine();
                Console.WriteLine("------------- BAD END -------------");

                Console.ReadLine();
            }
            else if (input3 == "climb")
            {

                Console.Clear();

                Console.WriteLine("You spot the village from above the tree line, it was to the east all along!");
                Console.WriteLine("------------- GOOD END -------------");

                Console.ReadLine();
            }

        }
        else if (input == "east")
        {
            Console.Clear();

            Console.WriteLine("You head east for a long while, and eventually find your way back to the village!");
            Console.WriteLine("Now you can warn your friends about the vampires!");
            Console.WriteLine("------------- GOOD END -------------");

            Console.ReadLine();
        }
        else if (input == "west")
        {

            Console.Clear();

            Console.WriteLine("You find yourself at the edge of a dreary swamp.");
            Console.WriteLine("Do you go fishing or attempt to cross the swamp?");

            string input4 = Console.ReadLine();
            input4 = input4.ToLower();

            if (input4 == "fish")
            {

                Console.Clear();

                Console.WriteLine("You assemble a makeshift fishing rod and use some local insects as bait.");
                Console.WriteLine("The commotion and bait bugs in the water draw local Crocodiles!");
                Console.WriteLine("You've become croc chow!");
                Console.WriteLine("------------- BAD END -------------");

                Console.ReadLine();

            }
            else if (input4 == "cross")
            {

                Console.Clear();

                Console.WriteLine("You wade through the murky water, but something pulls you under by the ankle!");
                Console.WriteLine("Crossing crocodile infested waters may not have been the best idea...");
                Console.WriteLine("------------- BAD END -------------");

                Console.ReadLine();
            }
        }
    }
}
