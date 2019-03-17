using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertTo24HourTime
{
    class Program
    {
        static void Main(string[] args)
        {
            string time1 = "1:00 am";
            string time2 = "1:00 pm";
            string time3 = "12:00 am";
            string time4 = "12:00 pm";
            string time5 = "5:30 pm";
            string time6 = "3:25 am";
            string time7 = "12:45 am";

            ConvertToMilitary(time1);
            ConvertToMilitary(time2);
            ConvertToMilitary(time3);
            ConvertToMilitary(time4);
            ConvertToMilitary(time5);
            ConvertToMilitary(time6);
            ConvertToMilitary(time7);
        }

        private static void ConvertToMilitary(string time)
        {
            // Console.WriteLine($"{time}");             //write out time before it's changed
            string[] firstsplit = time.Split(' ');      //splits at the space
            string hourmin = firstsplit[0];             //assigns time to hourmin
            string timeday = firstsplit[1];
            string[] secondsplit = hourmin.Split(':');  //splits hourmin at colon

            int num = int.Parse(secondsplit[0]);        //changes the hour to an int

            if (num == 12)
            {
                if (timeday == "pm")
                {
                    num = 12;
                    StringBuilder newstrings = new StringBuilder($"{num}");
                    newstrings.Append(secondsplit[1]);
                    Console.WriteLine($"{time} = {newstrings}");
                }
                else if (timeday == "am")
                {
                    string amtime = String.Format($"{0:00}");
                    Console.WriteLine($"{time} = {amtime}{secondsplit[1]}");
                }
            }
            else if (timeday == "pm")
            {
                num += 12;
                StringBuilder newstrings = new StringBuilder($"{num}");
                newstrings.Append(secondsplit[1]);
                Console.WriteLine($"{time} = {newstrings}");
            }
            else if (timeday == "am")
            {
                if (num < 10)
                {
                    string amtime = String.Format($"{0:0}");
                    Console.WriteLine($"{time} = {amtime + num}{secondsplit[1]}");
                }
                else if (num > 10)
                {
                    //num = num;
                    StringBuilder newstrings = new StringBuilder($"{num}");
                    newstrings.Append(secondsplit[1]);
                    Console.WriteLine($"{time} = {newstrings}");
                }
            } 
        }
    }   
}
