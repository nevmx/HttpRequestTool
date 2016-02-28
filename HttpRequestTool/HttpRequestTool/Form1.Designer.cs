namespace HttpRequestTool
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.requestStringTextBox = new System.Windows.Forms.TextBox();
            this.addGetButton = new System.Windows.Forms.Button();
            this.requestListBox = new System.Windows.Forms.ListBox();
            this.sendAllButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // requestStringTextBox
            // 
            this.requestStringTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.requestStringTextBox.Location = new System.Drawing.Point(12, 12);
            this.requestStringTextBox.Name = "requestStringTextBox";
            this.requestStringTextBox.Size = new System.Drawing.Size(546, 20);
            this.requestStringTextBox.TabIndex = 0;
            // 
            // addGetButton
            // 
            this.addGetButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addGetButton.Location = new System.Drawing.Point(564, 10);
            this.addGetButton.Name = "addGetButton";
            this.addGetButton.Size = new System.Drawing.Size(101, 23);
            this.addGetButton.TabIndex = 1;
            this.addGetButton.Text = "Add GET";
            this.addGetButton.UseVisualStyleBackColor = true;
            this.addGetButton.Click += new System.EventHandler(this.addGetButton_Click);
            // 
            // requestListBox
            // 
            this.requestListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.requestListBox.FormattingEnabled = true;
            this.requestListBox.Location = new System.Drawing.Point(12, 38);
            this.requestListBox.Name = "requestListBox";
            this.requestListBox.Size = new System.Drawing.Size(546, 212);
            this.requestListBox.TabIndex = 2;
            // 
            // sendAllButton
            // 
            this.sendAllButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sendAllButton.Location = new System.Drawing.Point(564, 226);
            this.sendAllButton.Name = "sendAllButton";
            this.sendAllButton.Size = new System.Drawing.Size(101, 23);
            this.sendAllButton.TabIndex = 3;
            this.sendAllButton.Text = "Send All";
            this.sendAllButton.UseVisualStyleBackColor = true;
            this.sendAllButton.Click += new System.EventHandler(this.sendAllButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.clearButton.Location = new System.Drawing.Point(564, 198);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(101, 23);
            this.clearButton.TabIndex = 4;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 261);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.sendAllButton);
            this.Controls.Add(this.requestListBox);
            this.Controls.Add(this.addGetButton);
            this.Controls.Add(this.requestStringTextBox);
            this.MinimumSize = new System.Drawing.Size(400, 300);
            this.Name = "Form1";
            this.Text = "HTTP Request Tool";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox requestStringTextBox;
        private System.Windows.Forms.Button addGetButton;
        private System.Windows.Forms.ListBox requestListBox;
        private System.Windows.Forms.Button sendAllButton;
        private System.Windows.Forms.Button clearButton;
    }
}

