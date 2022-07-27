namespace Client.Tabs
{
    partial class TabFilm
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

            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelFilmName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelFilmDescription = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonBuyTicket = new System.Windows.Forms.Button();

            this.panelContext.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.panel1.Location = new System.Drawing.Point(220, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(580, 35);
            this.panel1.TabIndex = 2;
            // 
            // panelContext
            // 
            this.panelContext.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelContext.AutoScroll = true;
            this.panelContext.AutoScrollMargin = new System.Drawing.Size(0, 12);
            this.panelContext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.panelContext.Controls.Add(this.buttonBuyTicket);
            this.panelContext.Controls.Add(this.label3);
            this.panelContext.Controls.Add(this.panel3);
            this.panelContext.Controls.Add(this.labelFilmDescription);
            this.panelContext.Controls.Add(this.label2);
            this.panelContext.Controls.Add(this.labelFilmName);
            this.panelContext.Controls.Add(this.label1);
            this.panelContext.Controls.Add(this.pictureBox1);
            this.panelContext.Location = new System.Drawing.Point(0, 35);
            this.panelContext.Margin = new System.Windows.Forms.Padding(12, 12, 28, 12);
            this.panelContext.Name = "panelContext";
            this.panelContext.Size = new System.Drawing.Size(800, 456);
            this.panelContext.TabIndex = 3;
            this.panelContext.Paint += new System.Windows.Forms.PaintEventHandler(this.panelContext_Paint);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(534, 199);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(187, 31);
            this.button1.TabIndex = 8;
            this.button1.Text = "Buy Ticket";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btCheckout_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 262);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 21);
            this.label3.TabIndex = 7;
            this.label3.Text = "Trailer:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel3.Location = new System.Drawing.Point(12, 286);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(758, 351);
            this.panel3.TabIndex = 6;
            // 
            // labelFilmDescription
            // 
            this.labelFilmDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelFilmDescription.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFilmDescription.ForeColor = System.Drawing.Color.White;
            this.labelFilmDescription.Location = new System.Drawing.Point(216, 120);
            this.labelFilmDescription.Name = "labelFilmDescription";
            this.labelFilmDescription.Size = new System.Drawing.Size(255, 110);
            this.labelFilmDescription.TabIndex = 5;
            this.labelFilmDescription.Text = "Some Description";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(198, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Description:";
            // 
            // labelFilmName
            // 
            this.labelFilmName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelFilmName.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFilmName.ForeColor = System.Drawing.Color.White;
            this.labelFilmName.Location = new System.Drawing.Point(216, 35);
            this.labelFilmName.Name = "labelFilmName";
            this.labelFilmName.Size = new System.Drawing.Size(255, 64);
            this.labelFilmName.TabIndex = 3;
            this.labelFilmName.Text = "Some Film Name\r\n\r\n";
            //
            // buttonBuyTicket
            // 
            this.buttonBuyTicket.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.buttonBuyTicket.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonBuyTicket.FlatAppearance.BorderSize = 0;
            this.buttonBuyTicket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBuyTicket.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBuyTicket.ForeColor = System.Drawing.Color.White;
            this.buttonBuyTicket.Location = new System.Drawing.Point(534, 199);
            this.buttonBuyTicket.Name = "buttonBuyTicket";
            this.buttonBuyTicket.Size = new System.Drawing.Size(187, 31);
            this.buttonBuyTicket.TabIndex = 8;
            this.buttonBuyTicket.Text = "Buy Ticket";
            this.buttonBuyTicket.UseVisualStyleBackColor = false;
            // 
            // TabFilm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(800, 491);
            this.Controls.Add(this.panelContext);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TabFilm";
            this.Text = "TabFilm";
            this.Load += new System.EventHandler(this.TabFilm_Load);
            this.panelContext.ResumeLayout(false);
            this.panelContext.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelContext;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelFilmDescription;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelFilmName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button buttonBuyTicket;
    }
}