using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome To Joseph's Mindfulness Program ");

        
        List<string>menu = new List<string>();
        menu.Add ("1. Start Breathing Activity");
        menu.Add ("2. Start Reflecting Activity");
        menu.Add ("3. Start Listing Activity");
        menu.Add ("4. Quit");

       

        int user = -999999999;

       

        while (user != 4 )
        {

            //checks the list (Menu) and print them with index starting from 1
            
            foreach (string value in menu)
            {
                // Console.WriteLine($"{index}. {value}");
                // index  ++;

            
                Console.WriteLine(value); 

            
            }
            Console.Write("Select a Choice from the menu: ");
            user = int.Parse(Console.ReadLine());


            if (user == 1)
            {
                BreathingActivity breath = new BreathingActivity("Breathing Activity", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
                
                breath.DisplayStartingMessage();
                int input = int.Parse(Console.ReadLine());

                //using while loop to time the inner programe
                DateTime startTime = DateTime.Now;
                DateTime endTime = startTime.AddSeconds(input);
                while (DateTime.Now < endTime)
                {
                    breath.Run();
                }

                //Displaying the ending message
                breath.DisplayEndingMessage();
                breath.ShowSpinner();
                Console.Clear();
            }


            else if(user == 2)
            {
                ReflectingActivity reflect = new ReflectingActivity("Reflecting Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");

                reflect.DisplayStartingMessage();
                int input2 = int.Parse(Console.ReadLine());

                //using while loop to time the inner programe
                DateTime startTime = DateTime.Now;
                DateTime endTime = startTime.AddSeconds(input2);
                while (DateTime.Now < endTime)
                {
                    Console.Clear(); //Clearing the console to make the output clean
                    reflect.Run();
                    Console.WriteLine(); // to make line spacing
                    
                    reflect.DisplayPrompt();
                
                    Console.ReadLine();
                    Console.WriteLine(); // to make line spacing
                    Console.WriteLine("Now ponder on each of the following question as they related to this experience.");
                    Console.Write("You may begin in: ");
                    reflect.ShowCountDown(5);

                    Console.Clear(); //Clearing the console to make the output clean
                    reflect.DisplayQuestions();
                    reflect.ShowSpinner();
                    Console.WriteLine(); // to make line spacing
                    Console.WriteLine();

                    reflect.DisplayQuestions();
                    reflect.ShowSpinner();
                    Console.WriteLine(); // to make line spacing
                    Console.WriteLine();

                    reflect.DisplayQuestions();
                    reflect.ShowSpinner();
                    Console.WriteLine(); // to make line spacing
                    Console.WriteLine();

                    reflect.DisplayQuestions();
                    reflect.ShowSpinner();
                    Console.WriteLine(); // to make line spacing
                    Console.WriteLine();

                    reflect.DisplayQuestions();
                    reflect.ShowSpinner();
                    Console.WriteLine(); // to make line spacing
                    Console.WriteLine();

                    
                    reflect.DisplayQuestions();
                    reflect.ShowSpinner();
                    Console.WriteLine(); // to make line spacing
                    Console.WriteLine();

            
                }
                reflect.DisplayEndingMessage();
                reflect.ShowSpinner();

                
                Console.Clear();                                       


            }

            else if(user == 3)
            {
                ListingActivity myListing = new ListingActivity("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
            
                myListing.DisplayStartingMessage();
                int input3 = int.Parse(Console.ReadLine());

                //using while loop to time the inner programe
                DateTime startTime = DateTime.Now;
                DateTime endTime = startTime.AddSeconds(input3);
                while (DateTime.Now < endTime)
                {
                    Console.Clear();
                    myListing.Run();
                    Console.WriteLine();

                    myListing.DisplayPrompt();
                    string user4 = Console.ReadLine();
                    Console.WriteLine();
                    //calling the add method to add whatever the user enters to _myListing list 
                    // for future update
                    myListing.GetListFromUser(user4);  

                    
                    string user5= Console.ReadLine();
                    Console.WriteLine();
                    //calling the add method to add whatever the user enters to _myListing list 
                    // for future update
                    myListing.GetListFromUser(user5);  

                   
                    string user6= Console.ReadLine();
                    Console.WriteLine();
                    //calling the add method to add whatever the user enters to _myListing list 
                    // for future update
                    myListing.GetListFromUser(user6);  



                    
                    string user7= Console.ReadLine();
                    Console.WriteLine();
                    //calling the add method to add whatever the user enters to _myListing list 
                    // for future update
                    myListing.GetListFromUser(user7);  


                   
                    string user8= Console.ReadLine();
                    Console.WriteLine();
                    //calling the add method to add whatever the user enters to _myListing list 
                    // for future update
                    myListing.GetListFromUser(user8);  


                   
                    string user9= Console.ReadLine();
                    Console.WriteLine();
                    //calling the add method to add whatever the user enters to _myListing list 
                    // for future update
                    myListing.GetListFromUser(user9);   


                    string user10= Console.ReadLine();
                    Console.WriteLine();
                    //calling the add method to add whatever the user enters to _myListing list 
                    // for future update
                    myListing.GetListFromUser(user10);                                  
                                                                
                                 

                }

            
                myListing.DisplayEndingMessage();
                myListing.ShowSpinner();

                Console.Clear(); 
            } 

            
            
            

            else
            {
                break;


          


            }
        }
        



    }
}