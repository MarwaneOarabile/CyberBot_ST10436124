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
            Console.WriteLine("\n========= CYBERSECURITY AWARENESS BOT =========\n");
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
        bool cancel = false;
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
            Console.WriteLine($"║             WELCOME {name, -24} ║"               );
            Console.WriteLine( "╚═══════════════════════════════════════════════╝\n");


            Console.WriteLine($"Welcome {name} to the CyberBot, the best cybersecurity chatbot");
        }



        // this methods is used to display a menu

        
        public void StartMenu()
        {
            // this methods is used to display a menu

            
            Console.WriteLine("\n1. Start Chat");
            Console.WriteLine("2. Exit");
            Console.Write("\nPlease select an option from the menu Above: ");
            cancel = false;

            // this methods is used to get user input

            try
            {

                do
                {
                    string input = Console.ReadLine();
                    

                    if (string.IsNullOrEmpty(input) || string.IsNullOrWhiteSpace(input))
                    {
                        Console.Write("\nPlease enter a valid OPTION 1 or 2: ");


                    }
                    else
                    {
                        int inputConvertInt = int.Parse(input);

                        if (inputConvertInt == 1)
                        {
                            Console.WriteLine("\nStarting chat...");
                            reponses();
                            cancel = true;
                        }
                        else if (inputConvertInt == 2)
                        {
                            Console.WriteLine("\nExiting...");
                            cancel = true;
                        }
                        else
                        {
                            Console.Write("\nPlease enter a valid OPTION 1 or 2: ");

                        }
                        cancel = true;
                    }

                    
                    

                } while (!cancel);
            }

            catch (Exception)
            {
                Console.Write("\nI didn’t quite understand that. Could you rephrase?”  ");
                throw;
            }

            
            
        }

        // q4 Basic Response System

        private void reponses()
        {
            cancel = false;

            do
            {
                Console.WriteLine("Please Select a reponse from the list below: ");

                Console.WriteLine("1. Hello");
                Console.WriteLine("2. How are you?");
                Console.WriteLine("3. What is your purpose?");
                Console.WriteLine("4. What can I ask you about?");
                Console.WriteLine("5. What makes a password safe?");
                Console.WriteLine("6. What is phising?");
                Console.WriteLine("7. How do I safeley browse the internet");

                Console.WriteLine("8. Can I ask my own question?");

                Console.WriteLine("9. Cancel?");

                int userInput = 0;

                try
                {
                    userInput = int.Parse(Console.ReadLine());
                    if (userInput < 1 || userInput > 9)
                    {
                        Console.WriteLine("Please select a valid option");
                    }

                }
                catch (FormatException)
                {
                    Console.WriteLine("I didn’t quite understand that. Could you rephrase?");
                    continue; // Retry the input
                }






                switch (userInput)
                {
                    case 1:
                        Console.WriteLine("Hello");
                        break;
                    case 2:
                        Console.WriteLine("I am fine, thank you for asking");
                        break;
                    case 3:
                        Console.WriteLine("I am here to help you with your questions");
                        break;
                    case 4:
                        Console.WriteLine("You can ask me about anything");
                        break;
                    case 5:
                        Console.WriteLine("A safe password should be at least 8 characters long and should include a mix of letters, numbers, and symbols.");
                        break;
                    case 6:
                        Console.WriteLine("Phishing is a type of cyber attack where an attacker tries to trick you into giving them your personal information.");
                        break;
                    case 7:
                        Console.WriteLine("To safely browse the internet, you should use a VPN, avoid clicking on suspicious links, and keep your software up to date.");
                        break;
                    case 8:
                        userQuestion();

                        break;
                    case 9:
                        cancel = true;
                        break;
                }
                while (!cancel) ;

            } while (!cancel);


        }

        //allows user to ask their own questions
        public void userQuestion()
        {
            string userQuestion;
            Console.WriteLine("CyberBot: You can ask me a cybersecurity question, or type 'exit' to go back to the main menu.");

            do
            {

                Console.WriteLine("\nPlease ask your question:");
                userQuestion = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(userQuestion))
                {
                    Console.WriteLine("CyberBot: I didn’t quite understand that. Could you rephrase?");
                    continue; // skips to the next loop iteration
                }


                userQuestion = userQuestion.ToLower().Trim();

                Console.WriteLine("You asked: " + userQuestion);

                if (userQuestion == "exit")
                {
                    Console.WriteLine("CyberBot: Exiting Q&A mode. Goodbye for now, " + name + "!");
                    break;
                }
                else if (userQuestion.Contains("hello") || userQuestion.Contains("hi"))
                {
                    Console.WriteLine($"CyberBot: Hello {name}, as you know I am CyberBot.");
                }
                else if (userQuestion.Contains("how are you"))
                {
                    Console.WriteLine($"CyberBot: I am fine, thank you for asking, {name}.");
                }
                else if (userQuestion.Contains("cybersecurity"))
                {
                    Console.WriteLine("CyberBot: Cybersecurity is the practice of protecting systems, networks, and programs from cyber attacks.");
                }
                else if (userQuestion.Contains("password"))
                {
                    Console.WriteLine("CyberBot: A strong password must be longer than 8 characters and include a mix of uppercase, lowercase, numbers, and symbols.");
                }
                else if (userQuestion.Contains("phishing"))
                {
                    Console.WriteLine("CyberBot: Phishing is when someone tries to trick you into giving personal info by pretending to be someone you trust.");
                }
                else if (userQuestion.Contains("browsing") || userQuestion.Contains("safe"))
                {
                    Console.WriteLine("CyberBot: To browse safely: keep your software updated, use antivirus, and don’t click on suspicious links.");
                }
                else
                {
                    Console.WriteLine($"CyberBot: I'm sorry {name}, I don't have an answer for that yet.");
                }

            } while (true);

            Console.WriteLine("Returning to main menu...");
            reponses(); // Optionally return to the main menu

        }

    }
}
