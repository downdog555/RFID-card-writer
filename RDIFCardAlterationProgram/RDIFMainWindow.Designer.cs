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
            this.AccessLevelLabel = new System.Windows.Forms.Label();
            this.accessLevel = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataAsigned = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // GetComPort
            // 
            this.GetComPort.Location = new System.Drawing.Point(6, 19);
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
            this.PortName.Location = new System.Drawing.Point(312, 29);
            this.PortName.Name = "PortName";
            this.PortName.Size = new System.Drawing.Size(53, 13);
            this.PortName.TabIndex = 1;
            this.PortName.Text = "Unknown";
            // 
            // getCard
            // 
            this.getCard.Location = new System.Drawing.Point(6, 19);
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
            this.CardKeyDetails.Location = new System.Drawing.Point(6, 52);
            this.CardKeyDetails.Name = "CardKeyDetails";
            this.CardKeyDetails.Size = new System.Drawing.Size(53, 13);
            this.CardKeyDetails.TabIndex = 3;
            this.CardKeyDetails.Text = "Card Key:";
            // 
            // manData
            // 
            this.manData.Location = new System.Drawing.Point(65, 45);
            this.manData.Name = "manData";
            this.manData.Size = new System.Drawing.Size(125, 20);
            this.manData.TabIndex = 4;
            // 
            // dataWriteLabel
            // 
            this.dataWriteLabel.AutoSize = true;
            this.dataWriteLabel.Location = new System.Drawing.Point(6, 52);
            this.dataWriteLabel.Name = "dataWriteLabel";
            this.dataWriteLabel.Size = new System.Drawing.Size(102, 13);
            this.dataWriteLabel.TabIndex = 5;
            this.dataWriteLabel.Text = "Data To Be Written:";
            // 
            // dataWriteBox
            // 
            this.dataWriteBox.Location = new System.Drawing.Point(114, 45);
            this.dataWriteBox.Name = "dataWriteBox";
            this.dataWriteBox.Size = new System.Drawing.Size(125, 20);
            this.dataWriteBox.TabIndex = 6;
            // 
            // DataWrite
            // 
            this.DataWrite.Location = new System.Drawing.Point(0, 19);
            this.DataWrite.Name = "DataWrite";
            this.DataWrite.Size = new System.Drawing.Size(223, 23);
            this.DataWrite.TabIndex = 7;
            this.DataWrite.Text = "Write Data To Card";
            this.DataWrite.UseVisualStyleBackColor = true;
            this.DataWrite.Click += new System.EventHandler(this.DataWrite_Click);
            // 
            // GetDataButton
            // 
            this.GetDataButton.Location = new System.Drawing.Point(3, 19);
            this.GetDataButton.Name = "GetDataButton";
            this.GetDataButton.Size = new System.Drawing.Size(223, 23);
            this.GetDataButton.TabIndex = 8;
            this.GetDataButton.Text = "Get Data to Be Written To Card";
            this.GetDataButton.UseVisualStyleBackColor = true;
            this.GetDataButton.Click += new System.EventHandler(this.GetDataButton_Click);
            // 
            // dataRead
            // 
            this.dataRead.Location = new System.Drawing.Point(6, 19);
            this.dataRead.Name = "dataRead";
            this.dataRead.Size = new System.Drawing.Size(223, 23);
            this.dataRead.TabIndex = 9;
            this.dataRead.Text = "Read Assinged Data";
            this.dataRead.UseVisualStyleBackColor = true;
            this.dataRead.Click += new System.EventHandler(this.dataRead_Click);
            // 
            // AccessLevelLabel
            // 
            this.AccessLevelLabel.AutoSize = true;
            this.AccessLevelLabel.Location = new System.Drawing.Point(6, 78);
            this.AccessLevelLabel.Name = "AccessLevelLabel";
            this.AccessLevelLabel.Size = new System.Drawing.Size(74, 13);
            this.AccessLevelLabel.TabIndex = 11;
            this.AccessLevelLabel.Text = "Access Level:";
            // 
            // accessLevel
            // 
            this.accessLevel.Location = new System.Drawing.Point(114, 71);
            this.accessLevel.Name = "accessLevel";
            this.accessLevel.Size = new System.Drawing.Size(125, 20);
            this.accessLevel.TabIndex = 12;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.GetComPort);
            this.groupBox1.Controls.Add(this.PortName);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(382, 50);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Check For Reader Connection";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(253, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Com Port:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.getCard);
            this.groupBox2.Controls.Add(this.CardKeyDetails);
            this.groupBox2.Controls.Add(this.manData);
            this.groupBox2.Location = new System.Drawing.Point(13, 70);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(382, 80);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Get Manafuacturer Data";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataAsigned);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.GetDataButton);
            this.groupBox3.Controls.Add(this.dataWriteLabel);
            this.groupBox3.Controls.Add(this.dataWriteBox);
            this.groupBox3.Controls.Add(this.accessLevel);
            this.groupBox3.Controls.Add(this.AccessLevelLabel);
            this.groupBox3.Location = new System.Drawing.Point(13, 157);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(382, 149);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Get Data to Be Assigned";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.DataWrite);
            this.groupBox4.Location = new System.Drawing.Point(16, 312);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(379, 49);
            this.groupBox4.TabIndex = 16;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Write Data";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dataRead);
            this.groupBox5.Location = new System.Drawing.Point(16, 367);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(379, 54);
            this.groupBox5.TabIndex = 17;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Check Data";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Our Data:";
            // 
            // dataAsigned
            // 
            this.dataAsigned.Location = new System.Drawing.Point(114, 102);
            this.dataAsigned.Name = "dataAsigned";
            this.dataAsigned.Size = new System.Drawing.Size(125, 20);
            this.dataAsigned.TabIndex = 14;
            // 
            // RDIFMainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 433);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "RDIFMainWindow";
            this.Text = "Card Writer";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Label AccessLevelLabel;
        private System.Windows.Forms.TextBox accessLevel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox dataAsigned;
        private System.Windows.Forms.Label label2;
    }
}

