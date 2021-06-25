
namespace Sem2FProject
{
    partial class AddFlight
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.FlightIdLabel = new System.Windows.Forms.Label();
            this.DeptCombo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ArrivalCombo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.AirlineCombo = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SeatCombo = new System.Windows.Forms.ComboBox();
            this.AddAirlineBtn = new System.Windows.Forms.Button();
            this.AddAirportBtn = new System.Windows.Forms.Button();
            this.CreateBtn = new System.Windows.Forms.Button();
            this.BackBtn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.ClassCombo = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(270, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Add New Flight";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(675, 40);
            this.panel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 51);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Flight ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(118, 118);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "Departure";
            // 
            // FlightIdLabel
            // 
            this.FlightIdLabel.AutoSize = true;
            this.FlightIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FlightIdLabel.Location = new System.Drawing.Point(88, 51);
            this.FlightIdLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.FlightIdLabel.Name = "FlightIdLabel";
            this.FlightIdLabel.Size = new System.Drawing.Size(0, 20);
            this.FlightIdLabel.TabIndex = 15;
            // 
            // DeptCombo
            // 
            this.DeptCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.DeptCombo.FormattingEnabled = true;
            this.DeptCombo.Location = new System.Drawing.Point(296, 115);
            this.DeptCombo.Name = "DeptCombo";
            this.DeptCombo.Size = new System.Drawing.Size(258, 28);
            this.DeptCombo.TabIndex = 17;
            this.DeptCombo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DeptCombo_MouseClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(118, 167);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "Arrival";
            // 
            // ArrivalCombo
            // 
            this.ArrivalCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ArrivalCombo.FormattingEnabled = true;
            this.ArrivalCombo.Location = new System.Drawing.Point(296, 167);
            this.ArrivalCombo.Name = "ArrivalCombo";
            this.ArrivalCombo.Size = new System.Drawing.Size(258, 28);
            this.ArrivalCombo.TabIndex = 17;
            this.ArrivalCombo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ArrivalCombo_MouseClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(118, 222);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "Airline";
            // 
            // AirlineCombo
            // 
            this.AirlineCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.AirlineCombo.FormattingEnabled = true;
            this.AirlineCombo.Location = new System.Drawing.Point(296, 222);
            this.AirlineCombo.Name = "AirlineCombo";
            this.AirlineCombo.Size = new System.Drawing.Size(258, 28);
            this.AirlineCombo.TabIndex = 17;
            this.AirlineCombo.SelectedIndexChanged += new System.EventHandler(this.AirlineCombo_SelectedIndexChanged);
            this.AirlineCombo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.AirlineCombo_MouseClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(118, 278);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Seat No";
            // 
            // SeatCombo
            // 
            this.SeatCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.SeatCombo.FormattingEnabled = true;
            this.SeatCombo.Location = new System.Drawing.Point(296, 278);
            this.SeatCombo.Name = "SeatCombo";
            this.SeatCombo.Size = new System.Drawing.Size(258, 28);
            this.SeatCombo.TabIndex = 17;
            this.SeatCombo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.SeatCombo_MouseClick);
            // 
            // AddAirlineBtn
            // 
            this.AddAirlineBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.AddAirlineBtn.Location = new System.Drawing.Point(573, 51);
            this.AddAirlineBtn.Name = "AddAirlineBtn";
            this.AddAirlineBtn.Size = new System.Drawing.Size(97, 28);
            this.AddAirlineBtn.TabIndex = 18;
            this.AddAirlineBtn.Text = "Add Airline";
            this.AddAirlineBtn.UseVisualStyleBackColor = true;
            this.AddAirlineBtn.Click += new System.EventHandler(this.AddAirlineBtn_Click);
            // 
            // AddAirportBtn
            // 
            this.AddAirportBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.AddAirportBtn.Location = new System.Drawing.Point(470, 51);
            this.AddAirportBtn.Name = "AddAirportBtn";
            this.AddAirportBtn.Size = new System.Drawing.Size(97, 28);
            this.AddAirportBtn.TabIndex = 18;
            this.AddAirportBtn.Text = "Add Airport";
            this.AddAirportBtn.UseVisualStyleBackColor = true;
            this.AddAirportBtn.Click += new System.EventHandler(this.AddAirportBtn_Click);
            // 
            // CreateBtn
            // 
            this.CreateBtn.BackColor = System.Drawing.SystemColors.Highlight;
            this.CreateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateBtn.ForeColor = System.Drawing.Color.White;
            this.CreateBtn.Location = new System.Drawing.Point(573, 414);
            this.CreateBtn.Margin = new System.Windows.Forms.Padding(2);
            this.CreateBtn.Name = "CreateBtn";
            this.CreateBtn.Size = new System.Drawing.Size(83, 27);
            this.CreateBtn.TabIndex = 19;
            this.CreateBtn.Text = "Create";
            this.CreateBtn.UseVisualStyleBackColor = false;
            this.CreateBtn.Click += new System.EventHandler(this.CreateBtn_Click);
            // 
            // BackBtn
            // 
            this.BackBtn.BackColor = System.Drawing.SystemColors.Highlight;
            this.BackBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackBtn.ForeColor = System.Drawing.Color.White;
            this.BackBtn.Location = new System.Drawing.Point(15, 414);
            this.BackBtn.Margin = new System.Windows.Forms.Padding(2);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(83, 27);
            this.BackBtn.TabIndex = 19;
            this.BackBtn.Text = "Back";
            this.BackBtn.UseVisualStyleBackColor = false;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(118, 329);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "Class Type";
            // 
            // ClassCombo
            // 
            this.ClassCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ClassCombo.FormattingEnabled = true;
            this.ClassCombo.Location = new System.Drawing.Point(296, 329);
            this.ClassCombo.Name = "ClassCombo";
            this.ClassCombo.Size = new System.Drawing.Size(258, 28);
            this.ClassCombo.TabIndex = 17;
            this.ClassCombo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ClassCombo_MouseClick);
            // 
            // AddFlight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 452);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.CreateBtn);
            this.Controls.Add(this.AddAirportBtn);
            this.Controls.Add(this.AddAirlineBtn);
            this.Controls.Add(this.ClassCombo);
            this.Controls.Add(this.SeatCombo);
            this.Controls.Add(this.AirlineCombo);
            this.Controls.Add(this.ArrivalCombo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.DeptCombo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.FlightIdLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "AddFlight";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddFlight";
            this.Load += new System.EventHandler(this.AddFlight_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label FlightIdLabel;
        private System.Windows.Forms.ComboBox DeptCombo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox ArrivalCombo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox AirlineCombo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox SeatCombo;
        private System.Windows.Forms.Button AddAirlineBtn;
        private System.Windows.Forms.Button AddAirportBtn;
        private System.Windows.Forms.Button CreateBtn;
        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox ClassCombo;
    }
}