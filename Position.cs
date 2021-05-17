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
 *  Completion Date -   N/A
 */

namespace Assignment_2_Redo.Research
{
    class Position
    {
        
        public int ID { get; set; }//variable to get the ID of staff
        public string Level { get; set; }//variable to get the level
        public DateTime start { get; set; }// variable to get start date
        public DateTime end { get; set; }//variable to get end date

        public override string ToString()
        {
            return start + "-" + end; //start and end date of the enrollment 
        }
    }

        