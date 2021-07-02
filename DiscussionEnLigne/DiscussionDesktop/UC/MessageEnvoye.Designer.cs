
namespace DiscussionDesktop.UC
{
    partial class MessageEnvoye
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.dateTxt = new System.Windows.Forms.Label();
            this.receiversTxt = new System.Windows.Forms.Label();
            this.msgTxt = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(404, 71);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.SkyBlue;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.dateTxt, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.receiversTxt, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.msgTxt, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(83, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(318, 65);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // dateTxt
            // 
            this.dateTxt.AutoSize = true;
            this.dateTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateTxt.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTxt.ForeColor = System.Drawing.Color.DimGray;
            this.dateTxt.Location = new System.Drawing.Point(3, 45);
            this.dateTxt.Margin = new System.Windows.Forms.Padding(3);
            this.dateTxt.Name = "dateTxt";
            this.dateTxt.Size = new System.Drawing.Size(312, 17);
            this.dateTxt.TabIndex = 1;
            // 
            // receiversTxt
            // 
            this.receiversTxt.AutoSize = true;
            this.receiversTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.receiversTxt.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.receiversTxt.ForeColor = System.Drawing.Color.Gray;
            this.receiversTxt.Location = new System.Drawing.Point(3, 3);
            this.receiversTxt.Margin = new System.Windows.Forms.Padding(3);
            this.receiversTxt.Name = "receiversTxt";
            this.receiversTxt.Size = new System.Drawing.Size(312, 14);
            this.receiversTxt.TabIndex = 0;
            this.receiversTxt.Text = "Envoyé à : ";
            // 
            // msgTxt
            // 
            this.msgTxt.AutoSize = true;
            this.msgTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.msgTxt.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msgTxt.Location = new System.Drawing.Point(3, 23);
            this.msgTxt.Margin = new System.Windows.Forms.Padding(3);
            this.msgTxt.Name = "msgTxt";
            this.msgTxt.Size = new System.Drawing.Size(312, 16);
            this.msgTxt.TabIndex = 2;
            this.msgTxt.Resize += new System.EventHandler(this.msgTxt_Resize);
            // 
            // MessageEnvoye
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MessageEnvoye";
            this.Size = new System.Drawing.Size(404, 71);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label receiversTxt;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label dateTxt;
        private System.Windows.Forms.Label msgTxt;
    }
}
