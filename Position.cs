using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 *  Position Class -    Has a position that the Researcher was in sometime, along with
 *                      their Starting Date of said Position, Position Level, and the
 *                      End Date of Position if applicable
 *  Author(s) So Far -  Harrison Adams, Nghia Duc Hoang
 *  Completion Date -   N/A
 */

namespace Assignment_2_Redo.Research
{
    class Position : Researcher
    {
        //Variables (Change to Proper Format Later)
        public Level level
        {
            get; set;
        }
        public DateTime start   //Start Date of Job
        {
            get; set;
        }
        public DateTime end     //End Date of Job
        {
            get; set;
        }

        /* Getting User Input
         *  Level has to be an ENUM using Researcher's "EmploymentLevel"
         *  Start has to be Less than End Date and vice versa
         *  All have to be in proper format
         */

        //Format it using "Title" or "ToTitle" Method

        //Stores to Database



        /*
         *  Title - 
         *  @p1 - 
         *  Output - 
         */

        /* public string Title()
        {
            return "";
        }
         */


        /*
         * ToTitle - 
         * @p1 - 
         * Output - 
         */
        public string ToTitle(Level level)
        {
            if (level.Equals("Student"))
            {
                return "Student";
            }
            else if (level.Equals("A"))
            {
                return "Postdoc";
            }
            else if (level.Equals("B"))
            {
                return "Lecturer";
            }
            else if (level.Equals("C"))
            {
                return "Senior Lecturer";
            }
            else if (level.Equals("D"))
            {
                return "Associate Professor";
            }
            else
            {
                return "Professor";
            }
        }

        public override string ToString()
        {
            return level + " " + start + " " + end; 
        }
    }


}
        

