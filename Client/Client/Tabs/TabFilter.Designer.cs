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
            this.gbSortWay = new System.Windows.Forms.GroupBox();
            this.rbDesc = new System.Windows.Forms.RadioButton();
            this.rbAsc = new System.Windows.Forms.RadioButton();
            this.btReset = new System.Windows.Forms.Button();
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panelContext.SuspendLayout();
            this.gbSortWay.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.panel1.Location = new System.Drawing.Point(220, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(423, 35);
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
            this.panelContext.Controls.Add(this.gbSortWay);
            this.panelContext.Controls.Add(this.btReset);
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
            this.panelContext.Location = new System.Drawing.Point(0, 35);
            this.panelContext.Name = "panelContext";
            this.panelContext.Size = new System.Drawing.Size(643, 168);
            this.panelContext.TabIndex = 4;
            // 
            // gbSortWay
            // 
            this.gbSortWay.Controls.Add(this.rbDesc);
            this.gbSortWay.Controls.Add(this.rbAsc);
            this.gbSortWay.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gbSortWay.Location = new System.Drawing.Point(431, 31);
            this.gbSortWay.Name = "gbSortWay";
            this.gbSortWay.Size = new System.Drawing.Size(122, 92);
            this.gbSortWay.TabIndex = 11;
            this.gbSortWay.TabStop = false;
            this.gbSortWay.Text = "Sort Settings";
            // 
            // rbDesc
            // 
            this.rbDesc.AutoSize = true;
            this.rbDesc.ForeColor = System.Drawing.SystemColors.Control;
            this.rbDesc.Location = new System.Drawing.Point(7, 51);
            this.rbDesc.Name = "rbDesc";
            this.rbDesc.Size = new System.Drawing.Size(82, 17);
            this.rbDesc.TabIndex = 1;
            this.rbDesc.TabStop = true;
            this.rbDesc.Text = "Descending";
            this.rbDesc.UseVisualStyleBackColor = true;
            // 
            // rbAsc
            // 
            this.rbAsc.AutoSize = true;
            this.rbAsc.Checked = true;
            this.rbAsc.ForeColor = System.Drawing.SystemColors.Control;
            this.rbAsc.Location = new System.Drawing.Point(7, 20);
            this.rbAsc.Name = "rbAsc";
            this.rbAsc.Size = new System.Drawing.Size(75, 17);
            this.rbAsc.TabIndex = 0;
            this.rbAsc.TabStop = true;
            this.rbAsc.Text = "Ascending";
            this.rbAsc.UseVisualStyleBackColor = true;
            // 
            // btReset
            // 
            this.btReset.Location = new System.Drawing.Point(297, 110);
            this.btReset.Margin = new System.Windows.Forms.Padding(2);
            this.btReset.Name = "btReset";
            this.btReset.Size = new System.Drawing.Size(109, 21);
            this.btReset.TabIndex = 10;
            this.btReset.Text = "Reset";
            this.btReset.UseVisualStyleBackColor = true;
            this.btReset.Click += new System.EventHandler(this.btReset_Click);
            // 
            // btTitleSort
            // 
            this.btTitleSort.Location = new System.Drawing.Point(297, 35);
            this.btTitleSort.Margin = new System.Windows.Forms.Padding(2);
            this.btTitleSort.Name = "btTitleSort";
            this.btTitleSort.Size = new System.Drawing.Size(109, 22);
            this.btTitleSort.TabIndex = 9;
            this.btTitleSort.Text = "Title";
            this.btTitleSort.UseVisualStyleBackColor = true;
            this.btTitleSort.Click += new System.EventHandler(this.btTitleSort_Click);
            // 
            // btRatingSort
            // 
            this.btRatingSort.Location = new System.Drawing.Point(297, 82);
            this.btRatingSort.Margin = new System.Windows.Forms.Padding(2);
            this.btRatingSort.Name = "btRatingSort";
            this.btRatingSort.Size = new System.Drawing.Size(109, 22);
            this.btRatingSort.TabIndex = 8;
            this.btRatingSort.Text = "Rating";
            this.btRatingSort.UseVisualStyleBackColor = true;
            this.btRatingSort.Click += new System.EventHandler(this.btRatingSort_Click);
            // 
            // btTimeSort
            // 
            this.btTimeSort.Location = new System.Drawing.Point(297, 58);
            this.btTimeSort.Margin = new System.Windows.Forms.Padding(2);
            this.btTimeSort.Name = "btTimeSort";
            this.btTimeSort.Size = new System.Drawing.Size(109, 22);
            this.btTimeSort.TabIndex = 7;
            this.btTimeSort.Text = "Time";
            this.btTimeSort.UseVisualStyleBackColor = true;
            this.btTimeSort.Click += new System.EventHandler(this.btTimeSort_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label4.Location = new System.Drawing.Point(10, 105);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Movie Genre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label3.Location = new System.Drawing.Point(9, 63);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Movie Date";
            // 
            // cBMovieGenres
            // 
            this.cBMovieGenres.FormattingEnabled = true;
            this.cBMovieGenres.Location = new System.Drawing.Point(95, 102);
            this.cBMovieGenres.Margin = new System.Windows.Forms.Padding(2);
            this.cBMovieGenres.Name = "cBMovieGenres";
            this.cBMovieGenres.Size = new System.Drawing.Size(92, 21);
            this.cBMovieGenres.TabIndex = 4;
            this.cBMovieGenres.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cBMovieGenres_KeyDown);
            // 
            // dateTimePickerMovieF
            // 
            this.dateTimePickerMovieF.Location = new System.Drawing.Point(95, 63);
            this.dateTimePickerMovieF.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePickerMovieF.Name = "dateTimePickerMovieF";
            this.dateTimePickerMovieF.Size = new System.Drawing.Size(151, 20);
            this.dateTimePickerMovieF.TabIndex = 3;
            this.dateTimePickerMovieF.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dateTimePickerMovieF_KeyDown);
            // 
            // tbMovieTitleF
            // 
            this.tbMovieTitleF.Location = new System.Drawing.Point(95, 20);
            this.tbMovieTitleF.Margin = new System.Windows.Forms.Padding(2);
            this.tbMovieTitleF.Name = "tbMovieTitleF";
            this.tbMovieTitleF.Size = new System.Drawing.Size(76, 20);
            this.tbMovieTitleF.TabIndex = 2;
            this.tbMovieTitleF.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbMovieTitleF_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label2.Location = new System.Drawing.Point(9, 23);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Movie Title";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(485, 500);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // TabFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(643, 199);
            this.Controls.Add(this.panelContext);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TabFilter";
            this.Text = "TabTemplate";
            this.panelContext.ResumeLayout(false);
            this.panelContext.PerformLayout();
            this.gbSortWay.ResumeLayout(false);
            this.gbSortWay.PerformLayout();
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
        private Button btReset;
        private GroupBox gbSortWay;
        private RadioButton rbDesc;
        private RadioButton rbAsc;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}