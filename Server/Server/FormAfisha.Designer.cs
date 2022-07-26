namespace Server
{
    partial class FormAfisha
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cbRooms = new System.Windows.Forms.ComboBox();
            this.btAddtoFilm = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btAddtoAfisha = new System.Windows.Forms.Button();
            this.cbMovie = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(94, 5);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 19;
            // 
            // cbRooms
            // 
            this.cbRooms.FormattingEnabled = true;
            this.cbRooms.Location = new System.Drawing.Point(94, 67);
            this.cbRooms.Name = "cbRooms";
            this.cbRooms.Size = new System.Drawing.Size(200, 24);
            this.cbRooms.TabIndex = 18;
            // 
            // btAddtoFilm
            // 
            this.btAddtoFilm.Location = new System.Drawing.Point(300, 33);
            this.btAddtoFilm.Name = "btAddtoFilm";
            this.btAddtoFilm.Size = new System.Drawing.Size(120, 23);
            this.btAddtoFilm.TabIndex = 17;
            this.btAddtoFilm.Text = "Add Film";
            this.btAddtoFilm.UseVisualStyleBackColor = true;
            this.btAddtoFilm.Click += new System.EventHandler(this.btAddtoFilm_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 16);
            this.label3.TabIndex = 16;
            this.label3.Text = "Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "Movie Title:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "Room:";
            // 
            // btAddtoAfisha
            // 
            this.btAddtoAfisha.Location = new System.Drawing.Point(300, 102);
            this.btAddtoAfisha.Name = "btAddtoAfisha";
            this.btAddtoAfisha.Size = new System.Drawing.Size(120, 23);
            this.btAddtoAfisha.TabIndex = 13;
            this.btAddtoAfisha.Text = "Add to Afisha";
            this.btAddtoAfisha.UseVisualStyleBackColor = true;
            this.btAddtoAfisha.Click += new System.EventHandler(this.btAddtoAfisha_Click);
            // 
            // cbMovie
            // 
            this.cbMovie.FormattingEnabled = true;
            this.cbMovie.Location = new System.Drawing.Point(95, 33);
            this.cbMovie.Name = "cbMovie";
            this.cbMovie.Size = new System.Drawing.Size(199, 24);
            this.cbMovie.TabIndex = 20;
            // 
            // FormAfisha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 142);
            this.Controls.Add(this.cbMovie);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.cbRooms);
            this.Controls.Add(this.btAddtoFilm);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btAddtoAfisha);
            this.Name = "FormAfisha";
            this.Text = "FormAfisha";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox cbRooms;
        private System.Windows.Forms.Button btAddtoFilm;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btAddtoAfisha;
        private System.Windows.Forms.ComboBox cbMovie;
    }
}

