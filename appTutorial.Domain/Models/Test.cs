using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appTutorial.Domain.Models
{
    public class Test
    {
        
        public Guid TestID { get; }
        public string Testname { get; }
        public string TestDiscription { get; }
        public int TestTime { get; }
        public Guid AutorID { get; }

        public Test(Guid TestID, string Testname, string TestDiscription, int TestTime, Guid AutorID)
        {
            this.TestID = TestID;
            this.Testname = Testname;
            this.TestDiscription = TestDiscription;
            this.TestTime = TestTime;
            this.AutorID = AutorID;
        }
    }
}
