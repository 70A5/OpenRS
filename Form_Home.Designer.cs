namespace OpenRS
{
    partial class Form_Home
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
            this.btn_NewRes = new System.Windows.Forms.Button();
            this.Btn_IntakeRes = new System.Windows.Forms.Button();
            this.Btn_EditRes = new System.Windows.Forms.Button();
            this.Btn_Overview = new System.Windows.Forms.Button();
            this.Btn_Close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_NewRes
            // 
            this.btn_NewRes.Location = new System.Drawing.Point(208, 195);
            this.btn_NewRes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_NewRes.Name = "btn_NewRes";
            this.btn_NewRes.Size = new System.Drawing.Size(142, 143);
            this.btn_NewRes.TabIndex = 0;
            this.btn_NewRes.Text = "Nieuwe reservering";
            this.btn_NewRes.UseVisualStyleBackColor = true;
            this.btn_NewRes.Click += new System.EventHandler(this.btn_NewRes_Click);
            // 
            // Btn_IntakeRes
            // 
            this.Btn_IntakeRes.Location = new System.Drawing.Point(379, 195);
            this.Btn_IntakeRes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Btn_IntakeRes.Name = "Btn_IntakeRes";
            this.Btn_IntakeRes.Size = new System.Drawing.Size(142, 143);
            this.Btn_IntakeRes.TabIndex = 1;
            this.Btn_IntakeRes.Text = "Ontvangst reservering";
            this.Btn_IntakeRes.UseVisualStyleBackColor = true;
            this.Btn_IntakeRes.Click += new System.EventHandler(this.Btn_IntakeRes_Click);
            // 
            // Btn_EditRes
            // 
            this.Btn_EditRes.Location = new System.Drawing.Point(546, 195);
            this.Btn_EditRes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Btn_EditRes.Name = "Btn_EditRes";
            this.Btn_EditRes.Size = new System.Drawing.Size(142, 143);
            this.Btn_EditRes.TabIndex = 2;
            this.Btn_EditRes.Text = "Bewerken reservering";
            this.Btn_EditRes.UseVisualStyleBackColor = true;
            this.Btn_EditRes.Click += new System.EventHandler(this.Btn_EditRes_Click);
            // 
            // Btn_Overview
            // 
            this.Btn_Overview.Location = new System.Drawing.Point(546, 361);
            this.Btn_Overview.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Btn_Overview.Name = "Btn_Overview";
            this.Btn_Overview.Size = new System.Drawing.Size(142, 34);
            this.Btn_Overview.TabIndex = 3;
            this.Btn_Overview.Text = "Overzicht";
            this.Btn_Overview.UseVisualStyleBackColor = true;
            this.Btn_Overview.Click += new System.EventHandler(this.Btn_Overview_Click);
            // 
            // Btn_Close
            // 
            this.Btn_Close.Location = new System.Drawing.Point(796, 10);
            this.Btn_Close.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Btn_Close.Name = "Btn_Close";
            this.Btn_Close.Size = new System.Drawing.Size(98, 39);
            this.Btn_Close.TabIndex = 4;
            this.Btn_Close.Text = "Afsluiten";
            this.Btn_Close.UseVisualStyleBackColor = true;
            this.Btn_Close.Click += new System.EventHandler(this.Btn_Close_Click);
            // 
            // Form_Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 578);
            this.Controls.Add(this.Btn_Close);
            this.Controls.Add(this.Btn_Overview);
            this.Controls.Add(this.Btn_EditRes);
            this.Controls.Add(this.Btn_IntakeRes);
            this.Controls.Add(this.btn_NewRes);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form_Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_NewRes;
        private System.Windows.Forms.Button Btn_IntakeRes;
        private System.Windows.Forms.Button Btn_EditRes;
        private System.Windows.Forms.Button Btn_Overview;
        private System.Windows.Forms.Button Btn_Close;
    }
}

