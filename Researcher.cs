using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 *  Researcher Class -  Has all of the Details of a Specific Researcher, which is then used
 *                      by the "Student" or "Staff" Classes as a base
 *  Author(s) So Far -  Harrison Adams, XXX
 *  Completion Date -   20 May
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

    class Researcher
    {
        //======================================================================================
        //                                     Variables
        //======================================================================================

        public int id { get; set; }         // The ID of this researcher, used to identify them and is unique
        public string GivenName { get; set; }   // The First Name of the Researcher
        public string FamilyName { get; set; }  // The Last Name of the Researcher
        public string Title { get; set; }       // Eg: Mr, Ms, etc
        public string School { get; set; }      // The School the Researcher is Currently At 
        public string Campus { get; set; }      // The Campus the Researcher is Currently At (Hobart, Launceston, Cradle Coast)
        public string Email { get; set; }       // The Email that can Contact the Researcher
        public string Photo { get; set; }       // A Photo URL of the Researcher
        
        //======================================================================================
        //                                       Lists
        //======================================================================================

        public List<Publication> Publications { get; set; } //List of Publications the Researcher Made
        public List<Position> Jobs { get; set; }    //List of Positions the Researcher has been in

        //======================================================================================
        //                                     Functions
        //======================================================================================

        /*
            GetCurrentJob - Gets the current job of a Researcher by finding the different Positions of said researcher
                            and finding the Biggest "start" date.
            @p1 jobTitle - The Job Title of the Researcher that gets more details
            Output - The "Title()" function from "Position.cs"
        */
        public Position GetCurrentJob
        {
            //Return Title() from Position.cs
            get {
                var SortJobs = from Position p in Jobs  // Find all the jobs the researcher has
                            orderby p.start descending  // Sort jobs by newest to oldest
                            select p;                   // Grab the Details
                
                return SortJobs.FirstOrDefault(); //Selects First Job Title (Or Default Value)
            }
        }

        //---------------------------------------------------------------------------------------------------

        /*
            CurrentJobTitle -   Gets the current job title of a Researcher by finding the different Positions of said 
                                researcher and finding the Biggest "start" date.
            @p1 jobTitle - The Job Title of the Researcher that gets more details
            Output - The "ToTitle()" function from "Position.cs" where it will be stored in the "Title" variable
         */
        private string CurrentJobTitle
        {
            
            get {
                var SortJobs = from Position p in Jobs  // Find all the jobs the researcher has
                               orderby p.start descending  // Sort jobs by newest to oldest
                               select p;                   // Grab ONLY the Levels

                return SortJobs.FirstOrDefault().ToTitle; //Selects First Job Title (Or Default Value)
            }
        }

        //---------------------------------------------------------------------------------------------------

        /*
            CurrentJobStart -   Gets the current job of a Researcher by acting as a "Getter" Method
            Output - The Starting date of the Researcher's Current Job
         */
        private DateTime CurrentJobStart
        {
            get {
                var SortJobs = from Position p in Jobs      // Find all the jobs the researcher has
                               orderby p.start descending   // Sort jobs by newest to oldest
                               select p.start;              // Grab ONLY the Levels

                return SortJobs.FirstOrDefault(); //Selects First Job Title (Or Default Value)
            }
        }

        //---------------------------------------------------------------------------------------------------

        /*
            GetEarliestJob -    Gets the earliest job of a Researcher that they have had by finding all jobs
                                that a researcher had and finding the smallest date
            Output - Earliest Job Title
         */
        public Position GetEarliestJob
        {
            get {
                var SortJobs = from Position p in Jobs      // Find all the jobs the researcher has
                               orderby p.start ascending    // Sort jobs by newest to oldest
                               select p;                    // Grab ONLY the Levels

                return SortJobs.FirstOrDefault(); //Selects First Job Title (Or Default Value)
            }
        }

        //---------------------------------------------------------------------------------------------------

        /*
            EarliestStart - Gets the starting date of the Researcher's Earliest Job by finding all jobs that
                            a researher had and finding the smallest date
            Output - Earliest Job Starting Date (Researcher's First Day as a Researcher)
        */
        private DateTime EarliestStart
        {
            get
            {
                var SortJobs = from Position p in Jobs      // Find all the jobs the researcher has
                               orderby p.start ascending    // Sort jobs by newest to oldest
                               select p.start;              // Grab ONLY the Levels

                return SortJobs.FirstOrDefault(); //Selects First Job Title (Or Default Value)
            }
        }

        //---------------------------------------------------------------------------------------------------

        /*
            Tenture -   Calculates the Time in Fractional Years since the user has been commenced
                        with the Institution
            Output -    A Decimal Number calculated by The Earliest Day and another date, be it their end date
                        Or current date if researcher is still employed
         */
        public double Tenture
        {
            get { 
                //Gets the Last Date
                var SortDateEnd = from Position p in Jobs
                               orderby p.end ascending
                               select p.end;
                //Checks if Still Employed
                if (SortDateEnd.First() == null)
                {
                    //Convert to Days (Whole)
                    int daysFromStartToCurrent = (EarliestStart.Date - DateTime.Now.Date).Days;  //First Date - Current Date = Whole Days
                    //Return Calculated in Fractional Years
                    return daysFromStartToCurrent / 365.25;
                }
                else //If Not Employed Anymore
                {
                    //Calculate Time To End Day
                    int daysFromStartToEnd = (EarliestStart.Date - SortDateEnd.FirstOrDefault().Date).Days;  //First Date - End Date = Whole Days
                    //Return in Fractional Years
                    return daysFromStartToEnd / 365.25;
                }
                
            }
        }

        //---------------------------------------------------------------------------------------------------

        /*
            PublicationsCount - Counts the Total Amount of Publications made by the Researcher
            Output - The Amount of Publications
        */
        public int PublicationsCount
        {
            get { return Publications == null ? 0 : Publications.Count(); }

        }
    }

}
