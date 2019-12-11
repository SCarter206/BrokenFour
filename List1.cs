using System;
using System.Collections.Generic;
using System.Text;

namespace BrokenFour
{
    class List1
    {
        public void ListOfNums(int total, int brokenNum)
        {
            //List of strings that will be returned to user
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
            /*
            //loop to remove options containing broken number
            try
            {
                foreach (string i in options)
                {
                    if (i.Contains(brokenNum.ToString()))
                    {
                        options.Remove(i);
                    }


                }
            }catch (System.InvalidOperationException)
            {
                Console.WriteLine("System.InvalidOperationException");
                throw;
            }
            */

            //print final list of options that does not contain broken number
            foreach (string option in options)
            {
                Console.WriteLine(option);
            }

        }
        
        
    }
}
