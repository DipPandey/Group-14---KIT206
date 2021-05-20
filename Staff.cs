using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 *  Staff Class -       Inherits properties from "Researcher" Class and adds extra features specific
 *                      for Staff Member Researchers
 *  Author(s) So Far -  Harrison Adams, XXX
 *  Completion Date -   N/A
 */

namespace Assignment_2_Redo.Research
{

    class Staff : Researcher
    {
        //======================================================================================
        //                                     Functions
        //======================================================================================

        /*
         *  ThreeYearAverage -  The Total Number of Publications in the 3 Previous WHOLE Calander Years
         *                      Divided by 3. 
         *                      (Eg: If 2019, the 3 years are 2018, 2017, and 2016)
         *  Output - Returns a Decimal Number of the "Three Year Average"
         */
        public double ThreeYearAverage
        {
            get {
                var SortJobs = from Publication p in Publications      // Find all the jobs the Staff Researcher has
                               orderby p.Year descending    // Sort jobs by newest to oldest
                               select p;                    // Grab the Details
                int NumOfPub = 0;   //Number of Publications within range (Year-1, Year-2, Year-3) [Year is current Year]
                int CurrentYear = DateTime.Now.Year;    //Current Year in Int form
                //Get Publications
                foreach(var i in SortJobs)
                {
                    //Check if within last year and 3 years ago
                    if (i.Year < CurrentYear && i.Year >= (CurrentYear - 3) )
                    {
                        //Increase by 1
                        NumOfPub++;
                    }
                }

                //Gets Publication Number and divides by 3 for average
                return NumOfPub / 3;
            }

        }

        //---------------------------------------------------------------------------------------------------

        /*
         * Performance -    Gets the Performance of the Staff Member using their 3 Year Average and their Employment
         *                  Level's Amount of Expected Publications. 
         * Output - A Percentage value of how well they did (Eg: 70% of Expected Publication is Poor, 200% is Star Performance)
         */
        public string Performance
        {
            get {
                //Expected amount of Publications
                double ExpPub = 0;

                //Calculate Expeded Publications from Current Job (Values in RTM)
                switch (GetCurrentJob.level)
                {
                    
                    case EmploymentLevel.Student: ExpPub = 0; break;
                    case EmploymentLevel.A: ExpPub = 0.5; break;
                    case EmploymentLevel.B: ExpPub = 1; break;
                    case EmploymentLevel.C: ExpPub = 2; break;
                    case EmploymentLevel.D: ExpPub = 3.2; break;
                    case EmploymentLevel.E: ExpPub = 4; break;
                }

                //Returns Percentage of the performance
                return ((ThreeYearAverage / ExpPub) * 100) + "%";
            }
            
        }

    }

}
