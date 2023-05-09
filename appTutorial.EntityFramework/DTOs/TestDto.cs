﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appTutorial.EntityFramework.DTOs
{
    public class TestDto
    {
        [Key]//2:24
        public Guid TestID { get; set; }
        public string Testname { get; set; }
        public string TestDiscription { get; set; }
        public int TestTime { get; set; }
        public int AutorID { get; set; }

    }
}
