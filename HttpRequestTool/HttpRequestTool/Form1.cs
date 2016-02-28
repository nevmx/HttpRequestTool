using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HttpRequestTool
{
    public partial class Form1 : Form
    {
        private Manager m;

        public Form1()
        {
            InitializeComponent();

            // Get Manager instance
           m = Manager.GetInstance();


        }

        // Reload the listBox
        private void reloadListBox()
        {
            requestListBox.Items.Clear();

            foreach (Request request in m.Requests)
            {
                requestListBox.Items.Add(request.RequestString);
            }
        }

        // Add a request to the manager
        private void addGetButton_Click(object sender, EventArgs e)
        {
            m.CreateRequest(requestStringTextBox.Text);
            reloadListBox();
        }

        // Clear all requests in list
        private void clearButton_Click(object sender, EventArgs e)
        {
            m.Requests.Clear();
            reloadListBox();
        }

        private void sendAllButton_Click(object sender, EventArgs e)
        {
            RequestSender reqSender = m.RequestSender;

            reqSender.SendRequests(5000);
        }
    }
}
