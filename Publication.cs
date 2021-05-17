using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 *  Publication Class - Has all the details of a Publication
 *  Author(s) So Far - Harrison Adams, XXX
 *  Completion Date - N/A
*/

namespace Assignment_2_Redo.Research
{


    class Publication
    {
        public int Doi { get; set; }// indentifier for doi
        public string title { get; set; }//identifier for title of the publicaiton
        public String authors { get; set; }// author of the publication
        public DateTime year { get; set; }//publiation year 

        public string type { get; set; }// type of publication 

        public String CiteAs { get; set; }// citation for use of publication

        public DateTime available { get; set; }// available date of publication

        public override string ToString()
        {
            return ; //start and end date of the enrollment 
        }

        

    }
}
