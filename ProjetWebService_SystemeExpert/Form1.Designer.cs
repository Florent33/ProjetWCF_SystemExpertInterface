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
            this.listView1 = new System.Windows.Forms.ListView();
            this.ProchaineQuestion = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(51, 152);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(411, 329);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // ProchaineQuestion
            // 
            this.ProchaineQuestion.Location = new System.Drawing.Point(352, 487);
            this.ProchaineQuestion.Name = "ProchaineQuestion";
            this.ProchaineQuestion.Size = new System.Drawing.Size(110, 23);
            this.ProchaineQuestion.TabIndex = 2;
            this.ProchaineQuestion.Text = "Prochaine question";
            this.ProchaineQuestion.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(400, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(304, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Interface 2037 Ready for inquiry";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(248, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Questions";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(708, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Réponses";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(571, 340);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(342, 20);
            this.textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(571, 272);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(342, 20);
            this.textBox2.TabIndex = 7;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(804, 487);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Envoyer la réponse";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ProchaineQuestion);
            this.Controls.Add(this.listView1);
            this.Cursor = System.Windows.Forms.Cursors.PanWest;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.Text = "Interface 2037";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button ProchaineQuestion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
    }
}

