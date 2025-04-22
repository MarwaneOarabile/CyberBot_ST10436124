//st10436124 POE Part 1
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.Threading.Channels;
using System.Globalization;


namespace CyberBot_ST10436124
{
    internal class Chatbackend
    {

        // q1 add voice greeting 

        public void PlayGreeting()
        {
            // relative path to the audio file
            string fileLocation = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources", "greetings.wav");

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
            string asciiArtLogo = @"                                                 @@@@@@                                             
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
                                                @@@@@@@@";


            Console.WriteLine("\n ========= CYBERSECURITY AWARENESS BOT =========\n");
            Console.WriteLine(asciiArtLogo);
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
                TypingEffect("Please enter your name: ");
                name = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(name))
                {
                    TypingEffect("Please enter a valid name.");
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
            GetName();
            
            PrintDivider();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("╔═══════════════════════════════════════════════╗");
            Console.WriteLine($"║             WELCOME {name.ToUpper(),-25} ║");
            Console.WriteLine("╚═══════════════════════════════════════════════╝");
            Console.ResetColor();
            TypingEffect($"Welcome {name} to the CyberBot, the best cybersecurity chatbot!");
        }



        // this methods is used to display a menu


        public void StartMenu()
        {
            PrintDivider();
            PrintHeader("Main Menu");

            Console.WriteLine("\n1. Start Chat");
            Console.WriteLine("2. Exit");
            Console.Write("\nPlease select an option from the menu above: ");
            cancel = false;

            do
            {
                string input = Console.ReadLine();

                // Check if input is not empty and contains only digits
                if (string.IsNullOrWhiteSpace(input))
                {
                    TypingEffect("\nPlease enter a valid OPTION 1 or 2:");
                }
                else
                {
                    // Manually check if the input is a valid integer and within range
                    if (input.Length == 1 && input[0] >= '1' && input[0] <= '2')
                    {
                        int inputConvertInt = input[0] - '0';  // Convert char to integer

                        if (inputConvertInt == 1)
                        {
                            TypingEffect("\nStarting chat...");
                            reponses();
                            cancel = true;
                        }
                        else if (inputConvertInt == 2)
                        {
                            TypingEffect("\nExiting...");
                            cancel = true;
                        }
                    }
                    else
                    {
                        // Invalid input; prompt for retry
                        TypingEffect("\nInvalid input. Please enter OPTION 1 or 2:");
                    }
                }

            } while (!cancel);
        }


        // q4 Basic Response System

        private void reponses()
        {
            cancel = false;

            do
            {
                PrintDivider();
                PrintHeader("Cyber Questions");
                Console.WriteLine("1. Hello");
                Console.WriteLine("2. How are you?");
                Console.WriteLine("3. What is your purpose?");
                Console.WriteLine("4. What can I ask you about?");
                Console.WriteLine("5. What makes a password safe?");
                Console.WriteLine("6. What is phishing?");
                Console.WriteLine("7. How do I safely browse the internet?");
                Console.WriteLine("8. Can I ask my own question?");
                Console.WriteLine("9. Cancel");

                Console.Write("\nPlease select an option from the menu above: ");

                int userInput = 0;

                try
                {
                    userInput = int.Parse(Console.ReadLine());
                    if (userInput < 1 || userInput > 9)
                    {
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        TypingEffect("CyberBot: Please select a valid option.");
                        Console.ResetColor();
                        continue;
                    }
                }
                catch (FormatException)
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    TypingEffect("CyberBot: I didn’t quite understand that. Could you rephrase?");
                    Console.ResetColor();
                    continue;
                }

                switch (userInput)
                {
                    case 1:
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        TypingEffect("CyberBot: Hello");
                        Console.ResetColor();
                        break;
                    case 2:
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        TypingEffect("CyberBot: I am fine, thank you for asking");
                        Console.ResetColor();
                        break;
                    case 3:
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        TypingEffect("CyberBot: I am here to help you with your questions");
                        Console.ResetColor();
                        break;
                    case 4:
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        TypingEffect("CyberBot: You can ask me about cybersecurity topics.");
                        Console.ResetColor();
                        break;
                    case 5:
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        TypingEffect("CyberBot: A safe password should be at least 8 characters long and include a mix of letters, numbers, and symbols.");
                        Console.ResetColor();
                        break;
                    case 6:
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        TypingEffect("CyberBot: Phishing is a type of cyber attack where an attacker tries to trick you into giving them your personal information.");
                        Console.ResetColor();
                        break;
                    case 7:
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        TypingEffect("CyberBot: To safely browse the internet, use a VPN, avoid suspicious links, and keep your software updated.");
                        Console.ResetColor();
                        break;
                    case 8:
                        userQuestion(); // Inside that method, you can also color the bot's responses similarly
                        break;
                    case 9:
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        TypingEffect("CyberBot: Returning to main menu...");
                        Console.ResetColor();
                        cancel = true;
                        break;
                }

            } while (!cancel);
        }

        //allows user to ask their own questions
        public void userQuestion()
        {
            string userQuestion;
            Console.WriteLine("CyberBot: You can ask me a cybersecurity question, or type 'exit' to go back to the main menu.");

            do
            {

                Console.Write("\nPlease ask your question:");
                userQuestion = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(userQuestion))
                {
                    Console.WriteLine("CyberBot: I didn’t quite understand that. Could you rephrase?");
                    continue; // skips to the next loop iteration
                }


                userQuestion = userQuestion.ToLower().Trim();

                Console.WriteLine("You asked: " + userQuestion);

                if (userQuestion.Contains("exit")) 
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

        // q6 add visual elements to the chatbot

        // this method is used to format colour and and divider

        public void PrintDivider()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\n════════════════════════════════════════════════════════════");
            Console.ResetColor();
        }

        // this method is used to add typing effect to the text
        public void TypingEffect(string message, int delay = 15)
        {
            foreach (char c in message)
            {
                Console.Write(c);
                Thread.Sleep(delay);
            }
            Console.WriteLine(); // Move to next line after message
        }

        public void PrintHeader(string header)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n===== " + header.ToUpper() + " =====");
            Console.ResetColor();
        }

    }
}
