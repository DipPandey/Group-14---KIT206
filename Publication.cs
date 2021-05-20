using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 *  Publication Class - Has all the details of a Publication
 *  Author(s) So Far - Harrison Adams, XXX
 *  Completion Date - 20 May
*/

namespace Assignment_2_Redo.Research
{


    class Publication
    {
        //======================================================================================
        //                                     Variables
        //======================================================================================

        public string DOI { get; set; }            //The Identifier of the Publication
        public string Title { get; set; }          //The Title of the Publicaton
        public string Authors { get; set; }        //The Author(s) of said Publication
        public int Year { get; set; }         //The Year the Publication was released (Can be A Future Date) [Class says its "Date" Type]
        public enum Type { Conference, Journal, Other };  //The Different Types of Publication it can be
        public string CiteAs { get; set; }         //The Citation of Said Publication
        public DateTime Available { get; set; }    //When the Publication is Available to the Public (Can be a Future Date) [Class says its "Date" Type]

        /*  Gets User Input
         *      Type - Has to Be "Conference", "Journal" or "Other" ["OutputType" Enum]
         *      Year and Available - Has to be a Date
         *      Write More When Figuring out this better
         */

        //======================================================================================
        //                                     Functions
        //======================================================================================

        /*
         *  Age() -     Gets the Age of the Publication and returns it as an int
         *  Output -    Returns the Age of the Publication, can be negative if not released currently
         */
        public int Age
        {
            get { 
                int currentYear = DateTime.Now.Year;
                return (currentYear - Year); 
            }
        }

        public override string ToString()
        {
            return Title + ", by " + Authors;
        }

    }

}
