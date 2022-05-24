namespace OpenRS
{
    partial class Form_Overview
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Overview));
            this.Btn_Back = new System.Windows.Forms.Button();
            this.btn_Insert = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txt_Orders = new System.Windows.Forms.TextBox();
            this.txt_UID = new System.Windows.Forms.TextBox();
            this.txt_Items = new System.Windows.Forms.TextBox();
            this.txt_Datum = new System.Windows.Forms.TextBox();
            this.txt_IsFinished = new System.Windows.Forms.TextBox();
            this.txt_IsTooLate = new System.Windows.Forms.TextBox();
            this.Order = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Datum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsFinished = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsTooLate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_Back
            // 
            this.Btn_Back.Location = new System.Drawing.Point(17, 20);
            this.Btn_Back.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_Back.Name = "Btn_Back";
            this.Btn_Back.Size = new System.Drawing.Size(90, 33);
            this.Btn_Back.TabIndex = 0;
            this.Btn_Back.Text = "Terug";
            this.Btn_Back.UseVisualStyleBackColor = true;
            this.Btn_Back.Click += new System.EventHandler(this.Btn_Back_Click);
            // 
            // btn_Insert
            // 
            this.btn_Insert.Location = new System.Drawing.Point(525, 218);
            this.btn_Insert.Name = "btn_Insert";
            this.btn_Insert.Size = new System.Drawing.Size(124, 43);
            this.btn_Insert.TabIndex = 2;
            this.btn_Insert.Text = "Toevoegen record";
            this.btn_Insert.UseVisualStyleBackColor = true;
            this.btn_Insert.Click += new System.EventHandler(this.btn_Insert_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(526, 267);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(123, 43);
            this.btn_Update.TabIndex = 3;
            this.btn_Update.Text = "Update record";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(526, 316);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(123, 43);
            this.btn_Delete.TabIndex = 4;
            this.btn_Delete.Text = "Verwijder record";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Order,
            this.UID,
            this.Cid,
            this.Datum,
            this.IsFinished,
            this.IsTooLate});
            this.dataGridView1.Location = new System.Drawing.Point(12, 218);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(507, 356);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // txt_Orders
            // 
            this.txt_Orders.Location = new System.Drawing.Point(54, 192);
            this.txt_Orders.Name = "txt_Orders";
            this.txt_Orders.Size = new System.Drawing.Size(42, 20);
            this.txt_Orders.TabIndex = 5;
            // 
            // txt_UID
            // 
            this.txt_UID.Location = new System.Drawing.Point(92, 192);
            this.txt_UID.Name = "txt_UID";
            this.txt_UID.Size = new System.Drawing.Size(104, 20);
            this.txt_UID.TabIndex = 6;
            // 
            // txt_Items
            // 
            this.txt_Items.Location = new System.Drawing.Point(193, 192);
            this.txt_Items.Name = "txt_Items";
            this.txt_Items.Size = new System.Drawing.Size(52, 20);
            this.txt_Items.TabIndex = 7;
            // 
            // txt_Datum
            // 
            this.txt_Datum.Location = new System.Drawing.Point(244, 192);
            this.txt_Datum.Name = "txt_Datum";
            this.txt_Datum.Size = new System.Drawing.Size(76, 20);
            this.txt_Datum.TabIndex = 8;
            // 
            // txt_IsFinished
            // 
            this.txt_IsFinished.Location = new System.Drawing.Point(326, 192);
            this.txt_IsFinished.Name = "txt_IsFinished";
            this.txt_IsFinished.Size = new System.Drawing.Size(100, 20);
            this.txt_IsFinished.TabIndex = 9;
            // 
            // txt_IsTooLate
            // 
            this.txt_IsTooLate.Location = new System.Drawing.Point(432, 192);
            this.txt_IsTooLate.Name = "txt_IsTooLate";
            this.txt_IsTooLate.Size = new System.Drawing.Size(100, 20);
            this.txt_IsTooLate.TabIndex = 10;
            // 
            // Order
            // 
            this.Order.HeaderText = "Order";
            this.Order.MaxInputLength = 4;
            this.Order.Name = "Order";
            this.Order.ReadOnly = true;
            this.Order.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Order.Width = 40;
            // 
            // UID
            // 
            this.UID.HeaderText = "UID";
            this.UID.MaxInputLength = 9;
            this.UID.Name = "UID";
            this.UID.ReadOnly = true;
            this.UID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Cid
            // 
            this.Cid.HeaderText = "Cid";
            this.Cid.MaxInputLength = 500;
            this.Cid.Name = "Cid";
            this.Cid.ReadOnly = true;
            this.Cid.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Cid.Width = 50;
            // 
            // Datum
            // 
            this.Datum.HeaderText = "Datum";
            this.Datum.MaxInputLength = 8;
            this.Datum.Name = "Datum";
            this.Datum.ReadOnly = true;
            this.Datum.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Datum.Width = 75;
            // 
            // IsFinished
            // 
            this.IsFinished.HeaderText = "IsFinished";
            this.IsFinished.Name = "IsFinished";
            this.IsFinished.ReadOnly = true;
            this.IsFinished.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // IsTooLate
            // 
            this.IsTooLate.HeaderText = "IsTooLate";
            this.IsTooLate.Name = "IsTooLate";
            this.IsTooLate.ReadOnly = true;
            this.IsTooLate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Form_Overview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(952, 586);
            this.Controls.Add(this.txt_IsTooLate);
            this.Controls.Add(this.txt_IsFinished);
            this.Controls.Add(this.txt_Datum);
            this.Controls.Add(this.txt_Items);
            this.Controls.Add(this.txt_UID);
            this.Controls.Add(this.txt_Orders);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_Insert);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Btn_Back);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form_Overview";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Overzicht - OpenRS";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Back;
        private System.Windows.Forms.Button btn_Insert;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txt_Orders;
        private System.Windows.Forms.TextBox txt_UID;
        private System.Windows.Forms.TextBox txt_Items;
        private System.Windows.Forms.TextBox txt_Datum;
        private System.Windows.Forms.TextBox txt_IsFinished;
        private System.Windows.Forms.TextBox txt_IsTooLate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Order;
        private System.Windows.Forms.DataGridViewTextBoxColumn UID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Datum;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsFinished;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsTooLate;
    }
}