using System; 
using System.Collections.Generic;
using System.IO;


class Program
{
    static void Main(string[] args)
    {   
        List<string>menu = new List<string>();
        menu.Add ("1.Write");
        menu.Add ("2.Display");
        menu.Add ("3.Load");
        menu.Add ("4.Save");
        menu.Add ("5.Quit");



        int user = -999999999;

        

        //declares the integer loop variable beforehand, help from Kodfy.net
        // int index = 1;
        



        Journal theEntry = new Journal();
        
        while (user != 5)
        {

            //checks the list (Menu) and print them with index starting from 1
            
            foreach (string value in menu)
            {
                // Console.WriteLine($"{index}. {value}");
                // index  ++;

            
                Console.WriteLine(value); 

            
            }
            Console.Write("What would you like to do? ");
            user = int.Parse(Console.ReadLine());
            
            

            if (user == 1)
            {
                


                PromptGenerators Hint = new PromptGenerators();
                string  myHints = Hint.GetRandomPromt();

                DateTime theCurrentTime = DateTime.Now;
                string dateText = theCurrentTime.ToShortDateString();

                
                Entry userInput = new Entry();
                userInput._date = dateText;

                userInput._promptText = myHints;

                Console.WriteLine(myHints);

                string userinput = Console.ReadLine();
                userInput._entryText = userinput;
                
                
                // this adds the code to a list in the journal       
           

                theEntry.AddEntry(userInput);

                
            }


            else if (user == 2)

            {
                // calls the display mettod of the entry
                        
                theEntry.DisplayAll();                                                  
                               
            }

            else if (user == 3)
            {
                Console.Write("What is the file name? ");
                string  userInput2 = Console.ReadLine();
                theEntry.LoadFromFile(userInput2);

                theEntry.DisplayAll();   
                
            }


            else if (user == 4)
            
            {
                
                Console.Write("What is the file name? ");
                string  userInput2 = Console.ReadLine();

                theEntry.SaveToFile(userInput2);

                

                

                
            }

                       
 
        
            


        }             


    }         
                    
}