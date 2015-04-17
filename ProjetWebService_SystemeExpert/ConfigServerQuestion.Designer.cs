namespace ProjetWebService_SystemeExpert
{
    partial class ConfigServerQuestion
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
            this.lbl_urlServiceWeb = new System.Windows.Forms.Label();
            this.txt_urlServiceWeb = new System.Windows.Forms.TextBox();
            this.btn_enregistrer = new System.Windows.Forms.Button();
            this.grp_configServiceWeb = new System.Windows.Forms.GroupBox();
            this.grp_configServiceWeb.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_urlServiceWeb
            // 
            this.lbl_urlServiceWeb.AutoSize = true;
            this.lbl_urlServiceWeb.Location = new System.Drawing.Point(6, 19);
            this.lbl_urlServiceWeb.Name = "lbl_urlServiceWeb";
            this.lbl_urlServiceWeb.Size = new System.Drawing.Size(80, 13);
            this.lbl_urlServiceWeb.TabIndex = 0;
            this.lbl_urlServiceWeb.Text = "Url service web";
            // 
            // txt_urlServiceWeb
            // 
            this.txt_urlServiceWeb.Dock = System.Windows.Forms.DockStyle.Right;
            this.txt_urlServiceWeb.Location = new System.Drawing.Point(110, 16);
            this.txt_urlServiceWeb.Name = "txt_urlServiceWeb";
            this.txt_urlServiceWeb.Size = new System.Drawing.Size(231, 20);
            this.txt_urlServiceWeb.TabIndex = 1;
            // 
            // btn_enregistrer
            // 
            this.btn_enregistrer.Location = new System.Drawing.Point(110, 47);
            this.btn_enregistrer.Name = "btn_enregistrer";
            this.btn_enregistrer.Size = new System.Drawing.Size(231, 23);
            this.btn_enregistrer.TabIndex = 2;
            this.btn_enregistrer.Text = "Enregistrer";
            this.btn_enregistrer.UseVisualStyleBackColor = true;
            this.btn_enregistrer.Click += new System.EventHandler(this.btn_enregistrer_Click);
            // 
            // grp_configServiceWeb
            // 
            this.grp_configServiceWeb.Controls.Add(this.lbl_urlServiceWeb);
            this.grp_configServiceWeb.Controls.Add(this.btn_enregistrer);
            this.grp_configServiceWeb.Controls.Add(this.txt_urlServiceWeb);
            this.grp_configServiceWeb.Location = new System.Drawing.Point(12, 12);
            this.grp_configServiceWeb.Name = "grp_configServiceWeb";
            this.grp_configServiceWeb.Size = new System.Drawing.Size(344, 76);
            this.grp_configServiceWeb.TabIndex = 3;
            this.grp_configServiceWeb.TabStop = false;
            this.grp_configServiceWeb.Text = "Configuration Service web";
            // 
            // ConfigServerQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 100);
            this.Controls.Add(this.grp_configServiceWeb);
            this.Name = "ConfigServerQuestion";
            this.Text = "ConfigServerQuestion";
            this.Load += new System.EventHandler(this.ConfigServerQuestion_Load);
            this.grp_configServiceWeb.ResumeLayout(false);
            this.grp_configServiceWeb.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_urlServiceWeb;
        private System.Windows.Forms.TextBox txt_urlServiceWeb;
        private System.Windows.Forms.Button btn_enregistrer;
        private System.Windows.Forms.GroupBox grp_configServiceWeb;
    }
}