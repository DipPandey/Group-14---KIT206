using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 *  Researcher Class -  Has all of the Details of a Specific Researcher, which is then used
 *                      by the "Student" or "Staff" Classes as a base
 *  Author(s) So Far -  Harrison Adams, XXX
 *  Completion Date -   N/A
 */

namespace Assignment_2_Redo.Research
{
    //
    public enum EmploymentLevel { Student, A, B, C, D, E };  //The Different Levels a Researcher can be
    /*  Employment Level Details
     *  Type - Name - Expected Publications
     *  Student - Student - 0
     *  A - Postdoc - 0.5
     *  B - Lecturer - 1
     *  C - Senior Lecturer - 2
     *  D - Associate Professor - 3.2
     *  E - Professor - 4
     */


    public class Researcher
    {
        //Variables
        public int id { get; set; }           // The ID of this researcher, used to identify them and is unique
        public string GivenName { get; set; }  // The First Name of the Researcher
        public string FamilyName { get; set; } // The Last Name of the Researcher
        public string Title { get; set; }      // Eg: Mr, Ms, etc
        public string School { get; set; }   // The School the Researcher is Currently At 
        public string Campus { get; set; }   // The Campus the Researcher is Currently At (Hobart, Launceston, Cradle Coast)
        public string Email { get; set; }      // The Email that can Contact the Researcher
        public String Photo { get; set; }    // A Photo URL of the Researcher
        public String degree { get; set; } // degree currently involved in
        public int SupervisorId { get; set; }// supervisor id- null if not a supervisor

        public DateTime utasStart { get; set; }// utas start date 
        public DateTime currentStart { get; set }// current start date 


        public List<Researcher> Skills { get; set; }

        /*  Get the Data (User Input)
         *      Title - As "Mr", "Ms" or some other title like that
         *      Campus - Has to be "Hobart", "Launceston" or "Cradle Coast" [Possible Enum?]
         *      Photo - Stored as a string URL, Displayed as an image
         */

        //Store Completed Researcher in the Database
    }

    //Methods

    /*
        GetCurrentJob - Gets the current job of a Researcher by finding the different Positions of said researcher
                        and finding the Biggest "start" date.
        @p1 jobTitle - The Job Title of the Researcher that gets more details
        Output - The "Title()" function from "Position.cs"
     */
    static void GetCurrentJob()
    {
        //

    }

    /*
        CurrentJobTitle -   Gets the current job title of a Researcher by finding the different Positions of said 
                            researcher and finding the Biggest "start" date.
        @p1 jobTitle - The Job Title of the Researcher that gets more details
        Output - The "ToTitle()" function from "Position.cs" where it will be stored in the "Title" variable
     */
    static void CurrentJobTitle()
    {
        //
        
    }

    /*
        CurrentJobStart -   Gets the current job of a Researcher by acting as a "Getter" Method
        Output - The Starting date of the Researcher's Current Job
     */
    static void CurrentJobStart()
    {
        //

    }

    /*
        GetEarliestJob -    Gets the earliest job of a Researcher that they have had by finding all jobs
                            that a researcher had and finding the smallest date
        Output - Earliest Job Title
     */
    static void GetEarliestJob()
    {
        //Checks the Position Class(es) for Earliest Job

    }

    /*
        EarliestStart - Gets the starting date of the Researcher's Earliest Job by finding all jobs that
                        a researher had and finding the smallest date
        Output - Earliest Job Starting Date (Researcher's First Day as a Researcher)
    */
    static void EarliestStart()
    {
        //

    }

    /*
        Tenture -   Calculates the Time in Fractional Years since the user has been commenced
                    with the Institution
        @p1 - EarliestStart() for specific Researcher
        @p2 - 
        Output -    A Decimal Number calculated by EarliestStart() and another date, be it their end date
                    Or current date if researcher is still employed
     */
    static void Tenture()
    {
        //Uses the "EarliestStart()" Method to get the Starting Date
        
        //Checks if Researcher is still employed

        //If Employed Calculate with Current Date, If Not Calculate with End Date of Last Position

        //Return Number in Decimal form


    }

    /*
        PublicationsCount - Counts the Total Amount of Publications made by the Researcher
        Output - The Amount of Publications
     */
    static int PublicationsCount()
    {
        //Local Var
        int PubAmount = 0;  //The Amount of Publications that is returned to user

        //Gather all of the Publications made by the Researcher
        
        //Seperate by DOIs in order to remove duplicates
        
        // Count the DOIs
        
        // Return the Amount of DOIs

    }

}
