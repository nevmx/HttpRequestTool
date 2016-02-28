using System;
using System.Net;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HttpRequestTool
{
    public class RequestSender
    {
        private int requestQueueLimit = 10;
        private Queue<Request> requestQueue;
        private WebRequest webRequest;
        private Stream responseStream;

        public RequestSender()
        {
            requestQueue = new Queue<Request>();
        }

        /// <summary>
        /// Add a request to the queue of requests. (Enqueue)
        /// </summary>
        /// <param name="httpRequest">The Http Request object.</param>
        public void AddRequest(Request httpRequest)
        {
            if (requestQueue.Count < requestQueueLimit)
            {
                requestQueue.Enqueue(httpRequest);
            }
        }

        public void SendRequests(int sleepTime)
        {
            while (requestQueue.Count > 0)
            {
                webRequest = WebRequest.Create(requestQueue.Dequeue().RequestString);

                responseStream = webRequest.GetResponse().GetResponseStream();
                StreamReader streamReader = new StreamReader(responseStream);

                string sLine = "";

                while (sLine != null)
                {
                    sLine = streamReader.ReadLine();
                    if (sLine != null)
                    {
                        Console.WriteLine(sLine);
                    }
                    System.Threading.Thread.Sleep(sleepTime);
                }

            }
        }
    }
}
