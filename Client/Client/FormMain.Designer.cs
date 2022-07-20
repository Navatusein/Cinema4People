namespace Client
{
    partial class FormMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelAfisha = new System.Windows.Forms.Panel();
            this.buttonTabAfisha = new System.Windows.Forms.Button();
            this.panelForm = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panelAfisha.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelAfisha
            // 
            this.panelAfisha.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelAfisha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.panelAfisha.Controls.Add(this.button1);
            this.panelAfisha.Controls.Add(this.buttonTabAfisha);
            this.panelAfisha.Location = new System.Drawing.Point(0, 35);
            this.panelAfisha.Margin = new System.Windows.Forms.Padding(0);
            this.panelAfisha.Name = "panelAfisha";
            this.panelAfisha.Size = new System.Drawing.Size(220, 415);
            this.panelAfisha.TabIndex = 1;
            // 
            // buttonTabAfisha
            // 
            this.buttonTabAfisha.BackColor = System.Drawing.Color.Transparent;
            this.buttonTabAfisha.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonTabAfisha.FlatAppearance.BorderSize = 0;
            this.buttonTabAfisha.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.buttonTabAfisha.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.buttonTabAfisha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTabAfisha.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonTabAfisha.ForeColor = System.Drawing.Color.White;
            this.buttonTabAfisha.Location = new System.Drawing.Point(0, 0);
            this.buttonTabAfisha.Name = "buttonTabAfisha";
            this.buttonTabAfisha.Size = new System.Drawing.Size(220, 50);
            this.buttonTabAfisha.TabIndex = 0;
            this.buttonTabAfisha.Text = "Afisha";
            this.buttonTabAfisha.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonTabAfisha.UseVisualStyleBackColor = false;
            this.buttonTabAfisha.Click += new System.EventHandler(this.buttonTabAfisha_Click);
            // 
            // panelForm
            // 
            this.panelForm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.panelForm.Location = new System.Drawing.Point(220, 0);
            this.panelForm.Name = "panelForm";
            this.panelForm.Size = new System.Drawing.Size(580, 450);
            this.panelForm.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(220, 35);
            this.panel1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(0, 50);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(220, 50);
            this.button1.TabIndex = 1;
            this.button1.Text = "Film";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelForm);
            this.Controls.Add(this.panelAfisha);
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.TransparencyKey = System.Drawing.Color.Blue;
            this.panelAfisha.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelAfisha;
        private System.Windows.Forms.Button buttonTabAfisha;
        private System.Windows.Forms.Panel panelForm;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
    }
}

