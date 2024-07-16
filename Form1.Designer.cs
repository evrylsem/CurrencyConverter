namespace Currency
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            amountInput = new TextBox();
            label1 = new Label();
            fromBox = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            toBox = new ComboBox();
            label4 = new Label();
            resultOutput = new TextBox();
            convertBtn = new Button();
            button2 = new Button();
            panel2 = new Panel();
            toRate = new Label();
            label7 = new Label();
            fromRate = new Label();
            swapBtn = new Button();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Center;
            panel1.Location = new Point(1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(742, 101);
            panel1.TabIndex = 0;
            // 
            // amountInput
            // 
            amountInput.BackColor = Color.FromArgb(243, 238, 234);
            amountInput.BorderStyle = BorderStyle.None;
            amountInput.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            amountInput.ForeColor = Color.FromArgb(119, 107, 93);
            amountInput.Location = new Point(80, 329);
            amountInput.Multiline = true;
            amountInput.Name = "amountInput";
            amountInput.Size = new Size(191, 34);
            amountInput.TabIndex = 1;
            amountInput.TextAlign = HorizontalAlignment.Right;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(119, 107, 93);
            label1.Location = new Point(80, 295);
            label1.Name = "label1";
            label1.Size = new Size(72, 21);
            label1.TabIndex = 2;
            label1.Text = "Amount";
            // 
            // fromBox
            // 
            fromBox.BackColor = Color.FromArgb(243, 238, 234);
            fromBox.FlatStyle = FlatStyle.Flat;
            fromBox.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            fromBox.ForeColor = Color.FromArgb(119, 107, 93);
            fromBox.FormattingEnabled = true;
            fromBox.Location = new Point(80, 233);
            fromBox.Name = "fromBox";
            fromBox.Size = new Size(191, 29);
            fromBox.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(119, 107, 93);
            label2.Location = new Point(80, 198);
            label2.Name = "label2";
            label2.Size = new Size(49, 21);
            label2.TabIndex = 4;
            label2.Text = "From";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(119, 107, 93);
            label3.Location = new Point(465, 198);
            label3.Name = "label3";
            label3.Size = new Size(28, 21);
            label3.TabIndex = 6;
            label3.Text = "To";
            label3.Click += label3_Click;
            // 
            // toBox
            // 
            toBox.BackColor = Color.FromArgb(243, 238, 234);
            toBox.FlatStyle = FlatStyle.Flat;
            toBox.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            toBox.ForeColor = Color.FromArgb(119, 107, 93);
            toBox.FormattingEnabled = true;
            toBox.Location = new Point(465, 233);
            toBox.Name = "toBox";
            toBox.Size = new Size(191, 29);
            toBox.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(119, 107, 93);
            label4.Location = new Point(466, 295);
            label4.Name = "label4";
            label4.Size = new Size(57, 21);
            label4.TabIndex = 8;
            label4.Text = "Result";
            // 
            // resultOutput
            // 
            resultOutput.BackColor = Color.FromArgb(243, 238, 234);
            resultOutput.BorderStyle = BorderStyle.None;
            resultOutput.Enabled = false;
            resultOutput.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            resultOutput.ForeColor = Color.FromArgb(119, 107, 93);
            resultOutput.Location = new Point(465, 329);
            resultOutput.Multiline = true;
            resultOutput.Name = "resultOutput";
            resultOutput.Size = new Size(191, 34);
            resultOutput.TabIndex = 7;
            resultOutput.Text = "0.00";
            resultOutput.TextAlign = HorizontalAlignment.Right;
            // 
            // convertBtn
            // 
            convertBtn.BackColor = Color.FromArgb(119, 107, 93);
            convertBtn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            convertBtn.ForeColor = Color.FromArgb(243, 238, 234);
            convertBtn.Location = new Point(407, 404);
            convertBtn.Name = "convertBtn";
            convertBtn.Size = new Size(103, 39);
            convertBtn.TabIndex = 9;
            convertBtn.Text = "Convert";
            convertBtn.UseVisualStyleBackColor = false;
            convertBtn.MouseClick += convert;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(243, 238, 234);
            button2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.FromArgb(119, 107, 93);
            button2.Location = new Point(235, 404);
            button2.Name = "button2";
            button2.Size = new Size(103, 39);
            button2.TabIndex = 10;
            button2.Text = "Reset";
            button2.UseVisualStyleBackColor = false;
            button2.MouseClick += reset;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(243, 238, 234);
            panel2.Controls.Add(toRate);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(fromRate);
            panel2.Location = new Point(1, 100);
            panel2.Name = "panel2";
            panel2.Size = new Size(742, 78);
            panel2.TabIndex = 11;
            // 
            // toRate
            // 
            toRate.AutoSize = true;
            toRate.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            toRate.ForeColor = Color.FromArgb(119, 107, 93);
            toRate.Location = new Point(488, 23);
            toRate.Name = "toRate";
            toRate.Size = new Size(50, 25);
            toRate.TabIndex = 16;
            toRate.Text = "0.00";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(119, 107, 93);
            label7.Location = new Point(356, 23);
            label7.Name = "label7";
            label7.Size = new Size(25, 25);
            label7.TabIndex = 15;
            label7.Text = "=";
            // 
            // fromRate
            // 
            fromRate.AutoSize = true;
            fromRate.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            fromRate.ForeColor = Color.FromArgb(119, 107, 93);
            fromRate.Location = new Point(194, 23);
            fromRate.Name = "fromRate";
            fromRate.Size = new Size(50, 25);
            fromRate.TabIndex = 14;
            fromRate.Text = "0.00";
            // 
            // swapBtn
            // 
            swapBtn.BackgroundImage = (Image)resources.GetObject("swapBtn.BackgroundImage");
            swapBtn.BackgroundImageLayout = ImageLayout.Zoom;
            swapBtn.Location = new Point(347, 280);
            swapBtn.Name = "swapBtn";
            swapBtn.Size = new Size(52, 36);
            swapBtn.TabIndex = 12;
            swapBtn.UseVisualStyleBackColor = true;
            swapBtn.MouseClick += swap;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(235, 227, 213);
            ClientSize = new Size(743, 485);
            Controls.Add(swapBtn);
            Controls.Add(panel2);
            Controls.Add(button2);
            Controls.Add(convertBtn);
            Controls.Add(label4);
            Controls.Add(resultOutput);
            Controls.Add(label3);
            Controls.Add(toBox);
            Controls.Add(label2);
            Controls.Add(fromBox);
            Controls.Add(label1);
            Controls.Add(amountInput);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Currency Converter";
            Load += Form1_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private TextBox amountInput;
        private Label label1;
        private ComboBox fromBox;
        private Label label2;
        private Label label3;
        private ComboBox toBox;
        private Label label4;
        private TextBox resultOutput;
        private Button convertBtn;
        private Button button2;
        private Panel panel2;
        private Label toRate;
        private Label label7;
        private Label fromRate;
        private Button swapBtn;
    }
}
