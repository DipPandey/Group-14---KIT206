using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 *  Student Class - Inherits Properties from the "Researcher" Class but adds features
 *                  meant for Students (A Sub-Class of Researcher)
 *  Author(s) So Far - Harrison Adams, XXX
 *  Completion Date - 20 May
 */

namespace Assignment_2_Redo.Research
{
    class Student : Researcher
    {
        //======================================================================================
        //                                     Variables
        //======================================================================================
        public string Degree { get; set; }  //The Degree a Student Has

    }

}
