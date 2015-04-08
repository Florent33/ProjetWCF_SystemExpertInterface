namespace ProjetWebService_SystemeExpert
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.titre_label1 = new System.Windows.Forms.Label();
            this.question_label2 = new System.Windows.Forms.Label();
            this.reponse_label3 = new System.Windows.Forms.Label();
            this.question_textBox1 = new System.Windows.Forms.TextBox();
            this.reponse_textBox2 = new System.Windows.Forms.TextBox();
            this.prochaineQuestion_button1 = new System.Windows.Forms.Button();
            this.envoyerReponse_button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titre_label1
            // 
            this.titre_label1.AutoSize = true;
            this.titre_label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titre_label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.titre_label1.Location = new System.Drawing.Point(275, 9);
            this.titre_label1.Name = "titre_label1";
            this.titre_label1.Size = new System.Drawing.Size(350, 25);
            this.titre_label1.TabIndex = 0;
            this.titre_label1.Text = "Interface 2037 Ready for inquiry";
            // 
            // question_label2
            // 
            this.question_label2.AutoSize = true;
            this.question_label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.question_label2.Location = new System.Drawing.Point(208, 117);
            this.question_label2.Name = "question_label2";
            this.question_label2.Size = new System.Drawing.Size(55, 13);
            this.question_label2.TabIndex = 1;
            this.question_label2.Text = "Question :";
            // 
            // reponse_label3
            // 
            this.reponse_label3.AutoSize = true;
            this.reponse_label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.reponse_label3.Location = new System.Drawing.Point(207, 183);
            this.reponse_label3.Name = "reponse_label3";
            this.reponse_label3.Size = new System.Drawing.Size(56, 13);
            this.reponse_label3.TabIndex = 2;
            this.reponse_label3.Text = "Réponse :";
            // 
            // question_textBox1
            // 
            this.question_textBox1.Location = new System.Drawing.Point(275, 114);
            this.question_textBox1.Name = "question_textBox1";
            this.question_textBox1.Size = new System.Drawing.Size(350, 20);
            this.question_textBox1.TabIndex = 3;
            // 
            // reponse_textBox2
            // 
            this.reponse_textBox2.Location = new System.Drawing.Point(275, 180);
            this.reponse_textBox2.Name = "reponse_textBox2";
            this.reponse_textBox2.Size = new System.Drawing.Size(350, 20);
            this.reponse_textBox2.TabIndex = 4;
            // 
            // prochaineQuestion_button1
            // 
            this.prochaineQuestion_button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.prochaineQuestion_button1.Location = new System.Drawing.Point(275, 240);
            this.prochaineQuestion_button1.Name = "prochaineQuestion_button1";
            this.prochaineQuestion_button1.Size = new System.Drawing.Size(107, 23);
            this.prochaineQuestion_button1.TabIndex = 5;
            this.prochaineQuestion_button1.Text = "Prochaine question";
            this.prochaineQuestion_button1.UseVisualStyleBackColor = true;
            // 
            // envoyerReponse_button2
            // 
            this.envoyerReponse_button2.Location = new System.Drawing.Point(528, 240);
            this.envoyerReponse_button2.Name = "envoyerReponse_button2";
            this.envoyerReponse_button2.Size = new System.Drawing.Size(97, 23);
            this.envoyerReponse_button2.TabIndex = 6;
            this.envoyerReponse_button2.Text = "Envoyer réponse";
            this.envoyerReponse_button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(884, 361);
            this.Controls.Add(this.envoyerReponse_button2);
            this.Controls.Add(this.prochaineQuestion_button1);
            this.Controls.Add(this.reponse_textBox2);
            this.Controls.Add(this.question_textBox1);
            this.Controls.Add(this.reponse_label3);
            this.Controls.Add(this.question_label2);
            this.Controls.Add(this.titre_label1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titre_label1;
        private System.Windows.Forms.Label question_label2;
        private System.Windows.Forms.Label reponse_label3;
        private System.Windows.Forms.TextBox question_textBox1;
        private System.Windows.Forms.TextBox reponse_textBox2;
        private System.Windows.Forms.Button prochaineQuestion_button1;
        private System.Windows.Forms.Button envoyerReponse_button2;

    }
}

