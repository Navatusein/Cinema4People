namespace Server
{
    partial class Form2
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.lbRooms = new System.Windows.Forms.ListBox();
            this.NewRoomSettingsTable = new System.Windows.Forms.DataGridView();
            this.rowIndex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeofSeat = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbRoomName = new System.Windows.Forms.TextBox();
            this.btAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NewRoomSettingsTable)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(158, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "1";
            // 
            // lbRooms
            // 
            this.lbRooms.FormattingEnabled = true;
            this.lbRooms.Location = new System.Drawing.Point(13, 12);
            this.lbRooms.Name = "lbRooms";
            this.lbRooms.Size = new System.Drawing.Size(192, 329);
            this.lbRooms.TabIndex = 11;
            this.lbRooms.SelectedIndexChanged += new System.EventHandler(this.lbRooms_SelectedIndexChanged);
            // 
            // NewRoomSettingsTable
            // 
            this.NewRoomSettingsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.NewRoomSettingsTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rowIndex,
            this.colAmount,
            this.tbPrice,
            this.typeofSeat});
            this.NewRoomSettingsTable.Location = new System.Drawing.Point(24, 48);
            this.NewRoomSettingsTable.Name = "NewRoomSettingsTable";
            this.NewRoomSettingsTable.Size = new System.Drawing.Size(310, 272);
            this.NewRoomSettingsTable.TabIndex = 31;
            this.NewRoomSettingsTable.DefaultValuesNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.NewRoomSettingsTable_DefaultValuesNeeded);
            this.NewRoomSettingsTable.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.NewRoomSettingsTable_RowsAdded);
            // 
            // rowIndex
            // 
            this.rowIndex.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.rowIndex.FillWeight = 111.9289F;
            this.rowIndex.HeaderText = "Row Number";
            this.rowIndex.Name = "rowIndex";
            this.rowIndex.ReadOnly = true;
            this.rowIndex.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // colAmount
            // 
            this.colAmount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle1.Format = "N2";
            this.colAmount.DefaultCellStyle = dataGridViewCellStyle1;
            this.colAmount.FillWeight = 111.9289F;
            this.colAmount.HeaderText = "Amount in this row";
            this.colAmount.Name = "colAmount";
            // 
            // tbPrice
            // 
            this.tbPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.Format = "C2";
            this.tbPrice.DefaultCellStyle = dataGridViewCellStyle2;
            this.tbPrice.FillWeight = 76.14214F;
            this.tbPrice.HeaderText = "Single seat price";
            this.tbPrice.Name = "tbPrice";
            // 
            // typeofSeat
            // 
            this.typeofSeat.HeaderText = "Type of seat";
            this.typeofSeat.Items.AddRange(new object[] {
            "Base",
            "First Class",
            "VIP"});
            this.typeofSeat.Name = "typeofSeat";
            this.typeofSeat.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.typeofSeat.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tbRoomName);
            this.groupBox1.Controls.Add(this.btAdd);
            this.groupBox1.Controls.Add(this.NewRoomSettingsTable);
            this.groupBox1.Location = new System.Drawing.Point(211, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(347, 338);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add new room";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 46;
            this.label5.Text = "Room name:";
            // 
            // tbRoomName
            // 
            this.tbRoomName.Location = new System.Drawing.Point(94, 19);
            this.tbRoomName.Name = "tbRoomName";
            this.tbRoomName.Size = new System.Drawing.Size(100, 20);
            this.tbRoomName.TabIndex = 45;
            this.tbRoomName.TextChanged += new System.EventHandler(this.tbRoomName_TextChanged);
            // 
            // btAdd
            // 
            this.btAdd.Enabled = false;
            this.btAdd.Location = new System.Drawing.Point(212, 18);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(105, 21);
            this.btAdd.TabIndex = 44;
            this.btAdd.Text = "Add";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 356);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbRooms);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.NewRoomSettingsTable)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbRooms;
        private System.Windows.Forms.DataGridView NewRoomSettingsTable;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbRoomName;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn rowIndex;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn tbPrice;
        private System.Windows.Forms.DataGridViewComboBoxColumn typeofSeat;
    }
}

