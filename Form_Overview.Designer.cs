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
            this.txt_StartDate = new System.Windows.Forms.TextBox();
            this.txt_IsFinished = new System.Windows.Forms.TextBox();
            this.txt_IsTooLate = new System.Windows.Forms.TextBox();
            this.lbl_Overzicht = new System.Windows.Forms.Label();
            this.lbl_Messages = new System.Windows.Forms.Label();
            this.txt_EndDate = new System.Windows.Forms.TextBox();
            this.Order = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsFinished = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsTooLate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_Back
            // 
            this.Btn_Back.Location = new System.Drawing.Point(23, 25);
            this.Btn_Back.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_Back.Name = "Btn_Back";
            this.Btn_Back.Size = new System.Drawing.Size(120, 41);
            this.Btn_Back.TabIndex = 0;
            this.Btn_Back.Text = "Terug";
            this.Btn_Back.UseVisualStyleBackColor = true;
            this.Btn_Back.Click += new System.EventHandler(this.Btn_Back_Click);
            // 
            // btn_Insert
            // 
            this.btn_Insert.Location = new System.Drawing.Point(419, 25);
            this.btn_Insert.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Insert.Name = "btn_Insert";
            this.btn_Insert.Size = new System.Drawing.Size(165, 53);
            this.btn_Insert.TabIndex = 12;
            this.btn_Insert.Text = "Toevoegen record";
            this.btn_Insert.UseVisualStyleBackColor = true;
            this.btn_Insert.Click += new System.EventHandler(this.btn_Insert_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(420, 86);
            this.btn_Update.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(164, 53);
            this.btn_Update.TabIndex = 13;
            this.btn_Update.Text = "Update record";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(420, 146);
            this.btn_Delete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(164, 53);
            this.btn_Delete.TabIndex = 14;
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
            this.StartDate,
            this.EndDate,
            this.IsFinished,
            this.IsTooLate});
            this.dataGridView1.Location = new System.Drawing.Point(16, 268);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(732, 438);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // txt_Orders
            // 
            this.txt_Orders.Location = new System.Drawing.Point(67, 238);
            this.txt_Orders.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_Orders.Name = "txt_Orders";
            this.txt_Orders.Size = new System.Drawing.Size(47, 22);
            this.txt_Orders.TabIndex = 5;
            // 
            // txt_UID
            // 
            this.txt_UID.Location = new System.Drawing.Point(111, 238);
            this.txt_UID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_UID.Name = "txt_UID";
            this.txt_UID.Size = new System.Drawing.Size(121, 22);
            this.txt_UID.TabIndex = 6;
            // 
            // txt_Items
            // 
            this.txt_Items.Location = new System.Drawing.Point(231, 238);
            this.txt_Items.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_Items.Name = "txt_Items";
            this.txt_Items.Size = new System.Drawing.Size(54, 22);
            this.txt_Items.TabIndex = 7;
            // 
            // txt_StartDate
            // 
            this.txt_StartDate.Location = new System.Drawing.Point(308, 238);
            this.txt_StartDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_StartDate.Name = "txt_StartDate";
            this.txt_StartDate.Size = new System.Drawing.Size(77, 22);
            this.txt_StartDate.TabIndex = 8;
            // 
            // txt_IsFinished
            // 
            this.txt_IsFinished.Location = new System.Drawing.Point(518, 238);
            this.txt_IsFinished.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_IsFinished.Name = "txt_IsFinished";
            this.txt_IsFinished.Size = new System.Drawing.Size(78, 22);
            this.txt_IsFinished.TabIndex = 10;
            // 
            // txt_IsTooLate
            // 
            this.txt_IsTooLate.Location = new System.Drawing.Point(631, 238);
            this.txt_IsTooLate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_IsTooLate.Name = "txt_IsTooLate";
            this.txt_IsTooLate.Size = new System.Drawing.Size(80, 22);
            this.txt_IsTooLate.TabIndex = 11;
            // 
            // lbl_Overzicht
            // 
            this.lbl_Overzicht.AutoSize = true;
            this.lbl_Overzicht.Font = new System.Drawing.Font("Helvetica", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Overzicht.Location = new System.Drawing.Point(15, 84);
            this.lbl_Overzicht.Name = "lbl_Overzicht";
            this.lbl_Overzicht.Size = new System.Drawing.Size(177, 43);
            this.lbl_Overzicht.TabIndex = 11;
            this.lbl_Overzicht.Text = "Overzicht";
            // 
            // lbl_Messages
            // 
            this.lbl_Messages.AutoSize = true;
            this.lbl_Messages.Font = new System.Drawing.Font("Helvetica", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Messages.Location = new System.Drawing.Point(17, 127);
            this.lbl_Messages.Name = "lbl_Messages";
            this.lbl_Messages.Size = new System.Drawing.Size(301, 33);
            this.lbl_Messages.TabIndex = 12;
            this.lbl_Messages.Text = "Er zijn geen conflicten.";
            // 
            // txt_EndDate
            // 
            this.txt_EndDate.Location = new System.Drawing.Point(411, 238);
            this.txt_EndDate.Name = "txt_EndDate";
            this.txt_EndDate.Size = new System.Drawing.Size(74, 22);
            this.txt_EndDate.TabIndex = 9;
            // 
            // Order
            // 
            this.Order.HeaderText = "Order";
            this.Order.MaxInputLength = 4;
            this.Order.MinimumWidth = 6;
            this.Order.Name = "Order";
            this.Order.ReadOnly = true;
            this.Order.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Order.Width = 40;
            // 
            // UID
            // 
            this.UID.HeaderText = "UID";
            this.UID.MaxInputLength = 9;
            this.UID.MinimumWidth = 6;
            this.UID.Name = "UID";
            this.UID.ReadOnly = true;
            this.UID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.UID.Width = 125;
            // 
            // Cid
            // 
            this.Cid.HeaderText = "Cid";
            this.Cid.MaxInputLength = 500;
            this.Cid.MinimumWidth = 6;
            this.Cid.Name = "Cid";
            this.Cid.ReadOnly = true;
            this.Cid.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Cid.Width = 50;
            // 
            // StartDate
            // 
            this.StartDate.HeaderText = "StartDate";
            this.StartDate.MaxInputLength = 8;
            this.StartDate.MinimumWidth = 6;
            this.StartDate.Name = "StartDate";
            this.StartDate.ReadOnly = true;
            this.StartDate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.StartDate.Width = 75;
            // 
            // EndDate
            // 
            this.EndDate.HeaderText = "EndDate";
            this.EndDate.MaxInputLength = 8;
            this.EndDate.MinimumWidth = 6;
            this.EndDate.Name = "EndDate";
            this.EndDate.ReadOnly = true;
            this.EndDate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.EndDate.Width = 75;
            // 
            // IsFinished
            // 
            this.IsFinished.HeaderText = "IsFinished";
            this.IsFinished.MinimumWidth = 6;
            this.IsFinished.Name = "IsFinished";
            this.IsFinished.ReadOnly = true;
            this.IsFinished.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.IsFinished.Width = 75;
            // 
            // IsTooLate
            // 
            this.IsTooLate.HeaderText = "IsTooLate";
            this.IsTooLate.MinimumWidth = 6;
            this.IsTooLate.Name = "IsTooLate";
            this.IsTooLate.ReadOnly = true;
            this.IsTooLate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.IsTooLate.Width = 75;
            // 
            // Form_Overview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1269, 721);
            this.Controls.Add(this.txt_EndDate);
            this.Controls.Add(this.lbl_Messages);
            this.Controls.Add(this.lbl_Overzicht);
            this.Controls.Add(this.txt_IsTooLate);
            this.Controls.Add(this.txt_IsFinished);
            this.Controls.Add(this.txt_StartDate);
            this.Controls.Add(this.txt_Items);
            this.Controls.Add(this.txt_UID);
            this.Controls.Add(this.txt_Orders);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_Insert);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Btn_Back);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
        private System.Windows.Forms.TextBox txt_StartDate;
        private System.Windows.Forms.TextBox txt_IsFinished;
        private System.Windows.Forms.TextBox txt_IsTooLate;
        private System.Windows.Forms.Label lbl_Overzicht;
        private System.Windows.Forms.Label lbl_Messages;
        private System.Windows.Forms.TextBox txt_EndDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Order;
        private System.Windows.Forms.DataGridViewTextBoxColumn UID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cid;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn EndDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsFinished;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsTooLate;
    }
}