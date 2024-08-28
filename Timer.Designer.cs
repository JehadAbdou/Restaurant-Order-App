namespace Project
{
    partial class Timer
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
            components = new System.ComponentModel.Container();
            lblTimer = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // lblTimer
            // 
            lblTimer.BorderStyle = BorderStyle.Fixed3D;
            lblTimer.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTimer.Location = new Point(21, 56);
            lblTimer.Name = "lblTimer";
            lblTimer.Size = new Size(231, 89);
            lblTimer.TabIndex = 0;
            lblTimer.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(42, 35);
            label1.Name = "label1";
            label1.Size = new Size(191, 21);
            label1.TabIndex = 1;
            label1.Text = "Time to deliver your order";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(55, 145);
            label2.Name = "label2";
            label2.Size = new Size(161, 21);
            label2.TabIndex = 2;
            label2.Text = "Thanks for your order";
            // 
            // Timer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(285, 188);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblTimer);
            MaximizeBox = false;
            Name = "Timer";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Delivery time";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTimer;
        private System.Windows.Forms.Timer timer1;
        private Label label1;
        private Label label2;
    }
}