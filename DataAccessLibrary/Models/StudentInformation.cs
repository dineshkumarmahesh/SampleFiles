using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using Dapper;

namespace SampleFiles.Model
{
   public  class StudentInformation
    {
        public string entername { get; set; }
        public string fathername { get; set; }
        public string email { get; set; }
        public string gender { get; set; }

    }
}
