﻿using System;

namespace API.Models
{
    public class Response
    {
        public int Code { get; set; }
        public string Message { get; set; }
        public Object Data { get; set; }
    }
}
