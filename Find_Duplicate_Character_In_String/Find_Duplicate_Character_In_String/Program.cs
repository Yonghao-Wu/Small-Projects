using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Find_Duplicate_Character_In_String
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("I can find duplicates in the string you type in \nEnter string here: \n");

            string user_input = Console.ReadLine();//Get the user input

            //Create a list of Tuples with character, integer, and a list of integers as its parameters
            //Character to find which character has a duplicate
            //Integer to count the number of duplicates of the character
            //List of integers to find the index of the duplicated characters
            List<Tuple<char, int, List<int>>> list_of_char = new List<Tuple<char,int, List<int>>>();

            //Create a list of characters
            List<char> list = new List<char>();

            bool duplicates_exist = false;//Let's assume that there are no duplicates to begin with

            
            foreach(char c in user_input)
            {
                //Create temporary count for duplicates, index and list of index objects. 
                //Garbage collection will destroy after each iteration and will recreate it.
                int count = 0;
                int count_for_index = 0; 
                List<int> indexes = new List<int>(); 

                //Compare the character that's being looked at to the string
                foreach(char ch in user_input)
                {
                    //Every iteration in this loop will increment the count_for_index object by one, this will give you the position of the character
                    count_for_index += 1; 

                    if(c == ch)
                    {
                        //If there is a match between the character that's being looked at and the character in the string iteration
                        //increment the count for duplicates and log the count_for_index. 
                        count += 1;
                        indexes.Add(count_for_index);
                    }
                }

                //If the list of characters don't have the character that's being looked at, and if the character being looked at is not a space, 
                //and if the count for duplicates is above 1, add the character to the list and add the new tuple to the list of tuples.
                if (!list.Contains(c) && c != char.Parse(" ") && count > 1)
                {
                    duplicates_exist = true;//If count is above 1, turn duplicates_exist value to true
                    list.Add(c);
                    list_of_char.Add(new Tuple<char, int, List<int>>(c, count, indexes));
                }
            }

            //Results
            if (duplicates_exist == true)//If there are duplicates, then
            {
                Console.WriteLine("\nList of characters that are duplicated in the string: \n");

                foreach (Tuple<char, int, List<int>> ch in list_of_char)
                {
                    Console.Write("Character: " + ch.Item1 + ", Count: " + ch.Item2 + ", Indexes: ");

                    foreach (int item in ch.Item3)
                    {
                        if (item != ch.Item3.Last())//If index is not the last item in the list, add a comma after 
                        {
                            Console.Write(item + ", ");
                        }
                        else//Otherwise, no commas. 
                        {
                            Console.Write(item);
                        }

                    }

                    Console.WriteLine();
                }
            }
            else//If there are no duplicates, then
            {
                Console.WriteLine("\nThere are no duplicates in your string.");
            }

            Console.ReadKey(); 
        }
    }
}
