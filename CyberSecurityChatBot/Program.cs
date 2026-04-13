using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Threading;// added this to contribut ein aiding with bitmap and image manipulation for the ascii image

namespace CyberSecurityChatBot
{

    internal class Program
    {
        User user = new User();//this is how i extract user data from the filled in data and store it


        static void Main(string[] args)
        {

            Program obj = new Program();

            obj.welcomesound();//this will play the wav sound clip
            obj.asciilogo();//this will end up showing both manual and image ascii, so the logo and image
            obj.getUserDetails();
            obj.wellcomeUser();
            //obj.cybersecurityquestions();
            //obj.cyberResponse();
            obj.startchat();
        }

        public void welcomesound()
        {
            SoundPlayer player = new SoundPlayer("Khosi.wav");
            //record welcomng sound
            //soundplayer is calss used tto play sound

            // execute sound
            player.PlaySync();//currently eperiencing an error here
            //had to place my wav file in the debug folder, going to test if it works will comment next
            //if it does
            //changed the recording and shortened it

            //add sound to folder make sure wav format
            //PlayeSync allows Audio to play before ASCII shows

        }

        public void asciilogo()
        {

            Console.ForegroundColor = ConsoleColor.Red;

            Console.Write(@"


88  dP 88  88  dP""Yb  .dP""Y8 88                                                          
88odP  88  88 dP   Yb `Ybo."" 88                                                          
88""Yb  888888 Yb   dP o.`Y8b 88                                                          
88  Yb 88  88  YbodP  8bodP' 88                                                          
 dP""""b8 Yb  dP 88""""Yb 888888 88""""Yb                                                      
dP   `""  YbdP  88__dP 88__   88__dP                                                      
Yb        8P   88""""Yb 88""""   88""Yb                                                       
 YboodP  dP    88oodP 888888 88  Yb                                                      
.dP""Y8 888888  dP""""b8 88   88 88""""Yb 88 888888 Yb  dP      dP""""b8 88  88    db    888888 
`Ybo."" 88__   dP   `"" 88   88 88__dP 88   88    YbdP      dP   `"" 88  88   dPYb     88   
o.`Y8b 88""""   Yb      Y8   8P 88""Yb  88   88     8P       Yb      888888  dP__Yb    88   
8bodP' 888888  YboodP `YbodP' 88  Yb 88   88    dP         YboodP 88  88 dP""""""""Yb   88   
88""""Yb  dP""Yb  888888                                                                
88__dP dP   Yb   88                                                                  
88""""Yb Yb   dP   88                                                                  
88oodP  YbodP    88                                                                  


                                    ");


            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(@"
              
                              
                            [^_^]
                            /| |\
                             / \");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(@"

                     ========================
                      KHOSI CYBER SECURITY BOT
                     ========================
                       you are now PLUGGED in
                     ========================
                                ");
            //create a cyber security themed iiamge
            //ASCII logo
            //now call ascii image
            //asci();//get this ammended image doesnt display as well as sound
            //removing te png that i wanted to dsplay would ratgher dplay an asci image
        }

        public void drawline()
        {
            Console.WriteLine("=========================================================================================================");
        }//done to create borders and simulate a more interactive console experience
        private void getUserDetails()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Personal Details: \n");
            //User user = new User();
            drawline();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Enter your Name:    ");
            user.studentName = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Enter your Surname:    ");
            user.studentSurname = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Enter your Student Number:  ");
            user.studentID = Console.ReadLine();
            drawline();

            while (string.IsNullOrWhiteSpace(user.studentName))
            {
                Console.Write("Nmaer cannot be empty");
                Console.Write("Enter your name:    ");
                user.studentName = Console.ReadLine();
                drawline();
            }
            while (string.IsNullOrWhiteSpace(user.studentSurname))
            {
                Console.Write("Student Surname cannot be empty");
                Console.Write("Enter your Surname:    ");
                user.studentSurname = Console.ReadLine();
                drawline();
            }

            while (string.IsNullOrWhiteSpace(user.studentID))//could use while statement for all if statements
            {

                Console.Write("");
                Console.Write("Enter your Student Number:    ");
                user.studentID = Console.ReadLine();
                drawline();
            }



        }

        public void wellcomeUser()
        {
            //User user = new User();
            Console.Write($@"
        
              
                              __  __
                             |  \/  |  [^_^]
                             | \  / |  /| |\
                             | |\/| |   / \
                             |_|  |_|

                     ========================
                     KHOSI CYBER SECURITY BOT
                     ========================
                      you are now PLUGGED in
                     ========================
                            YESSIRRR
                =================================
                WELCOME {user.studentName} {user.studentSurname}
                ID: {user.studentID}
                =================================
                ");

        }


        public string getresponses(string input)
        {

            input = input.ToLower();


            if (input.Contains("hello") || input.Contains("hi") || input.Contains("hey") || input.Contains("greetings") || input.Contains("what's up") || input.Contains("yo"))
            {
                return $"Hello! {user.studentName} {user.studentSurname}. How can I assist you with cybersecurity today?";
            }
            else if (input.Contains("how are you") || input.Contains("how are you doing") || input.Contains("how's it going") || input.Contains("how do you feel") || input.Contains("what's up with you") || input.Contains("how are you feeling") || input.Contains("hud") || input.Contains("wassup"))
            {
                return "I'm just a bot, for you my G i will always be fantatsic. lets get back to whats important, as I'm here to help you with all your cybersecurity questions!";
            }
            else if (input.Contains("what is cybersecurity") || input.Contains("cybersecurity definition") || input.Contains("explain cybersecurity") || input.Contains("cybersecurity") || input.Contains("cyber") || input.Contains("what is cyber security") || input.Contains("cyber security definition") || input.Contains("security"))
            {
                return "Cybersecurity is the practice of protecting systems, networks, and data from digital attacks.";
            }
            else if (input.Contains("how to stay safe online") || input.Contains("tips for online safety") || input.Contains("how to protect myself online") || input.Contains("online safety") || input.Contains("stay safe online") || input.Contains("safe") || input.Contains("safety") || input.Contains("tips"))
            {
                return "To stay safe online, use strong passwords, enable two-factor authentication, and be cautious of suspicious links.";
            }
            else if (input.Contains("what is phishing") || input.Contains("phishing definition") || input.Contains("what is a phishing attack") || input.Contains("phishing") || input.Contains("phishing scam") || input.Contains("attack"))
            {
                return "Phishing is a cyber attack where attackers impersonate legitimate entities to steal sensitive information.";

            }
            else if (input.Contains("what is malware") || input.Contains("malware definition") || input.Contains("what is a malware attack"))
            {
                return "Malware is malicious software designed to harm or exploit any programmable device, service, or network.";
            }
            else if (input.Contains("what is ransomware") || input.Contains("ransomware definition") || input.Contains("what is a ransomware attack"))
            {
                return "Ransomware is a type of malware that encrypts a victim's files and demands payment for the decryption key.";
            }
            else if (input.Contains("what is a firewall") || input.Contains("firewall definition") || input.Contains("what does a firewall do"))
            {
                return "A firewall is a network security device that monitors and filters incoming and outgoing network traffic based on an organization's previously established security policies.";
            }
            else if (input.Contains("what is encryption") || input.Contains("encryption definition") || input.Contains("how does encryption work"))
            {
                return "Encryption is the process of converting information or data into a code, especially to prevent unauthorized access.";
            }
            else if (input.Contains("what is a vpn") || input.Contains("vpn definition") || input.Contains("how does a vpn work"))
            {
                return "A VPN, or Virtual Private Network, is a service that encrypts your internet connection and hides your IP address to enhance online privacy and security.";
            }
            else if (input.Contains("what is two-factor authentication") || input.Contains("2fa definition") || input.Contains("how does two-factor authentication work"))
            {
                return "Two-factor authentication (2FA) is a security process in which the user provides two different authentication factors to verify themselves.";
            }
            else
            {
                return "I'm sorry, I don't have an answer for that. Can you please ask something else related to cybersecurity?";
            }






        }

        public void startchat()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Start AI Chat");
            Console.WriteLine($"{user.studentName}, you can now ask me any cybersecurity-related questions. I'm here to help!");
            Console.WriteLine("\nType 'exit' to end the chat.");
            while (true)
            {//this is he uesers chat loop, where they can ask questions and get responses, also has an exit condition to end the chat
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write($"{user.studentName}:  ");
                string input = Console.ReadLine();

                if (input.ToLower() == "exit")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Goodbye! Adios Amigo");
                    break;
                }

                string response = getresponses(input);
                Console.ForegroundColor = ConsoleColor.Blue;
                drawline();
                typetext($"Khosi Bot: {response}"   );
                
                drawline();






            }
        }

        public void typetext(string text, int delay = 30)//this is a method to simulate the bot typing out the response, it takes in the text to be displayed and an optional delay parameter to control the speed of the typing effect
        {
            Console.Write("bot is typing...");
            for (int i = 0; i<2; i++)
            {
                Thread.Sleep(delay);
                Console.Write(".");
                
            }

            Console.WriteLine();
            
            foreach (char c in text)
                {  
                Console.Write(c); 
                Thread.Sleep(delay);
            }

            Console.WriteLine();
        }
    }

}