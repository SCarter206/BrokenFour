using System;
using System.Collections.Generic;
using System.Text;

namespace BrokenFour
{
    class List1
    {
        public void ListOfNums(int total, char brokenNum)
        {
            //List of strings 
            List<string> options = new List<string>();
            
            //decloration of list one and two
            List<int> listOne = new List<int>();
            for (int i = 0; i <= total; i++)
            {
                listOne.Add(i);
            }
            List<int> listTwo = new List<int>();
            for (int i = 0; i <= total; i++)
            {
                listTwo.Add(i);
            }
            
            //loop to create list of numbers that equal total
            foreach(int i in listOne)
            {
                foreach(int j in listTwo)
                {
                    if (i + j == total)
                    {
                        string newString = i + " and " + j + " are an option";
                        options.Add(newString); 
                    }
                }
            }

            //creats a list without the broken number present
            List<string> listThree = new List<string>();
            foreach(string option in options)
            {
                if (FilterOfChar(option, brokenNum) == true)
                {
                    listThree.Add(option);
                }
                else
                {
                    continue;
                }
            }
            //Remove first and last option on list
            listThree.RemoveAt(0);
            listThree.Reverse();
            listThree.RemoveAt(0);
            listThree.Reverse();

            //acount for number of options removed
            int NumberOfOptions = listThree.Count / 2; 
            //to remove repeat options from list
            listThree.RemoveRange(0, NumberOfOptions);

            //prints listThree
            foreach(string option in listThree)
            {
                Console.WriteLine(option);
            }
            

           

        }
        //-------------------------------------------------------------------------------------------------------------------------------------------------
        //function intended to filter each string and remove those with brokenNum creating listThree
        public static bool FilterOfChar(string sentence, char brokenNumber)
        {
            bool is_option = true;
            foreach (char i in sentence)
            {
                if (i == brokenNumber)
                {
                    is_option = false;
                    break;
                }
                else
                {
                    is_option = true;
                    continue;
                }
            }

            return is_option;


        }




    }
}

   

