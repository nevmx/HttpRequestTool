using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HttpRequestTool
{
    public class Request
    {
        private int id { get; set; }
        public string RequestString { get; set; }

        // Constructor
        public Request(int id, string requestString)
        {
            this.id = id;
            this.RequestString = requestString;
        }
    }
}
