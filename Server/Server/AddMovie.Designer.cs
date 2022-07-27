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
            this.tbActorRole = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbActorName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbGenre = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btSelect = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tbDuration = new System.Windows.Forms.TextBox();
            this.cbActors = new System.Windows.Forms.ComboBox();
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
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 360);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 13);
            this.label10.TabIndex = 33;
            this.label10.Text = "Added actors";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btAddActor);
            this.groupBox1.Controls.Add(this.btSelectActorPhoto);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.tbActorRole);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.tbActorName);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(6, 232);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(431, 119);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Actor";
            // 
            // btAddActor
            // 
            this.btAddActor.Location = new System.Drawing.Point(348, 91);
            this.btAddActor.Name = "btAddActor";
            this.btAddActor.Size = new System.Drawing.Size(75, 23);
            this.btAddActor.TabIndex = 23;
            this.btAddActor.Text = "Add actor";
            this.btAddActor.UseVisualStyleBackColor = true;
            this.btAddActor.Click += new System.EventHandler(this.btAddActor_Click);
            // 
            // btSelectActorPhoto
            // 
            this.btSelectActorPhoto.Location = new System.Drawing.Point(109, 62);
            this.btSelectActorPhoto.Name = "btSelectActorPhoto";
            this.btSelectActorPhoto.Size = new System.Drawing.Size(314, 23);
            this.btSelectActorPhoto.TabIndex = 22;
            this.btSelectActorPhoto.Text = "Select actor\'s photo";
            this.btSelectActorPhoto.UseVisualStyleBackColor = true;
            this.btSelectActorPhoto.Click += new System.EventHandler(this.btSelectActorPhoto_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 67);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Actor\'s phoot";
            // 
            // tbActorRole
            // 
            this.tbActorRole.Location = new System.Drawing.Point(109, 37);
            this.tbActorRole.Margin = new System.Windows.Forms.Padding(2);
            this.tbActorRole.Name = "tbActorRole";
            this.tbActorRole.Size = new System.Drawing.Size(314, 20);
            this.tbActorRole.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 40);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Actor role";
            // 
            // tbActorName
            // 
            this.tbActorName.Location = new System.Drawing.Point(109, 13);
            this.tbActorName.Margin = new System.Windows.Forms.Padding(2);
            this.tbActorName.Name = "tbActorName";
            this.tbActorName.Size = new System.Drawing.Size(314, 20);
            this.tbActorName.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Actor name";
            // 
            // tbGenre
            // 
            this.tbGenre.Location = new System.Drawing.Point(115, 207);
            this.tbGenre.Margin = new System.Windows.Forms.Padding(2);
            this.tbGenre.Name = "tbGenre";
            this.tbGenre.Size = new System.Drawing.Size(314, 20);
            this.tbGenre.TabIndex = 30;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 207);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "Genre";
            // 
            // btSelect
            // 
            this.btSelect.Location = new System.Drawing.Point(115, 179);
            this.btSelect.Name = "btSelect";
            this.btSelect.Size = new System.Drawing.Size(314, 23);
            this.btSelect.TabIndex = 28;
            this.btSelect.Text = "Select poster";
            this.btSelect.UseVisualStyleBackColor = true;
            this.btSelect.Click += new System.EventHandler(this.btSelect_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 184);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Select poster";
            // 
            // tbDuration
            // 
            this.tbDuration.Location = new System.Drawing.Point(115, 154);
            this.tbDuration.Margin = new System.Windows.Forms.Padding(2);
            this.tbDuration.Name = "tbDuration";
            this.tbDuration.Size = new System.Drawing.Size(314, 20);
            this.tbDuration.TabIndex = 26;
            // 
            // cbActors
            // 
            this.cbActors.FormattingEnabled = true;
            this.cbActors.Location = new System.Drawing.Point(115, 357);
            this.cbActors.Name = "cbActors";
            this.cbActors.Size = new System.Drawing.Size(314, 21);
            this.cbActors.TabIndex = 31;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 154);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Duration";
            // 
            // tbDescription
            // 
            this.tbDescription.Location = new System.Drawing.Point(115, 70);
            this.tbDescription.Margin = new System.Windows.Forms.Padding(2);
            this.tbDescription.Multiline = true;
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(314, 71);
            this.tbDescription.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 70);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Description";
            // 
            // tbTrailerLink
            // 
            this.tbTrailerLink.Location = new System.Drawing.Point(115, 40);
            this.tbTrailerLink.Margin = new System.Windows.Forms.Padding(2);
            this.tbTrailerLink.Name = "tbTrailerLink";
            this.tbTrailerLink.Size = new System.Drawing.Size(314, 20);
            this.tbTrailerLink.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 40);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Trailer Link";
            // 
            // tbTitle
            // 
            this.tbTitle.Location = new System.Drawing.Point(115, 11);
            this.tbTitle.Margin = new System.Windows.Forms.Padding(2);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(314, 20);
            this.tbTitle.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Title";
            // 
            // btAddMovie
            // 
            this.btAddMovie.Location = new System.Drawing.Point(12, 413);
            this.btAddMovie.Name = "btAddMovie";
            this.btAddMovie.Size = new System.Drawing.Size(417, 23);
            this.btAddMovie.TabIndex = 34;
            this.btAddMovie.Text = "Add movie";
            this.btAddMovie.UseVisualStyleBackColor = true;
            this.btAddMovie.Click += new System.EventHandler(this.btAddMovie_Click);
            // 
            // btDeleteActor
            // 
            this.btDeleteActor.Location = new System.Drawing.Point(354, 384);
            this.btDeleteActor.Name = "btDeleteActor";
            this.btDeleteActor.Size = new System.Drawing.Size(75, 23);
            this.btDeleteActor.TabIndex = 24;
            this.btDeleteActor.Text = "Delete actor";
            this.btDeleteActor.UseVisualStyleBackColor = true;
            this.btDeleteActor.Click += new System.EventHandler(this.btDeleteActor_Click);
            // 
            // ofd1
            // 
            this.ofd1.FileName = "openFileDialog1";
            // 
            // AddMovie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 444);
            this.Controls.Add(this.btDeleteActor);
            this.Controls.Add(this.btAddMovie);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tbGenre);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btSelect);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbDuration);
            this.Controls.Add(this.cbActors);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbDescription);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbTrailerLink);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbTitle);
            this.Controls.Add(this.label1);
            this.Name = "AddMovie";
            this.Text = "AddMovie";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btSelectActorPhoto;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbActorRole;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbActorName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbGenre;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btSelect;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbDuration;
        private System.Windows.Forms.ComboBox cbActors;
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
    }
}