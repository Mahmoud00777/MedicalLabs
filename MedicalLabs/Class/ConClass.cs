using MedicalLabs.Properties;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;


namespace MedicalLabs.Classes
{
    class ConClass
    {

        public static string SqlQuery;
        public static SqlDataAdapter da;
        public static SqlCommand cmd;

        public static SqlConnection con = new SqlConnection("Data Source=" + Settings.Default.Server + ";Initial Catalog=" + Settings.Default.Database + ";Integrated Security=False;User Id=" + Settings.Default.SQLLogin + ";Password=" + Settings.Default.SQLPassword + ";");


    }
}
