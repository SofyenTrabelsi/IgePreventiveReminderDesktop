namespace IgePreventiveReminder
{
    partial class AjoutUniteMedical
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AjoutUniteMedical));
            this.titleLabel = new System.Windows.Forms.Label();
            this.confirmerButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.typeTextBox = new System.Windows.Forms.TextBox();
            this.nomTextBox = new System.Windows.Forms.TextBox();
            this.gouvernoratComboBox = new System.Windows.Forms.ComboBox();
            this.villeComboBox = new System.Windows.Forms.ComboBox();
            this.codePostalTextBox = new System.Windows.Forms.TextBox();
            this.closeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(77, 21);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(287, 36);
            this.titleLabel.TabIndex = 16;
            this.titleLabel.Text = "Ajout Unité Medical";
            // 
            // confirmerButton
            // 
            this.confirmerButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.confirmerButton.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmerButton.Location = new System.Drawing.Point(194, 297);
            this.confirmerButton.Name = "confirmerButton";
            this.confirmerButton.Size = new System.Drawing.Size(139, 41);
            this.confirmerButton.TabIndex = 19;
            this.confirmerButton.Text = "Confirmer";
            this.confirmerButton.UseVisualStyleBackColor = false;
            this.confirmerButton.Click += new System.EventHandler(this.confirmerButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(63, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 18);
            this.label2.TabIndex = 20;
            this.label2.Text = "Type :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(63, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 18);
            this.label3.TabIndex = 21;
            this.label3.Text = "Nom :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(37, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 18);
            this.label4.TabIndex = 22;
            this.label4.Text = "Adresse :";
            // 
            // typeTextBox
            // 
            this.typeTextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeTextBox.Location = new System.Drawing.Point(127, 109);
            this.typeTextBox.Name = "typeTextBox";
            this.typeTextBox.Size = new System.Drawing.Size(232, 26);
            this.typeTextBox.TabIndex = 23;
            // 
            // nomTextBox
            // 
            this.nomTextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomTextBox.Location = new System.Drawing.Point(127, 155);
            this.nomTextBox.Name = "nomTextBox";
            this.nomTextBox.Size = new System.Drawing.Size(232, 26);
            this.nomTextBox.TabIndex = 24;
            // 
            // gouvernoratComboBox
            // 
            this.gouvernoratComboBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gouvernoratComboBox.FormattingEnabled = true;
            this.gouvernoratComboBox.Location = new System.Drawing.Point(127, 201);
            this.gouvernoratComboBox.Name = "gouvernoratComboBox";
            this.gouvernoratComboBox.Size = new System.Drawing.Size(113, 26);
            this.gouvernoratComboBox.TabIndex = 25;
            this.gouvernoratComboBox.SelectedValueChanged += new System.EventHandler(this.gouvernoratComboBox_SelectedValueChanged);
            // 
            // villeComboBox
            // 
            this.villeComboBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.villeComboBox.FormattingEnabled = true;
            this.villeComboBox.Location = new System.Drawing.Point(246, 201);
            this.villeComboBox.Name = "villeComboBox";
            this.villeComboBox.Size = new System.Drawing.Size(113, 26);
            this.villeComboBox.TabIndex = 26;
            // 
            // codePostalTextBox
            // 
            this.codePostalTextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codePostalTextBox.Location = new System.Drawing.Point(365, 201);
            this.codePostalTextBox.MaxLength = 4;
            this.codePostalTextBox.Name = "codePostalTextBox";
            this.codePostalTextBox.Size = new System.Drawing.Size(77, 26);
            this.codePostalTextBox.TabIndex = 27;
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.Salmon;
            this.closeButton.Image = ((System.Drawing.Image)(resources.GetObject("closeButton.Image")));
            this.closeButton.Location = new System.Drawing.Point(467, -1);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(34, 34);
            this.closeButton.TabIndex = 28;
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // AjoutUniteMedical
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 350);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.codePostalTextBox);
            this.Controls.Add(this.villeComboBox);
            this.Controls.Add(this.gouvernoratComboBox);
            this.Controls.Add(this.nomTextBox);
            this.Controls.Add(this.typeTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.confirmerButton);
            this.Controls.Add(this.titleLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AjoutUniteMedical";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AjoutUniteMedical";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button confirmerButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox typeTextBox;
        private System.Windows.Forms.TextBox nomTextBox;
        private System.Windows.Forms.ComboBox gouvernoratComboBox;
        private System.Windows.Forms.ComboBox villeComboBox;
        private System.Windows.Forms.TextBox codePostalTextBox;
        private System.Windows.Forms.Button closeButton;
    }
}