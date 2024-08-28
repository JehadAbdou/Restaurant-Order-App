namespace Project
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            cmbDrinks = new ComboBox();
            cmbDesserts = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            lblSides = new Label();
            cmbSides = new ComboBox();
            label4 = new Label();
            txtNumOfPor = new TextBox();
            cmbSize = new ComboBox();
            label5 = new Label();
            btnAdd = new Button();
            btnConfirm = new Button();
            btnCancel = new Button();
            btnChange = new Button();
            menuStrip1 = new MenuStrip();
            toolStripMenuItem1 = new ToolStripMenuItem();
            logInToolStripMenuItem = new ToolStripMenuItem();
            cmbDishes = new ComboBox();
            label8 = new Label();
            dishesBindingSource = new BindingSource(components);
            dataGridView1 = new DataGridView();
            label9 = new Label();
            label10 = new Label();
            lblCount = new Label();
            lblSum = new Label();
            lblClock = new Label();
            btnDelete = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            printPreviewDialog1 = new PrintPreviewDialog();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dishesBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // cmbDrinks
            // 
            cmbDrinks.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDrinks.FormattingEnabled = true;
            cmbDrinks.Location = new Point(253, 38);
            cmbDrinks.Name = "cmbDrinks";
            cmbDrinks.Size = new Size(121, 23);
            cmbDrinks.TabIndex = 1;
            // 
            // cmbDesserts
            // 
            cmbDesserts.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDesserts.FormattingEnabled = true;
            cmbDesserts.Location = new Point(457, 41);
            cmbDesserts.Name = "cmbDesserts";
            cmbDesserts.Size = new Size(121, 23);
            cmbDesserts.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(210, 41);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 4;
            label2.Text = "Drinks";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(406, 44);
            label3.Name = "label3";
            label3.Size = new Size(50, 15);
            label3.TabIndex = 5;
            label3.Text = "Desserts";
            // 
            // lblSides
            // 
            lblSides.AutoSize = true;
            lblSides.Location = new Point(614, 47);
            lblSides.Name = "lblSides";
            lblSides.Size = new Size(34, 15);
            lblSides.TabIndex = 6;
            lblSides.Text = "Sides";
            // 
            // cmbSides
            // 
            cmbSides.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSides.FormattingEnabled = true;
            cmbSides.Location = new Point(653, 44);
            cmbSides.Name = "cmbSides";
            cmbSides.Size = new Size(121, 23);
            cmbSides.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(223, 83);
            label4.Name = "label4";
            label4.Size = new Size(95, 15);
            label4.TabIndex = 8;
            label4.Text = "Num of Portions";
            // 
            // txtNumOfPor
            // 
            txtNumOfPor.Location = new Point(321, 77);
            txtNumOfPor.Name = "txtNumOfPor";
            txtNumOfPor.Size = new Size(53, 23);
            txtNumOfPor.TabIndex = 9;
            // 
            // cmbSize
            // 
            cmbSize.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSize.FormattingEnabled = true;
            cmbSize.Location = new Point(74, 74);
            cmbSize.Name = "cmbSize";
            cmbSize.Size = new Size(121, 23);
            cmbSize.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 77);
            label5.Name = "label5";
            label5.Size = new Size(68, 15);
            label5.TabIndex = 11;
            label5.Text = "Portion size";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(457, 74);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(317, 37);
            btnAdd.TabIndex = 13;
            btnAdd.Text = "Add order";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnConfirm
            // 
            btnConfirm.Location = new Point(592, 329);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(173, 23);
            btnConfirm.TabIndex = 14;
            btnConfirm.Text = "Confirm order";
            btnConfirm.UseVisualStyleBackColor = true;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(592, 356);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(173, 23);
            btnCancel.TabIndex = 15;
            btnCancel.Text = "Cancel Order";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnChange
            // 
            btnChange.Location = new Point(31, 339);
            btnChange.Name = "btnChange";
            btnChange.Size = new Size(114, 23);
            btnChange.TabIndex = 16;
            btnChange.Text = "Change";
            btnChange.UseVisualStyleBackColor = true;
            btnChange.Click += btnChange_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 24;
            menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { logInToolStripMenuItem });
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(37, 20);
            toolStripMenuItem1.Text = "File";
            // 
            // logInToolStripMenuItem
            // 
            logInToolStripMenuItem.Name = "logInToolStripMenuItem";
            logInToolStripMenuItem.Size = new Size(107, 22);
            logInToolStripMenuItem.Text = "Log in";
            // 
            // cmbDishes
            // 
            cmbDishes.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDishes.FormattingEnabled = true;
            cmbDishes.Location = new Point(74, 41);
            cmbDishes.Name = "cmbDishes";
            cmbDishes.Size = new Size(121, 23);
            cmbDishes.TabIndex = 26;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(21, 44);
            label8.Name = "label8";
            label8.Size = new Size(41, 15);
            label8.TabIndex = 27;
            label8.Text = "Dishes";
            // 
            // dishesBindingSource
            // 
            dishesBindingSource.DataSource = typeof(Dishes);
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(21, 117);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(753, 206);
            dataGridView1.TabIndex = 28;
            // 
            // label9
            // 
            label9.BackColor = SystemColors.AppWorkspace;
            label9.BorderStyle = BorderStyle.FixedSingle;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(565, 402);
            label9.Name = "label9";
            label9.Size = new Size(100, 23);
            label9.TabIndex = 29;
            label9.Text = "Count";
            // 
            // label10
            // 
            label10.BackColor = SystemColors.AppWorkspace;
            label10.BorderStyle = BorderStyle.FixedSingle;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(566, 438);
            label10.Name = "label10";
            label10.Size = new Size(100, 23);
            label10.TabIndex = 30;
            label10.Text = "Sum";
            // 
            // lblCount
            // 
            lblCount.BackColor = SystemColors.ScrollBar;
            lblCount.BorderStyle = BorderStyle.Fixed3D;
            lblCount.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCount.Location = new Point(665, 402);
            lblCount.Name = "lblCount";
            lblCount.Size = new Size(100, 23);
            lblCount.TabIndex = 31;
            // 
            // lblSum
            // 
            lblSum.BackColor = SystemColors.ScrollBar;
            lblSum.BorderStyle = BorderStyle.Fixed3D;
            lblSum.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSum.Location = new Point(665, 438);
            lblSum.Name = "lblSum";
            lblSum.Size = new Size(100, 23);
            lblSum.TabIndex = 32;
            // 
            // lblClock
            // 
            lblClock.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblClock.ForeColor = SystemColors.HotTrack;
            lblClock.Location = new Point(31, 398);
            lblClock.Name = "lblClock";
            lblClock.Size = new Size(343, 49);
            lblClock.TabIndex = 33;
            lblClock.Text = "Time";
            lblClock.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(162, 339);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(114, 23);
            btnDelete.TabIndex = 34;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog1.ClientSize = new Size(400, 300);
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            printPreviewDialog1.Load += printPreviewDialog1_Load;
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 472);
            Controls.Add(btnDelete);
            Controls.Add(lblClock);
            Controls.Add(lblSum);
            Controls.Add(lblCount);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(dataGridView1);
            Controls.Add(label8);
            Controls.Add(cmbDishes);
            Controls.Add(btnChange);
            Controls.Add(btnCancel);
            Controls.Add(btnConfirm);
            Controls.Add(btnAdd);
            Controls.Add(label5);
            Controls.Add(cmbSize);
            Controls.Add(txtNumOfPor);
            Controls.Add(label4);
            Controls.Add(cmbSides);
            Controls.Add(lblSides);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(cmbDesserts);
            Controls.Add(cmbDrinks);
            Controls.Add(menuStrip1);
            Name = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dishesBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox cmbDrinks;
        private ComboBox cmbDesserts;
        private Label label2;
        private Label label3;
        private Label lblSides;
        private ComboBox cmbSides;
        private Label label4;
        private TextBox txtNumOfPor;
        private ComboBox cmbSize;
        private Label label5;
        private Button btnAdd;
        private Button btnConfirm;
        private Button btnCancel;
        private Button btnChange;
        private TextBox textBox2;
        private Label lblClock;
        private TextBox textBox3;
        private Label label6;
        private TextBox textBox4;
        private Label label7;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem logInToolStripMenuItem;
        private ComboBox cmbDishes;
        private Label label8;
        private DataGridViewTextBoxColumn vegdishDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn alt1DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn alt2DataGridViewTextBoxColumn;
        private BindingSource dishesBindingSource;
        private DataGridView dataGridView1;
        private Label label9;
        private Label label10;
        private Label lblCount;
        private Label lblSum;
        private Button btnDelete;
        private System.Windows.Forms.Timer timer1;
        private PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}
