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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.TC_Container = new System.Windows.Forms.TabControl();
            this.TP_Dialogues = new System.Windows.Forms.TabPage();
            this.TP_Personnages = new System.Windows.Forms.TabPage();
            this.TS_Menu = new System.Windows.Forms.ToolStrip();
            this.TSBT_Ajouter = new System.Windows.Forms.ToolStripButton();
            this.TSBT_Supprimer = new System.Windows.Forms.ToolStripButton();
            this.TSTB_Recherche = new System.Windows.Forms.ToolStripTextBox();
            this.TC_Container.SuspendLayout();
            this.TS_Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // TC_Container
            // 
            this.TC_Container.Controls.Add(this.TP_Dialogues);
            this.TC_Container.Controls.Add(this.TP_Personnages);
            this.TC_Container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TC_Container.Location = new System.Drawing.Point(0, 25);
            this.TC_Container.Name = "TC_Container";
            this.TC_Container.SelectedIndex = 0;
            this.TC_Container.Size = new System.Drawing.Size(1228, 500);
            this.TC_Container.TabIndex = 0;
            // 
            // TP_Dialogues
            // 
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
            this.TP_Personnages.Size = new System.Drawing.Size(1220, 499);
            this.TP_Personnages.TabIndex = 1;
            this.TP_Personnages.Text = "Personnages";
            this.TP_Personnages.UseVisualStyleBackColor = true;
            // 
            // TS_Menu
            // 
            this.TS_Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSBT_Ajouter,
            this.TSBT_Supprimer,
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
    }
}

