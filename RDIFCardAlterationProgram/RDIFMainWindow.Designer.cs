namespace RDIFCardAlterationProgram
{
    partial class RDIFMainWindow
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
            this.GetComPort = new System.Windows.Forms.Button();
            this.PortName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // GetComPort
            // 
            this.GetComPort.Location = new System.Drawing.Point(13, 13);
            this.GetComPort.Name = "GetComPort";
            this.GetComPort.Size = new System.Drawing.Size(223, 23);
            this.GetComPort.TabIndex = 0;
            this.GetComPort.Text = "Check For Reader Connection";
            this.GetComPort.UseVisualStyleBackColor = true;
            this.GetComPort.Click += new System.EventHandler(this.GetComPort_Click);
            // 
            // PortName
            // 
            this.PortName.AutoSize = true;
            this.PortName.Location = new System.Drawing.Point(13, 43);
            this.PortName.Name = "PortName";
            this.PortName.Size = new System.Drawing.Size(35, 13);
            this.PortName.TabIndex = 1;
            this.PortName.Text = "label1";
            // 
            // RDIFMainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.PortName);
            this.Controls.Add(this.GetComPort);
            this.Name = "RDIFMainWindow";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GetComPort;
        private System.Windows.Forms.Label PortName;
    }
}

