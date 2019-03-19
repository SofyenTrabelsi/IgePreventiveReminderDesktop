namespace IgePreventiveReminder
{
    partial class UniteMedicalCard
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

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UniteMedicalCard));
            this.ModifierButton = new System.Windows.Forms.Button();
            this.SupprimerButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.adresseL = new System.Windows.Forms.Label();
            this.nomL = new System.Windows.Forms.Label();
            this.typeL = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ModifierButton
            // 
            this.ModifierButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.ModifierButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.ModifierButton.Image = ((System.Drawing.Image)(resources.GetObject("ModifierButton.Image")));
            this.ModifierButton.Location = new System.Drawing.Point(445, 7);
            this.ModifierButton.Name = "ModifierButton";
            this.ModifierButton.Size = new System.Drawing.Size(40, 42);
            this.ModifierButton.TabIndex = 0;
            this.ModifierButton.UseVisualStyleBackColor = false;
            this.ModifierButton.Click += new System.EventHandler(this.ModifierButton_Click);
            // 
            // SupprimerButton
            // 
            this.SupprimerButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.SupprimerButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.SupprimerButton.Image = ((System.Drawing.Image)(resources.GetObject("SupprimerButton.Image")));
            this.SupprimerButton.Location = new System.Drawing.Point(445, 50);
            this.SupprimerButton.Name = "SupprimerButton";
            this.SupprimerButton.Size = new System.Drawing.Size(40, 42);
            this.SupprimerButton.TabIndex = 1;
            this.SupprimerButton.UseVisualStyleBackColor = false;
            this.SupprimerButton.Click += new System.EventHandler(this.SupprimerButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Type :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nom :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Adresse :";
            // 
            // adresseL
            // 
            this.adresseL.AutoSize = true;
            this.adresseL.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adresseL.Location = new System.Drawing.Point(96, 75);
            this.adresseL.Name = "adresseL";
            this.adresseL.Size = new System.Drawing.Size(0, 18);
            this.adresseL.TabIndex = 7;
            // 
            // nomL
            // 
            this.nomL.AutoSize = true;
            this.nomL.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomL.Location = new System.Drawing.Point(96, 41);
            this.nomL.Name = "nomL";
            this.nomL.Size = new System.Drawing.Size(0, 18);
            this.nomL.TabIndex = 6;
            // 
            // typeL
            // 
            this.typeL.AutoSize = true;
            this.typeL.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeL.Location = new System.Drawing.Point(96, 8);
            this.typeL.Name = "typeL";
            this.typeL.Size = new System.Drawing.Size(0, 18);
            this.typeL.TabIndex = 5;
            // 
            // UniteMedicalCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.adresseL);
            this.Controls.Add(this.nomL);
            this.Controls.Add(this.typeL);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SupprimerButton);
            this.Controls.Add(this.ModifierButton);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "UniteMedicalCard";
            this.Size = new System.Drawing.Size(490, 100);
            this.Click += new System.EventHandler(this.UniteMedicalCard_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ModifierButton;
        private System.Windows.Forms.Button SupprimerButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label adresseL;
        private System.Windows.Forms.Label nomL;
        private System.Windows.Forms.Label typeL;
    }
}
