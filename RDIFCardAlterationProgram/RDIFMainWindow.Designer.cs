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
            this.getCard = new System.Windows.Forms.Button();
            this.CardKeyDetails = new System.Windows.Forms.Label();
            this.manData = new System.Windows.Forms.TextBox();
            this.dataWriteLabel = new System.Windows.Forms.Label();
            this.dataWriteBox = new System.Windows.Forms.TextBox();
            this.DataWrite = new System.Windows.Forms.Button();
            this.GetDataButton = new System.Windows.Forms.Button();
            this.dataRead = new System.Windows.Forms.Button();
            this.DumpData = new System.Windows.Forms.Button();
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
            // getCard
            // 
            this.getCard.Location = new System.Drawing.Point(13, 76);
            this.getCard.Name = "getCard";
            this.getCard.Size = new System.Drawing.Size(223, 23);
            this.getCard.TabIndex = 2;
            this.getCard.Text = "Check Card";
            this.getCard.UseVisualStyleBackColor = true;
            this.getCard.Click += new System.EventHandler(this.getCard_Click);
            // 
            // CardKeyDetails
            // 
            this.CardKeyDetails.AutoSize = true;
            this.CardKeyDetails.Location = new System.Drawing.Point(13, 126);
            this.CardKeyDetails.Name = "CardKeyDetails";
            this.CardKeyDetails.Size = new System.Drawing.Size(53, 13);
            this.CardKeyDetails.TabIndex = 3;
            this.CardKeyDetails.Text = "Card Key:";
            // 
            // manData
            // 
            this.manData.Location = new System.Drawing.Point(121, 119);
            this.manData.Name = "manData";
            this.manData.Size = new System.Drawing.Size(125, 20);
            this.manData.TabIndex = 4;
            // 
            // dataWriteLabel
            // 
            this.dataWriteLabel.AutoSize = true;
            this.dataWriteLabel.Location = new System.Drawing.Point(13, 150);
            this.dataWriteLabel.Name = "dataWriteLabel";
            this.dataWriteLabel.Size = new System.Drawing.Size(102, 13);
            this.dataWriteLabel.TabIndex = 5;
            this.dataWriteLabel.Text = "Data To Be Written:";
            // 
            // dataWriteBox
            // 
            this.dataWriteBox.Location = new System.Drawing.Point(121, 147);
            this.dataWriteBox.Name = "dataWriteBox";
            this.dataWriteBox.Size = new System.Drawing.Size(125, 20);
            this.dataWriteBox.TabIndex = 6;
            // 
            // DataWrite
            // 
            this.DataWrite.Location = new System.Drawing.Point(16, 214);
            this.DataWrite.Name = "DataWrite";
            this.DataWrite.Size = new System.Drawing.Size(223, 23);
            this.DataWrite.TabIndex = 7;
            this.DataWrite.Text = "Write Data To Card";
            this.DataWrite.UseVisualStyleBackColor = true;
            this.DataWrite.Click += new System.EventHandler(this.DataWrite_Click);
            // 
            // GetDataButton
            // 
            this.GetDataButton.Location = new System.Drawing.Point(16, 173);
            this.GetDataButton.Name = "GetDataButton";
            this.GetDataButton.Size = new System.Drawing.Size(223, 23);
            this.GetDataButton.TabIndex = 8;
            this.GetDataButton.Text = "Get Data to Be Written To Card";
            this.GetDataButton.UseVisualStyleBackColor = true;
            this.GetDataButton.Click += new System.EventHandler(this.GetDataButton_Click);
            // 
            // dataRead
            // 
            this.dataRead.Location = new System.Drawing.Point(16, 243);
            this.dataRead.Name = "dataRead";
            this.dataRead.Size = new System.Drawing.Size(223, 23);
            this.dataRead.TabIndex = 9;
            this.dataRead.Text = "Read Assinged Data";
            this.dataRead.UseVisualStyleBackColor = true;
            this.dataRead.Click += new System.EventHandler(this.dataRead_Click);
            // 
            // DumpData
            // 
            this.DumpData.Location = new System.Drawing.Point(16, 289);
            this.DumpData.Name = "DumpData";
            this.DumpData.Size = new System.Drawing.Size(75, 23);
            this.DumpData.TabIndex = 10;
            this.DumpData.Text = "Dump Data:";
            this.DumpData.UseVisualStyleBackColor = true;
            this.DumpData.Click += new System.EventHandler(this.DumpData_Click);
            // 
            // RDIFMainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 347);
            this.Controls.Add(this.DumpData);
            this.Controls.Add(this.dataRead);
            this.Controls.Add(this.GetDataButton);
            this.Controls.Add(this.DataWrite);
            this.Controls.Add(this.dataWriteBox);
            this.Controls.Add(this.dataWriteLabel);
            this.Controls.Add(this.manData);
            this.Controls.Add(this.CardKeyDetails);
            this.Controls.Add(this.getCard);
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
        private System.Windows.Forms.Button getCard;
        private System.Windows.Forms.Label CardKeyDetails;
        private System.Windows.Forms.TextBox manData;
        private System.Windows.Forms.Label dataWriteLabel;
        private System.Windows.Forms.TextBox dataWriteBox;
        private System.Windows.Forms.Button DataWrite;
        private System.Windows.Forms.Button GetDataButton;
        private System.Windows.Forms.Button dataRead;
        private System.Windows.Forms.Button DumpData;
    }
}

