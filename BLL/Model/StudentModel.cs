﻿using System;
using System.Collections.Generic;
using DAL.EF;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Model
{
    public class StudentModel 
    {

        public int S_Id { get; set; }


        public string First_Name { get; set; }

        public string Last_Name { get; set; }

        public string Email { get; set; }

        public string Department { get; set; }

        public string Gender { get; set; }
                    
        public string Phone_number { get; set; }

        public string Address { get; set; }
    }
}
