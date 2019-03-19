namespace IgePreventiveReminder
{
    partial class UtilisateursForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UtilisateursForm));
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.logOutButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.usersButton = new System.Windows.Forms.Button();
            this.uniteMButton = new System.Windows.Forms.Button();
            this.accueilButton = new System.Windows.Forms.Button();
            this.rechercheComboBox = new System.Windows.Forms.ComboBox();
            this.rechercheTextBox = new System.Windows.Forms.TextBox();
            this.addUserButton = new System.Windows.Forms.Button();
            this.usersCardFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.indexLabel = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.logOutButton);
            this.panel2.Location = new System.Drawing.Point(-5, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(760, 38);
            this.panel2.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(374, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 36);
            this.label1.TabIndex = 14;
            this.label1.Text = "Utilisateurs";
            // 
            // logOutButton
            // 
            this.logOutButton.BackColor = System.Drawing.Color.LightSteelBlue;
            this.logOutButton.Image = ((System.Drawing.Image)(resources.GetObject("logOutButton.Image")));
            this.logOutButton.Location = new System.Drawing.Point(710, 0);
            this.logOutButton.Name = "logOutButton";
            this.logOutButton.Size = new System.Drawing.Size(47, 38);
            this.logOutButton.TabIndex = 6;
            this.logOutButton.UseVisualStyleBackColor = false;
            this.logOutButton.Click += new System.EventHandler(this.logOutButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.usersButton);
            this.panel1.Controls.Add(this.uniteMButton);
            this.panel1.Controls.Add(this.accueilButton);
            this.panel1.Location = new System.Drawing.Point(-5, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(206, 538);
            this.panel1.TabIndex = 8;
            // 
            // usersButton
            // 
            this.usersButton.BackColor = System.Drawing.Color.LightSteelBlue;
            this.usersButton.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usersButton.ForeColor = System.Drawing.Color.Black;
            this.usersButton.Image = ((System.Drawing.Image)(resources.GetObject("usersButton.Image")));
            this.usersButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.usersButton.Location = new System.Drawing.Point(3, 251);
            this.usersButton.Name = "usersButton";
            this.usersButton.Size = new System.Drawing.Size(203, 37);
            this.usersButton.TabIndex = 2;
            this.usersButton.Text = "Utilisateurs";
            this.usersButton.UseVisualStyleBackColor = false;
            this.usersButton.Click += new System.EventHandler(this.usersButton_Click);
            // 
            // uniteMButton
            // 
            this.uniteMButton.BackColor = System.Drawing.Color.LightSteelBlue;
            this.uniteMButton.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uniteMButton.ForeColor = System.Drawing.Color.Black;
            this.uniteMButton.Image = ((System.Drawing.Image)(resources.GetObject("uniteMButton.Image")));
            this.uniteMButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uniteMButton.Location = new System.Drawing.Point(3, 203);
            this.uniteMButton.Name = "uniteMButton";
            this.uniteMButton.Size = new System.Drawing.Size(203, 37);
            this.uniteMButton.TabIndex = 1;
            this.uniteMButton.Text = "Unité medical";
            this.uniteMButton.UseVisualStyleBackColor = false;
            this.uniteMButton.Click += new System.EventHandler(this.uniteMButton_Click);
            // 
            // accueilButton
            // 
            this.accueilButton.BackColor = System.Drawing.Color.LightSteelBlue;
            this.accueilButton.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accueilButton.ForeColor = System.Drawing.Color.Black;
            this.accueilButton.Image = ((System.Drawing.Image)(resources.GetObject("accueilButton.Image")));
            this.accueilButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.accueilButton.Location = new System.Drawing.Point(3, 156);
            this.accueilButton.Name = "accueilButton";
            this.accueilButton.Size = new System.Drawing.Size(203, 37);
            this.accueilButton.TabIndex = 0;
            this.accueilButton.Text = "Accueil";
            this.accueilButton.UseVisualStyleBackColor = false;
            this.accueilButton.Click += new System.EventHandler(this.accueilButton_Click);
            // 
            // rechercheComboBox
            // 
            this.rechercheComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.rechercheComboBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rechercheComboBox.FormattingEnabled = true;
            this.rechercheComboBox.Items.AddRange(new object[] {
            "E-mail",
            "Poste",
            "Type",
            "UnitéMedical (Nom)"});
            this.rechercheComboBox.Location = new System.Drawing.Point(244, 140);
            this.rechercheComboBox.Name = "rechercheComboBox";
            this.rechercheComboBox.Size = new System.Drawing.Size(253, 26);
            this.rechercheComboBox.TabIndex = 12;
            // 
            // rechercheTextBox
            // 
            this.rechercheTextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rechercheTextBox.Location = new System.Drawing.Point(244, 107);
            this.rechercheTextBox.Name = "rechercheTextBox";
            this.rechercheTextBox.Size = new System.Drawing.Size(464, 26);
            this.rechercheTextBox.TabIndex = 11;
            this.rechercheTextBox.TextChanged += new System.EventHandler(this.rechercheTextBox_TextChanged);
            // 
            // addUserButton
            // 
            this.addUserButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addUserButton.Image = ((System.Drawing.Image)(resources.GetObject("addUserButton.Image")));
            this.addUserButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addUserButton.Location = new System.Drawing.Point(592, 44);
            this.addUserButton.Name = "addUserButton";
            this.addUserButton.Size = new System.Drawing.Size(116, 36);
            this.addUserButton.TabIndex = 13;
            this.addUserButton.Text = "Utilisateur";
            this.addUserButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.addUserButton.UseVisualStyleBackColor = true;
            this.addUserButton.Click += new System.EventHandler(this.addUserButton_Click);
            // 
            // usersCardFlowLayoutPanel
            // 
            this.usersCardFlowLayoutPanel.Location = new System.Drawing.Point(207, 189);
            this.usersCardFlowLayoutPanel.Name = "usersCardFlowLayoutPanel";
            this.usersCardFlowLayoutPanel.Size = new System.Drawing.Size(534, 349);
            this.usersCardFlowLayoutPanel.TabIndex = 20;
            // 
            // indexLabel
            // 
            this.indexLabel.AutoSize = true;
            this.indexLabel.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.indexLabel.Location = new System.Drawing.Point(503, 147);
            this.indexLabel.Name = "indexLabel";
            this.indexLabel.Size = new System.Drawing.Size(194, 14);
            this.indexLabel.TabIndex = 21;
            this.indexLabel.Text = "<--  Sélectionner un type de recherche";
            this.indexLabel.Visible = false;
            // 
            // UtilisateursForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 550);
            this.Controls.Add(this.indexLabel);
            this.Controls.Add(this.usersCardFlowLayoutPanel);
            this.Controls.Add(this.addUserButton);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.rechercheComboBox);
            this.Controls.Add(this.rechercheTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UtilisateursForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UtilisateursForm";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button logOutButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button usersButton;
        private System.Windows.Forms.Button uniteMButton;
        private System.Windows.Forms.Button accueilButton;
        private System.Windows.Forms.ComboBox rechercheComboBox;
        private System.Windows.Forms.TextBox rechercheTextBox;
        private System.Windows.Forms.Button addUserButton;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.FlowLayoutPanel usersCardFlowLayoutPanel;
        private System.Windows.Forms.Label indexLabel;
    }
}