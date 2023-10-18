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
    public static bool Wall(int y,int x, string[][]maze)
    {
        if (maze[y][x] == "N")
        {
            Console.WriteLine("You hit a wall – Game Over!");
            return true;
        }
        else
        {
            return false;
        }
    }
    public static bool Bounds(int y,int x)
    {
        if (x < 0 || y < 0 || x > 4 || y > 4)
        {
            Console.WriteLine("You can’t move there – it’s out of bounds!");
            return true;
        }
        else { return false; }
    }
    public static void Main(string[] args)
    {
        string[] line1 = { "_", "N", "_", "N", "N" };
        string[] line2 = { "_", "N", "_", "N", "_" };
        string[] line3 = { "_", "_", "_", "N", "_" };
        string[] line4 = { "N", "N", "_", "_", "W" };
        string[] line5 = { "_", "_", "_", "N", "N" };
        string[][] maze = { line1, line2, line3, line4, line5 };
        int x = 0, y = 4;

        Console.WriteLine("[Maze Game]");
        do
        {
            maze[y][x] = "P";
            Console.WriteLine();
            foreach (string[] line in maze)
            {
                foreach (string l in line)
                {
                    Console.Write(l + ".");
                }
                Console.WriteLine();
            }
            Console.Write("Which direction do you want to move? ");
            string direction = Console.ReadLine();
            if (direction == "Right")
            {
                maze[y][x] = "_";
                x++;
                if (Bounds(y, x) == true) { x--; }
                if (Wall(y, x, maze) == true) { break; }
               
            }
            else if (direction == "Left")
            {
                maze[y][x] = "_";
                x--;
                if (Bounds(y, x) == true) { x++; }
                if (Wall(y, x, maze) == true) { break; }
                
            }
            else if (direction == "Up")
            {
                maze[y][x] = "_";
                y--;
                if (Bounds(y, x) == true) { y++; }
                if (Wall(y, x, maze) == true) { break; }
                
            }
            else if (direction == "Down")
            {
                maze[y][x] = "_";
                y++;
                if (Bounds(y, x) == true) { y--; }
                if (Wall(y, x, maze) == true) { break; }
                
            }
            else
            {
                Console.WriteLine("That’s not a valid direction!");
            }
            maze[y][x] = "P";

        } while (maze[3][4] == "W");
        if (maze[3][4]=="P")Console.WriteLine("\nYou win!");

    }
}