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
            this.panelForm = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btHistory = new System.Windows.Forms.Button();
            this.btMain = new System.Windows.Forms.Button();
            this.btBack = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelForm
            // 
            this.panelForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.panelForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelForm.Location = new System.Drawing.Point(0, 0);
            this.panelForm.Name = "panelForm";
            this.panelForm.Size = new System.Drawing.Size(800, 450);
            this.panelForm.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.panel1.Controls.Add(this.btHistory);
            this.panel1.Controls.Add(this.btMain);
            this.panel1.Controls.Add(this.btBack);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(220, 35);
            this.panel1.TabIndex = 1;
            // 
            // btHistory
            // 
            this.btHistory.Location = new System.Drawing.Point(136, 5);
            this.btHistory.Margin = new System.Windows.Forms.Padding(3, 3, 3, 5);
            this.btHistory.Name = "btHistory";
            this.btHistory.Size = new System.Drawing.Size(81, 30);
            this.btHistory.TabIndex = 2;
            this.btHistory.Text = "History";
            this.btHistory.UseVisualStyleBackColor = true;
            this.btHistory.Click += new System.EventHandler(this.btHistory_Click);
            // 
            // btMain
            // 
            this.btMain.Location = new System.Drawing.Point(72, 5);
            this.btMain.Margin = new System.Windows.Forms.Padding(3, 3, 3, 5);
            this.btMain.Name = "btMain";
            this.btMain.Size = new System.Drawing.Size(45, 30);
            this.btMain.TabIndex = 1;
            this.btMain.Text = "Home";
            this.btMain.UseVisualStyleBackColor = true;
            this.btMain.Click += new System.EventHandler(this.btMain_Click);
            // 
            // btBack
            // 
            this.btBack.BackColor = System.Drawing.Color.Transparent;
            this.btBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btBack.ForeColor = System.Drawing.Color.Black;
            this.btBack.Location = new System.Drawing.Point(23, 5);
            this.btBack.Margin = new System.Windows.Forms.Padding(3, 3, 3, 5);
            this.btBack.Name = "btBack";
            this.btBack.Size = new System.Drawing.Size(30, 30);
            this.btBack.TabIndex = 0;
            this.btBack.Text = "<";
            this.btBack.UseVisualStyleBackColor = false;
            this.btBack.Click += new System.EventHandler(this.btBack_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelForm);
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.TransparencyKey = System.Drawing.Color.Blue;
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelForm;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btHistory;
        private System.Windows.Forms.Button btMain;
        private System.Windows.Forms.Button btBack;
    }
}

