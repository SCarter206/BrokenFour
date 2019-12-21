using System;
using System.Collections.Generic;
using System.Text;

namespace BrokenFour
{
    class List1
    {
        public void ListOfNums(int total, char brokenNum)
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



            //for loop
            for (int i = 0; i <= options.Count; i++)
            {
                var option = options[i];
                for (int j = 0; j <= option.Length; i++)
                {
                    if (option[j] == brokenNum)
                    {
                        finalList.Remove(finalList[i]);
                    }
                }
            }
            
            
            //print list to console
            foreach (string option in finalList)
            {
                Console.WriteLine(option);
            }

        }
        
        
    }
}
