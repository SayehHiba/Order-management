namespace WindowsFormsApplication1
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.newC = new System.Windows.Forms.Button();
            this.nomCl = new System.Windows.Forms.Label();
            this.codeClient = new System.Windows.Forms.Label();
            this.datec = new System.Windows.Forms.Label();
            this.CodeCm = new System.Windows.Forms.Label();
            this.NomPrenom = new System.Windows.Forms.Label();
            this.DateCm = new System.Windows.Forms.Label();
            this.CodeCl = new System.Windows.Forms.Label();
            this.CodeCmd = new System.Windows.Forms.Label();
            this.totalprix = new System.Windows.Forms.Label();
            this.prixprd = new System.Windows.Forms.Label();
            this.contiteprod = new System.Windows.Forms.Label();
            this.labelprd = new System.Windows.Forms.Label();
            this.quitter = new System.Windows.Forms.Button();
            this.supprimercmd = new System.Windows.Forms.Button();
            this.mdifiercmd = new System.Windows.Forms.Button();
            this.ajoutcmd = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.valider = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.total = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(19, 144);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(368, 299);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // newC
            // 
            this.newC.Location = new System.Drawing.Point(402, 82);
            this.newC.Name = "newC";
            this.newC.Size = new System.Drawing.Size(144, 24);
            this.newC.TabIndex = 5;
            this.newC.Text = "nouvelle commande";
            this.newC.UseVisualStyleBackColor = true;
            this.newC.Click += new System.EventHandler(this.newC_Click);
            // 
            // nomCl
            // 
            this.nomCl.AutoSize = true;
            this.nomCl.Location = new System.Drawing.Point(433, 90);
            this.nomCl.Name = "nomCl";
            this.nomCl.Size = new System.Drawing.Size(19, 13);
            this.nomCl.TabIndex = 13;
            this.nomCl.Text = "....";
            // 
            // codeClient
            // 
            this.codeClient.AutoSize = true;
            this.codeClient.Location = new System.Drawing.Point(169, 90);
            this.codeClient.Name = "codeClient";
            this.codeClient.Size = new System.Drawing.Size(19, 13);
            this.codeClient.TabIndex = 12;
            this.codeClient.Text = "....";
            // 
            // datec
            // 
            this.datec.AutoSize = true;
            this.datec.Location = new System.Drawing.Point(433, 47);
            this.datec.Name = "datec";
            this.datec.Size = new System.Drawing.Size(19, 13);
            this.datec.TabIndex = 11;
            this.datec.Text = "....";
            // 
            // CodeCm
            // 
            this.CodeCm.AutoSize = true;
            this.CodeCm.Location = new System.Drawing.Point(169, 47);
            this.CodeCm.Name = "CodeCm";
            this.CodeCm.Size = new System.Drawing.Size(19, 13);
            this.CodeCm.TabIndex = 10;
            this.CodeCm.Text = "....";
            // 
            // NomPrenom
            // 
            this.NomPrenom.AutoSize = true;
            this.NomPrenom.Location = new System.Drawing.Point(303, 90);
            this.NomPrenom.Name = "NomPrenom";
            this.NomPrenom.Size = new System.Drawing.Size(68, 13);
            this.NomPrenom.TabIndex = 9;
            this.NomPrenom.Text = "Nom Prenom";
            // 
            // DateCm
            // 
            this.DateCm.AutoSize = true;
            this.DateCm.Location = new System.Drawing.Point(303, 47);
            this.DateCm.Name = "DateCm";
            this.DateCm.Size = new System.Drawing.Size(86, 13);
            this.DateCm.TabIndex = 8;
            this.DateCm.Text = "Date Commande";
            // 
            // CodeCl
            // 
            this.CodeCl.AutoSize = true;
            this.CodeCl.Location = new System.Drawing.Point(60, 90);
            this.CodeCl.Name = "CodeCl";
            this.CodeCl.Size = new System.Drawing.Size(64, 13);
            this.CodeCl.TabIndex = 7;
            this.CodeCl.Text = "Code Client ";
            // 
            // CodeCmd
            // 
            this.CodeCmd.AutoSize = true;
            this.CodeCmd.Location = new System.Drawing.Point(60, 47);
            this.CodeCmd.Name = "CodeCmd";
            this.CodeCmd.Size = new System.Drawing.Size(88, 13);
            this.CodeCmd.TabIndex = 6;
            this.CodeCmd.Text = "Code Commande";
            // 
            // totalprix
            // 
            this.totalprix.AutoSize = true;
            this.totalprix.Location = new System.Drawing.Point(334, 26);
            this.totalprix.Name = "totalprix";
            this.totalprix.Size = new System.Drawing.Size(96, 13);
            this.totalprix.TabIndex = 9;
            this.totalprix.Text = "Total Ligne Produit";
            // 
            // prixprd
            // 
            this.prixprd.AutoSize = true;
            this.prixprd.Location = new System.Drawing.Point(245, 26);
            this.prixprd.Name = "prixprd";
            this.prixprd.Size = new System.Drawing.Size(63, 13);
            this.prixprd.TabIndex = 8;
            this.prixprd.Text = "Prix Unitaire";
            // 
            // contiteprod
            // 
            this.contiteprod.AutoSize = true;
            this.contiteprod.Location = new System.Drawing.Point(135, 26);
            this.contiteprod.Name = "contiteprod";
            this.contiteprod.Size = new System.Drawing.Size(75, 13);
            this.contiteprod.TabIndex = 7;
            this.contiteprod.Text = "qantite Produit";
            this.contiteprod.Click += new System.EventHandler(this.label2_Click);
            // 
            // labelprd
            // 
            this.labelprd.AutoSize = true;
            this.labelprd.Location = new System.Drawing.Point(45, 26);
            this.labelprd.Name = "labelprd";
            this.labelprd.Size = new System.Drawing.Size(69, 13);
            this.labelprd.TabIndex = 6;
            this.labelprd.Text = "Label Produit";
            // 
            // quitter
            // 
            this.quitter.Location = new System.Drawing.Point(512, 391);
            this.quitter.Name = "quitter";
            this.quitter.Size = new System.Drawing.Size(71, 22);
            this.quitter.TabIndex = 5;
            this.quitter.Text = "Quitter";
            this.quitter.UseVisualStyleBackColor = true;
            this.quitter.Click += new System.EventHandler(this.quitter_Click);
            // 
            // supprimercmd
            // 
            this.supprimercmd.Location = new System.Drawing.Point(436, 391);
            this.supprimercmd.Name = "supprimercmd";
            this.supprimercmd.Size = new System.Drawing.Size(71, 22);
            this.supprimercmd.TabIndex = 4;
            this.supprimercmd.Text = "supprimer";
            this.supprimercmd.UseVisualStyleBackColor = true;
            this.supprimercmd.Click += new System.EventHandler(this.supprimercmd_Click);
            // 
            // mdifiercmd
            // 
            this.mdifiercmd.Location = new System.Drawing.Point(359, 391);
            this.mdifiercmd.Name = "mdifiercmd";
            this.mdifiercmd.Size = new System.Drawing.Size(71, 22);
            this.mdifiercmd.TabIndex = 3;
            this.mdifiercmd.Text = "modifier";
            this.mdifiercmd.UseVisualStyleBackColor = true;
            // 
            // ajoutcmd
            // 
            this.ajoutcmd.Location = new System.Drawing.Point(282, 391);
            this.ajoutcmd.Name = "ajoutcmd";
            this.ajoutcmd.Size = new System.Drawing.Size(71, 22);
            this.ajoutcmd.TabIndex = 2;
            this.ajoutcmd.Text = "ajouter";
            this.ajoutcmd.UseVisualStyleBackColor = true;
            this.ajoutcmd.Click += new System.EventHandler(this.ajoutcmd_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(19, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(368, 126);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "recharche";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(25, 247);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(362, 150);
            this.dataGridView2.TabIndex = 2;
            this.dataGridView2.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.valider);
            this.groupBox1.Controls.Add(this.nomCl);
            this.groupBox1.Controls.Add(this.codeClient);
            this.groupBox1.Controls.Add(this.datec);
            this.groupBox1.Controls.Add(this.CodeCm);
            this.groupBox1.Controls.Add(this.NomPrenom);
            this.groupBox1.Controls.Add(this.DateCm);
            this.groupBox1.Controls.Add(this.CodeCl);
            this.groupBox1.Controls.Add(this.CodeCmd);
            this.groupBox1.Controls.Add(this.quitter);
            this.groupBox1.Controls.Add(this.supprimercmd);
            this.groupBox1.Controls.Add(this.mdifiercmd);
            this.groupBox1.Controls.Add(this.ajoutcmd);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(393, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(607, 431);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // valider
            // 
            this.valider.Location = new System.Drawing.Point(98, 392);
            this.valider.Name = "valider";
            this.valider.Size = new System.Drawing.Size(75, 23);
            this.valider.TabIndex = 14;
            this.valider.Text = "valider";
            this.valider.UseVisualStyleBackColor = true;
            this.valider.Click += new System.EventHandler(this.valider_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.Location = new System.Drawing.Point(28, 141);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(561, 244);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "commande";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.Controls.Add(this.total);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.totalprix);
            this.panel1.Controls.Add(this.prixprd);
            this.panel1.Controls.Add(this.contiteprod);
            this.panel1.Controls.Add(this.labelprd);
            this.panel1.Controls.Add(this.newC);
            this.panel1.Location = new System.Drawing.Point(6, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(549, 210);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // total
            // 
            this.total.AutoSize = true;
            this.total.Location = new System.Drawing.Point(496, 43);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(13, 13);
            this.total.TabIndex = 11;
            this.total.Text = "0";
            this.total.Click += new System.EventHandler(this.total_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(487, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 27);
            this.label1.TabIndex = 10;
            this.label1.Text = "Total";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 464);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button newC;
        private System.Windows.Forms.Label nomCl;
        private System.Windows.Forms.Label codeClient;
        private System.Windows.Forms.Label datec;
        private System.Windows.Forms.Label CodeCm;
        private System.Windows.Forms.Label NomPrenom;
        private System.Windows.Forms.Label DateCm;
        private System.Windows.Forms.Label CodeCl;
        private System.Windows.Forms.Label CodeCmd;
        private System.Windows.Forms.Label totalprix;
        private System.Windows.Forms.Label prixprd;
        private System.Windows.Forms.Label contiteprod;
        private System.Windows.Forms.Label labelprd;
        private System.Windows.Forms.Button quitter;
        private System.Windows.Forms.Button supprimercmd;
        private System.Windows.Forms.Button mdifiercmd;
        private System.Windows.Forms.Button ajoutcmd;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label total;
        private System.Windows.Forms.Button valider;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}

