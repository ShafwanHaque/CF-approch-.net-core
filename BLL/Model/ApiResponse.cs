﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Model
{
    public class ApiResponse
    {
        public string Code { get; set; }
        public string Message { get; set; }
        public object? ResponseData { get; set; }        
        
    }
    public enum ResponseType
    {
        Success,
        NotFound,
        Failure
    }
}
