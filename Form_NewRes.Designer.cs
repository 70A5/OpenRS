namespace OpenRS
{
    partial class Form_NewRes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_NewRes));
            this.btn_Foto = new System.Windows.Forms.Button();
            this.Btn_Video = new System.Windows.Forms.Button();
            this.Btn_Back = new System.Windows.Forms.Button();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Foto
            // 
            this.btn_Foto.Location = new System.Drawing.Point(201, 144);
            this.btn_Foto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Foto.Name = "btn_Foto";
            this.btn_Foto.Size = new System.Drawing.Size(156, 153);
            this.btn_Foto.TabIndex = 0;
            this.btn_Foto.Text = "Foto";
            this.btn_Foto.UseVisualStyleBackColor = true;
            // 
            // Btn_Video
            // 
            this.Btn_Video.Location = new System.Drawing.Point(409, 144);
            this.Btn_Video.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_Video.Name = "Btn_Video";
            this.Btn_Video.Size = new System.Drawing.Size(156, 153);
            this.Btn_Video.TabIndex = 1;
            this.Btn_Video.Text = "Video";
            this.Btn_Video.UseVisualStyleBackColor = true;
            // 
            // Btn_Back
            // 
            this.Btn_Back.Location = new System.Drawing.Point(316, 22);
            this.Btn_Back.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_Back.Name = "Btn_Back";
            this.Btn_Back.Size = new System.Drawing.Size(53, 46);
            this.Btn_Back.TabIndex = 4;
            this.Btn_Back.Text = "Terug";
            this.Btn_Back.UseVisualStyleBackColor = true;
            this.Btn_Back.Click += new System.EventHandler(this.Btn_Back_Click);
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Helvetica", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.Location = new System.Drawing.Point(24, 24);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(276, 33);
            this.lbl_Title.TabIndex = 5;
            this.lbl_Title.Text = "Nieuwe reservering";
            // 
            // Form_NewRes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_Title);
            this.Controls.Add(this.Btn_Back);
            this.Controls.Add(this.Btn_Video);
            this.Controls.Add(this.btn_Foto);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form_NewRes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nieuwe Reservering - OpenRS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Foto;
        private System.Windows.Forms.Button Btn_Video;
        private System.Windows.Forms.Button Btn_Back;
        private System.Windows.Forms.Label lbl_Title;
    }
}