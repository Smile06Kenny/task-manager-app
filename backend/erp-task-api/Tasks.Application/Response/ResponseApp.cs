using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks.Application.Response
{
    public class ResponseApp<T>
    {
        public int StatusCode { get; set; }

        public string Message { get; set; } = string.Empty;

        public T? Data { get; set; }

        public ResponseApp()
        {
        }

        public ResponseApp(T data)
        {
            StatusCode = 200;
            Message = "OK";
            Data = data;
        }

        public ResponseApp(int statusCode, string message, T? data)
        {
            StatusCode = statusCode;
            Message = message;
            Data = data;
        }
    }
}
