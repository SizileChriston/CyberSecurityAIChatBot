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
            obj.cybersecurityquestions();
            obj.cyberResponse();





            Console.WriteLine("Hello, World!");
            Console.ReadLine();
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
            Console.ForegroundColor = ConsoleColor.Blue ;
            Console.WriteLine(@"
              
                              
                                                                       [^_^]
                                                                       /| |\
                                                                        / \");
            Console.ForegroundColor = ConsoleColor.Red;

            //Console.WriteLine(@"

            //         /$$   /$$ /$$                           /$$        /$$$$$$            /$$                                    
            //        | $$  /$$/| $$                          |__/       /$$__  $$          | $$                                    
            //        | $$ /$$/ | $$$$$$$   /$$$$$$   /$$$$$$$ /$$      | $$  \__/ /$$   /$$| $$$$$$$   /$$$$$$   /$$$$$$           
            //        | $$$$$/  | $$__  $$ /$$__  $$ /$$_____/| $$      | $$      | $$  | $$| $$__  $$ /$$__  $$ /$$__  $$          
            //        | $$  $$  | $$  \ $$| $$  \ $$|  $$$$$$ | $$      | $$      | $$  | $$| $$  \ $$| $$$$$$$$| $$  \__/          
            //        | $$\  $$ | $$  | $$| $$  | $$ \____  $$| $$      | $$    $$| $$  | $$| $$  | $$| $$_____/| $$                
            //        | $$ \  $$| $$  | $$|  $$$$$$/ /$$$$$$$/| $$      |  $$$$$$/|  $$$$$$$| $$$$$$$/|  $$$$$$$| $$                
            //        |__/  \__/|__/  |__/ \______/ |_______/ |__/       \______/  \____  $$|_______/  \_______/|__/                
            //                                                                     /$$  | $$                                        
            //                                                                    |  $$$$$$/                                        
            //                                                                     \______/                                         
            //          /$$$$$$                                          /$$   /$$                     /$$$$$$$              /$$    
            //         /$$__  $$                                        |__/  | $$                    | $$__  $$            | $$    
            //        | $$  \__/  /$$$$$$   /$$$$$$$ /$$   /$$  /$$$$$$  /$$ /$$$$$$   /$$   /$$      | $$  \ $$  /$$$$$$  /$$$$$$  
            //        |  $$$$$$  /$$__  $$ /$$_____/| $$  | $$ /$$__  $$| $$|_  $$_/  | $$  | $$      | $$$$$$$  /$$__  $$|_  $$_/  
            //         \____  $$| $$$$$$$$| $$      | $$  | $$| $$  \__/| $$  | $$    | $$  | $$      | $$__  $$| $$  \ $$  | $$    
            //         /$$  \ $$| $$_____/| $$      | $$  | $$| $$      | $$  | $$ /$$| $$  | $$      | $$  \ $$| $$  | $$  | $$ /$$
            //        |  $$$$$$/|  $$$$$$$|  $$$$$$$|  $$$$$$/| $$      | $$  |  $$$$/|  $$$$$$$      | $$$$$$$/|  $$$$$$/  |  $$$$/
            //         \______/  \_______/ \_______/ \______/ |__/      |__/   \___/   \____  $$      |_______/  \______/    \___/  
            //                                                                         /$$  | $$                                    
            //                                                                        |  $$$$$$/                                    
            //                                                                         \______/                                     

            //        ");

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

        //private void asci()
        //{
        //    Console.WriteLine("\nLoading Visual Logo");
        //    string path = "3pplug.png";//this is where i will put the image file directory
        //    //string path = "\"C:\\Users\\Steeze\\OneDrive\\Documents\\School Rosebank\\2026\\Programming 2A\\helloworld\\New folder\\POEChatBot\\POEChatBot\\3pplug.png\"";
        //    int consoleWidth = Console.WindowWidth;//this will help with resizing the image to fit the console better, also aspect ratio is better now, but still not perfect, gonna try to use a different image and see if it works better
        //    int consoleHeight = Console.WindowHeight;

        //    int newWidth = consoleWidth/2;
        //    int newHeight = consoleHeight/3;  

        //    Bitmap image = new Bitmap(path);//the image was located in the wrong path , relocated it and placed it in the debug bin
        //                                    //program runs without any errors, but imiage doesnt display properly
        //    Bitmap resized = new Bitmap(image, new Size(newWidth, newHeight));//changed 50 to 30 for better aspect ratio
        //                                                          //resizing the image to fit console better, also aspect ratio is better now, but still not perfect, gonna try to use a different image and see if it works better


        //    for (int y = 0; y < resized.Height; y +=2)
        //    {

        //        int padding = (consoleWidth - newWidth) / 2;//this will centre my logo
        //        Console.Write(new string(' ', padding));

        //        for (int x = 0; x < resized.Width; x++)
        //        {
        //            Color pixel = resized.GetPixel(x, y);

        //            int gray = (int)(0.3*pixel.R + 0.59*pixel.G + 0.11*pixel.B) / 3;//image wasnt  being generated properly
        //                                                                            //gonna use better grey scaling

        //            string chars = "@#W$9876543210?!abc;:+=-,._ ";//this will provide more levels
        //                                                          // and more darkness 
        //                                                          //still bhaving issues wth dspalying 

        //            char asiiChar = chars[gray * chars.Length / 256];

        //            Console.Write(asiiChar);

        //        }
        //        Console.WriteLine();//adds line breaks

        //    }
            
        //}

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
                     KHOSI CYBER SECURITY BOT
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
