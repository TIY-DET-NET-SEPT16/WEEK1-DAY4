﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WEEK1_DAY4
{
    class Program
    {
        static void Main(string[] args)
        {
            //#region Nested for Loops

            //int sunday = 0;
            //int monday = 1;
            //int tuesday = 2;
            //int wednesday = 3;
            //int thursday = 4;
            //int friday = 5;
            //int saturday = 6;

            ////I want to loop 3 times here because class is 3 months long
            //for (int month = 0; month < 3; month++)
            //{
            //    //I want to loop 4 times here because every month has 4 weeks
            //    for (int week = 0; week < 4; week++)
            //    {
            //        //I want to loop 7 times here because every week has 7 days
            //        for (int day = 0; day < 7; day++)
            //        {
            //            if (day == sunday)
            //            {
            //                DoHomework(day, week, month);
            //            }
            //            else if (day == monday)
            //            {
            //                GoToSchool(day, week, month);
            //            }
            //            else if (day == tuesday)
            //            {
            //                GoToSchool(day, week, month);
            //            }
            //            else if (day == wednesday)
            //            {
            //                GoToSchool(day, week, month);
            //            }
            //            else if (day == thursday)
            //            {
            //                GoToSchool(day, week, month);
            //            }
            //            else if (day == friday)
            //            {
            //                GoToSchool(day, week, month);
            //            }
            //            else if (day == saturday)
            //            {
            //                DoHomework(day, week, month);
            //            }
            //        }
            //    }
            //}

            //#endregion

            //#region Typed Method Calls

            bool someBoolVariable = false;


            
            //#endregion

            #region Arrays

            string[] myArray = new string[5];
            for(int i = 2; i < myArray.Length; i++)
            {
                myArray[i] = string.Format("Count is {0}", i);
                Console.WriteLine(myArray[i]);
            }

            //for (int i = 0; i < myArray.Length; i++)
            //{
            //    Console.WriteLine(myArray[i]);
            //}

            //Console.WriteLine(myArray[2]);
            //Console.WriteLine(myArray.ToString());

            Console.WriteLine(myArray);

            #endregion

            Console.ReadLine();
        }

        static void GoToSchool(int whatDay, int whatWeek, int whatMonth)
        {
            //Do all the stuff required to get yourself to school
            Console.WriteLine(string.Format("Going to school on day {0}, week {1}, month{2}",
                whatDay, whatWeek, whatMonth));

            DoHomework(whatDay, whatWeek, whatMonth);
        }

        static void DoHomework(int whatHomeworkDay, int whatHomeworkWeek, int whatHomeworkMonth)
        {
            //Do your homework!
            Console.WriteLine(string.Format("Doing homework on homework day {0}, on homework week {1}, on homework month {2}",
                whatHomeworkDay, whatHomeworkWeek, whatHomeworkMonth));
        }
    }
}
