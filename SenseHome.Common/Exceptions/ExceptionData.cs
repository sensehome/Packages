﻿using System.Net;

namespace SenseHome.Common.Exceptions
{
    public class ExceptionData
    {
        public HttpStatusCode StatusCode { get; set; }
        public int StatusCodeValue => (int)StatusCode;
        public string Message { get; set; }
    }
}
