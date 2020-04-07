namespace MoveWithoutHeader
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pnPageContainet = new System.Windows.Forms.Panel();
            this.flpCaption = new System.Windows.Forms.FlowLayoutPanel();
            this.tsbMinimize = new System.Windows.Forms.ToolStripButton();
            this.tsbMaximize = new System.Windows.Forms.ToolStripButton();
            this.tsbNormal = new System.Windows.Forms.ToolStripButton();
            this.tsbClose = new System.Windows.Forms.ToolStripButton();
            this.tsBoxControls = new System.Windows.Forms.ToolStrip();
            this.tableLayoutPanel1.SuspendLayout();
            this.tsBoxControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.Window;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.tsBoxControls, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.flpCaption, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pnPageContainet, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(1, 1);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(798, 448);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // pnPageContainet
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.pnPageContainet, 2);
            this.pnPageContainet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnPageContainet.Location = new System.Drawing.Point(0, 25);
            this.pnPageContainet.Margin = new System.Windows.Forms.Padding(0);
            this.pnPageContainet.Name = "pnPageContainet";
            this.pnPageContainet.Size = new System.Drawing.Size(798, 423);
            this.pnPageContainet.TabIndex = 2;
            // 
            // flpCaption
            // 
            this.flpCaption.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.flpCaption.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpCaption.Location = new System.Drawing.Point(0, 0);
            this.flpCaption.Margin = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.flpCaption.Name = "flpCaption";
            this.flpCaption.Size = new System.Drawing.Size(698, 24);
            this.flpCaption.TabIndex = 1;
            this.flpCaption.MouseDown += new System.Windows.Forms.MouseEventHandler(this.flpCaption_MouseDown);
            this.flpCaption.MouseMove += new System.Windows.Forms.MouseEventHandler(this.flpCaption_MouseMove);
            this.flpCaption.MouseUp += new System.Windows.Forms.MouseEventHandler(this.flpCaption_MouseUp);
            // 
            // tsbMinimize
            // 
            this.tsbMinimize.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbMinimize.Image = ((System.Drawing.Image)(resources.GetObject("tsbMinimize.Image")));
            this.tsbMinimize.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbMinimize.Name = "tsbMinimize";
            this.tsbMinimize.Size = new System.Drawing.Size(23, 20);
            this.tsbMinimize.Text = "toolStripButton1";
            this.tsbMinimize.Click += new System.EventHandler(this.tsbMinimize_Click);
            // 
            // tsbMaximize
            // 
            this.tsbMaximize.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbMaximize.Image = ((System.Drawing.Image)(resources.GetObject("tsbMaximize.Image")));
            this.tsbMaximize.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbMaximize.Name = "tsbMaximize";
            this.tsbMaximize.Size = new System.Drawing.Size(23, 20);
            this.tsbMaximize.Text = "toolStripButton2";
            this.tsbMaximize.Click += new System.EventHandler(this.tsbMaximize_Click);
            // 
            // tsbNormal
            // 
            this.tsbNormal.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbNormal.Image = ((System.Drawing.Image)(resources.GetObject("tsbNormal.Image")));
            this.tsbNormal.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNormal.Name = "tsbNormal";
            this.tsbNormal.Size = new System.Drawing.Size(23, 20);
            this.tsbNormal.Text = "toolStripButton1";
            this.tsbNormal.Visible = false;
            this.tsbNormal.Click += new System.EventHandler(this.tsbNormal_Click);
            // 
            // tsbClose
            // 
            this.tsbClose.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbClose.Image = ((System.Drawing.Image)(resources.GetObject("tsbClose.Image")));
            this.tsbClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbClose.Name = "tsbClose";
            this.tsbClose.Size = new System.Drawing.Size(23, 20);
            this.tsbClose.Text = "toolStripButton3";
            this.tsbClose.Click += new System.EventHandler(this.tsbClose_Click);
            // 
            // tsBoxControls
            // 
            this.tsBoxControls.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tsBoxControls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tsBoxControls.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsBoxControls.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbMinimize,
            this.tsbMaximize,
            this.tsbNormal,
            this.tsbClose});
            this.tsBoxControls.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.tsBoxControls.Location = new System.Drawing.Point(698, 0);
            this.tsBoxControls.Name = "tsBoxControls";
            this.tsBoxControls.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.tsBoxControls.ShowItemToolTips = false;
            this.tsBoxControls.Size = new System.Drawing.Size(100, 25);
            this.tsBoxControls.TabIndex = 0;
            this.tsBoxControls.Text = "toolStrip1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.SystemColors.Control;
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tsBoxControls.ResumeLayout(false);
            this.tsBoxControls.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flpCaption;
        private System.Windows.Forms.Panel pnPageContainet;
        private System.Windows.Forms.ToolStrip tsBoxControls;
        private System.Windows.Forms.ToolStripButton tsbMinimize;
        private System.Windows.Forms.ToolStripButton tsbMaximize;
        private System.Windows.Forms.ToolStripButton tsbNormal;
        private System.Windows.Forms.ToolStripButton tsbClose;
    }
}

