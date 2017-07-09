using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlServerCe;

namespace P3
{
    class PolaczBaza
    {
        public static SqlCeConnection pol;
        public static SqlCeCommand cmd;
        public static bool Polancz()
        {
            pol = new SqlCeConnection(@"Data Source=D:\Day.sdf");
            try
            {
                pol.Open();
                return true; 
            }
            catch 
            {
                return false;
            }
        }
        public static SqlCeResultSet Select(string komenda) 
        {
            cmd = new SqlCeCommand();
            cmd.Connection = pol;
            cmd.CommandText = komenda;
            return cmd.ExecuteResultSet(ResultSetOptions.Scrollable | ResultSetOptions.Updatable);
        }
    }
}
