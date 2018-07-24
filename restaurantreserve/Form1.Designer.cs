namespace restaurantreserve
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Seatdrop = new System.Windows.Forms.NumericUpDown();
            this.Checkbutton = new System.Windows.Forms.Button();
            this.Timebox = new System.Windows.Forms.ComboBox();
            this.Daybox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.avail = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Seatdrop)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(380, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 80);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bookings";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe Script", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(366, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(281, 53);
            this.label2.TabIndex = 25;
            this.label2.Text = "5 pm - 10 pm";
            // 
            // Seatdrop
            // 
            this.Seatdrop.Font = new System.Drawing.Font("Segoe Script", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Seatdrop.Location = new System.Drawing.Point(537, 217);
            this.Seatdrop.Name = "Seatdrop";
            this.Seatdrop.Size = new System.Drawing.Size(120, 46);
            this.Seatdrop.TabIndex = 26;
            this.Seatdrop.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // Checkbutton
            // 
            this.Checkbutton.BackColor = System.Drawing.Color.White;
            this.Checkbutton.Font = new System.Drawing.Font("Segoe Script", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Checkbutton.Location = new System.Drawing.Point(688, 219);
            this.Checkbutton.Name = "Checkbutton";
            this.Checkbutton.Size = new System.Drawing.Size(128, 46);
            this.Checkbutton.TabIndex = 27;
            this.Checkbutton.Text = "Check";
            this.Checkbutton.UseVisualStyleBackColor = false;
            this.Checkbutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // Timebox
            // 
            this.Timebox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Timebox.Font = new System.Drawing.Font("Segoe Script", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Timebox.FormattingEnabled = true;
            this.Timebox.Items.AddRange(new object[] {
            "5.00pm",
            "5.30pm",
            "6.00pm",
            "6.30pm",
            "7.00pm",
            "7.30pm",
            "8.00pm",
            "8.30pm",
            "9.00pm",
            "9.30pm",
            "10.00pm"});
            this.Timebox.Location = new System.Drawing.Point(342, 216);
            this.Timebox.Name = "Timebox";
            this.Timebox.Size = new System.Drawing.Size(153, 46);
            this.Timebox.TabIndex = 28;
            this.Timebox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Daybox
            // 
            this.Daybox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Daybox.Font = new System.Drawing.Font("Segoe Script", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Daybox.FormattingEnabled = true;
            this.Daybox.Items.AddRange(new object[] {
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday ",
            "Sunday"});
            this.Daybox.Location = new System.Drawing.Point(116, 216);
            this.Daybox.Name = "Daybox";
            this.Daybox.Size = new System.Drawing.Size(183, 46);
            this.Daybox.TabIndex = 29;
            this.Daybox.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe Script", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(542, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 53);
            this.label3.TabIndex = 30;
            this.label3.Text = "Seats";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe Script", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(107, 401);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(269, 53);
            this.label4.TabIndex = 31;
            this.label4.Text = "Availability : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe Script", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(107, 317);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 53);
            this.label5.TabIndex = 32;
            this.label5.Text = "Price :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe Script", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(718, 317);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 53);
            this.label6.TabIndex = 33;
            this.label6.Text = "0.00";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // avail
            // 
            this.avail.AccessibleName = "h";
            this.avail.AutoSize = true;
            this.avail.BackColor = System.Drawing.Color.Transparent;
            this.avail.Font = new System.Drawing.Font("Segoe Script", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.avail.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.avail.Location = new System.Drawing.Point(637, 401);
            this.avail.Name = "avail";
            this.avail.Size = new System.Drawing.Size(179, 53);
            this.avail.TabIndex = 35;
            this.avail.Text = "____________";
            this.avail.Click += new System.EventHandler(this.avail_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Segoe Script", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label8.Location = new System.Drawing.Point(366, 161);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 53);
            this.label8.TabIndex = 36;
            this.label8.Text = "Time";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Segoe Script", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label9.Location = new System.Drawing.Point(169, 161);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 53);
            this.label9.TabIndex = 37;
            this.label9.Text = "Day";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Segoe Script", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label10.Location = new System.Drawing.Point(679, 317);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 53);
            this.label10.TabIndex = 38;
            this.label10.Text = "£";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Segoe Script", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(116, 481);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 46);
            this.button1.TabIndex = 39;
            this.button1.Text = "Book";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1012, 563);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.avail);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Daybox);
            this.Controls.Add(this.Timebox);
            this.Controls.Add(this.Checkbutton);
            this.Controls.Add(this.Seatdrop);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "restaurant";
            ((System.ComponentModel.ISupportInitialize)(this.Seatdrop)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown Seatdrop;
        private System.Windows.Forms.Button Checkbutton;
        private System.Windows.Forms.ComboBox Timebox;
        private System.Windows.Forms.ComboBox Daybox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label avail;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button1;
    }
}

