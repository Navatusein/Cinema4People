namespace Server
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
            this.btAfisha = new System.Windows.Forms.Button();
            this.btRoom = new System.Windows.Forms.Button();
            this.btBar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btAfisha
            // 
            this.btAfisha.Location = new System.Drawing.Point(193, 102);
            this.btAfisha.Name = "btAfisha";
            this.btAfisha.Size = new System.Drawing.Size(75, 23);
            this.btAfisha.TabIndex = 0;
            this.btAfisha.Text = "Afisha";
            this.btAfisha.UseVisualStyleBackColor = true;
            this.btAfisha.Click += new System.EventHandler(this.btAfisha_Click);
            // 
            // btRoom
            // 
            this.btRoom.Location = new System.Drawing.Point(193, 6);
            this.btRoom.Name = "btRoom";
            this.btRoom.Size = new System.Drawing.Size(75, 23);
            this.btRoom.TabIndex = 1;
            this.btRoom.Text = "Room";
            this.btRoom.UseVisualStyleBackColor = true;
            this.btRoom.Click += new System.EventHandler(this.btRoom_Click);
            // 
            // btBar
            // 
            this.btBar.Location = new System.Drawing.Point(193, 55);
            this.btBar.Name = "btBar";
            this.btBar.Size = new System.Drawing.Size(75, 23);
            this.btBar.TabIndex = 2;
            this.btBar.Text = "Bar";
            this.btBar.UseVisualStyleBackColor = true;
            this.btBar.Click += new System.EventHandler(this.btBar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Add room";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Add products to the bar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Create afisha";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 149);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btBar);
            this.Controls.Add(this.btRoom);
            this.Controls.Add(this.btAfisha);
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btAfisha;
        private System.Windows.Forms.Button btRoom;
        private System.Windows.Forms.Button btBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

