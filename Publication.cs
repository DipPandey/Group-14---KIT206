using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 *  Publication Class - Has all the details of a Publication
 *  Author(s) So Far - Harrison Adams, Nghia Duc Hoang
 *  Completion Date - N/A
*/

namespace Assignment_2_Redo.Research
{

    public enum Type { Conference, Journal, Other };
    class Publication
    {
        //Variables
        private string DOI;         //The Identifier of the Publication
        private string Title;       //The Title of the Publicaton
        private string Authors;     //The Author(s) of said Publication
        private DateTime PublicationYear;        //The Year the Publication was released (Can be A Future Date) [Class says its "Date" Type]
        private Type Type;        //The Type of Publication (Conference, Journal, Other) [Make an ENUM for this called "OutputType"]
        private string CiteAs;      //The Citation of Said Publication
        private DateTime Availablity;   //When the Publication is Available to the Public (Can be a Future Date) [Class says its "Date" Type]
        private int age;

        public int Age
        {
            get { return age; }
            set { age =  }
        }

        public string ThisYear()
        {
            string ThisYear = DateTime.Now.Year.ToString();
            return ThisYear; 
        }
        public override string ToString()
        {
            return DOI + " " + Title + " " + Authors + " " +
                PublicationYear + " " + Type + " " + CiteAs + " " +
                Availablity + " " + Age;
        }
        /*  Gets User Input
         *      Type - Has to Be "Conference", "Journal" or "Other" ["OutputType" Enum]
         *      Year and Available - Has to be a Date
         *      Write More When Figuring out this better
         */


        //Gets the Age of the Publication using Age() Method

        //Stores to Database

    }

    /*
     *  Age() -     Gets the Age of the Publication and returns it as an int
     *  @p1 -       ???
     *  Output -    Returns the Age of the Publication 
     */

    /*public int Age()
    {
        get { return age; }
        //Gets the Year of Release for the Publication (Or "Year" Var)

        //Gets current Year

        //Finds the Difference between the Years and Returns it (Current Year - Release Year)

    }
     */
}
