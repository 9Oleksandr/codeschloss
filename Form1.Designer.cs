namespace K18
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
            labelDisplay = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            ButtonEnter = new Button();
            ButtonCall = new Button();
            ButtonControl = new Button();
            button0 = new Button();
            cch = new Button();
            SuspendLayout();
            // 
            // labelDisplay
            // 
            labelDisplay.BackColor = SystemColors.ActiveCaptionText;
            labelDisplay.BorderStyle = BorderStyle.FixedSingle;
            labelDisplay.Font = new Font("Segoe UI", 30F);
            labelDisplay.ForeColor = SystemColors.HighlightText;
            labelDisplay.Location = new Point(12, 29);
            labelDisplay.Name = "labelDisplay";
            labelDisplay.Size = new Size(457, 256);
            labelDisplay.TabIndex = 14;
            labelDisplay.TextAlign = ContentAlignment.MiddleCenter;
            labelDisplay.Click += labelDisplay_Click;
            // 
            // button1
            // 
            button1.Location = new Point(487, 28);
            button1.Name = "button1";
            button1.Size = new Size(123, 73);
            button1.TabIndex = 1;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(635, 29);
            button2.Name = "button2";
            button2.Size = new Size(123, 72);
            button2.TabIndex = 2;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(487, 107);
            button3.Name = "button3";
            button3.Size = new Size(123, 72);
            button3.TabIndex = 3;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(635, 107);
            button4.Name = "button4";
            button4.Size = new Size(123, 72);
            button4.TabIndex = 4;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(487, 185);
            button5.Name = "button5";
            button5.Size = new Size(123, 72);
            button5.TabIndex = 5;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(635, 185);
            button6.Name = "button6";
            button6.Size = new Size(123, 72);
            button6.TabIndex = 6;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Location = new Point(487, 263);
            button7.Name = "button7";
            button7.Size = new Size(123, 72);
            button7.TabIndex = 7;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Location = new Point(635, 263);
            button8.Name = "button8";
            button8.Size = new Size(123, 72);
            button8.TabIndex = 8;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.Location = new Point(487, 341);
            button9.Name = "button9";
            button9.Size = new Size(123, 72);
            button9.TabIndex = 9;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // ButtonEnter
            // 
            ButtonEnter.Location = new Point(82, 292);
            ButtonEnter.Name = "ButtonEnter";
            ButtonEnter.Size = new Size(289, 56);
            ButtonEnter.TabIndex = 10;
            ButtonEnter.Text = "Enter";
            ButtonEnter.UseVisualStyleBackColor = true;
            ButtonEnter.Click += ButtonEnter_Click;
            // 
            // ButtonCall
            // 
            ButtonCall.Location = new Point(18, 354);
            ButtonCall.Name = "ButtonCall";
            ButtonCall.Size = new Size(136, 59);
            ButtonCall.TabIndex = 11;
            ButtonCall.Text = "Call";
            ButtonCall.UseVisualStyleBackColor = true;
            ButtonCall.Click += ButtonCall_Click;
            // 
            // ButtonControl
            // 
            ButtonControl.Location = new Point(303, 354);
            ButtonControl.Name = "ButtonControl";
            ButtonControl.Size = new Size(137, 59);
            ButtonControl.TabIndex = 12;
            ButtonControl.Text = "Control";
            ButtonControl.UseVisualStyleBackColor = true;
            ButtonControl.Click += ButtonControl_Click;
            // 
            // button0
            // 
            button0.Location = new Point(635, 341);
            button0.Name = "button0";
            button0.Size = new Size(123, 72);
            button0.TabIndex = 13;
            button0.Text = "0";
            button0.UseVisualStyleBackColor = true;
            button0.Click += button0_Click;
            // 
            // cch
            // 
            cch.Location = new Point(160, 354);
            cch.Name = "cch";
            cch.Size = new Size(137, 59);
            cch.TabIndex = 15;
            cch.Text = "Change control code";
            cch.UseVisualStyleBackColor = true;
            cch.Click += cch_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cch);
            Controls.Add(button0);
            Controls.Add(ButtonControl);
            Controls.Add(ButtonCall);
            Controls.Add(ButtonEnter);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(labelDisplay);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Label labelDisplay;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button ButtonEnter;
        private Button ButtonCall;
        private Button ButtonControl;
        private Button button0;
        private Button cch;
    }
}
