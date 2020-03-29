namespace schoolCanceled
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAirTemp = new System.Windows.Forms.TextBox();
            this.txtWindChill = new System.Windows.Forms.TextBox();
            this.txtSnowIn = new System.Windows.Forms.TextBox();
            this.btnSchoolStatus = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSchoolCanceled = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Air Temperature:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Wind Chill:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Inches of Snowfall:";
            // 
            // txtAirTemp
            // 
            this.txtAirTemp.Location = new System.Drawing.Point(132, 28);
            this.txtAirTemp.Name = "txtAirTemp";
            this.txtAirTemp.Size = new System.Drawing.Size(100, 20);
            this.txtAirTemp.TabIndex = 3;
            // 
            // txtWindChill
            // 
            this.txtWindChill.Location = new System.Drawing.Point(132, 70);
            this.txtWindChill.Name = "txtWindChill";
            this.txtWindChill.Size = new System.Drawing.Size(100, 20);
            this.txtWindChill.TabIndex = 4;
            // 
            // txtSnowIn
            // 
            this.txtSnowIn.Location = new System.Drawing.Point(132, 116);
            this.txtSnowIn.Name = "txtSnowIn";
            this.txtSnowIn.Size = new System.Drawing.Size(100, 20);
            this.txtSnowIn.TabIndex = 5;
            // 
            // btnSchoolStatus
            // 
            this.btnSchoolStatus.Location = new System.Drawing.Point(71, 213);
            this.btnSchoolStatus.Name = "btnSchoolStatus";
            this.btnSchoolStatus.Size = new System.Drawing.Size(150, 23);
            this.btnSchoolStatus.TabIndex = 6;
            this.btnSchoolStatus.Text = "Determine school status";
            this.btnSchoolStatus.UseVisualStyleBackColor = true;
            this.btnSchoolStatus.Click += new System.EventHandler(this.btnSchoolStatus_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "School Cancelled:";
            // 
            // txtSchoolCanceled
            // 
            this.txtSchoolCanceled.Location = new System.Drawing.Point(131, 161);
            this.txtSchoolCanceled.Name = "txtSchoolCanceled";
            this.txtSchoolCanceled.ReadOnly = true;
            this.txtSchoolCanceled.Size = new System.Drawing.Size(100, 20);
            this.txtSchoolCanceled.TabIndex = 8;
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(107, 256);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AcceptButton = this.btnSchoolStatus;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txtSchoolCanceled);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnSchoolStatus);
            this.Controls.Add(this.txtSnowIn);
            this.Controls.Add(this.txtWindChill);
            this.Controls.Add(this.txtAirTemp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAirTemp;
        private System.Windows.Forms.TextBox txtWindChill;
        private System.Windows.Forms.TextBox txtSnowIn;
        private System.Windows.Forms.Button btnSchoolStatus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSchoolCanceled;
        private System.Windows.Forms.Button btnExit;
    }
}

