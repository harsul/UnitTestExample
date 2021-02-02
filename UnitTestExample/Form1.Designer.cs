
namespace UnitTestExample
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
            this.textBox_current = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Recie = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listBox_receipt = new System.Windows.Forms.ListBox();
            this.listBox_output = new System.Windows.Forms.ListBox();
            this.button_addReceipt = new System.Windows.Forms.Button();
            this.button_addOutput = new System.Windows.Forms.Button();
            this.textBox_receipt = new System.Windows.Forms.TextBox();
            this.textBox_output = new System.Windows.Forms.TextBox();
            this.dateTimePicker_receipt = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_output = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Recie.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_current
            // 
            this.textBox_current.Location = new System.Drawing.Point(59, 9);
            this.textBox_current.Name = "textBox_current";
            this.textBox_current.ReadOnly = true;
            this.textBox_current.Size = new System.Drawing.Size(100, 20);
            this.textBox_current.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Current";
            // 
            // Recie
            // 
            this.Recie.Controls.Add(this.label2);
            this.Recie.Controls.Add(this.dateTimePicker_receipt);
            this.Recie.Controls.Add(this.textBox_receipt);
            this.Recie.Controls.Add(this.button_addReceipt);
            this.Recie.Location = new System.Drawing.Point(15, 52);
            this.Recie.Name = "Recie";
            this.Recie.Size = new System.Drawing.Size(200, 100);
            this.Recie.TabIndex = 2;
            this.Recie.TabStop = false;
            this.Recie.Text = "Receipt";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dateTimePicker_output);
            this.groupBox1.Controls.Add(this.textBox_output);
            this.groupBox1.Controls.Add(this.button_addOutput);
            this.groupBox1.Location = new System.Drawing.Point(251, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Output";
            // 
            // listBox_receipt
            // 
            this.listBox_receipt.FormattingEnabled = true;
            this.listBox_receipt.Location = new System.Drawing.Point(15, 158);
            this.listBox_receipt.Name = "listBox_receipt";
            this.listBox_receipt.Size = new System.Drawing.Size(200, 277);
            this.listBox_receipt.TabIndex = 4;
            // 
            // listBox_output
            // 
            this.listBox_output.FormattingEnabled = true;
            this.listBox_output.Location = new System.Drawing.Point(251, 158);
            this.listBox_output.Name = "listBox_output";
            this.listBox_output.Size = new System.Drawing.Size(200, 277);
            this.listBox_output.TabIndex = 5;
            // 
            // button_addReceipt
            // 
            this.button_addReceipt.Location = new System.Drawing.Point(119, 71);
            this.button_addReceipt.Name = "button_addReceipt";
            this.button_addReceipt.Size = new System.Drawing.Size(75, 23);
            this.button_addReceipt.TabIndex = 0;
            this.button_addReceipt.Text = "Add";
            this.button_addReceipt.UseVisualStyleBackColor = true;
            this.button_addReceipt.Click += new System.EventHandler(this.button_addReceipt_Click);
            // 
            // button_addOutput
            // 
            this.button_addOutput.Location = new System.Drawing.Point(119, 71);
            this.button_addOutput.Name = "button_addOutput";
            this.button_addOutput.Size = new System.Drawing.Size(75, 23);
            this.button_addOutput.TabIndex = 1;
            this.button_addOutput.Text = "Add";
            this.button_addOutput.UseVisualStyleBackColor = true;
            this.button_addOutput.Click += new System.EventHandler(this.button_addOutput_Click);
            // 
            // textBox_receipt
            // 
            this.textBox_receipt.Location = new System.Drawing.Point(94, 36);
            this.textBox_receipt.Name = "textBox_receipt";
            this.textBox_receipt.Size = new System.Drawing.Size(100, 20);
            this.textBox_receipt.TabIndex = 6;
            // 
            // textBox_output
            // 
            this.textBox_output.Location = new System.Drawing.Point(94, 36);
            this.textBox_output.Name = "textBox_output";
            this.textBox_output.Size = new System.Drawing.Size(100, 20);
            this.textBox_output.TabIndex = 7;
            // 
            // dateTimePicker_receipt
            // 
            this.dateTimePicker_receipt.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_receipt.Location = new System.Drawing.Point(6, 36);
            this.dateTimePicker_receipt.Name = "dateTimePicker_receipt";
            this.dateTimePicker_receipt.Size = new System.Drawing.Size(82, 20);
            this.dateTimePicker_receipt.TabIndex = 7;
            // 
            // dateTimePicker_output
            // 
            this.dateTimePicker_output.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_output.Location = new System.Drawing.Point(6, 36);
            this.dateTimePicker_output.Name = "dateTimePicker_output";
            this.dateTimePicker_output.Size = new System.Drawing.Size(82, 20);
            this.dateTimePicker_output.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(116, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Quantity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(116, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Quantity";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 450);
            this.Controls.Add(this.listBox_output);
            this.Controls.Add(this.listBox_receipt);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Recie);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_current);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Recie.ResumeLayout(false);
            this.Recie.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_current;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox Recie;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker_receipt;
        private System.Windows.Forms.TextBox textBox_receipt;
        private System.Windows.Forms.Button button_addReceipt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker_output;
        private System.Windows.Forms.TextBox textBox_output;
        private System.Windows.Forms.Button button_addOutput;
        private System.Windows.Forms.ListBox listBox_receipt;
        private System.Windows.Forms.ListBox listBox_output;
    }
}

