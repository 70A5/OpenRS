namespace OpenRS
{
    partial class Form_IntakeRes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_IntakeRes));
            this.Btn_Back = new System.Windows.Forms.Button();
            this.btn_IntakeComplete = new System.Windows.Forms.Button();
            this.txt_IntakeComplete = new System.Windows.Forms.TextBox();
            this.lbl_Cid = new System.Windows.Forms.Label();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Btn_Back
            // 
            this.Btn_Back.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_Back.BackgroundImage")));
            this.Btn_Back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Back.ForeColor = System.Drawing.Color.White;
            this.Btn_Back.Location = new System.Drawing.Point(340, 32);
            this.Btn_Back.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_Back.Name = "Btn_Back";
            this.Btn_Back.Size = new System.Drawing.Size(63, 57);
            this.Btn_Back.TabIndex = 0;
            this.Btn_Back.UseVisualStyleBackColor = true;
            this.Btn_Back.Click += new System.EventHandler(this.Btn_Back_Click);
            // 
            // btn_IntakeComplete
            // 
            this.btn_IntakeComplete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_IntakeComplete.BackgroundImage")));
            this.btn_IntakeComplete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_IntakeComplete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_IntakeComplete.ForeColor = System.Drawing.Color.White;
            this.btn_IntakeComplete.Location = new System.Drawing.Point(337, 307);
            this.btn_IntakeComplete.Name = "btn_IntakeComplete";
            this.btn_IntakeComplete.Size = new System.Drawing.Size(170, 47);
            this.btn_IntakeComplete.TabIndex = 1;
            this.btn_IntakeComplete.UseVisualStyleBackColor = true;
            this.btn_IntakeComplete.Click += new System.EventHandler(this.btn_IntakeComplete_Click);
            // 
            // txt_IntakeComplete
            // 
            this.txt_IntakeComplete.Location = new System.Drawing.Point(337, 266);
            this.txt_IntakeComplete.Name = "txt_IntakeComplete";
            this.txt_IntakeComplete.Size = new System.Drawing.Size(170, 20);
            this.txt_IntakeComplete.TabIndex = 2;
            // 
            // lbl_Cid
            // 
            this.lbl_Cid.AutoSize = true;
            this.lbl_Cid.Location = new System.Drawing.Point(334, 250);
            this.lbl_Cid.Name = "lbl_Cid";
            this.lbl_Cid.Size = new System.Drawing.Size(85, 13);
            this.lbl_Cid.TabIndex = 3;
            this.lbl_Cid.Text = "Camera ID (P01)";
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Helvetica", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.Location = new System.Drawing.Point(166, 181);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(570, 22);
            this.lbl_Title.TabIndex = 4;
            this.lbl_Title.Text = "Voer een camera ID in om deze te markeren als beschikbaar.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Helvetica", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(310, 32);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ontvangst reservering";
            // 
            // Form_IntakeRes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 574);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_Title);
            this.Controls.Add(this.lbl_Cid);
            this.Controls.Add(this.txt_IntakeComplete);
            this.Controls.Add(this.btn_IntakeComplete);
            this.Controls.Add(this.Btn_Back);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form_IntakeRes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ontvangst Reservering - OpenRS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Back;
        private System.Windows.Forms.Button btn_IntakeComplete;
        private System.Windows.Forms.TextBox txt_IntakeComplete;
        private System.Windows.Forms.Label lbl_Cid;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Label label1;
    }
}