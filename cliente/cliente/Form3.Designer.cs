namespace cliente
{
    partial class Form3
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panel1 = new Panel();
            button6 = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label5 = new Label();
            label6 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            timer2 = new System.Windows.Forms.Timer(components);
            button1 = new Button();
            button2 = new Button();
            richTextBox1 = new RichTextBox();
            button5 = new Button();
            button3 = new Button();
            button4 = new Button();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            numform = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 192, 255);
            panel1.Controls.Add(button6);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label6);
            panel1.Location = new Point(1, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(252, 450);
            panel1.TabIndex = 0;
            // 
            // button6
            // 
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatAppearance.MouseDownBackColor = Color.LightCoral;
            button6.FlatAppearance.MouseOverBackColor = Color.Red;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button6.Location = new Point(63, 191);
            button6.Name = "button6";
            button6.Size = new Size(105, 37);
            button6.TabIndex = 18;
            button6.Text = "RENDICIÓN";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(66, 291);
            label4.Name = "label4";
            label4.Size = new Size(102, 36);
            label4.TabIndex = 3;
            label4.Text = "label4";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(66, 218);
            label3.Name = "label3";
            label3.Size = new Size(102, 36);
            label3.TabIndex = 2;
            label3.Text = "label3";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(66, 152);
            label2.Name = "label2";
            label2.Size = new Size(102, 36);
            label2.TabIndex = 1;
            label2.Text = "label2";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(55, 91);
            label1.Name = "label1";
            label1.Size = new Size(122, 41);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(3, 8);
            label5.Name = "label5";
            label5.Size = new Size(82, 24);
            label5.TabIndex = 10;
            label5.Text = "Puntos:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(91, 8);
            label6.Name = "label6";
            label6.Size = new Size(74, 24);
            label6.TabIndex = 11;
            label6.Text = "label6";
            // 
            // timer1
            // 
            timer1.Interval = 5000;
            timer1.Tick += timer1_Tick_1;
            // 
            // timer2
            // 
            timer2.Interval = 5000;
            timer2.Tick += timer2_Tick_1;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.PaleGreen;
            button1.FlatAppearance.MouseOverBackColor = Color.SeaGreen;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(322, 201);
            button1.Name = "button1";
            button1.Size = new Size(89, 37);
            button1.TabIndex = 1;
            button1.Text = "INICIAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseDownBackColor = Color.PaleGreen;
            button2.FlatAppearance.MouseOverBackColor = Color.SeaGreen;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(456, 401);
            button2.Name = "button2";
            button2.Size = new Size(89, 37);
            button2.TabIndex = 2;
            button2.Text = "ENVIAR";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = Color.FromArgb(64, 64, 64);
            richTextBox1.BorderStyle = BorderStyle.None;
            richTextBox1.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox1.ForeColor = Color.White;
            richTextBox1.Location = new Point(551, 312);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(250, 139);
            richTextBox1.TabIndex = 3;
            richTextBox1.Text = "";
            richTextBox1.KeyPress += richTextBox1_KeyPress;
            // 
            // button5
            // 
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatAppearance.MouseDownBackColor = Color.LightCoral;
            button5.FlatAppearance.MouseOverBackColor = Color.Firebrick;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button5.Location = new Point(683, 269);
            button5.Name = "button5";
            button5.Size = new Size(105, 37);
            button5.TabIndex = 6;
            button5.Text = "PEDIR PISTA";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button3
            // 
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatAppearance.MouseDownBackColor = Color.LightCoral;
            button3.FlatAppearance.MouseOverBackColor = Color.Firebrick;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(556, 269);
            button3.Name = "button3";
            button3.Size = new Size(121, 37);
            button3.TabIndex = 7;
            button3.Text = "¡JUEGATELA!";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            button3.KeyPress += button3_KeyPress;
            // 
            // button4
            // 
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatAppearance.MouseDownBackColor = Color.LightCoral;
            button4.FlatAppearance.MouseOverBackColor = Color.Red;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button4.Location = new Point(306, 201);
            button4.Name = "button4";
            button4.Size = new Size(105, 37);
            button4.TabIndex = 8;
            button4.Text = "INICIAR";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1 });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlLightLight;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.Location = new Point(665, 1);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(136, 251);
            dataGridView1.TabIndex = 9;
            dataGridView1.CellClick += dataGridView1_CellClick_1;
            // 
            // Column1
            // 
            Column1.HeaderText = "Preguntas";
            Column1.Name = "Column1";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(494, 102);
            label7.Name = "label7";
            label7.Size = new Size(38, 15);
            label7.TabIndex = 12;
            label7.Text = "label7";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(494, 118);
            label8.Name = "label8";
            label8.Size = new Size(38, 15);
            label8.TabIndex = 13;
            label8.Text = "label8";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(494, 133);
            label9.Name = "label9";
            label9.Size = new Size(38, 15);
            label9.TabIndex = 14;
            label9.Text = "label9";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(494, 148);
            label10.Name = "label10";
            label10.Size = new Size(44, 15);
            label10.TabIndex = 15;
            label10.Text = "label10";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Century Gothic", 48F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label11.ForeColor = Color.DeepPink;
            label11.Location = new Point(294, 12);
            label11.Margin = new Padding(2, 0, 2, 0);
            label11.Name = "label11";
            label11.Size = new Size(185, 77);
            label11.TabIndex = 16;
            label11.Text = "TABÚ";
            // 
            // numform
            // 
            numform.AutoSize = true;
            numform.Location = new Point(535, 17);
            numform.Name = "numform";
            numform.Size = new Size(10, 15);
            numform.TabIndex = 17;
            numform.Text = "l";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 15, 15);
            ClientSize = new Size(800, 450);
            Controls.Add(numform);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(dataGridView1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button5);
            Controls.Add(richTextBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(panel1);
            ForeColor = SystemColors.ControlLightLight;
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private Button button1;
        private Button button2;
        private RichTextBox richTextBox1;
        private Button button5;
        private Button button3;
        private Button button4;
        private DataGridView dataGridView1;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label numform;
        private DataGridViewTextBoxColumn Column1;
        private Button button6;
    }
}