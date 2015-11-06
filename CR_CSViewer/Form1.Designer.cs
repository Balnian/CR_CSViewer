namespace CR_CSViewer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.TC_Container = new System.Windows.Forms.TabControl();
            this.TP_Dialogues = new System.Windows.Forms.TabPage();
            this.TP_Personnages = new System.Windows.Forms.TabPage();
            this.TS_Menu = new System.Windows.Forms.ToolStrip();
            this.TSBT_Ajouter = new System.Windows.Forms.ToolStripButton();
            this.TSBT_Supprimer = new System.Windows.Forms.ToolStripButton();
            this.TSTB_Recherche = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.ouvrirFichierDialoguesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ouvrirFichierQuêtesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enregistrerToutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enregistrerDialoguesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enregistrerQuêtesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TP_Quetes = new System.Windows.Forms.TabPage();
            this.LV_Dialogues = new System.Windows.Forms.ListView();
            this.IL_Dialogues = new System.Windows.Forms.ImageList(this.components);
            this.IL_Quest = new System.Windows.Forms.ImageList(this.components);
            this.TC_Container.SuspendLayout();
            this.TP_Dialogues.SuspendLayout();
            this.TS_Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // TC_Container
            // 
            this.TC_Container.Controls.Add(this.TP_Dialogues);
            this.TC_Container.Controls.Add(this.TP_Personnages);
            this.TC_Container.Controls.Add(this.TP_Quetes);
            this.TC_Container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TC_Container.Location = new System.Drawing.Point(0, 25);
            this.TC_Container.Name = "TC_Container";
            this.TC_Container.SelectedIndex = 0;
            this.TC_Container.Size = new System.Drawing.Size(1228, 500);
            this.TC_Container.TabIndex = 0;
            // 
            // TP_Dialogues
            // 
            this.TP_Dialogues.Controls.Add(this.LV_Dialogues);
            this.TP_Dialogues.Location = new System.Drawing.Point(4, 22);
            this.TP_Dialogues.Name = "TP_Dialogues";
            this.TP_Dialogues.Padding = new System.Windows.Forms.Padding(3);
            this.TP_Dialogues.Size = new System.Drawing.Size(1220, 474);
            this.TP_Dialogues.TabIndex = 0;
            this.TP_Dialogues.Text = "Dialogues";
            this.TP_Dialogues.UseVisualStyleBackColor = true;
            // 
            // TP_Personnages
            // 
            this.TP_Personnages.Location = new System.Drawing.Point(4, 22);
            this.TP_Personnages.Name = "TP_Personnages";
            this.TP_Personnages.Padding = new System.Windows.Forms.Padding(3);
            this.TP_Personnages.Size = new System.Drawing.Size(1220, 474);
            this.TP_Personnages.TabIndex = 1;
            this.TP_Personnages.Text = "Personnages";
            this.TP_Personnages.UseVisualStyleBackColor = true;
            // 
            // TS_Menu
            // 
            this.TS_Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.TSBT_Ajouter,
            this.TSBT_Supprimer,
            this.toolStripSeparator1,
            this.toolStripLabel1,
            this.TSTB_Recherche});
            this.TS_Menu.Location = new System.Drawing.Point(0, 0);
            this.TS_Menu.Name = "TS_Menu";
            this.TS_Menu.Size = new System.Drawing.Size(1228, 25);
            this.TS_Menu.TabIndex = 1;
            this.TS_Menu.Text = "toolStrip1";
            // 
            // TSBT_Ajouter
            // 
            this.TSBT_Ajouter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.TSBT_Ajouter.Image = ((System.Drawing.Image)(resources.GetObject("TSBT_Ajouter.Image")));
            this.TSBT_Ajouter.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSBT_Ajouter.Name = "TSBT_Ajouter";
            this.TSBT_Ajouter.Size = new System.Drawing.Size(50, 22);
            this.TSBT_Ajouter.Text = "Ajouter";
            // 
            // TSBT_Supprimer
            // 
            this.TSBT_Supprimer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.TSBT_Supprimer.Image = ((System.Drawing.Image)(resources.GetObject("TSBT_Supprimer.Image")));
            this.TSBT_Supprimer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSBT_Supprimer.Name = "TSBT_Supprimer";
            this.TSBT_Supprimer.Size = new System.Drawing.Size(66, 22);
            this.TSBT_Supprimer.Text = "Supprimer";
            // 
            // TSTB_Recherche
            // 
            this.TSTB_Recherche.Name = "TSTB_Recherche";
            this.TSTB_Recherche.Size = new System.Drawing.Size(100, 25);
            this.TSTB_Recherche.Click += new System.EventHandler(this.TSTB_Recherche_Click);
            this.TSTB_Recherche.TextChanged += new System.EventHandler(this.TSTB_Recherche_TextChanged);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(65, 22);
            this.toolStripLabel1.Text = "Recherche:";
            this.toolStripLabel1.Click += new System.EventHandler(this.toolStripLabel1_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ouvrirFichierDialoguesToolStripMenuItem,
            this.ouvrirFichierQuêtesToolStripMenuItem,
            this.enregistrerToutToolStripMenuItem,
            this.enregistrerDialoguesToolStripMenuItem,
            this.enregistrerQuêtesToolStripMenuItem});
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(55, 22);
            this.toolStripButton1.Text = "Fichier";
            // 
            // ouvrirFichierDialoguesToolStripMenuItem
            // 
            this.ouvrirFichierDialoguesToolStripMenuItem.Name = "ouvrirFichierDialoguesToolStripMenuItem";
            this.ouvrirFichierDialoguesToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.ouvrirFichierDialoguesToolStripMenuItem.Text = "Ouvrir Fichier Dialogues ...";
            this.ouvrirFichierDialoguesToolStripMenuItem.Click += new System.EventHandler(this.ouvrirFichierDialoguesToolStripMenuItem_Click);
            // 
            // ouvrirFichierQuêtesToolStripMenuItem
            // 
            this.ouvrirFichierQuêtesToolStripMenuItem.Name = "ouvrirFichierQuêtesToolStripMenuItem";
            this.ouvrirFichierQuêtesToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.ouvrirFichierQuêtesToolStripMenuItem.Text = "Ouvrir Fichier Quêtes ...";
            // 
            // enregistrerToutToolStripMenuItem
            // 
            this.enregistrerToutToolStripMenuItem.Name = "enregistrerToutToolStripMenuItem";
            this.enregistrerToutToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.enregistrerToutToolStripMenuItem.Text = "Enregistrer Tout";
            // 
            // enregistrerDialoguesToolStripMenuItem
            // 
            this.enregistrerDialoguesToolStripMenuItem.Name = "enregistrerDialoguesToolStripMenuItem";
            this.enregistrerDialoguesToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.enregistrerDialoguesToolStripMenuItem.Text = "Enregistrer Dialogues";
            // 
            // enregistrerQuêtesToolStripMenuItem
            // 
            this.enregistrerQuêtesToolStripMenuItem.Name = "enregistrerQuêtesToolStripMenuItem";
            this.enregistrerQuêtesToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.enregistrerQuêtesToolStripMenuItem.Text = "Enregistrer Quêtes";
            // 
            // TP_Quetes
            // 
            this.TP_Quetes.Location = new System.Drawing.Point(4, 22);
            this.TP_Quetes.Name = "TP_Quetes";
            this.TP_Quetes.Size = new System.Drawing.Size(1220, 474);
            this.TP_Quetes.TabIndex = 2;
            this.TP_Quetes.Text = "Quêtes";
            this.TP_Quetes.UseVisualStyleBackColor = true;
            // 
            // LV_Dialogues
            // 
            this.LV_Dialogues.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LV_Dialogues.FullRowSelect = true;
            this.LV_Dialogues.GridLines = true;
            this.LV_Dialogues.LargeImageList = this.IL_Dialogues;
            this.LV_Dialogues.Location = new System.Drawing.Point(3, 3);
            this.LV_Dialogues.Name = "LV_Dialogues";
            this.LV_Dialogues.Size = new System.Drawing.Size(1214, 468);
            this.LV_Dialogues.SmallImageList = this.IL_Dialogues;
            this.LV_Dialogues.TabIndex = 0;
            this.LV_Dialogues.TileSize = new System.Drawing.Size(200, 200);
            this.LV_Dialogues.UseCompatibleStateImageBehavior = false;
            this.LV_Dialogues.View = System.Windows.Forms.View.Details;
            // 
            // IL_Dialogues
            // 
            this.IL_Dialogues.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("IL_Dialogues.ImageStream")));
            this.IL_Dialogues.TransparentColor = System.Drawing.Color.Transparent;
            this.IL_Dialogues.Images.SetKeyName(0, "Dialogue.png");
            // 
            // IL_Quest
            // 
            this.IL_Quest.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("IL_Quest.ImageStream")));
            this.IL_Quest.TransparentColor = System.Drawing.Color.Transparent;
            this.IL_Quest.Images.SetKeyName(0, "Quest.png");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1228, 525);
            this.Controls.Add(this.TC_Container);
            this.Controls.Add(this.TS_Menu);
            this.Name = "Form1";
            this.Text = "Form1";
            this.TC_Container.ResumeLayout(false);
            this.TP_Dialogues.ResumeLayout(false);
            this.TS_Menu.ResumeLayout(false);
            this.TS_Menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl TC_Container;
        private System.Windows.Forms.TabPage TP_Dialogues;
        private System.Windows.Forms.TabPage TP_Personnages;
        private System.Windows.Forms.ToolStrip TS_Menu;
        private System.Windows.Forms.ToolStripButton TSBT_Ajouter;
        private System.Windows.Forms.ToolStripButton TSBT_Supprimer;
        private System.Windows.Forms.ToolStripTextBox TSTB_Recherche;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.TabPage TP_Quetes;
        private System.Windows.Forms.ToolStripDropDownButton toolStripButton1;
        private System.Windows.Forms.ToolStripMenuItem ouvrirFichierDialoguesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ouvrirFichierQuêtesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enregistrerToutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enregistrerDialoguesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enregistrerQuêtesToolStripMenuItem;
        private System.Windows.Forms.ListView LV_Dialogues;
        private System.Windows.Forms.ImageList IL_Dialogues;
        private System.Windows.Forms.ImageList IL_Quest;
    }
}

