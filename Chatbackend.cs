using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.Threading.Channels;

namespace CyberBot_ST10436124
{
    internal class Chatbackend
    {

        // q1 add voice greeting 

        public void PlayGreeting()
        {
            string fileLocation = @"C:\Users\Oarabile Marwane\OneDrive - ADvTECH Ltd\Oarabile\2025\Semester 3\PROG6221  Programming 2A\PROG6221\2025\Term 1\ST10436124_PROG6221_PART1_POE\CyberBot_ST10436124\greetings.wav";

            if (File.Exists(fileLocation))
            {
                SoundPlayer player = new SoundPlayer(fileLocation);

                player.PlaySync(); 

            }
            else
            {
                Console.WriteLine("Greeting audio file not found: " + fileLocation);
            }


        }

        // q2 add a method to display the logo
        public void imageDisplay()
        {
            Console.WriteLine(@"                                                 @@@@@@                                             
                                               @@@@@@@@@@@                                          
                                            @@@@@@@@@@@@@@@@                                        
                                   @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@                               
                                   @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@                               
                                   @@@@@@@@@@@@@@      @@@@@@@@@@@@@@                               
                                   @@@@@@@@@@@@   @@@@   @@@@@@@@@@@@                               
                                   @@@@@@@@@@@  @@@@@@@@  @@@@@@@@@@@                               
                                   @@@@@@@@@@@  @@@@@@@@  @@@@@@@@@@@                               
                                   @@@@@@@@@@@  @@@@@@@@  @@@@@@@@@@@                               
                                   @@@@@@@@@@@  @@@@@@@@  @@@@@@@@@@@@                              
                                   @@@@@@@                    @@@@@@@@                              
                                   @@@@@@@  @@@@@@@@@@@@@@@@  @@@@@@@@                              
                                   @@@@@@@  @@@@@@@@@@@@@@@@  @@@@@@@@                              
                                   @@@@@@@  @@@@@@@  @@@@@@@  @@@@@@@@                              
                                   @@@@@@@  @@@@@@@@@@@@@@@@  @@@@@@@@                              
                                   @@@@@@@      @@@@@@@@@     @@@@@@@                               
                                   @@@@@@@@@@@@          @@@@@@@@@@@@                               
                                    @@@@@@@@@@@@@@@  @@@@@@@@@@@@@@@                                
                                     @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@                                 
                                       @@@@@@@@@@@@@@@@@@@@@@@@@@                                   
                                          @@@@@@@@@@@@@@@@@@@@                                      
                                             @@@@@@@@@@@@@@                                         
                                                @@@@@@@@");
        }

        // q3 Display a text-based welcome message with decorative boarderd 

        private string name;
        private bool cancel = false;
        //method gets name
        public void GetName()
        {
            cancel = false;
            
            do
            {
                Console.Write("\nPlease enter your name: ");
                name = Console.ReadLine();

                if (string.IsNullOrEmpty(name) || string.IsNullOrWhiteSpace(name))
                {
                    Console.Write("\nPlease enter a valid name: ");
                    

                }
                else
                {
                    cancel = true;
                }

            } while (!cancel);

             
        }

        // this method displays a welcome message with name
        public void WelcomeMessage()
        {
            // this method is used to get the name of the user
            GetName();
            // Decorative border and welcome message
            Console.WriteLine( "╔═══════════════════════════════════════════════╗");
            Console.WriteLine( "║             WELCOME " +name+ "                ");
            Console.WriteLine( "╚═══════════════════════════════════════════════╝\n");


            Console.WriteLine($"Welcome {name} to the CyberBot, the best cybersecurity chatbot");
        }

        public void Start()
        {
   
            // this methods is used to display a menu
            Console.WriteLine("1. Start Chat");
            Console.WriteLine("2. Exit");

            // this methods is used to get user input
            string input = Console.ReadLine();
            // this methods is used to check if the user input is valid
            if (input == "1")
            {
                //reponses();


            }
            else if (input == "2")
            {
               // cancel = true;
                Environment.Exit(0);
            }
        }

    }
}
