namespace OpenRS
{
    partial class Form_NewRes2
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
            this.btn_next = new System.Windows.Forms.Button();
            this.lvi_camera = new System.Windows.Forms.ListBox();
            this.btn_back = new System.Windows.Forms.Button();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.dtp_start = new System.Windows.Forms.DateTimePicker();
            this.dtp_end = new System.Windows.Forms.DateTimePicker();
            this.lbl_start = new System.Windows.Forms.Label();
            this.lbl_end = new System.Windows.Forms.Label();
            this.lvi_leerling = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btn_next
            // 
            this.btn_next.Location = new System.Drawing.Point(479, 272);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(113, 37);
            this.btn_next.TabIndex = 0;
            this.btn_next.Text = "Volgende";
            this.btn_next.UseVisualStyleBackColor = true;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // lvi_camera
            // 
            this.lvi_camera.FormattingEnabled = true;
            this.lvi_camera.ItemHeight = 16;
            this.lvi_camera.Location = new System.Drawing.Point(472, 151);
            this.lvi_camera.Name = "lvi_camera";
            this.lvi_camera.Size = new System.Drawing.Size(120, 36);
            this.lvi_camera.TabIndex = 1;
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(215, 29);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(55, 42);
            this.btn_back.TabIndex = 2;
            this.btn_back.Text = "Terug";
            this.btn_back.UseVisualStyleBackColor = true;
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Helvetica", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.Location = new System.Drawing.Point(12, 29);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(178, 33);
            this.lbl_Title.TabIndex = 6;
            this.lbl_Title.Text = "Reservering";
            // 
            // dtp_start
            // 
            this.dtp_start.Location = new System.Drawing.Point(40, 151);
            this.dtp_start.Name = "dtp_start";
            this.dtp_start.Size = new System.Drawing.Size(165, 22);
            this.dtp_start.TabIndex = 7;
            // 
            // dtp_end
            // 
            this.dtp_end.Location = new System.Drawing.Point(241, 151);
            this.dtp_end.Name = "dtp_end";
            this.dtp_end.Size = new System.Drawing.Size(163, 22);
            this.dtp_end.TabIndex = 8;
            // 
            // lbl_start
            // 
            this.lbl_start.AutoSize = true;
            this.lbl_start.Location = new System.Drawing.Point(37, 132);
            this.lbl_start.Name = "lbl_start";
            this.lbl_start.Size = new System.Drawing.Size(34, 16);
            this.lbl_start.TabIndex = 9;
            this.lbl_start.Text = "Start";
            // 
            // lbl_end
            // 
            this.lbl_end.AutoSize = true;
            this.lbl_end.Location = new System.Drawing.Point(238, 132);
            this.lbl_end.Name = "lbl_end";
            this.lbl_end.Size = new System.Drawing.Size(42, 16);
            this.lbl_end.TabIndex = 10;
            this.lbl_end.Text = "Einde";
            // 
            // lvi_leerling
            // 
            this.lvi_leerling.FormattingEnabled = true;
            this.lvi_leerling.ItemHeight = 16;
            this.lvi_leerling.Location = new System.Drawing.Point(40, 272);
            this.lvi_leerling.Name = "lvi_leerling";
            this.lvi_leerling.Size = new System.Drawing.Size(269, 36);
            this.lvi_leerling.TabIndex = 11;
            // 
            // Form_NewRes2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lvi_leerling);
            this.Controls.Add(this.lbl_end);
            this.Controls.Add(this.lbl_start);
            this.Controls.Add(this.dtp_end);
            this.Controls.Add(this.dtp_start);
            this.Controls.Add(this.lbl_Title);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.lvi_camera);
            this.Controls.Add(this.btn_next);
            this.Name = "Form_NewRes2";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.ListBox lvi_camera;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.DateTimePicker dtp_start;
        private System.Windows.Forms.DateTimePicker dtp_end;
        private System.Windows.Forms.Label lbl_start;
        private System.Windows.Forms.Label lbl_end;
        private System.Windows.Forms.ListBox lvi_leerling;
    }
}