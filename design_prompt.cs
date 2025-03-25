using System;
using System.Media;
using System.IO;
using System.Collections;

namespace poe_part1
{
    
    public class design_prompt
    {
        //variable declaration [Global]
        private string user_name = string.Empty;
        private string user_asking = string.Empty;

        //constructor
        public design_prompt()
        {
            //playing audio before anything else
            new playNow();

           
            //displaying ascii art
            new asciiArt();



         
            //welcoming the user and prompting the name
            //we are also changing the color
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("-----------------------------------------------------------------------------");
            //changing color for the message again
            Console.ForegroundColor= ConsoleColor.Blue;
            Console.WriteLine("|    Welcome to AI ChatBot. I'm here to help you stay safe online!        |");
            //changing it to green to repeat the color
            Console.ForegroundColor=ConsoleColor.Cyan;
            Console.WriteLine("-----------------------------------------------------------------------------");

            //AI asks for the user name
            Console.ForegroundColor= ConsoleColor.Magenta;
            Console.Write("\nHello! What is your name? ");

            Console.ForegroundColor = ConsoleColor.Blue;
            string userName = Console.ReadLine();

           

            //where user enters their name, before do while loop
            //change color for user's name
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("You:->  ");
            //reset the color to white so user can see what they enter
            Console.ForegroundColor = ConsoleColor.White;
            //ask for name
            user_name = Console.ReadLine();

            //re-create the interface
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("ChatBot:-> ");
            //resetting color to gray for the question
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Hi " + user_name + ", can I assist you today?");
            Console.WriteLine("Type 'exit' anytime to quit the chat.");

            //we have the username collected from the user
            //proceeds to do_while

            // chat loop
            do
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(user_name + ":-> ");
                Console.ForegroundColor = ConsoleColor.White;
                user_asking = Console.ReadLine();

                // check if user typed "exit"
                if (user_asking.Trim().ToLower() == "exit")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"ChatBot:-> Goodbye {user_name}, stay safe online.");
                    break;
                }

                // call filter class to process user input
                new Filter(user_asking);
                
            } while (true); // loop continues until break




        }//end of constructor




        // this class stores chatbot responses and topics
        public class Filter
        {
            // Declare ArrayLists for questions and ignored words
            private ArrayList questions = new ArrayList();
            private ArrayList ignore = new ArrayList();
            private ArrayList answers = new ArrayList();

            // Constructor
            public Filter(string userInput)
            {
                // Store topics and ignored words
                questions.Add("phishing");
                answers.Add  ("Never provide personal financial info, including your SS number, account number or passwords, over the internet unless you initiated the contact."); 

                questions.Add("firewall");
                answers.Add  ("Regularly update your firewall to help prevent hacking, malware, and data breaches while ensuring privacy and compliance.");

                questions.Add("how are you");
                answers.Add  ("I'm just a bot, but I'm functioning optimally.");

                questions.Add("what can i ask you");
                answers.Add  ("You can ask about password security, phishing, or safe browsing.");

                questions.Add("password security");
                answers.Add  ("Never reuse passwords across different sites, use a password manager.");

                questions.Add("malware");
                answers.Add  ("Keep your antivirus software updated to protect against malware.");

                questions.Add("public wifi");
                answers.Add  ("Using public Wi-Fi can expose you to various risks like malware infection, and identity theft. Stay alert!");

                ignore.Add("tell");
                ignore.Add("me");
                ignore.Add("about");
                ignore.Add("please");
                ignore.Add("the");
                ignore.Add("and");
                ignore.Add("how");

                // Process and display response
                ProcessQuestion(userInput);
            }

            // Method to process input and filter responses
            private void ProcessQuestion(string input)
            {
                // Convert input to lowercase
                input = input.ToLower();

                // Check for an exact match first
                if (questions.Contains(input))
                {
                    int exactIndex = questions.IndexOf(input);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("ChatBot:-> " + answers[exactIndex]);
                    return;
                }

                // Split input into words and filter
                string[] filteredWords = input.Split(' ');
                ArrayList validWords = new ArrayList();

                foreach (string word in filteredWords)
                {
                    if (!ignore.Contains(word))
                    {
                        validWords.Add(word);
                    }
                }

                // Match valid words with questions and collect responses
                ArrayList responses = new ArrayList();
                foreach (string validWord in validWords)
                {
                    for (int i = 0; i < questions.Count; i++)
                    {
                        if (questions[i].ToString().Contains(validWord))
                        {
                            if (!responses.Contains(answers[i]))
                            {
                                responses.Add(answers[i]); // Avoid duplicate responses
                            }
                        }
                    }
                }

                // Display results
                if (responses.Count > 0)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("ChatBot:-> " + string.Join(" + ", responses.ToArray()));
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("ChatBot:-> Please search something related to cybersecurity.");
                }
            }
        }



    }//end of class
}//end of namespace
