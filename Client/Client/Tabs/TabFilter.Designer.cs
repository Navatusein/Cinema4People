using System.Windows.Forms;

namespace Client.Tabs
{
    partial class TabFilter
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelContext = new System.Windows.Forms.Panel();
            this.btTitleSort = new System.Windows.Forms.Button();
            this.btRatingSort = new System.Windows.Forms.Button();
            this.btTimeSort = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cBMovieGenres = new System.Windows.Forms.ComboBox();
            this.dateTimePickerMovieF = new System.Windows.Forms.DateTimePicker();
            this.tbMovieTitleF = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelContext.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.panel1.Location = new System.Drawing.Point(293, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(289, 43);
            this.panel1.TabIndex = 3;
            // 
            // panelContext
            // 
            this.panelContext.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelContext.AutoScroll = true;
            this.panelContext.AutoScrollMargin = new System.Drawing.Size(0, 12);
            this.panelContext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.panelContext.Controls.Add(this.btTitleSort);
            this.panelContext.Controls.Add(this.btRatingSort);
            this.panelContext.Controls.Add(this.btTimeSort);
            this.panelContext.Controls.Add(this.label4);
            this.panelContext.Controls.Add(this.label3);
            this.panelContext.Controls.Add(this.cBMovieGenres);
            this.panelContext.Controls.Add(this.dateTimePickerMovieF);
            this.panelContext.Controls.Add(this.tbMovieTitleF);
            this.panelContext.Controls.Add(this.label2);
            this.panelContext.Controls.Add(this.label1);
            this.panelContext.Location = new System.Drawing.Point(0, 43);
            this.panelContext.Margin = new System.Windows.Forms.Padding(4);
            this.panelContext.Name = "panelContext";
            this.panelContext.Size = new System.Drawing.Size(583, 202);
            this.panelContext.TabIndex = 4;
            // 
            // btTitleSort
            // 
            this.btTitleSort.Location = new System.Drawing.Point(396, 43);
            this.btTitleSort.Name = "btTitleSort";
            this.btTitleSort.Size = new System.Drawing.Size(145, 27);
            this.btTitleSort.TabIndex = 9;
            this.btTitleSort.Text = "Title";
            this.btTitleSort.UseVisualStyleBackColor = true;
            this.btTitleSort.Click += new System.EventHandler(this.btTitleSort_Click);
            // 
            // btRatingSort
            // 
            this.btRatingSort.Location = new System.Drawing.Point(396, 101);
            this.btRatingSort.Name = "btRatingSort";
            this.btRatingSort.Size = new System.Drawing.Size(145, 27);
            this.btRatingSort.TabIndex = 8;
            this.btRatingSort.Text = "Rating";
            this.btRatingSort.UseVisualStyleBackColor = true;
            this.btRatingSort.Click += new System.EventHandler(this.btRatingSort_Click);
            // 
            // btTimeSort
            // 
            this.btTimeSort.Location = new System.Drawing.Point(396, 72);
            this.btTimeSort.Name = "btTimeSort";
            this.btTimeSort.Size = new System.Drawing.Size(145, 27);
            this.btTimeSort.TabIndex = 7;
            this.btTimeSort.Text = "Time";
            this.btTimeSort.UseVisualStyleBackColor = true;
            this.btTimeSort.Click += new System.EventHandler(this.btTimeSort_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label4.Location = new System.Drawing.Point(13, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Movie Genre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label3.Location = new System.Drawing.Point(12, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Movie Date";
            // 
            // cBMovieGenres
            // 
            this.cBMovieGenres.FormattingEnabled = true;
            this.cBMovieGenres.Location = new System.Drawing.Point(127, 126);
            this.cBMovieGenres.Name = "cBMovieGenres";
            this.cBMovieGenres.Size = new System.Drawing.Size(121, 24);
            this.cBMovieGenres.TabIndex = 4;
            this.cBMovieGenres.SelectedIndexChanged += new System.EventHandler(this.cBMovieGenres_SelectedIndexChanged);
            // 
            // dateTimePickerMovieF
            // 
            this.dateTimePickerMovieF.Location = new System.Drawing.Point(127, 77);
            this.dateTimePickerMovieF.Name = "dateTimePickerMovieF";
            this.dateTimePickerMovieF.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerMovieF.TabIndex = 3;
            this.dateTimePickerMovieF.ValueChanged += new System.EventHandler(this.dateTimePickerMovieF_ValueChanged);
            // 
            // tbMovieTitleF
            // 
            this.tbMovieTitleF.Location = new System.Drawing.Point(127, 25);
            this.tbMovieTitleF.Name = "tbMovieTitleF";
            this.tbMovieTitleF.Size = new System.Drawing.Size(100, 22);
            this.tbMovieTitleF.TabIndex = 2;
            this.tbMovieTitleF.TextChanged += new System.EventHandler(this.tbMovieTitleF_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label2.Location = new System.Drawing.Point(12, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Movie Title";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(647, 615);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // TabFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(583, 245);
            this.Controls.Add(this.panelContext);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TabFilter";
            this.Text = "TabTemplate";
            this.panelContext.ResumeLayout(false);
            this.panelContext.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelContext;
        private System.Windows.Forms.Label label1;
        private Label label4;
        private Label label3;
        private ComboBox cBMovieGenres;
        private DateTimePicker dateTimePickerMovieF;
        private TextBox tbMovieTitleF;
        private Label label2;
        private Button btTitleSort;
        private Button btRatingSort;
        private Button btTimeSort;
    }
}