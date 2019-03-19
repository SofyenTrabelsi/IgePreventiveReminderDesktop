namespace IgePreventiveReminder
{
    partial class ComposantCard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ComposantCard));
            this.SupprimerButton = new System.Windows.Forms.Button();
            this.ModifierButton = new System.Windows.Forms.Button();
            this.dateML = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.refL = new System.Windows.Forms.Label();
            this.nomL = new System.Windows.Forms.Label();
            this.typeL = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SupprimerButton
            // 
            this.SupprimerButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.SupprimerButton.Image = ((System.Drawing.Image)(resources.GetObject("SupprimerButton.Image")));
            this.SupprimerButton.Location = new System.Drawing.Point(447, 76);
            this.SupprimerButton.Name = "SupprimerButton";
            this.SupprimerButton.Size = new System.Drawing.Size(40, 42);
            this.SupprimerButton.TabIndex = 11;
            this.SupprimerButton.UseVisualStyleBackColor = false;
            this.SupprimerButton.Click += new System.EventHandler(this.SupprimerButton_Click);
            // 
            // ModifierButton
            // 
            this.ModifierButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.ModifierButton.Image = ((System.Drawing.Image)(resources.GetObject("ModifierButton.Image")));
            this.ModifierButton.Location = new System.Drawing.Point(447, 33);
            this.ModifierButton.Name = "ModifierButton";
            this.ModifierButton.Size = new System.Drawing.Size(40, 42);
            this.ModifierButton.TabIndex = 10;
            this.ModifierButton.UseVisualStyleBackColor = false;
            this.ModifierButton.Click += new System.EventHandler(this.ModifierButton_Click);
            // 
            // dateML
            // 
            this.dateML.AutoSize = true;
            this.dateML.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateML.Location = new System.Drawing.Point(172, 112);
            this.dateML.Name = "dateML";
            this.dateML.Size = new System.Drawing.Size(0, 18);
            this.dateML.TabIndex = 29;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(3, 110);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(165, 18);
            this.label9.TabIndex = 27;
            this.label9.Text = "Date de maintenance :";
            // 
            // refL
            // 
            this.refL.AutoSize = true;
            this.refL.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refL.Location = new System.Drawing.Point(174, 80);
            this.refL.Name = "refL";
            this.refL.Size = new System.Drawing.Size(0, 18);
            this.refL.TabIndex = 26;
            // 
            // nomL
            // 
            this.nomL.AutoSize = true;
            this.nomL.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomL.Location = new System.Drawing.Point(174, 51);
            this.nomL.Name = "nomL";
            this.nomL.Size = new System.Drawing.Size(0, 18);
            this.nomL.TabIndex = 25;
            // 
            // typeL
            // 
            this.typeL.AutoSize = true;
            this.typeL.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeL.Location = new System.Drawing.Point(178, 24);
            this.typeL.Name = "typeL";
            this.typeL.Size = new System.Drawing.Size(0, 18);
            this.typeL.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(80, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 18);
            this.label3.TabIndex = 23;
            this.label3.Text = "Référence :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(119, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 18);
            this.label2.TabIndex = 22;
            this.label2.Text = "Nom :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(119, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 18);
            this.label1.TabIndex = 21;
            this.label1.Text = "Type :";
            // 
            // ComposantCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.dateML);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.refL);
            this.Controls.Add(this.nomL);
            this.Controls.Add(this.typeL);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SupprimerButton);
            this.Controls.Add(this.ModifierButton);
            this.Name = "ComposantCard";
            this.Size = new System.Drawing.Size(490, 150);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SupprimerButton;
        private System.Windows.Forms.Button ModifierButton;
        private System.Windows.Forms.Label dateML;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label refL;
        private System.Windows.Forms.Label nomL;
        private System.Windows.Forms.Label typeL;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
