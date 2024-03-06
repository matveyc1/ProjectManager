using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SQLite;
using static System.Net.Mime.MediaTypeNames;

namespace ProjectVPK.Models
{
    public class Note
    {
        [PrimaryKey, AutoIncrement]
        
        public int Id { get; set; }

        public string email { get; set; }

        public string password { get; set; }
    }
}
