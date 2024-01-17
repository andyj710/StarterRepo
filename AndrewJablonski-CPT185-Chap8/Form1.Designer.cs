
namespace AndrewJablonski_CPT185_Chap8
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
            this.label1 = new System.Windows.Forms.Label();
            this.usrInputTextBox = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.morseOutputLabel = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Enabled = false;
            this.label1.Location = new System.Drawing.Point(63, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(498, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please enter the text that you want to be converted to Morse Code:";
            // 
            // usrInputTextBox
            // 
            this.usrInputTextBox.Location = new System.Drawing.Point(67, 69);
            this.usrInputTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.usrInputTextBox.Name = "usrInputTextBox";
            this.usrInputTextBox.Size = new System.Drawing.Size(494, 28);
            this.usrInputTextBox.TabIndex = 0;
            this.toolTip1.SetToolTip(this.usrInputTextBox, "Only enter the English alphabet, 0-9, comma, period, and a ? mark:");
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(144, 398);
            this.calculateButton.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(154, 46);
            this.calculateButton.TabIndex = 1;
            this.calculateButton.Text = "&Convert";
            this.toolTip1.SetToolTip(this.calculateButton, "This will convert English to Morse");
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(144, 480);
            this.clearButton.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(154, 46);
            this.clearButton.TabIndex = 2;
            this.clearButton.Text = "Clea&r";
            this.toolTip1.SetToolTip(this.clearButton, "This will clear the form:");
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(325, 480);
            this.exitButton.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(154, 46);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "E&xit";
            this.toolTip1.SetToolTip(this.exitButton, "This will Exit the form:");
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // morseOutputLabel
            // 
            this.morseOutputLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.morseOutputLabel.Enabled = false;
            this.morseOutputLabel.Location = new System.Drawing.Point(162, 121);
            this.morseOutputLabel.Name = "morseOutputLabel";
            this.morseOutputLabel.Size = new System.Drawing.Size(292, 241);
            this.morseOutputLabel.TabIndex = 8;
            this.morseOutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.morseOutputLabel, "This is where your Morse Code will output to:");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 556);
            this.Controls.Add(this.morseOutputLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.usrInputTextBox);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Morse Code Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox usrInputTextBox;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label morseOutputLabel;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

