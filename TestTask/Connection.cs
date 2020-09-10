using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTask
{
    public class Connection
    {
        static string location = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName + "\\TestTask\\TestDB.mdf";
        public static string connection = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=" + location + ";Initial Catalog = TestDB; Integrated Security = True";
    }
}
