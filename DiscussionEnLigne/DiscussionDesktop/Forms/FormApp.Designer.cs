
namespace DiscussionDesktop
{
    partial class FormApp
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtMsg = new System.Windows.Forms.RichTextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.layout = new System.Windows.Forms.TableLayoutPanel();
            this.btnDecon = new System.Windows.Forms.Button();
            this.layoutUsers = new System.Windows.Forms.FlowLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.chkbxAucun = new System.Windows.Forms.CheckBox();
            this.chkbxTout = new System.Windows.Forms.CheckBox();
            this.layoutMsgs = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.layout.SuspendLayout();
            this.layoutUsers.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.tableLayoutPanel1.Controls.Add(this.txtMsg, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnSend, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.layoutMsgs, 2, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 81F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // txtMsg
            // 
            this.txtMsg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMsg.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMsg.Location = new System.Drawing.Point(179, 376);
            this.txtMsg.Name = "txtMsg";
            this.txtMsg.Size = new System.Drawing.Size(562, 61);
            this.txtMsg.TabIndex = 1;
            this.txtMsg.Text = "";
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.Color.Lavender;
            this.btnSend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSend.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSend.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSend.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua;
            this.btnSend.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkTurquoise;
            this.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSend.Location = new System.Drawing.Point(747, 376);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(34, 61);
            this.btnSend.TabIndex = 2;
            this.btnSend.Text = "➤";
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.layout);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(19, 12);
            this.panel1.Name = "panel1";
            this.tableLayoutPanel1.SetRowSpan(this.panel1, 2);
            this.panel1.Size = new System.Drawing.Size(154, 425);
            this.panel1.TabIndex = 1;
            // 
            // layout
            // 
            this.layout.BackColor = System.Drawing.Color.SkyBlue;
            this.layout.ColumnCount = 1;
            this.layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layout.Controls.Add(this.btnDecon, 0, 0);
            this.layout.Controls.Add(this.layoutUsers, 0, 1);
            this.layout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layout.Location = new System.Drawing.Point(0, 0);
            this.layout.Name = "layout";
            this.layout.RowCount = 2;
            this.layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.layout.Size = new System.Drawing.Size(152, 423);
            this.layout.TabIndex = 4;
            // 
            // btnDecon
            // 
            this.btnDecon.BackColor = System.Drawing.Color.Lavender;
            this.btnDecon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDecon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDecon.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnDecon.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua;
            this.btnDecon.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkTurquoise;
            this.btnDecon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDecon.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDecon.Location = new System.Drawing.Point(3, 3);
            this.btnDecon.Name = "btnDecon";
            this.btnDecon.Size = new System.Drawing.Size(146, 36);
            this.btnDecon.TabIndex = 0;
            this.btnDecon.Text = "Déconnecter";
            this.btnDecon.UseVisualStyleBackColor = false;
            this.btnDecon.Click += new System.EventHandler(this.btnDecon_Click);
            // 
            // layoutUsers
            // 
            this.layoutUsers.AutoScroll = true;
            this.layoutUsers.Controls.Add(this.panel3);
            this.layoutUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutUsers.Location = new System.Drawing.Point(0, 45);
            this.layoutUsers.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.layoutUsers.Name = "layoutUsers";
            this.layoutUsers.Size = new System.Drawing.Size(152, 378);
            this.layoutUsers.TabIndex = 1;
            this.layoutUsers.Resize += new System.EventHandler(this.layoutUsers_Resize);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.chkbxAucun);
            this.panel3.Controls.Add(this.chkbxTout);
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(146, 62);
            this.panel3.TabIndex = 0;
            // 
            // chkbxAucun
            // 
            this.chkbxAucun.AutoSize = true;
            this.chkbxAucun.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkbxAucun.Location = new System.Drawing.Point(6, 31);
            this.chkbxAucun.Name = "chkbxAucun";
            this.chkbxAucun.Size = new System.Drawing.Size(62, 20);
            this.chkbxAucun.TabIndex = 1;
            this.chkbxAucun.Text = "Aucun";
            this.chkbxAucun.UseVisualStyleBackColor = true;
            this.chkbxAucun.CheckedChanged += new System.EventHandler(this.chkbxAucun_CheckedChanged);
            // 
            // chkbxTout
            // 
            this.chkbxTout.AutoSize = true;
            this.chkbxTout.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkbxTout.Location = new System.Drawing.Point(6, 8);
            this.chkbxTout.Name = "chkbxTout";
            this.chkbxTout.Size = new System.Drawing.Size(50, 20);
            this.chkbxTout.TabIndex = 0;
            this.chkbxTout.Text = "Tout";
            this.chkbxTout.UseVisualStyleBackColor = true;
            this.chkbxTout.CheckedChanged += new System.EventHandler(this.chkbxTout_CheckedChanged);
            // 
            // layoutMsgs
            // 
            this.layoutMsgs.AutoScroll = true;
            this.layoutMsgs.BackColor = System.Drawing.Color.Lavender;
            this.layoutMsgs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tableLayoutPanel1.SetColumnSpan(this.layoutMsgs, 2);
            this.layoutMsgs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutMsgs.Location = new System.Drawing.Point(179, 12);
            this.layoutMsgs.Name = "layoutMsgs";
            this.layoutMsgs.Size = new System.Drawing.Size(602, 358);
            this.layoutMsgs.TabIndex = 3;
            this.layoutMsgs.Resize += new System.EventHandler(this.layoutMsgs_Resize);
            // 
            // FormApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FormApp";
            this.Text = "Discussion En Ligne";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormApp_FormClosed);
            this.Load += new System.EventHandler(this.FormApp_Load);
            this.Shown += new System.EventHandler(this.FormApp_Shown);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.layout.ResumeLayout(false);
            this.layoutUsers.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.RichTextBox txtMsg;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TableLayoutPanel layout;
        private System.Windows.Forms.Button btnDecon;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel layoutUsers;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.CheckBox chkbxAucun;
        private System.Windows.Forms.CheckBox chkbxTout;
        private System.Windows.Forms.FlowLayoutPanel layoutMsgs;
    }
}

