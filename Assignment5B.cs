/* 
Class: CSE 1321L 
Section: #03 
Term: Fall 2023
Instructor: John Blake 
Name: Christopher Morrison
Lab#: Assignment5B
*/

using System;

class Assignment5B
{

    public static void Main(string[] args)
    {
        string[] line1 = { "_", "N", "_", "N", "N" };
        string[] line2 = { "_", "N", "_", "N", "_" };
        string[] line3 = { "_", "_", "_", "N", "_" };
        string[] line4 = { "N", "N", "_", "_", "W" };
        string[] line5 = { "_", "_", "_", "N", "N" };
        string[][] maze= {line1, line2, line3, line4, line5};
        int x = 0, y = 4;
       
        Console.WriteLine("[Maze Game]");
        do
        {
            maze[y][x] = "P";
            foreach (string[] line in maze)
            {
                foreach (string l in line)
                {
                    Console.Write(l + ".");
                }
                Console.WriteLine();
            }
            Console.Write("Which direction do you want to move? ");
            string direction= Console.ReadLine();
            if (direction == "Right")
            {
                maze[y][x] = "_";
                x++;
            }
            else if (direction == "left")
            {
                maze[y][x] = "_";
                x--;
            }
            else if (direction == "Up")
            {
                maze[y][x] = "_";
                y--;
            }
            else if (direction == "Down")
            {
                maze[y][x] = "_";
                y++;
            }
            else
            {
                Console.WriteLine("That’s not a valid direction!");
            }

        } while (maze[3][4] != "P");
        Console.WriteLine("\nYou win!");
        
    }
}
