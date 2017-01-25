namespace MVP_StopWatch
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
            this.SecondsTextBox = new System.Windows.Forms.TextBox();
            this.ResetButton = new System.Windows.Forms.Button();
            this.StopButon = new System.Windows.Forms.Button();
            this.StartButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // SecondsTextBox
            // 
            this.SecondsTextBox.Location = new System.Drawing.Point(5, 75);
            this.SecondsTextBox.Name = "SecondsTextBox";
            this.SecondsTextBox.Size = new System.Drawing.Size(100, 20);
            this.SecondsTextBox.TabIndex = 7;
            // 
            // ResetButton
            // 
            this.ResetButton.Location = new System.Drawing.Point(204, 21);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(75, 23);
            this.ResetButton.TabIndex = 6;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // StopButon
            // 
            this.StopButon.Location = new System.Drawing.Point(107, 22);
            this.StopButon.Name = "StopButon";
            this.StopButon.Size = new System.Drawing.Size(75, 23);
            this.StopButon.TabIndex = 5;
            this.StopButon.Text = "Stop";
            this.StopButon.UseVisualStyleBackColor = true;
            this.StopButon.Click += new System.EventHandler(this.StopButon_Click);
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(5, 23);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(75, 23);
            this.StartButton.TabIndex = 4;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 113);
            this.Controls.Add(this.SecondsTextBox);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.StopButon);
            this.Controls.Add(this.StartButton);
            this.Name = "Form1";
            this.Text = "MVP_StopWatch";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox SecondsTextBox;
        public System.Windows.Forms.Button ResetButton;
        public System.Windows.Forms.Button StopButon;
        public System.Windows.Forms.Button StartButton;
        public System.Windows.Forms.Timer timer1;
    }
}

