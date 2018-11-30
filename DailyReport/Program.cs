using System;


namespace DailyReport
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Daily Report 11/30/2018");
            Console.ReadLine();

            Console.WriteLine("What course are you on?");
            string yourCourse = Console.ReadLine();
            //Console.ReadLine();

            Console.WriteLine("What page number are you on?");
            string pageNumber = Console.ReadLine();
            int pagNumber = Convert.ToInt32(pageNumber);
            //Console.ReadLine();

            Console.WriteLine("Do you need help with anything?");
            bool help = false;
            Console.ReadLine();
            

            Console.WriteLine("Is there any feedback you would like to provide?");
            bool feed = true;
            Console.ReadLine();
           

            Console.WriteLine("Please be specific with feedback now");
            string yourFeedback = Console.ReadLine();
            

            Console.WriteLine("How many hours did you study today?");
            string hoursStudied = Console.ReadLine();
            int studyHour = Convert.ToInt32(hoursStudied);


            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");
            Console.ReadLine();




            //string yourName = Console.ReadLine();
            //Console.WriteLine("Your name is:" + yourName);
            //Console.ReadLine();

            //What is your favorite number (plus 5)

            //Console.WriteLine("What is your favorite number?");
            //string favoriteNumber = Console.ReadLine();
            //int favNum = Convert.ToInt32(favoriteNumber);
            //int total = favNum + 5;
            //Console.WriteLine("Your favorite number plus 5 is :" + total);
            //Console.ReadLine();


        }
    }
}
