using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using MySql.Data.MySqlClient;


namespace Assignment_2_Redo.DBA
{
    abstract class Database
    { 
            //If including error reporting within this class (as this sample does) then you'll need a way
            //to control whether the errors are actually shown or silently ignored, since once you have
            //connected the GUI to the Boss object then the GUI designer will execute its code, which
            //will try to connect to the database to load live data into the GUI at design time.
            private static bool reportingErrors = false;

            //These would not be hard coded in the source file normally, but read from the application's settings (and, ideally, with some amount of basic encryption applied)
            private const string db = "kit206";
            private const string user = "kit206";
            private const string pass = "kit206";
            private const string server = "alacritas.cis.utas.edu.au";

            private static MySqlConnection conn = null;

            //Part of step 2.3.3 in Week 8 tutorial. This method is a gift to you because .NET's approach to converting strings to enums is so horribly broken
            public static T ParseEnum<T>(string value)
            {
                return (T)Enum.Parse(typeof(T), value);
            }

            /// <summary>
            /// Creates and returns (but does not open) the connection to the database.
            /// </summary>
            private static MySqlConnection GetConnection()
            {
                if (conn == null)
                {
                    //Note: This approach is not thread-safe
                    string connectionString = String.Format("Database={0};Data Source={1};User Id={2};Password={3}", db, server, user, pass);
                    conn = new MySqlConnection(connectionString);
                }
                return conn;
            }

            //For step 2.2 in Week 8 tutorial
            public static List<Researcher> LoadAllResearcher()
            {
                List<Researcher> staff = new List<Researcher>();

                MySqlConnection conn = GetConnection();
                MySqlDataReader rdr = null;

                try
                {
                    conn.Open();

                    MySqlCommand cmd = new MySqlCommand("Select title, year, type, available" + "from publicaitonn as respub" +
                        "where pub.doi = respub.doi and researccher_id =pubid", conn);
                    rdr = cmd.ExecuteReader();

                    while (rdr.Read())
                    {
                        //Note that in your assignment you will need to inspect the *type* of the
                        //employee/researcher before deciding which kind of concrete class to create.
                        staff.Add(new Researcher { 
                            title = rdr.GetString(0),
                            Year = rdr.GetInt32(1),
                            Mode = ParseEnum<Mode> (rdr.GetString(2))
                            Name = rdr.GetString(1) + " " + rdr.GetString(2) });
                    }
                }
                catch (MySqlException e)
                {
                    ReportError("loading staff", e);
                }
                finally
                {
                    if (rdr != null)
                    {
                        rdr.Close();
                    }
                    if (conn != null)
                    {
                        conn.Close();
                    }
                }

                return Researcher;
            }
        }
}
