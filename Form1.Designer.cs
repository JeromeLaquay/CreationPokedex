namespace CreationPokedex
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
            this.creer = new System.Windows.Forms.Button();
            this.NumeroBox = new System.Windows.Forms.TextBox();
            this.NomBox = new System.Windows.Forms.TextBox();
            this.PVBox = new System.Windows.Forms.TextBox();
            this.PDBox = new System.Windows.Forms.TextBox();
            this.AttackBox = new System.Windows.Forms.ComboBox();
            this.labelInfo = new System.Windows.Forms.Label();
            this.ajouterAttaque = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // creer
            // 
            this.creer.Location = new System.Drawing.Point(69, 264);
            this.creer.Name = "creer";
            this.creer.Size = new System.Drawing.Size(173, 23);
            this.creer.TabIndex = 0;
            this.creer.Text = "creer pokemon";
            this.creer.UseVisualStyleBackColor = true;
            this.creer.Click += new System.EventHandler(this.creer_Click);
            // 
            // NumeroBox
            // 
            this.NumeroBox.Location = new System.Drawing.Point(29, 38);
            this.NumeroBox.Name = "NumeroBox";
            this.NumeroBox.Size = new System.Drawing.Size(255, 22);
            this.NumeroBox.TabIndex = 1;
            // 
            // NomBox
            // 
            this.NomBox.Location = new System.Drawing.Point(29, 82);
            this.NomBox.Name = "NomBox";
            this.NomBox.Size = new System.Drawing.Size(255, 22);
            this.NomBox.TabIndex = 2;
            // 
            // PVBox
            // 
            this.PVBox.Location = new System.Drawing.Point(29, 127);
            this.PVBox.Name = "PVBox";
            this.PVBox.Size = new System.Drawing.Size(255, 22);
            this.PVBox.TabIndex = 3;
            // 
            // PDBox
            // 
            this.PDBox.Location = new System.Drawing.Point(29, 172);
            this.PDBox.Name = "PDBox";
            this.PDBox.Size = new System.Drawing.Size(255, 22);
            this.PDBox.TabIndex = 4;
            // 
            // AttackBox
            // 
            this.AttackBox.FormattingEnabled = true;
            this.AttackBox.Location = new System.Drawing.Point(29, 219);
            this.AttackBox.Name = "AttackBox";
            this.AttackBox.Size = new System.Drawing.Size(255, 24);
            this.AttackBox.TabIndex = 5;
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Location = new System.Drawing.Point(128, 325);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(46, 17);
            this.labelInfo.TabIndex = 6;
            this.labelInfo.Text = "label1";
            // 
            // ajouterAttaque
            // 
            this.ajouterAttaque.Location = new System.Drawing.Point(29, 384);
            this.ajouterAttaque.Name = "ajouterAttaque";
            this.ajouterAttaque.Size = new System.Drawing.Size(255, 23);
            this.ajouterAttaque.TabIndex = 7;
            this.ajouterAttaque.Text = "ajouter les attaques";
            this.ajouterAttaque.UseVisualStyleBackColor = true;
            this.ajouterAttaque.Click += new System.EventHandler(this.ajouterAttaque_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(414, 38);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(435, 228);
            this.listBox1.TabIndex = 8;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(937, 510);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.ajouterAttaque);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.AttackBox);
            this.Controls.Add(this.PDBox);
            this.Controls.Add(this.PVBox);
            this.Controls.Add(this.NomBox);
            this.Controls.Add(this.NumeroBox);
            this.Controls.Add(this.creer);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button creerBtn;
        private System.Windows.Forms.Button creer;
        private System.Windows.Forms.TextBox NumeroBox;
        private System.Windows.Forms.TextBox NomBox;
        private System.Windows.Forms.TextBox PVBox;
        private System.Windows.Forms.TextBox PDBox;
        private System.Windows.Forms.ComboBox AttackBox;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.Button ajouterAttaque;
        private System.Windows.Forms.ListBox listBox1;
    }
}

