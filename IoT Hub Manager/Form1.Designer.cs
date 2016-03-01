namespace IoT_Hub_Manager
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
            this.lblConnectionString = new System.Windows.Forms.Label();
            this.txtConnectionString = new System.Windows.Forms.TextBox();
            this.lblDeviceName = new System.Windows.Forms.Label();
            this.txtDeviceName = new System.Windows.Forms.TextBox();
            this.btnRegisterDevice = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.btnDeRegister = new System.Windows.Forms.Button();
            this.btnClearOutput = new System.Windows.Forms.Button();
            this.btnGetDevices = new System.Windows.Forms.Button();
            this.btnGetDevice = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblConnectionString
            // 
            this.lblConnectionString.AutoSize = true;
            this.lblConnectionString.Location = new System.Drawing.Point(51, 41);
            this.lblConnectionString.Name = "lblConnectionString";
            this.lblConnectionString.Size = new System.Drawing.Size(201, 20);
            this.lblConnectionString.TabIndex = 0;
            this.lblConnectionString.Text = "IoT Hub Connection String:";
            // 
            // txtConnectionString
            // 
            this.txtConnectionString.Location = new System.Drawing.Point(254, 38);
            this.txtConnectionString.Name = "txtConnectionString";
            this.txtConnectionString.Size = new System.Drawing.Size(1148, 26);
            this.txtConnectionString.TabIndex = 1;
            // 
            // lblDeviceName
            // 
            this.lblDeviceName.AutoSize = true;
            this.lblDeviceName.Location = new System.Drawing.Point(141, 95);
            this.lblDeviceName.Name = "lblDeviceName";
            this.lblDeviceName.Size = new System.Drawing.Size(107, 20);
            this.lblDeviceName.TabIndex = 2;
            this.lblDeviceName.Text = "Device Name:";
            // 
            // txtDeviceName
            // 
            this.txtDeviceName.Location = new System.Drawing.Point(254, 92);
            this.txtDeviceName.Name = "txtDeviceName";
            this.txtDeviceName.Size = new System.Drawing.Size(332, 26);
            this.txtDeviceName.TabIndex = 3;
            this.txtDeviceName.Text = "Device1";
            // 
            // btnRegisterDevice
            // 
            this.btnRegisterDevice.Location = new System.Drawing.Point(55, 156);
            this.btnRegisterDevice.Name = "btnRegisterDevice";
            this.btnRegisterDevice.Size = new System.Drawing.Size(120, 38);
            this.btnRegisterDevice.TabIndex = 4;
            this.btnRegisterDevice.Text = "Register";
            this.btnRegisterDevice.UseVisualStyleBackColor = true;
            this.btnRegisterDevice.Click += new System.EventHandler(this.btnRegisterDevice_Click);
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(55, 217);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResult.Size = new System.Drawing.Size(1347, 324);
            this.txtResult.TabIndex = 5;
            // 
            // btnDeRegister
            // 
            this.btnDeRegister.Location = new System.Drawing.Point(204, 156);
            this.btnDeRegister.Name = "btnDeRegister";
            this.btnDeRegister.Size = new System.Drawing.Size(120, 38);
            this.btnDeRegister.TabIndex = 6;
            this.btnDeRegister.Text = "DeRegister";
            this.btnDeRegister.UseVisualStyleBackColor = true;
            this.btnDeRegister.Click += new System.EventHandler(this.btnDeRegister_Click);
            // 
            // btnClearOutput
            // 
            this.btnClearOutput.Location = new System.Drawing.Point(662, 156);
            this.btnClearOutput.Name = "btnClearOutput";
            this.btnClearOutput.Size = new System.Drawing.Size(120, 38);
            this.btnClearOutput.TabIndex = 9;
            this.btnClearOutput.Text = "Clear Output";
            this.btnClearOutput.UseVisualStyleBackColor = true;
            this.btnClearOutput.Click += new System.EventHandler(this.btnClearOutput_Click);
            // 
            // btnGetDevices
            // 
            this.btnGetDevices.Location = new System.Drawing.Point(511, 156);
            this.btnGetDevices.Name = "btnGetDevices";
            this.btnGetDevices.Size = new System.Drawing.Size(120, 38);
            this.btnGetDevices.TabIndex = 10;
            this.btnGetDevices.Text = "Get Devices";
            this.btnGetDevices.UseVisualStyleBackColor = true;
            this.btnGetDevices.Click += new System.EventHandler(this.btnGetDevices_Click);
            // 
            // btnGetDevice
            // 
            this.btnGetDevice.Location = new System.Drawing.Point(356, 156);
            this.btnGetDevice.Name = "btnGetDevice";
            this.btnGetDevice.Size = new System.Drawing.Size(120, 38);
            this.btnGetDevice.TabIndex = 11;
            this.btnGetDevice.Text = "Get Device";
            this.btnGetDevice.UseVisualStyleBackColor = true;
            this.btnGetDevice.Click += new System.EventHandler(this.btnGetDevice_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1455, 568);
            this.Controls.Add(this.btnGetDevice);
            this.Controls.Add(this.btnGetDevices);
            this.Controls.Add(this.btnClearOutput);
            this.Controls.Add(this.btnDeRegister);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.btnRegisterDevice);
            this.Controls.Add(this.txtDeviceName);
            this.Controls.Add(this.lblDeviceName);
            this.Controls.Add(this.txtConnectionString);
            this.Controls.Add(this.lblConnectionString);
            this.Name = "Form1";
            this.Text = "IoT Hub Manager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblConnectionString;
        private System.Windows.Forms.TextBox txtConnectionString;
        private System.Windows.Forms.Label lblDeviceName;
        private System.Windows.Forms.TextBox txtDeviceName;
        private System.Windows.Forms.Button btnRegisterDevice;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button btnDeRegister;
        private System.Windows.Forms.Button btnClearOutput;
        private System.Windows.Forms.Button btnGetDevices;
        private System.Windows.Forms.Button btnGetDevice;
    }
}

