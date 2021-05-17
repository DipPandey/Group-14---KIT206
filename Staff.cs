using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows; //for generating a MessageBox upon encountering an error

using MySql.Data.MySqlClient;
using MySql.Data.Types;

/*
 *  Staff Class -       Inherits properties from "Researcher" Class and adds extra features specific
 *                      for Staff Member Researchers
 *  Author(s) So Far -  Harrison Adams, Dip Pandey
 *  Completion Date -   N/A
 */

namespace Assignment_2_Redo.Research
{
    

    class Staff
    {
        //Get All Detail from Researcher

        //Calculate 3 Year Average

        //Calculate Performance

        //Store in Database
    }

    /*
     *  ThreeYearAverage -  The Total Number of Publications in the 3 Previous WHOLE Calander Years
     *                      Divided by 3. 
     *                      (Eg: If 2019, the 3 years are 2018, 2017, and 2016)
     *  @p1 - A
     *  Output - Returns a Decimal Number of the "Three Year Average"
     */
    public void ThreeYearAverage()
    {
        //Gets the Current Year

        //Gets the Three Previous Years (Eg: Year - 1, Year - 2, Year - 3)

        //Gets the Amount of Publications for All 3 Years and adds them together

        //Divide Sum of Publications by 3 and return the Result

    }

    /*
     * Performance -    Gets the Performance of the Staff Member using their 3 Year Average and their Employment
     *                  Level's Amount of Expected Publications. 
     * @p1 - A
     * Output - A Percentage value of how well they did (Eg: 70% of Expected Publication is Poor, 200% is Star Performance)
     */
    public void Performance()
    {
        //Gets the Staff Members Three Year Average using "ThreeYearAverage()"

        //Gets the Staff's Employment Level and finds the Number of Expected Publications Done

        //Divide their 3 Year Average by their Expected Publications to get a Percentage

        //Return either the Percentage or the Rating as seen in 5.2 of the RAP Requirements Document, Achievement Reports
    }

}
