namespace Server
{
    partial class AddMovie
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
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btAddActor = new System.Windows.Forms.Button();
            this.btSelectActorPhoto = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.tbActorLastName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbActorFirstName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbGenre = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btSelect = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tbDuration = new System.Windows.Forms.TextBox();
            this.cbDelActors = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbTrailerLink = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btAddMovie = new System.Windows.Forms.Button();
            this.btDeleteActor = new System.Windows.Forms.Button();
            this.ofd1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.CbMovie = new System.Windows.Forms.ComboBox();
            this.CbActors = new System.Windows.Forms.ComboBox();
            this.btActorToMovie = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(16, 568);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 16);
            this.label10.TabIndex = 33;
            this.label10.Text = "Added actors";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btAddActor);
            this.groupBox1.Controls.Add(this.btSelectActorPhoto);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.tbActorLastName);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.tbActorFirstName);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(8, 286);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(575, 146);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Actor";
            // 
            // btAddActor
            // 
            this.btAddActor.Location = new System.Drawing.Point(425, 112);
            this.btAddActor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btAddActor.Name = "btAddActor";
            this.btAddActor.Size = new System.Drawing.Size(139, 28);
            this.btAddActor.TabIndex = 23;
            this.btAddActor.Text = "Add actor";
            this.btAddActor.UseVisualStyleBackColor = true;
            this.btAddActor.Click += new System.EventHandler(this.btAddActor_Click);
            // 
            // btSelectActorPhoto
            // 
            this.btSelectActorPhoto.Location = new System.Drawing.Point(145, 76);
            this.btSelectActorPhoto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btSelectActorPhoto.Name = "btSelectActorPhoto";
            this.btSelectActorPhoto.Size = new System.Drawing.Size(419, 28);
            this.btSelectActorPhoto.TabIndex = 22;
            this.btSelectActorPhoto.Text = "Select actor\'s photo";
            this.btSelectActorPhoto.UseVisualStyleBackColor = true;
            this.btSelectActorPhoto.Click += new System.EventHandler(this.btSelectActorPhoto_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 82);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 16);
            this.label9.TabIndex = 21;
            this.label9.Text = "Actor\'s phoot";
            // 
            // tbActorLastName
            // 
            this.tbActorLastName.Location = new System.Drawing.Point(145, 46);
            this.tbActorLastName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbActorLastName.Name = "tbActorLastName";
            this.tbActorLastName.Size = new System.Drawing.Size(417, 22);
            this.tbActorLastName.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 49);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 16);
            this.label8.TabIndex = 19;
            this.label8.Text = "Actor Last Name";
            // 
            // tbActorFirstName
            // 
            this.tbActorFirstName.Location = new System.Drawing.Point(145, 16);
            this.tbActorFirstName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbActorFirstName.Name = "tbActorFirstName";
            this.tbActorFirstName.Size = new System.Drawing.Size(417, 22);
            this.tbActorFirstName.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 25);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 16);
            this.label7.TabIndex = 15;
            this.label7.Text = "Actor Frist Name";
            // 
            // tbGenre
            // 
            this.tbGenre.Location = new System.Drawing.Point(153, 255);
            this.tbGenre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbGenre.Name = "tbGenre";
            this.tbGenre.Size = new System.Drawing.Size(417, 22);
            this.tbGenre.TabIndex = 30;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 255);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 16);
            this.label6.TabIndex = 29;
            this.label6.Text = "Genre";
            // 
            // btSelect
            // 
            this.btSelect.Location = new System.Drawing.Point(153, 220);
            this.btSelect.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btSelect.Name = "btSelect";
            this.btSelect.Size = new System.Drawing.Size(419, 28);
            this.btSelect.TabIndex = 28;
            this.btSelect.Text = "Select poster";
            this.btSelect.UseVisualStyleBackColor = true;
            this.btSelect.Click += new System.EventHandler(this.btSelect_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 16);
            this.label4.TabIndex = 27;
            this.label4.Text = "Select poster";
            // 
            // tbDuration
            // 
            this.tbDuration.Location = new System.Drawing.Point(153, 190);
            this.tbDuration.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbDuration.Name = "tbDuration";
            this.tbDuration.Size = new System.Drawing.Size(417, 22);
            this.tbDuration.TabIndex = 26;
            // 
            // cbDelActors
            // 
            this.cbDelActors.FormattingEnabled = true;
            this.cbDelActors.Location = new System.Drawing.Point(153, 564);
            this.cbDelActors.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbDelActors.Name = "cbDelActors";
            this.cbDelActors.Size = new System.Drawing.Size(417, 24);
            this.cbDelActors.TabIndex = 31;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 16);
            this.label5.TabIndex = 25;
            this.label5.Text = "Duration";
            // 
            // tbDescription
            // 
            this.tbDescription.Location = new System.Drawing.Point(153, 86);
            this.tbDescription.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbDescription.Multiline = true;
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(417, 86);
            this.tbDescription.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 16);
            this.label3.TabIndex = 23;
            this.label3.Text = "Description";
            // 
            // tbTrailerLink
            // 
            this.tbTrailerLink.Location = new System.Drawing.Point(153, 49);
            this.tbTrailerLink.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbTrailerLink.Name = "tbTrailerLink";
            this.tbTrailerLink.Size = new System.Drawing.Size(417, 22);
            this.tbTrailerLink.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 16);
            this.label2.TabIndex = 21;
            this.label2.Text = "Trailer Link";
            // 
            // tbTitle
            // 
            this.tbTitle.Location = new System.Drawing.Point(153, 14);
            this.tbTitle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(417, 22);
            this.tbTitle.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 16);
            this.label1.TabIndex = 19;
            this.label1.Text = "Title";
            // 
            // btAddMovie
            // 
            this.btAddMovie.Location = new System.Drawing.Point(16, 633);
            this.btAddMovie.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btAddMovie.Name = "btAddMovie";
            this.btAddMovie.Size = new System.Drawing.Size(556, 28);
            this.btAddMovie.TabIndex = 34;
            this.btAddMovie.Text = "Add movie";
            this.btAddMovie.UseVisualStyleBackColor = true;
            this.btAddMovie.Click += new System.EventHandler(this.btAddMovie_Click);
            // 
            // btDeleteActor
            // 
            this.btDeleteActor.Location = new System.Drawing.Point(472, 598);
            this.btDeleteActor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btDeleteActor.Name = "btDeleteActor";
            this.btDeleteActor.Size = new System.Drawing.Size(100, 28);
            this.btDeleteActor.TabIndex = 24;
            this.btDeleteActor.Text = "Delete actor";
            this.btDeleteActor.UseVisualStyleBackColor = true;
            this.btDeleteActor.Click += new System.EventHandler(this.btDeleteActor_Click);
            // 
            // ofd1
            // 
            this.ofd1.FileName = "openFileDialog1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btActorToMovie);
            this.groupBox2.Controls.Add(this.CbActors);
            this.groupBox2.Controls.Add(this.CbMovie);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Location = new System.Drawing.Point(8, 438);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(575, 119);
            this.groupBox2.TabIndex = 35;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Movie  To Actors";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 18);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 16);
            this.label11.TabIndex = 34;
            this.label11.Text = "Movie";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(9, 53);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(38, 16);
            this.label12.TabIndex = 35;
            this.label12.Text = "Actor";
            // 
            // CbMovie
            // 
            this.CbMovie.FormattingEnabled = true;
            this.CbMovie.Location = new System.Drawing.Point(145, 15);
            this.CbMovie.Margin = new System.Windows.Forms.Padding(4);
            this.CbMovie.Name = "CbMovie";
            this.CbMovie.Size = new System.Drawing.Size(417, 24);
            this.CbMovie.TabIndex = 36;
            // 
            // CbActors
            // 
            this.CbActors.FormattingEnabled = true;
            this.CbActors.Location = new System.Drawing.Point(145, 45);
            this.CbActors.Margin = new System.Windows.Forms.Padding(4);
            this.CbActors.Name = "CbActors";
            this.CbActors.Size = new System.Drawing.Size(417, 24);
            this.CbActors.TabIndex = 37;
            // 
            // btActorToMovie
            // 
            this.btActorToMovie.Location = new System.Drawing.Point(425, 84);
            this.btActorToMovie.Margin = new System.Windows.Forms.Padding(4);
            this.btActorToMovie.Name = "btActorToMovie";
            this.btActorToMovie.Size = new System.Drawing.Size(137, 28);
            this.btActorToMovie.TabIndex = 24;
            this.btActorToMovie.Text = "Actor To Movie";
            this.btActorToMovie.UseVisualStyleBackColor = true;
            this.btActorToMovie.Click += new System.EventHandler(this.btActorToMovie_Click);
            // 
            // AddMovie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 674);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btDeleteActor);
            this.Controls.Add(this.btAddMovie);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tbGenre);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btSelect);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbDuration);
            this.Controls.Add(this.cbDelActors);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbDescription);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbTrailerLink);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbTitle);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AddMovie";
            this.Text = "AddMovie";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btSelectActorPhoto;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbActorLastName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbActorFirstName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbGenre;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btSelect;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbDuration;
        private System.Windows.Forms.ComboBox cbDelActors;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbDescription;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbTrailerLink;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btAddMovie;
        private System.Windows.Forms.Button btAddActor;
        private System.Windows.Forms.Button btDeleteActor;
        private System.Windows.Forms.OpenFileDialog ofd1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox CbActors;
        private System.Windows.Forms.ComboBox CbMovie;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btActorToMovie;
    }
}