using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using ProductSpecialSubmission.Models;

namespace ProductSpecialSubmission.Models
{
    class Database
    {
        public Products Products { get; set; }
        public Database()
        {
            string connString = "Server=DESKTOP-01TA4PH\\SQLEXPRESS;Integrated Security=True;Database=SpecialSubmission";
            SqlConnection conn = new SqlConnection(connString);
            Products = new Products(conn);
        }
    }
}
