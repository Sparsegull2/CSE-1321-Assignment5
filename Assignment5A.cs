/* 
Class: CSE 1321L 
Section: #03 
Term: Fall 2023
Instructor: John Blake 
Name: Christopher Morrison
Lab#: Assignment5A
*/

using System;
class Assignment5A
{

    public static void Main(string[] args)
    {
        string[] friends = {" ", " ", " ", " ", " ", " ", " ", " ", " ", " " };
        Console.WriteLine("[Top 10 Friend’s List]");
        int choice=0,slot=0;
        string name;
        do
        {
            Console.Write("\nWhat would you like to do?\n1) Enter a friend’s name\n2) Replace a friend’s name\n3) Display your friends list\n4) Quit\nYour choice:");
            choice= int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.Write("\nEnter a name: ");
                    name = Console.ReadLine();
                    if (slot < 10)
                    {
                       
                        foreach (string f in friends)
                        {
                            if (f == name)
                            {
                                Console.WriteLine("Sorry, they’re already on the list!");
                                break;
                            }
                        }
                        friends[slot] = name;
                        slot++;
                    }
                    else
                    {
                        Console.WriteLine("Sorry, your friends list is full!");
                    }
                    break;
                    case 2:
                    Console.Write("\nEnter an index: ");
                    int index=int.Parse(Console.ReadLine());
                    Console.Write("Enter a name: ");
                    name=Console.ReadLine();
                    if (index < 10 && friends[index]!=" ")
                    {
                        string change= friends[index];
                        friends[index] = name;
                        Console.WriteLine("\n"+name+" has replaced "+change+" on your friends list!");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, that’s an invalid command!");
                    }
                    break;
                    case 3:
                    int rank = 0;
                    foreach (string s in friends)
                    {
                        rank++;
                        Console.WriteLine(rank + ") " + s);
                    }
                    break;
                    case 4:
                    Console.WriteLine("[Program Ends]");
                    break;
                default:
                    Console.WriteLine("Invalid Choice");
                    break;
            }
        } while (choice!=4); 
            
    }
}
