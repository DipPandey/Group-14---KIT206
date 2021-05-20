using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 *  Position Class -    Has a position that the Researcher was in sometime, along with
 *                      their Starting Date of said Position, Position Level, and the
 *                      End Date of Position if applicable
 *  Author(s) So Far -  Harrison Adams, XXX
 *  Completion Date -   20 May
 */

namespace Assignment_2_Redo.Research
{
    class Position
    {
        //======================================================================================
        //                                     Variables
        //======================================================================================
        public EmploymentLevel level { get; set; }    //The Employment Level that position has
        public DateTime start { get; set; }    //Start Date of Job
        public DateTime end { get; set; }      //End Date of Job

        /* Getting User Input
         *  Level has to be an ENUM using Researcher's "EmploymentLevel"
         *  Start has to be Less than End Date and vice versa
         *  All have to be in proper format
         */

        //======================================================================================
        //                                     Functions
        //======================================================================================

        /*
         *  Title - Changes the Employment Level to their Actual Position Name
         *  Output - Position Name based on Level (String Output)
         */
        public string Title
        {
            get {
                return "Help";
            }
        }

        //--------------------------------------------------------------------------------------

        /*
         *  ToTitle - Changes the Employment Level to their Actual Position Name
         *  Output -  Position Name based on Level (String Output)
         */
        public string ToTitle
        {
            get {
                string levelName = "";
                switch (level)
                {
                    case EmploymentLevel.Student: levelName = "Student"; break;
                    case EmploymentLevel.A: levelName = "Postdoc"; break;
                    case EmploymentLevel.B: levelName = "Lecturer"; break;
                    case EmploymentLevel.C: levelName = "Senior Lecturer"; break;
                    case EmploymentLevel.D: levelName = "Associate Professor"; break;
                    case EmploymentLevel.E: levelName = "Professor"; break;
                }
                return levelName;
            }
        }

    }

}
        

