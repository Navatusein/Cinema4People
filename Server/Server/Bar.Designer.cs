
namespace Server
{
    partial class Bar
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "",
            "",
            ""}, -1);
            this.label1 = new System.Windows.Forms.Label();
            this.addbtn = new System.Windows.Forms.Button();
            this.nametb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pricetb = new System.Windows.Forms.TextBox();
            this.quantitytb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.imagetb = new System.Windows.Forms.TextBox();
            this.imagebtn = new System.Windows.Forms.Button();
            this.removebtn = new System.Windows.Forms.Button();
            this.productslv = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // addbtn
            // 
            this.addbtn.Location = new System.Drawing.Point(15, 193);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(75, 23);
            this.addbtn.TabIndex = 1;
            this.addbtn.Text = "Add";
            this.addbtn.UseVisualStyleBackColor = true;
            this.addbtn.Click += new System.EventHandler(this.addbtn_Click);
            // 
            // nametb
            // 
            this.nametb.Location = new System.Drawing.Point(100, 20);
            this.nametb.Name = "nametb";
            this.nametb.Size = new System.Drawing.Size(183, 22);
            this.nametb.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Quantity";
            // 
            // pricetb
            // 
            this.pricetb.Location = new System.Drawing.Point(100, 60);
            this.pricetb.Name = "pricetb";
            this.pricetb.Size = new System.Drawing.Size(183, 22);
            this.pricetb.TabIndex = 5;
            // 
            // quantitytb
            // 
            this.quantitytb.Location = new System.Drawing.Point(100, 97);
            this.quantitytb.Name = "quantitytb";
            this.quantitytb.Size = new System.Drawing.Size(183, 22);
            this.quantitytb.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Image";
            // 
            // imagetb
            // 
            this.imagetb.Location = new System.Drawing.Point(100, 140);
            this.imagetb.Name = "imagetb";
            this.imagetb.Size = new System.Drawing.Size(183, 22);
            this.imagetb.TabIndex = 8;
            // 
            // imagebtn
            // 
            this.imagebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.imagebtn.Location = new System.Drawing.Point(289, 140);
            this.imagebtn.Name = "imagebtn";
            this.imagebtn.Size = new System.Drawing.Size(23, 23);
            this.imagebtn.TabIndex = 9;
            this.imagebtn.Text = "...";
            this.imagebtn.UseVisualStyleBackColor = true;
            this.imagebtn.Click += new System.EventHandler(this.imagebtn_Click);
            // 
            // removebtn
            // 
            this.removebtn.Location = new System.Drawing.Point(100, 193);
            this.removebtn.Name = "removebtn";
            this.removebtn.Size = new System.Drawing.Size(75, 23);
            this.removebtn.TabIndex = 10;
            this.removebtn.Text = "Remove";
            this.removebtn.UseVisualStyleBackColor = true;
            this.removebtn.Click += new System.EventHandler(this.removebtn_Click);
            // 
            // productslv
            // 
            this.productslv.HideSelection = false;
            this.productslv.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.productslv.Location = new System.Drawing.Point(327, 12);
            this.productslv.Name = "productslv";
            this.productslv.Size = new System.Drawing.Size(444, 204);
            this.productslv.TabIndex = 11;
            this.productslv.UseCompatibleStateImageBehavior = false;
            // 
            // Bar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 258);
            this.Controls.Add(this.productslv);
            this.Controls.Add(this.removebtn);
            this.Controls.Add(this.imagebtn);
            this.Controls.Add(this.imagetb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.quantitytb);
            this.Controls.Add(this.pricetb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nametb);
            this.Controls.Add(this.addbtn);
            this.Controls.Add(this.label1);
            this.Name = "Bar";
            this.Text = "Bar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addbtn;
        private System.Windows.Forms.TextBox nametb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox pricetb;
        private System.Windows.Forms.TextBox quantitytb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox imagetb;
        private System.Windows.Forms.Button imagebtn;
        private System.Windows.Forms.Button removebtn;
        private System.Windows.Forms.ListView productslv;
    }
}