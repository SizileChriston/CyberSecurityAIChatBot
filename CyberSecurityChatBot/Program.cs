using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;// added this to contribut ein aiding with bitmap and image manipulation for the ascii image

namespace CyberSecurityChatBot
{
    
    internal class Program
    {
        User user = new User();//this is how i extract user data from the filled in data and store it

        static void Main(string[] args)
        {

            Program obj = new Program();

            obj.welcomesound();
            obj.asciilogo();//this will end up showing both manual and image ascii, so the logo and image
            obj.getUserDetails();
            obj.wellcomeUser();
            obj.cybersecurityquestions();
            obj.cyberResponse();





            Console.WriteLine("Hello, World!");
            Console.ReadLine();
        }

        public void welcomesound()
        {
            SoundPlayer player = new SoundPlayer("makhosi.wav");
            //record welcomng sound
            //soundplayer is calss used tto play sound

            // execute sound
            player.PlaySync();//currently eperiencing an error here
            //had to place my wav file in the debug folder, going to test if it works will comment next
            //if it does

            //add sound to folder make sure wav format
            //PlayeSync allows Audio to play before ASCII shows

        }

        public void asciilogo()
        {
            Console.WriteLine(@"
              
                              __  __
                             |  \/  |  [^_^]
                             | \  / |  /| |\
                             | |\/| |   / \
                             |_|  |_|

                     ========================
                         MAKHOSI CHAT BOT
                     ========================
                       you are now PLUGGED in
                     ========================
                                ");
            //create a cyber security themed iiamge
            //ASCII logo
            //now call ascii image
            asci();//get this ammended image doesnt display as well as sound
        }

        private void asci()
        {
            Console.WriteLine("\nLoading Visual Logo");
            string path = "3pplug.png";//this is where i will put the image file directory
            //string path = "\"C:\\Users\\Steeze\\OneDrive\\Documents\\School Rosebank\\2026\\Programming 2A\\helloworld\\New folder\\POEChatBot\\POEChatBot\\3pplug.png\"";

            Bitmap image = new Bitmap(path);
            Bitmap resized = new Bitmap(image, new Size(100, 50));

            for (int y = 0; y < resized.Height; y++)
            {
                for (int x = 0; x < resized.Width; x++)
                {
                    Color pixel = resized.GetPixel(x, y);

                    int gray = (pixel.R + pixel.G + pixel.B) / 3;

                    string chars = "@#s%?*+;:,. ";

                    char asiiChar = chars[gray * chars.Length / 256];

                    Console.Write(asiiChar);

                }


            }
        }

        private void getUserDetails()
        {

            //User user = new User();

            Console.Write("Enter your Name:    ");
            user.studentName = Console.ReadLine();

            Console.Write("Enter your Surname:    ");
            user.studentSurname = Console.ReadLine();

            Console.Write("Enter your Student Number:  ");
            user.studentID = Console.ReadLine();

            while (string.IsNullOrWhiteSpace(user.studentName))
            {
                Console.Write("Nmaer cannot be empty");
                Console.Write("Enter your name:    ");
                user.studentName = Console.ReadLine();

            }
            while (string.IsNullOrEmpty(user.studentSurname))
            {
                Console.Write("Student Surname cannot be empty");
                Console.Write("Enter your Surname:    ");
                user.studentSurname = Console.ReadLine();
            }

            while (string.IsNullOrEmpty(user.studentID))//could use while statement for all if statements
            {

                Console.Write("");
                Console.Write("Enter your Student ID:    ");
                user.studentID = Console.ReadLine();

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
                         MAKHOSI CHAT BOT
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

        public void cybersecurityquestions()
        {

            Console.WriteLine($"How are you today  " + user.studentName + "  " + user.studentSurname + "?:    ");
            user.mood = Console.ReadLine();

            Console.WriteLine("Whats your purpose with me as your cyber securtiy App bot?:    ");
            user.purpose = Console.ReadLine();

            Console.WriteLine("What IT can i ask you about?:    ");
            user.about = Console.ReadLine();

        }


        public void cyberResponse()
        {

            Console.Write($@"
        
              
                              __  __
                             |  \/  |  [^_^]
                             | \  / |  /| |\
                             | |\/| |   / \
                             |_|  |_|

                     ========================
                         MAKHOSI CHAT BOT
                     ========================
                       SO.........
                        {user.studentName} i noticed that today youre in a {user.mood} mood
                        your purpose with me as your bot is {user.purpose}, which isnt a bad idea, i apreciate the interest
                        and 
                        this is what info youd lke to disclose about yourself:  {user.about}

                        
                                ");


        }

    }
}
