
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnSendRequest = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbApiKey = new System.Windows.Forms.TextBox();
            this.btnSaveAPIKey = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbRequestStatus = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbPhoneNumber = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbRequestCount = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewTransaction = new System.Windows.Forms.DataGridView();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbBlance = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTransaction)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSendRequest
            // 
            this.btnSendRequest.Location = new System.Drawing.Point(12, 247);
            this.btnSendRequest.Name = "btnSendRequest";
            this.btnSendRequest.Size = new System.Drawing.Size(521, 35);
            this.btnSendRequest.TabIndex = 0;
            this.btnSendRequest.Text = "Send request";
            this.btnSendRequest.UseVisualStyleBackColor = true;
            this.btnSendRequest.Click += new System.EventHandler(this.btnSendRequest_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "API Key";
            // 
            // tbApiKey
            // 
            this.tbApiKey.Location = new System.Drawing.Point(63, 23);
            this.tbApiKey.Name = "tbApiKey";
            this.tbApiKey.Size = new System.Drawing.Size(184, 20);
            this.tbApiKey.TabIndex = 2;
            // 
            // btnSaveAPIKey
            // 
            this.btnSaveAPIKey.Location = new System.Drawing.Point(253, 22);
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
            this.panel1.Controls.Add(this.lbRequestStatus);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lbPhoneNumber);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lbRequestCount);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 294);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(251, 100);
            this.panel1.TabIndex = 4;
            // 
            // lbRequestStatus
            // 
            this.lbRequestStatus.AutoSize = true;
            this.lbRequestStatus.Location = new System.Drawing.Point(101, 69);
            this.lbRequestStatus.Name = "lbRequestStatus";
            this.lbRequestStatus.Size = new System.Drawing.Size(38, 13);
            this.lbRequestStatus.TabIndex = 5;
            this.lbRequestStatus.Text = "Reddy";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Request task:";
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Phone number:";
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Request count:";
            // 
            // dataGridViewTransaction
            // 
            this.dataGridViewTransaction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTransaction.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.description,
            this.amount,
            this.time});
            this.dataGridViewTransaction.Location = new System.Drawing.Point(12, 59);
            this.dataGridViewTransaction.Name = "dataGridViewTransaction";
            this.dataGridViewTransaction.ReadOnly = true;
            this.dataGridViewTransaction.Size = new System.Drawing.Size(521, 178);
            this.dataGridViewTransaction.TabIndex = 6;
            // 
            // description
            // 
            this.description.HeaderText = "Description";
            this.description.Name = "description";
            this.description.ReadOnly = true;
            this.description.Width = 400;
            // 
            // amount
            // 
            this.amount.HeaderText = "Amount";
            this.amount.Name = "amount";
            this.amount.ReadOnly = true;
            this.amount.Width = 50;
            // 
            // time
            // 
            this.time.HeaderText = "Time";
            this.time.Name = "time";
            this.time.ReadOnly = true;
            this.time.Width = 150;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(355, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Email:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(355, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Blance:";
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(404, 12);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(45, 13);
            this.lbEmail.TabIndex = 9;
            this.lbEmail.Text = "No data";
            // 
            // lbBlance
            // 
            this.lbBlance.AutoSize = true;
            this.lbBlance.Location = new System.Drawing.Point(404, 34);
            this.lbBlance.Name = "lbBlance";
            this.lbBlance.Size = new System.Drawing.Size(13, 13);
            this.lbBlance.TabIndex = 10;
            this.lbBlance.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 406);
            this.Controls.Add(this.lbBlance);
            this.Controls.Add(this.lbEmail);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridViewTransaction);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSaveAPIKey);
            this.Controls.Add(this.tbApiKey);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSendRequest);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTransaction)).EndInit();
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
        private System.Windows.Forms.Label lbRequestStatus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridViewTransaction;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label lbBlance;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        private System.Windows.Forms.DataGridViewTextBoxColumn amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn time;
    }
}

