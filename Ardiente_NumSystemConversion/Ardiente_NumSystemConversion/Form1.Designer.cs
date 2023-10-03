namespace Ardiente_NumSystemConversion
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
            this.label1 = new System.Windows.Forms.Label();
            this.inputText = new System.Windows.Forms.TextBox();
            this.binaryInButton = new System.Windows.Forms.RadioButton();
            this.hexaInButton = new System.Windows.Forms.RadioButton();
            this.octaInButton = new System.Windows.Forms.RadioButton();
            this.decimalInButton = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.decimalOutButton = new System.Windows.Forms.RadioButton();
            this.octaOutButton = new System.Windows.Forms.RadioButton();
            this.hexaOutButton = new System.Windows.Forms.RadioButton();
            this.binaryOutButton = new System.Windows.Forms.RadioButton();
            this.outputText = new System.Windows.Forms.Label();
            this.ConvertButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(332, 36);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(10);
            this.label1.Size = new System.Drawing.Size(92, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Input";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // inputText
            // 
            this.inputText.Location = new System.Drawing.Point(172, 151);
            this.inputText.Name = "inputText";
            this.inputText.Size = new System.Drawing.Size(421, 27);
            this.inputText.TabIndex = 1;
            this.inputText.TextChanged += new System.EventHandler(this.inputText_TextChanged);
            // 
            // binaryInButton
            // 
            this.binaryInButton.AutoSize = true;
            this.binaryInButton.Location = new System.Drawing.Point(136, 26);
            this.binaryInButton.Name = "binaryInButton";
            this.binaryInButton.Size = new System.Drawing.Size(71, 24);
            this.binaryInButton.TabIndex = 2;
            this.binaryInButton.TabStop = true;
            this.binaryInButton.Text = "Binary";
            this.binaryInButton.UseVisualStyleBackColor = true;
            this.binaryInButton.CheckedChanged += new System.EventHandler(this.binaryInButton_CheckedChanged);
            // 
            // hexaInButton
            // 
            this.hexaInButton.AutoSize = true;
            this.hexaInButton.Location = new System.Drawing.Point(213, 26);
            this.hexaInButton.Name = "hexaInButton";
            this.hexaInButton.Size = new System.Drawing.Size(117, 24);
            this.hexaInButton.TabIndex = 3;
            this.hexaInButton.TabStop = true;
            this.hexaInButton.Text = "Hexadecimal";
            this.hexaInButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.hexaInButton.UseVisualStyleBackColor = true;
            this.hexaInButton.CheckedChanged += new System.EventHandler(this.hexaInButton_CheckedChanged);
            // 
            // octaInButton
            // 
            this.octaInButton.AutoSize = true;
            this.octaInButton.Location = new System.Drawing.Point(336, 26);
            this.octaInButton.Name = "octaInButton";
            this.octaInButton.Size = new System.Drawing.Size(116, 24);
            this.octaInButton.TabIndex = 4;
            this.octaInButton.TabStop = true;
            this.octaInButton.Text = "OctaDecimal";
            this.octaInButton.UseVisualStyleBackColor = true;
            this.octaInButton.CheckedChanged += new System.EventHandler(this.octaInButton_CheckedChanged);
            // 
            // decimalInButton
            // 
            this.decimalInButton.AutoSize = true;
            this.decimalInButton.Location = new System.Drawing.Point(31, 26);
            this.decimalInButton.Name = "decimalInButton";
            this.decimalInButton.Size = new System.Drawing.Size(85, 24);
            this.decimalInButton.TabIndex = 5;
            this.decimalInButton.TabStop = true;
            this.decimalInButton.Text = "Decimal";
            this.decimalInButton.UseVisualStyleBackColor = true;
            this.decimalInButton.CheckedChanged += new System.EventHandler(this.decimalInButton_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(341, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "Output";
            // 
            // decimalOutButton
            // 
            this.decimalOutButton.AutoSize = true;
            this.decimalOutButton.Location = new System.Drawing.Point(14, 26);
            this.decimalOutButton.Name = "decimalOutButton";
            this.decimalOutButton.Size = new System.Drawing.Size(85, 24);
            this.decimalOutButton.TabIndex = 10;
            this.decimalOutButton.TabStop = true;
            this.decimalOutButton.Text = "Decimal";
            this.decimalOutButton.UseVisualStyleBackColor = true;
            this.decimalOutButton.CheckedChanged += new System.EventHandler(this.decimalOutButton_CheckedChanged);
            // 
            // octaOutButton
            // 
            this.octaOutButton.AutoSize = true;
            this.octaOutButton.Location = new System.Drawing.Point(319, 26);
            this.octaOutButton.Name = "octaOutButton";
            this.octaOutButton.Size = new System.Drawing.Size(116, 24);
            this.octaOutButton.TabIndex = 9;
            this.octaOutButton.TabStop = true;
            this.octaOutButton.Text = "OctaDecimal";
            this.octaOutButton.UseVisualStyleBackColor = true;
            this.octaOutButton.CheckedChanged += new System.EventHandler(this.octaOutButton_CheckedChanged);
            // 
            // hexaOutButton
            // 
            this.hexaOutButton.AutoSize = true;
            this.hexaOutButton.Location = new System.Drawing.Point(196, 26);
            this.hexaOutButton.Name = "hexaOutButton";
            this.hexaOutButton.Size = new System.Drawing.Size(117, 24);
            this.hexaOutButton.TabIndex = 8;
            this.hexaOutButton.TabStop = true;
            this.hexaOutButton.Text = "Hexadecimal";
            this.hexaOutButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.hexaOutButton.UseVisualStyleBackColor = true;
            this.hexaOutButton.CheckedChanged += new System.EventHandler(this.hexaOutButton_CheckedChanged);
            // 
            // binaryOutButton
            // 
            this.binaryOutButton.AutoSize = true;
            this.binaryOutButton.Location = new System.Drawing.Point(119, 26);
            this.binaryOutButton.Name = "binaryOutButton";
            this.binaryOutButton.Size = new System.Drawing.Size(71, 24);
            this.binaryOutButton.TabIndex = 7;
            this.binaryOutButton.TabStop = true;
            this.binaryOutButton.Text = "Binary";
            this.binaryOutButton.UseVisualStyleBackColor = true;
            this.binaryOutButton.CheckedChanged += new System.EventHandler(this.binaryOutButton_CheckedChanged);
            // 
            // outputText
            // 
            this.outputText.AutoSize = true;
            this.outputText.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.outputText.Location = new System.Drawing.Point(332, 267);
            this.outputText.Name = "outputText";
            this.outputText.Size = new System.Drawing.Size(100, 20);
            this.outputText.TabIndex = 11;
            this.outputText.Text = "output text";
            // 
            // ConvertButton
            // 
            this.ConvertButton.Location = new System.Drawing.Point(332, 370);
            this.ConvertButton.Name = "ConvertButton";
            this.ConvertButton.Size = new System.Drawing.Size(100, 29);
            this.ConvertButton.TabIndex = 12;
            this.ConvertButton.Text = "Convert";
            this.ConvertButton.UseVisualStyleBackColor = true;
            this.ConvertButton.Click += new System.EventHandler(this.ConvertButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.octaInButton);
            this.groupBox1.Controls.Add(this.binaryInButton);
            this.groupBox1.Controls.Add(this.hexaInButton);
            this.groupBox1.Controls.Add(this.decimalInButton);
            this.groupBox1.Location = new System.Drawing.Point(158, 85);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(458, 63);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.octaOutButton);
            this.groupBox2.Controls.Add(this.binaryOutButton);
            this.groupBox2.Controls.Add(this.hexaOutButton);
            this.groupBox2.Controls.Add(this.decimalOutButton);
            this.groupBox2.Location = new System.Drawing.Point(172, 310);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(458, 54);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ConvertButton);
            this.Controls.Add(this.outputText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.inputText);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "out put text";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox inputText;
        private RadioButton binaryInButton;
        private RadioButton hexaInButton;
        private RadioButton octaInButton;
        private RadioButton decimalInButton;
        private Label label2;
        private RadioButton decimalOutButton;
        private RadioButton octaOutButton;
        private RadioButton hexaOutButton;
        private RadioButton binaryOutButton;
        private Label outputText;
        private Button ConvertButton;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
    }
}