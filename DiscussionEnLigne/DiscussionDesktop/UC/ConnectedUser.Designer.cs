
namespace DiscussionDesktop.UC
{
    partial class ConnectedUser
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
            this.chkbx = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // chkbx
            // 
            this.chkbx.AutoSize = true;
            this.chkbx.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkbx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkbx.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkbx.Location = new System.Drawing.Point(4, 4);
            this.chkbx.Name = "chkbx";
            this.chkbx.Size = new System.Drawing.Size(100, 24);
            this.chkbx.TabIndex = 0;
            this.chkbx.Text = "chkbx";
            this.chkbx.UseVisualStyleBackColor = true;
            this.chkbx.CheckedChanged += new System.EventHandler(this.chkbx_CheckedChanged);
            // 
            // ConnectedUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.Controls.Add(this.chkbx);
            this.Name = "ConnectedUser";
            this.Padding = new System.Windows.Forms.Padding(4);
            this.Size = new System.Drawing.Size(108, 32);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkbx;
    }
}
