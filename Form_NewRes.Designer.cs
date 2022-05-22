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
            this.Btn_Lens = new System.Windows.Forms.Button();
            this.Btn_Accessoiries = new System.Windows.Forms.Button();
            this.Btn_Back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Foto
            // 
            this.btn_Foto.Location = new System.Drawing.Point(74, 92);
            this.btn_Foto.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Foto.Name = "btn_Foto";
            this.btn_Foto.Size = new System.Drawing.Size(117, 124);
            this.btn_Foto.TabIndex = 0;
            this.btn_Foto.Text = "Foto";
            this.btn_Foto.UseVisualStyleBackColor = true;
            // 
            // Btn_Video
            // 
            this.Btn_Video.Location = new System.Drawing.Point(230, 92);
            this.Btn_Video.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_Video.Name = "Btn_Video";
            this.Btn_Video.Size = new System.Drawing.Size(117, 124);
            this.Btn_Video.TabIndex = 1;
            this.Btn_Video.Text = "Video";
            this.Btn_Video.UseVisualStyleBackColor = true;
            // 
            // Btn_Lens
            // 
            this.Btn_Lens.Location = new System.Drawing.Point(380, 92);
            this.Btn_Lens.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_Lens.Name = "Btn_Lens";
            this.Btn_Lens.Size = new System.Drawing.Size(126, 124);
            this.Btn_Lens.TabIndex = 2;
            this.Btn_Lens.Text = "Lens";
            this.Btn_Lens.UseVisualStyleBackColor = true;
            // 
            // Btn_Accessoiries
            // 
            this.Btn_Accessoiries.Location = new System.Drawing.Point(74, 254);
            this.Btn_Accessoiries.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_Accessoiries.Name = "Btn_Accessoiries";
            this.Btn_Accessoiries.Size = new System.Drawing.Size(432, 46);
            this.Btn_Accessoiries.TabIndex = 3;
            this.Btn_Accessoiries.Text = "Accessoires";
            this.Btn_Accessoiries.UseVisualStyleBackColor = true;
            // 
            // Btn_Back
            // 
            this.Btn_Back.Location = new System.Drawing.Point(23, 22);
            this.Btn_Back.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_Back.Name = "Btn_Back";
            this.Btn_Back.Size = new System.Drawing.Size(82, 37);
            this.Btn_Back.TabIndex = 4;
            this.Btn_Back.Text = "Terug";
            this.Btn_Back.UseVisualStyleBackColor = true;
            this.Btn_Back.Click += new System.EventHandler(this.Btn_Back_Click);
            // 
            // Form_NewRes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.Btn_Back);
            this.Controls.Add(this.Btn_Accessoiries);
            this.Controls.Add(this.Btn_Lens);
            this.Controls.Add(this.Btn_Video);
            this.Controls.Add(this.btn_Foto);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form_NewRes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nieuwe Reservering - OpenRS";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Foto;
        private System.Windows.Forms.Button Btn_Video;
        private System.Windows.Forms.Button Btn_Lens;
        private System.Windows.Forms.Button Btn_Accessoiries;
        private System.Windows.Forms.Button Btn_Back;
    }
}