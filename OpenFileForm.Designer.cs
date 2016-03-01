namespace ORION
{
    partial class OpenFileForm
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
            this.importCSV = new System.Windows.Forms.Button();
            this.Button_Ok = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // importCSV
            // 
            this.importCSV.Location = new System.Drawing.Point(164, 48);
            this.importCSV.Name = "importCSV";
            this.importCSV.Size = new System.Drawing.Size(205, 69);
            this.importCSV.TabIndex = 0;
            this.importCSV.Text = "Import CSV";
            this.importCSV.UseVisualStyleBackColor = true;
            this.importCSV.Click += new System.EventHandler(this.importCSV_Click);
            // 
            // Button_Ok
            // 
            this.Button_Ok.Location = new System.Drawing.Point(43, 265);
            this.Button_Ok.Name = "Button_Ok";
            this.Button_Ok.Size = new System.Drawing.Size(132, 51);
            this.Button_Ok.TabIndex = 1;
            this.Button_Ok.Text = "Ok";
            this.Button_Ok.UseVisualStyleBackColor = true;
            this.Button_Ok.Click += new System.EventHandler(this.Button_Ok_Click);
            // 
            // OpenFileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 355);
            this.Controls.Add(this.Button_Ok);
            this.Controls.Add(this.importCSV);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "OpenFileForm";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button importCSV;
        private System.Windows.Forms.Button Button_Ok;
    }
}

