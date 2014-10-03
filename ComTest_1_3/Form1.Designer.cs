namespace ComTest_1_3
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnGetSerialPorts = new System.Windows.Forms.Button();
            this.rtbIncomingData = new System.Windows.Forms.RichTextBox();
            this.cboPorts = new System.Windows.Forms.ComboBox();
            this.cboBaudRate = new System.Windows.Forms.ComboBox();
            this.btnPortState = new System.Windows.Forms.Button();
            this.lbavailablePorts = new System.Windows.Forms.Label();
            this.lbBaudRates = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.lbIncomingData = new System.Windows.Forms.Label();
            this.lbDataToSend = new System.Windows.Forms.Label();
            this.cboHandshake = new System.Windows.Forms.ComboBox();
            this.lbHS = new System.Windows.Forms.Label();
            this.cboDataBits = new System.Windows.Forms.ComboBox();
            this.lbDataBits = new System.Windows.Forms.Label();
            this.cboStopBits = new System.Windows.Forms.ComboBox();
            this.lbStopBits = new System.Windows.Forms.Label();
            this.cboParity = new System.Windows.Forms.ComboBox();
            this.lbParity = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGetSerialPorts
            // 
            this.btnGetSerialPorts.Location = new System.Drawing.Point(13, 13);
            this.btnGetSerialPorts.Name = "btnGetSerialPorts";
            this.btnGetSerialPorts.Size = new System.Drawing.Size(75, 23);
            this.btnGetSerialPorts.TabIndex = 0;
            this.btnGetSerialPorts.Text = "Ports";
            this.btnGetSerialPorts.UseVisualStyleBackColor = true;
            this.btnGetSerialPorts.Click += new System.EventHandler(this.btnGetSerialPorts_Click);
            // 
            // rtbIncomingData
            // 
            this.rtbIncomingData.Location = new System.Drawing.Point(10, 133);
            this.rtbIncomingData.Name = "rtbIncomingData";
            this.rtbIncomingData.Size = new System.Drawing.Size(259, 163);
            this.rtbIncomingData.TabIndex = 1;
            this.rtbIncomingData.Text = "";
            // 
            // cboPorts
            // 
            this.cboPorts.FormattingEnabled = true;
            this.cboPorts.Location = new System.Drawing.Point(178, 15);
            this.cboPorts.Name = "cboPorts";
            this.cboPorts.Size = new System.Drawing.Size(121, 21);
            this.cboPorts.TabIndex = 2;
            this.cboPorts.SelectedIndexChanged += new System.EventHandler(this.cboPorts_SelectedIndexChanged);
            // 
            // cboBaudRate
            // 
            this.cboBaudRate.FormattingEnabled = true;
            this.cboBaudRate.Location = new System.Drawing.Point(178, 43);
            this.cboBaudRate.Name = "cboBaudRate";
            this.cboBaudRate.Size = new System.Drawing.Size(121, 21);
            this.cboBaudRate.TabIndex = 3;
            this.cboBaudRate.SelectedIndexChanged += new System.EventHandler(this.cboBaudRate_SelectedIndexChanged);
            // 
            // btnPortState
            // 
            this.btnPortState.Location = new System.Drawing.Point(13, 41);
            this.btnPortState.Name = "btnPortState";
            this.btnPortState.Size = new System.Drawing.Size(75, 23);
            this.btnPortState.TabIndex = 4;
            this.btnPortState.Text = "closed";
            this.btnPortState.UseVisualStyleBackColor = true;
            this.btnPortState.Click += new System.EventHandler(this.btnPortState_Click);
            // 
            // lbavailablePorts
            // 
            this.lbavailablePorts.AutoSize = true;
            this.lbavailablePorts.Location = new System.Drawing.Point(94, 18);
            this.lbavailablePorts.Name = "lbavailablePorts";
            this.lbavailablePorts.Size = new System.Drawing.Size(78, 13);
            this.lbavailablePorts.TabIndex = 5;
            this.lbavailablePorts.Text = "available ports:";
            // 
            // lbBaudRates
            // 
            this.lbBaudRates.AutoSize = true;
            this.lbBaudRates.Location = new System.Drawing.Point(112, 46);
            this.lbBaudRates.Name = "lbBaudRates";
            this.lbBaudRates.Size = new System.Drawing.Size(60, 13);
            this.lbBaudRates.TabIndex = 6;
            this.lbBaudRates.Text = "baud rates:";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(284, 133);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(259, 163);
            this.richTextBox1.TabIndex = 7;
            this.richTextBox1.Text = "";
            // 
            // lbIncomingData
            // 
            this.lbIncomingData.AutoSize = true;
            this.lbIncomingData.Location = new System.Drawing.Point(10, 114);
            this.lbIncomingData.Name = "lbIncomingData";
            this.lbIncomingData.Size = new System.Drawing.Size(76, 13);
            this.lbIncomingData.TabIndex = 8;
            this.lbIncomingData.Text = "incoming data:";
            // 
            // lbDataToSend
            // 
            this.lbDataToSend.AutoSize = true;
            this.lbDataToSend.Location = new System.Drawing.Point(281, 114);
            this.lbDataToSend.Name = "lbDataToSend";
            this.lbDataToSend.Size = new System.Drawing.Size(69, 13);
            this.lbDataToSend.TabIndex = 9;
            this.lbDataToSend.Text = "data to send:";
            // 
            // cboHandshake
            // 
            this.cboHandshake.FormattingEnabled = true;
            this.cboHandshake.Location = new System.Drawing.Point(178, 72);
            this.cboHandshake.Name = "cboHandshake";
            this.cboHandshake.Size = new System.Drawing.Size(121, 21);
            this.cboHandshake.TabIndex = 10;
            // 
            // lbHS
            // 
            this.lbHS.AutoSize = true;
            this.lbHS.Location = new System.Drawing.Point(99, 75);
            this.lbHS.Name = "lbHS";
            this.lbHS.Size = new System.Drawing.Size(73, 13);
            this.lbHS.TabIndex = 11;
            this.lbHS.Text = "Handshaking:";
            // 
            // cboDataBits
            // 
            this.cboDataBits.FormattingEnabled = true;
            this.cboDataBits.Location = new System.Drawing.Point(422, 15);
            this.cboDataBits.Name = "cboDataBits";
            this.cboDataBits.Size = new System.Drawing.Size(121, 21);
            this.cboDataBits.TabIndex = 12;
            // 
            // lbDataBits
            // 
            this.lbDataBits.AutoSize = true;
            this.lbDataBits.Location = new System.Drawing.Point(366, 18);
            this.lbDataBits.Name = "lbDataBits";
            this.lbDataBits.Size = new System.Drawing.Size(50, 13);
            this.lbDataBits.TabIndex = 13;
            this.lbDataBits.Text = "data bits:";
            // 
            // cboStopBits
            // 
            this.cboStopBits.FormattingEnabled = true;
            this.cboStopBits.Location = new System.Drawing.Point(422, 43);
            this.cboStopBits.Name = "cboStopBits";
            this.cboStopBits.Size = new System.Drawing.Size(121, 21);
            this.cboStopBits.TabIndex = 14;
            // 
            // lbStopBits
            // 
            this.lbStopBits.AutoSize = true;
            this.lbStopBits.Location = new System.Drawing.Point(367, 46);
            this.lbStopBits.Name = "lbStopBits";
            this.lbStopBits.Size = new System.Drawing.Size(49, 13);
            this.lbStopBits.TabIndex = 15;
            this.lbStopBits.Text = "stop bits:";
            // 
            // cboParity
            // 
            this.cboParity.FormattingEnabled = true;
            this.cboParity.Location = new System.Drawing.Point(422, 70);
            this.cboParity.Name = "cboParity";
            this.cboParity.Size = new System.Drawing.Size(121, 21);
            this.cboParity.TabIndex = 16;
            // 
            // lbParity
            // 
            this.lbParity.AutoSize = true;
            this.lbParity.Location = new System.Drawing.Point(381, 75);
            this.lbParity.Name = "lbParity";
            this.lbParity.Size = new System.Drawing.Size(35, 13);
            this.lbParity.TabIndex = 17;
            this.lbParity.Text = "parity:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 306);
            this.Controls.Add(this.lbParity);
            this.Controls.Add(this.cboParity);
            this.Controls.Add(this.lbStopBits);
            this.Controls.Add(this.cboStopBits);
            this.Controls.Add(this.lbDataBits);
            this.Controls.Add(this.cboDataBits);
            this.Controls.Add(this.lbHS);
            this.Controls.Add(this.cboHandshake);
            this.Controls.Add(this.lbDataToSend);
            this.Controls.Add(this.lbIncomingData);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.lbBaudRates);
            this.Controls.Add(this.lbavailablePorts);
            this.Controls.Add(this.btnPortState);
            this.Controls.Add(this.cboBaudRate);
            this.Controls.Add(this.cboPorts);
            this.Controls.Add(this.rtbIncomingData);
            this.Controls.Add(this.btnGetSerialPorts);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGetSerialPorts;
        private System.Windows.Forms.RichTextBox rtbIncomingData;
        private System.Windows.Forms.ComboBox cboPorts;
        private System.Windows.Forms.ComboBox cboBaudRate;
        private System.Windows.Forms.Button btnPortState;
        private System.Windows.Forms.Label lbavailablePorts;
        private System.Windows.Forms.Label lbBaudRates;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label lbIncomingData;
        private System.Windows.Forms.Label lbDataToSend;
        private System.Windows.Forms.ComboBox cboHandshake;
        private System.Windows.Forms.Label lbHS;
        private System.Windows.Forms.ComboBox cboDataBits;
        private System.Windows.Forms.Label lbDataBits;
        private System.Windows.Forms.ComboBox cboStopBits;
        private System.Windows.Forms.Label lbStopBits;
        private System.Windows.Forms.ComboBox cboParity;
        private System.Windows.Forms.Label lbParity;
    }
}

