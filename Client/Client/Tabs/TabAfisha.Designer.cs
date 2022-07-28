namespace Client.Tabs
{
    partial class TabAfisha
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TabAfisha));
            this.panelContext = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonFilter = new System.Windows.Forms.Button();
            this.imageList24 = new System.Windows.Forms.ImageList(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelContext
            // 
            this.panelContext.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelContext.AutoScroll = true;
            this.panelContext.AutoScrollMargin = new System.Drawing.Size(0, 12);
            this.panelContext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.panelContext.Location = new System.Drawing.Point(0, 43);
            this.panelContext.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelContext.Name = "panelContext";
            this.panelContext.Size = new System.Drawing.Size(1067, 511);
            this.panelContext.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.panel1.Controls.Add(this.buttonFilter);
            this.panel1.Location = new System.Drawing.Point(293, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(773, 43);
            this.panel1.TabIndex = 1;
            // 
            // buttonFilter
            // 
            this.buttonFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonFilter.FlatAppearance.BorderSize = 0;
            this.buttonFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFilter.ForeColor = System.Drawing.Color.Transparent;
            this.buttonFilter.ImageKey = "filter.png";
            this.buttonFilter.ImageList = this.imageList24;
            this.buttonFilter.Location = new System.Drawing.Point(705, 0);
            this.buttonFilter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonFilter.Name = "buttonFilter";
            this.buttonFilter.Size = new System.Drawing.Size(47, 43);
            this.buttonFilter.TabIndex = 0;
            this.buttonFilter.UseVisualStyleBackColor = true;
            this.buttonFilter.Click += new System.EventHandler(this.buttonFilter_Click);
            // 
            // imageList24
            // 
            this.imageList24.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList24.ImageStream")));
            this.imageList24.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList24.Images.SetKeyName(0, "filter.png");
            // 
            // TabAfisha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelContext);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "TabAfisha";
            this.Text = "TabAfisha";
            this.Resize += new System.EventHandler(this.TabAfisha_Resize);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContext;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonFilter;
        private System.Windows.Forms.ImageList imageList24;
    }
}