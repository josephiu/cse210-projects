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
        
        while (user != 5)
        {

            //checks the list (Menu) and print them with index starting from 1
            
            foreach (string value in menu)
            {
                // Console.WriteLine($"{index}. {value}");
                // index  ++;

            
                Console.WriteLine(value); 

            
            }
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

                Journal theEntry = new Journal();

                theEntry.AddEntry(userInput);

                theEntry.DisplayAll();
                                            


            }


            else if (user == 2)

            {
                
                Journal showList = new Journal();               
                                                                        
                               
                showList.DisplayAll();
                
                Console.WriteLine("saved");
            }

                  
                                  

                     
        
            


        }             


    }         
                    
}