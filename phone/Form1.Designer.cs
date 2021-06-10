
namespace phone
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
            this.btnSendRequest = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbApiKey = new System.Windows.Forms.TextBox();
            this.btnSaveAPIKey = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lbRequestCount = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbPhoneNumber = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSendRequest
            // 
            this.btnSendRequest.Location = new System.Drawing.Point(104, 159);
            this.btnSendRequest.Name = "btnSendRequest";
            this.btnSendRequest.Size = new System.Drawing.Size(266, 30);
            this.btnSendRequest.TabIndex = 0;
            this.btnSendRequest.Text = "Send request";
            this.btnSendRequest.UseVisualStyleBackColor = true;
            this.btnSendRequest.Click += new System.EventHandler(this.btnSendRequest_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "API Key";
            // 
            // tbApiKey
            // 
            this.tbApiKey.Location = new System.Drawing.Point(80, 23);
            this.tbApiKey.Name = "tbApiKey";
            this.tbApiKey.Size = new System.Drawing.Size(184, 20);
            this.tbApiKey.TabIndex = 2;
            // 
            // btnSaveAPIKey
            // 
            this.btnSaveAPIKey.Location = new System.Drawing.Point(294, 22);
            this.btnSaveAPIKey.Name = "btnSaveAPIKey";
            this.btnSaveAPIKey.Size = new System.Drawing.Size(76, 21);
            this.btnSaveAPIKey.TabIndex = 3;
            this.btnSaveAPIKey.Text = "Save API Key";
            this.btnSaveAPIKey.UseVisualStyleBackColor = true;
            this.btnSaveAPIKey.Click += new System.EventHandler(this.btnSaveAPIKey_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lbPhoneNumber);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lbRequestCount);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(11, 197);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(438, 110);
            this.panel1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Request count:";
            // 
            // lbRequestCount
            // 
            this.lbRequestCount.AutoSize = true;
            this.lbRequestCount.Location = new System.Drawing.Point(101, 14);
            this.lbRequestCount.Name = "lbRequestCount";
            this.lbRequestCount.Size = new System.Drawing.Size(13, 13);
            this.lbRequestCount.TabIndex = 1;
            this.lbRequestCount.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Phone number:";
            // 
            // lbPhoneNumber
            // 
            this.lbPhoneNumber.AutoSize = true;
            this.lbPhoneNumber.Location = new System.Drawing.Point(101, 42);
            this.lbPhoneNumber.Name = "lbPhoneNumber";
            this.lbPhoneNumber.Size = new System.Drawing.Size(45, 13);
            this.lbPhoneNumber.TabIndex = 3;
            this.lbPhoneNumber.Text = "No data";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(12, 55);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(437, 97);
            this.panel2.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 316);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSaveAPIKey);
            this.Controls.Add(this.tbApiKey);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSendRequest);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSendRequest;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbApiKey;
        private System.Windows.Forms.Button btnSaveAPIKey;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbRequestCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbPhoneNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
    }
}

