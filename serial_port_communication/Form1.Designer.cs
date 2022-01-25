
namespace serial_port_communication
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Refresh_button = new System.Windows.Forms.Button();
            this.COM_comboBox = new System.Windows.Forms.ComboBox();
            this.Baud_Rate_comboBox = new System.Windows.Forms.ComboBox();
            this.Data_Bits_comboBox = new System.Windows.Forms.ComboBox();
            this.Stop_bits_comboBox = new System.Windows.Forms.ComboBox();
            this.Parity_comboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Connect_button = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Send_button = new System.Windows.Forms.Button();
            this.SendTextBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Read_button = new System.Windows.Forms.Button();
            this.ReceivedTextBox = new System.Windows.Forms.TextBox();
            this.Clear_button = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Refresh_button
            // 
            resources.ApplyResources(this.Refresh_button, "Refresh_button");
            this.Refresh_button.Name = "Refresh_button";
            this.Refresh_button.UseVisualStyleBackColor = true;
            this.Refresh_button.Click += new System.EventHandler(this.Refresh_button_Click);
            // 
            // COM_comboBox
            // 
            this.COM_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.COM_comboBox, "COM_comboBox");
            this.COM_comboBox.FormattingEnabled = true;
            this.COM_comboBox.Name = "COM_comboBox";
            // 
            // Baud_Rate_comboBox
            // 
            this.Baud_Rate_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.Baud_Rate_comboBox, "Baud_Rate_comboBox");
            this.Baud_Rate_comboBox.FormattingEnabled = true;
            this.Baud_Rate_comboBox.Items.AddRange(new object[] {
            resources.GetString("Baud_Rate_comboBox.Items"),
            resources.GetString("Baud_Rate_comboBox.Items1"),
            resources.GetString("Baud_Rate_comboBox.Items2"),
            resources.GetString("Baud_Rate_comboBox.Items3"),
            resources.GetString("Baud_Rate_comboBox.Items4"),
            resources.GetString("Baud_Rate_comboBox.Items5"),
            resources.GetString("Baud_Rate_comboBox.Items6"),
            resources.GetString("Baud_Rate_comboBox.Items7")});
            this.Baud_Rate_comboBox.Name = "Baud_Rate_comboBox";
            // 
            // Data_Bits_comboBox
            // 
            this.Data_Bits_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.Data_Bits_comboBox, "Data_Bits_comboBox");
            this.Data_Bits_comboBox.FormattingEnabled = true;
            this.Data_Bits_comboBox.Items.AddRange(new object[] {
            resources.GetString("Data_Bits_comboBox.Items"),
            resources.GetString("Data_Bits_comboBox.Items1"),
            resources.GetString("Data_Bits_comboBox.Items2"),
            resources.GetString("Data_Bits_comboBox.Items3")});
            this.Data_Bits_comboBox.Name = "Data_Bits_comboBox";
            // 
            // Stop_bits_comboBox
            // 
            this.Stop_bits_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.Stop_bits_comboBox, "Stop_bits_comboBox");
            this.Stop_bits_comboBox.FormattingEnabled = true;
            this.Stop_bits_comboBox.Items.AddRange(new object[] {
            resources.GetString("Stop_bits_comboBox.Items"),
            resources.GetString("Stop_bits_comboBox.Items1"),
            resources.GetString("Stop_bits_comboBox.Items2")});
            this.Stop_bits_comboBox.Name = "Stop_bits_comboBox";
            // 
            // Parity_comboBox
            // 
            this.Parity_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.Parity_comboBox, "Parity_comboBox");
            this.Parity_comboBox.FormattingEnabled = true;
            this.Parity_comboBox.Items.AddRange(new object[] {
            resources.GetString("Parity_comboBox.Items"),
            resources.GetString("Parity_comboBox.Items1"),
            resources.GetString("Parity_comboBox.Items2"),
            resources.GetString("Parity_comboBox.Items3"),
            resources.GetString("Parity_comboBox.Items4"),
            resources.GetString("Parity_comboBox.Items5")});
            this.Parity_comboBox.Name = "Parity_comboBox";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // Connect_button
            // 
            this.Connect_button.BackColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this.Connect_button, "Connect_button");
            this.Connect_button.Name = "Connect_button";
            this.Connect_button.UseVisualStyleBackColor = false;
            this.Connect_button.Click += new System.EventHandler(this.Connect_button_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Send_button);
            this.groupBox1.Controls.Add(this.SendTextBox);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // Send_button
            // 
            resources.ApplyResources(this.Send_button, "Send_button");
            this.Send_button.Name = "Send_button";
            this.Send_button.UseVisualStyleBackColor = true;
            this.Send_button.Click += new System.EventHandler(this.Send_button_Click);
            // 
            // SendTextBox
            // 
            resources.ApplyResources(this.SendTextBox, "SendTextBox");
            this.SendTextBox.Name = "SendTextBox";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Read_button);
            this.groupBox2.Controls.Add(this.ReceivedTextBox);
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // Read_button
            // 
            resources.ApplyResources(this.Read_button, "Read_button");
            this.Read_button.Name = "Read_button";
            this.Read_button.UseVisualStyleBackColor = true;
            this.Read_button.Click += new System.EventHandler(this.Read_button_Click);
            // 
            // ReceivedTextBox
            // 
            resources.ApplyResources(this.ReceivedTextBox, "ReceivedTextBox");
            this.ReceivedTextBox.Name = "ReceivedTextBox";
            this.ReceivedTextBox.ReadOnly = true;
            // 
            // Clear_button
            // 
            resources.ApplyResources(this.Clear_button, "Clear_button");
            this.Clear_button.Name = "Clear_button";
            this.Clear_button.UseVisualStyleBackColor = true;
            this.Clear_button.Click += new System.EventHandler(this.Clear_button_Click);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.Clear_button);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Connect_button);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Parity_comboBox);
            this.Controls.Add(this.Stop_bits_comboBox);
            this.Controls.Add(this.Data_Bits_comboBox);
            this.Controls.Add(this.Baud_Rate_comboBox);
            this.Controls.Add(this.COM_comboBox);
            this.Controls.Add(this.Refresh_button);
            this.Name = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Refresh_button;
        private System.Windows.Forms.ComboBox COM_comboBox;
        private System.Windows.Forms.ComboBox Baud_Rate_comboBox;
        private System.Windows.Forms.ComboBox Data_Bits_comboBox;
        private System.Windows.Forms.ComboBox Stop_bits_comboBox;
        private System.Windows.Forms.ComboBox Parity_comboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Connect_button;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Send_button;
        private System.Windows.Forms.TextBox SendTextBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Read_button;
        private System.Windows.Forms.TextBox ReceivedTextBox;
        private System.Windows.Forms.Button Clear_button;
        private System.IO.Ports.SerialPort serialPort1;
    }
}

