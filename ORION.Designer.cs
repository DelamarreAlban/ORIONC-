namespace ORION
{
    partial class ORION
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importCSVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.classificationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.regressionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timeSeriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.ViewTabPage = new System.Windows.Forms.TabPage();
            this.AttributesTabPage = new System.Windows.Forms.TabPage();
            this.TextTabPage = new System.Windows.Forms.TabPage();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.selectionToolStripMenuItem,
            this.transformationToolStripMenuItem,
            this.classificationToolStripMenuItem,
            this.regressionToolStripMenuItem,
            this.timeSeriesToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(2319, 42);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importCSVToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(64, 38);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // importCSVToolStripMenuItem
            // 
            this.importCSVToolStripMenuItem.Name = "importCSVToolStripMenuItem";
            this.importCSVToolStripMenuItem.Size = new System.Drawing.Size(269, 38);
            this.importCSVToolStripMenuItem.Text = "Import CSV";
            this.importCSVToolStripMenuItem.Click += new System.EventHandler(this.importCSVToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(78, 38);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // selectionToolStripMenuItem
            // 
            this.selectionToolStripMenuItem.Name = "selectionToolStripMenuItem";
            this.selectionToolStripMenuItem.Size = new System.Drawing.Size(125, 38);
            this.selectionToolStripMenuItem.Text = "Selection";
            // 
            // transformationToolStripMenuItem
            // 
            this.transformationToolStripMenuItem.Name = "transformationToolStripMenuItem";
            this.transformationToolStripMenuItem.Size = new System.Drawing.Size(187, 38);
            this.transformationToolStripMenuItem.Text = "Transformation";
            // 
            // classificationToolStripMenuItem
            // 
            this.classificationToolStripMenuItem.Name = "classificationToolStripMenuItem";
            this.classificationToolStripMenuItem.Size = new System.Drawing.Size(165, 38);
            this.classificationToolStripMenuItem.Text = "Classification";
            // 
            // regressionToolStripMenuItem
            // 
            this.regressionToolStripMenuItem.Name = "regressionToolStripMenuItem";
            this.regressionToolStripMenuItem.Size = new System.Drawing.Size(142, 38);
            this.regressionToolStripMenuItem.Text = "Regression";
            // 
            // timeSeriesToolStripMenuItem
            // 
            this.timeSeriesToolStripMenuItem.Name = "timeSeriesToolStripMenuItem";
            this.timeSeriesToolStripMenuItem.Size = new System.Drawing.Size(150, 38);
            this.timeSeriesToolStripMenuItem.Text = "Time Series";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(82, 38);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(77, 38);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.ViewTabPage);
            this.tabControl1.Controls.Add(this.AttributesTabPage);
            this.tabControl1.Controls.Add(this.TextTabPage);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 42);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(2319, 1267);
            this.tabControl1.TabIndex = 1;
            // 
            // ViewTabPage
            // 
            this.ViewTabPage.Location = new System.Drawing.Point(8, 39);
            this.ViewTabPage.Name = "ViewTabPage";
            this.ViewTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.ViewTabPage.Size = new System.Drawing.Size(2303, 1220);
            this.ViewTabPage.TabIndex = 0;
            this.ViewTabPage.Text = "View";
            this.ViewTabPage.UseVisualStyleBackColor = true;
            // 
            // AttributesTabPage
            // 
            this.AttributesTabPage.Location = new System.Drawing.Point(8, 39);
            this.AttributesTabPage.Name = "AttributesTabPage";
            this.AttributesTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.AttributesTabPage.Size = new System.Drawing.Size(2303, 1220);
            this.AttributesTabPage.TabIndex = 1;
            this.AttributesTabPage.Text = "Attributes";
            this.AttributesTabPage.UseVisualStyleBackColor = true;
            // 
            // TextTabPage
            // 
            this.TextTabPage.Location = new System.Drawing.Point(8, 39);
            this.TextTabPage.Name = "TextTabPage";
            this.TextTabPage.Size = new System.Drawing.Size(2303, 1220);
            this.TextTabPage.TabIndex = 2;
            this.TextTabPage.Text = "Text";
            this.TextTabPage.UseVisualStyleBackColor = true;
            // 
            // ORION
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2319, 1309);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ORION";
            this.Text = "ORION";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem classificationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem regressionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem timeSeriesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importCSVToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage ViewTabPage;
        private System.Windows.Forms.TabPage AttributesTabPage;
        private System.Windows.Forms.TabPage TextTabPage;
    }
}