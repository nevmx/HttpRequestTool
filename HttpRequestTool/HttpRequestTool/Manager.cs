using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HttpRequestTool
{
    public class Manager
    {
        public RequestSender RequestSender { get; }
        public List<Request> Requests { get; }
        private static Manager manager = null;

        private int reqID = 1;

        private Manager()
        {
            RequestSender = new RequestSender();
            Requests = new List<Request>();
        }

        // Get an instance of this class (this class is a singleton class)
        public static Manager GetInstance()
        {
            if (manager == null)
            {
                manager = new Manager();
            }

            return manager;
        }

        // Create a request
        public void CreateRequest(string requestString)
        {
            Request newRequest = new Request(reqID, requestString);
            Requests.Add(newRequest);
            reqID++;
        }
    }
}
