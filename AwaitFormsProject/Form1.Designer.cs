namespace AwaitFormsProject
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.value1 = new System.Windows.Forms.TextBox();
            this.value2 = new System.Windows.Forms.TextBox();
            this.result = new System.Windows.Forms.TextBox();
            this.delaySeconds = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.calculate = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.timesPressed = new System.Windows.Forms.TextBox();
            this.buttonPlusOne = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.isAsync = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // value1
            // 
            this.value1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.value1.Location = new System.Drawing.Point(22, 204);
            this.value1.Name = "value1";
            this.value1.Size = new System.Drawing.Size(108, 29);
            this.value1.TabIndex = 1;
            // 
            // value2
            // 
            this.value2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.value2.Location = new System.Drawing.Point(160, 204);
            this.value2.Name = "value2";
            this.value2.Size = new System.Drawing.Size(108, 29);
            this.value2.TabIndex = 2;
            // 
            // result
            // 
            this.result.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.result.Location = new System.Drawing.Point(84, 332);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(108, 29);
            this.result.TabIndex = 3;
            // 
            // delaySeconds
            // 
            this.delaySeconds.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.delaySeconds.Location = new System.Drawing.Point(296, 204);
            this.delaySeconds.Name = "delaySeconds";
            this.delaySeconds.Size = new System.Drawing.Size(108, 29);
            this.delaySeconds.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(819, 65);
            this.label1.TabIndex = 5;
            this.label1.Text = "Asynchronous programming example";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(22, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "Number 1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(160, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 21);
            this.label3.TabIndex = 7;
            this.label3.Text = "Number 2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(296, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 21);
            this.label4.TabIndex = 8;
            this.label4.Text = "Delay in seconds";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(22, 335);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 21);
            this.label5.TabIndex = 9;
            this.label5.Text = "Result:";
            // 
            // calculate
            // 
            this.calculate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.calculate.Location = new System.Drawing.Point(22, 251);
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(81, 29);
            this.calculate.TabIndex = 10;
            this.calculate.Text = "Calculate";
            this.calculate.UseVisualStyleBackColor = true;
            this.calculate.Click += new System.EventHandler(this.calculate_ClickAsync);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(630, 167);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 21);
            this.label6.TabIndex = 11;
            this.label6.Text = "Other Task";
            // 
            // timesPressed
            // 
            this.timesPressed.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.timesPressed.Location = new System.Drawing.Point(822, 204);
            this.timesPressed.Name = "timesPressed";
            this.timesPressed.Size = new System.Drawing.Size(108, 29);
            this.timesPressed.TabIndex = 12;
            this.timesPressed.Text = "0";
            // 
            // buttonPlusOne
            // 
            this.buttonPlusOne.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonPlusOne.Location = new System.Drawing.Point(630, 251);
            this.buttonPlusOne.Name = "buttonPlusOne";
            this.buttonPlusOne.Size = new System.Drawing.Size(81, 29);
            this.buttonPlusOne.TabIndex = 13;
            this.buttonPlusOne.Text = "+1";
            this.buttonPlusOne.UseVisualStyleBackColor = true;
            this.buttonPlusOne.Click += new System.EventHandler(this.buttonPlusOne_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(630, 207);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(186, 21);
            this.label7.TabIndex = 14;
            this.label7.Text = "Number of times pressed";
            // 
            // isAsync
            // 
            this.isAsync.AutoSize = true;
            this.isAsync.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.isAsync.Location = new System.Drawing.Point(22, 106);
            this.isAsync.Name = "isAsync";
            this.isAsync.Size = new System.Drawing.Size(298, 29);
            this.isAsync.TabIndex = 15;
            this.isAsync.TabStop = true;
            this.isAsync.Text = "Enable Asynchronous execution";
            this.isAsync.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(27F, 65F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 537);
            this.Controls.Add(this.isAsync);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.buttonPlusOne);
            this.Controls.Add(this.timesPressed);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.calculate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.delaySeconds);
            this.Controls.Add(this.result);
            this.Controls.Add(this.value2);
            this.Controls.Add(this.value1);
            this.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(12, 13, 12, 13);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox value1;
        private TextBox value2;
        private TextBox result;
        private TextBox delaySeconds;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button calculate;
        private Label label6;
        private TextBox timesPressed;
        private Button buttonPlusOne;
        private Label label7;
        private RadioButton isAsync;
    }
}