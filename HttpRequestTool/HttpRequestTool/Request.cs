using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HttpRequestTool
{
    class Request
    {
        private int id { get; set; }
        private String requestString { get; set; }

        // Constructor
        public Request(int id, String requestString)
        {
            this.id = id;
            this.requestString = requestString;
        }
    }
}
