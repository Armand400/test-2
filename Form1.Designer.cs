namespace test_2
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
            Bajouter = new Button();
            emailadd = new TextBox();
            label1 = new Label();
            label3 = new Label();
            dataGridView1 = new DataGridView();
            nomadd = new TextBox();
            TBnomedit = new TextBox();
            TBemailedit = new TextBox();
            Lnomedit = new Label();
            Lemailedit = new Label();
            Bedit = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // Bajouter
            // 
            Bajouter.Location = new Point(41, 202);
            Bajouter.Name = "Bajouter";
            Bajouter.Size = new Size(94, 29);
            Bajouter.TabIndex = 0;
            Bajouter.Text = "Ajouter";
            Bajouter.UseVisualStyleBackColor = true;
            Bajouter.Click += button1_Click_1;
            // 
            // emailadd
            // 
            emailadd.Location = new Point(41, 138);
            emailadd.Name = "emailadd";
            emailadd.Size = new Size(125, 27);
            emailadd.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 115);
            label1.Name = "label1";
            label1.Size = new Size(46, 20);
            label1.TabIndex = 3;
            label1.Text = "Email";
            // 
            // label3
            // 
            label3.Location = new Point(41, 40);
            label3.Name = "label3";
            label3.Size = new Size(100, 23);
            label3.TabIndex = 6;
            label3.Text = "Nom";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.BackgroundColor = SystemColors.ActiveBorder;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(211, 24);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(671, 290);
            dataGridView1.TabIndex = 4;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // nomadd
            // 
            nomadd.Location = new Point(41, 66);
            nomadd.Name = "nomadd";
            nomadd.Size = new Size(125, 27);
            nomadd.TabIndex = 5;
            // 
            // TBnomedit
            // 
            TBnomedit.Location = new Point(343, 370);
            TBnomedit.Name = "TBnomedit";
            TBnomedit.Size = new Size(125, 27);
            TBnomedit.TabIndex = 7;
            TBnomedit.Visible = false;
            // 
            // TBemailedit
            // 
            TBemailedit.Location = new Point(563, 370);
            TBemailedit.Name = "TBemailedit";
            TBemailedit.Size = new Size(125, 27);
            TBemailedit.TabIndex = 8;
            TBemailedit.Visible = false;
            // 
            // Lnomedit
            // 
            Lnomedit.AutoSize = true;
            Lnomedit.Location = new Point(343, 347);
            Lnomedit.Name = "Lnomedit";
            Lnomedit.Size = new Size(42, 20);
            Lnomedit.TabIndex = 9;
            Lnomedit.Text = "Nom";
            Lnomedit.Visible = false;
            // 
            // Lemailedit
            // 
            Lemailedit.AutoSize = true;
            Lemailedit.Location = new Point(563, 347);
            Lemailedit.Name = "Lemailedit";
            Lemailedit.Size = new Size(46, 20);
            Lemailedit.TabIndex = 10;
            Lemailedit.Text = "Email";
            Lemailedit.Visible = false;
            // 
            // Bedit
            // 
            Bedit.Location = new Point(735, 368);
            Bedit.Name = "Bedit";
            Bedit.Size = new Size(94, 29);
            Bedit.TabIndex = 11;
            Bedit.Text = "Modifier";
            Bedit.UseVisualStyleBackColor = true;
            Bedit.Visible = false;
            Bedit.Click += Bedit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(936, 452);
            Controls.Add(Bedit);
            Controls.Add(Lemailedit);
            Controls.Add(Lnomedit);
            Controls.Add(TBemailedit);
            Controls.Add(TBnomedit);
            Controls.Add(nomadd);
            Controls.Add(dataGridView1);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(emailadd);
            Controls.Add(Bajouter);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Bajouter;
        private TextBox emailadd;
        private Label label1;
        private Label label3;
        private DataGridView dataGridView1;
        private TextBox textBox1;
        private TextBox TBnomedit;
        private TextBox TBemailedit;
        private Label Lnomedit;
        private Label Lemailedit;
        private Button Bedit;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private TextBox nomadd;
    }
}
