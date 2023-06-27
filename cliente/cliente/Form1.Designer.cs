namespace cliente
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
            tB_nombre = new TextBox();
            tB_contrasena = new TextBox();
            tB_email = new TextBox();
            btn_Iniciar = new Button();
            lbl_Bienvenido = new Label();
            dgv_conectados = new DataGridView();
            lbl_conectados = new Label();
            btn_salir = new Button();
            lbl_peticiones = new Label();
            cbx_ganadas = new CheckBox();
            cbx_jugadas = new CheckBox();
            cbx_ganador = new CheckBox();
            tB_peticion = new TextBox();
            lbl_contar = new Label();
            btn_enviar = new Button();
            btn_invitar = new Button();
            lbl_iniciado = new Label();
            cbx_existe = new CheckBox();
            panel1 = new Panel();
            button1 = new Button();
            linkLabel2 = new LinkLabel();
            label1 = new Label();
            linkLabel1 = new LinkLabel();
            panel4 = new Panel();
            panel3 = new Panel();
            panel2 = new Panel();
            panel5 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgv_conectados).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // tB_nombre
            // 
            tB_nombre.BackColor = Color.DeepPink;
            tB_nombre.BorderStyle = BorderStyle.None;
            tB_nombre.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            tB_nombre.ForeColor = Color.PaleVioletRed;
            tB_nombre.Location = new Point(46, 60);
            tB_nombre.Margin = new Padding(2);
            tB_nombre.Name = "tB_nombre";
            tB_nombre.Size = new Size(229, 24);
            tB_nombre.TabIndex = 0;
            tB_nombre.Text = "USUARIO";
            tB_nombre.Enter += tB_nombre_Enter;
            tB_nombre.Leave += tB_nombre_Leave;
            // 
            // tB_contrasena
            // 
            tB_contrasena.BackColor = Color.DeepPink;
            tB_contrasena.BorderStyle = BorderStyle.None;
            tB_contrasena.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            tB_contrasena.ForeColor = Color.PaleVioletRed;
            tB_contrasena.Location = new Point(48, 112);
            tB_contrasena.Margin = new Padding(2);
            tB_contrasena.Name = "tB_contrasena";
            tB_contrasena.Size = new Size(166, 24);
            tB_contrasena.TabIndex = 1;
            tB_contrasena.Text = "CONTRASEÑA";
            tB_contrasena.TextChanged += tB_contrasena_TextChanged;
            tB_contrasena.Enter += tB_contrasena_Enter;
            tB_contrasena.Leave += tB_contrasena_Leave;
            // 
            // tB_email
            // 
            tB_email.BackColor = Color.DeepPink;
            tB_email.BorderStyle = BorderStyle.None;
            tB_email.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            tB_email.ForeColor = Color.PaleVioletRed;
            tB_email.Location = new Point(46, 154);
            tB_email.Margin = new Padding(2);
            tB_email.Name = "tB_email";
            tB_email.Size = new Size(166, 26);
            tB_email.TabIndex = 2;
            tB_email.Text = "CORREO";
            tB_email.TextChanged += tB_email_TextChanged;
            tB_email.Enter += tB_email_Enter;
            tB_email.Leave += tB_email_Leave;
            // 
            // btn_Iniciar
            // 
            btn_Iniciar.BackColor = Color.PaleVioletRed;
            btn_Iniciar.FlatAppearance.BorderSize = 0;
            btn_Iniciar.FlatAppearance.MouseDownBackColor = Color.LightPink;
            btn_Iniciar.FlatAppearance.MouseOverBackColor = Color.Pink;
            btn_Iniciar.FlatStyle = FlatStyle.Flat;
            btn_Iniciar.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Iniciar.ForeColor = Color.FromArgb(15, 15, 15);
            btn_Iniciar.Location = new Point(73, 212);
            btn_Iniciar.Margin = new Padding(2);
            btn_Iniciar.Name = "btn_Iniciar";
            btn_Iniciar.Size = new Size(163, 38);
            btn_Iniciar.TabIndex = 7;
            btn_Iniciar.Text = "INICIAR SESIÓN";
            btn_Iniciar.UseVisualStyleBackColor = false;
            btn_Iniciar.Click += btn_Iniciar_Click;
            // 
            // lbl_Bienvenido
            // 
            lbl_Bienvenido.AutoSize = true;
            lbl_Bienvenido.BackColor = Color.Transparent;
            lbl_Bienvenido.Font = new Font("Century Gothic", 48F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            lbl_Bienvenido.ForeColor = Color.DeepPink;
            lbl_Bienvenido.Location = new Point(430, 1);
            lbl_Bienvenido.Margin = new Padding(2, 0, 2, 0);
            lbl_Bienvenido.Name = "lbl_Bienvenido";
            lbl_Bienvenido.Size = new Size(185, 77);
            lbl_Bienvenido.TabIndex = 9;
            lbl_Bienvenido.Text = "TABÚ";
            lbl_Bienvenido.Click += lbl_Bienvenido_Click;
            // 
            // dgv_conectados
            // 
            dgv_conectados.BackgroundColor = Color.FromArgb(15, 15, 15);
            dgv_conectados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_conectados.GridColor = SystemColors.ControlDarkDark;
            dgv_conectados.Location = new Point(392, 119);
            dgv_conectados.Margin = new Padding(2);
            dgv_conectados.Name = "dgv_conectados";
            dgv_conectados.RowHeadersWidth = 62;
            dgv_conectados.RowTemplate.Height = 33;
            dgv_conectados.Size = new Size(270, 150);
            dgv_conectados.TabIndex = 10;
            dgv_conectados.CellContentClick += dgv_conectados_CellContentClick;
            // 
            // lbl_conectados
            // 
            lbl_conectados.AutoSize = true;
            lbl_conectados.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_conectados.ForeColor = Color.DeepPink;
            lbl_conectados.Location = new Point(430, 90);
            lbl_conectados.Margin = new Padding(2, 0, 2, 0);
            lbl_conectados.Name = "lbl_conectados";
            lbl_conectados.Size = new Size(195, 19);
            lbl_conectados.TabIndex = 11;
            lbl_conectados.Text = "USUARIOS CONECTADOS";
            // 
            // btn_salir
            // 
            btn_salir.FlatAppearance.BorderSize = 0;
            btn_salir.FlatAppearance.MouseDownBackColor = Color.LightPink;
            btn_salir.FlatAppearance.MouseOverBackColor = Color.Pink;
            btn_salir.FlatStyle = FlatStyle.Flat;
            btn_salir.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_salir.ForeColor = Color.FromArgb(224, 224, 224);
            btn_salir.Location = new Point(905, 0);
            btn_salir.Margin = new Padding(2);
            btn_salir.Name = "btn_salir";
            btn_salir.Size = new Size(33, 33);
            btn_salir.TabIndex = 12;
            btn_salir.Text = "X";
            btn_salir.UseVisualStyleBackColor = true;
            btn_salir.Click += btn_salir_Click;
            // 
            // lbl_peticiones
            // 
            lbl_peticiones.AutoSize = true;
            lbl_peticiones.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_peticiones.ForeColor = Color.DeepPink;
            lbl_peticiones.Location = new Point(719, 90);
            lbl_peticiones.Margin = new Padding(2, 0, 2, 0);
            lbl_peticiones.Name = "lbl_peticiones";
            lbl_peticiones.Size = new Size(79, 17);
            lbl_peticiones.TabIndex = 13;
            lbl_peticiones.Text = "PETICIONES";
            // 
            // cbx_ganadas
            // 
            cbx_ganadas.AutoSize = true;
            cbx_ganadas.FlatStyle = FlatStyle.Flat;
            cbx_ganadas.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            cbx_ganadas.ForeColor = Color.DeepPink;
            cbx_ganadas.Location = new Point(709, 119);
            cbx_ganadas.Margin = new Padding(2);
            cbx_ganadas.Name = "cbx_ganadas";
            cbx_ganadas.Size = new Size(187, 21);
            cbx_ganadas.TabIndex = 15;
            cbx_ganadas.Text = "PARTIDAS GANADAS DE ...";
            cbx_ganadas.UseVisualStyleBackColor = true;
            // 
            // cbx_jugadas
            // 
            cbx_jugadas.AutoSize = true;
            cbx_jugadas.FlatStyle = FlatStyle.Flat;
            cbx_jugadas.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            cbx_jugadas.ForeColor = Color.DeepPink;
            cbx_jugadas.Location = new Point(709, 140);
            cbx_jugadas.Margin = new Padding(2);
            cbx_jugadas.Name = "cbx_jugadas";
            cbx_jugadas.Size = new Size(178, 21);
            cbx_jugadas.TabIndex = 16;
            cbx_jugadas.Text = "PARTIDAS JUGADAS DE...";
            cbx_jugadas.UseVisualStyleBackColor = true;
            // 
            // cbx_ganador
            // 
            cbx_ganador.AutoSize = true;
            cbx_ganador.FlatStyle = FlatStyle.Flat;
            cbx_ganador.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            cbx_ganador.ForeColor = Color.DeepPink;
            cbx_ganador.Location = new Point(709, 212);
            cbx_ganador.Margin = new Padding(2);
            cbx_ganador.Name = "cbx_ganador";
            cbx_ganador.Size = new Size(205, 21);
            cbx_ganador.TabIndex = 17;
            cbx_ganador.Text = "JUGADOR CON MÁS PUNTOS";
            cbx_ganador.UseVisualStyleBackColor = true;
            // 
            // tB_peticion
            // 
            tB_peticion.BackColor = Color.FromArgb(15, 15, 15);
            tB_peticion.BorderStyle = BorderStyle.None;
            tB_peticion.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tB_peticion.ForeColor = Color.White;
            tB_peticion.Location = new Point(735, 185);
            tB_peticion.Margin = new Padding(2);
            tB_peticion.Name = "tB_peticion";
            tB_peticion.Size = new Size(98, 15);
            tB_peticion.TabIndex = 18;
            // 
            // lbl_contar
            // 
            lbl_contar.BorderStyle = BorderStyle.FixedSingle;
            lbl_contar.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_contar.ForeColor = Color.DeepPink;
            lbl_contar.Location = new Point(796, 88);
            lbl_contar.Margin = new Padding(2, 0, 2, 0);
            lbl_contar.Name = "lbl_contar";
            lbl_contar.Size = new Size(29, 21);
            lbl_contar.TabIndex = 19;
            // 
            // btn_enviar
            // 
            btn_enviar.FlatAppearance.BorderSize = 0;
            btn_enviar.FlatAppearance.MouseDownBackColor = Color.LightPink;
            btn_enviar.FlatAppearance.MouseOverBackColor = Color.Pink;
            btn_enviar.FlatStyle = FlatStyle.Flat;
            btn_enviar.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_enviar.ForeColor = Color.FromArgb(224, 224, 224);
            btn_enviar.Location = new Point(735, 237);
            btn_enviar.Margin = new Padding(2);
            btn_enviar.Name = "btn_enviar";
            btn_enviar.Size = new Size(120, 29);
            btn_enviar.TabIndex = 20;
            btn_enviar.Text = "PETICIÓN";
            btn_enviar.UseVisualStyleBackColor = true;
            btn_enviar.Click += btn_enviar_Click;
            // 
            // btn_invitar
            // 
            btn_invitar.BackColor = Color.FromArgb(15, 15, 15);
            btn_invitar.FlatAppearance.BorderSize = 0;
            btn_invitar.FlatAppearance.MouseDownBackColor = Color.LightPink;
            btn_invitar.FlatAppearance.MouseOverBackColor = Color.Pink;
            btn_invitar.FlatStyle = FlatStyle.Flat;
            btn_invitar.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btn_invitar.ForeColor = Color.FromArgb(224, 224, 224);
            btn_invitar.Location = new Point(485, 287);
            btn_invitar.Margin = new Padding(2);
            btn_invitar.Name = "btn_invitar";
            btn_invitar.Size = new Size(96, 34);
            btn_invitar.TabIndex = 22;
            btn_invitar.Text = "INVITAR";
            btn_invitar.UseVisualStyleBackColor = false;
            btn_invitar.Click += btn_invitar_Click;
            // 
            // lbl_iniciado
            // 
            lbl_iniciado.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lbl_iniciado.AutoSize = true;
            lbl_iniciado.Font = new Font("Century Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_iniciado.ForeColor = Color.DeepPink;
            lbl_iniciado.Location = new Point(750, 26);
            lbl_iniciado.Margin = new Padding(2, 0, 2, 0);
            lbl_iniciado.Name = "lbl_iniciado";
            lbl_iniciado.Size = new Size(96, 33);
            lbl_iniciado.TabIndex = 23;
            lbl_iniciado.Text = "label1";
            lbl_iniciado.TextAlign = ContentAlignment.MiddleRight;
            lbl_iniciado.Click += lbl_iniciado_Click;
            // 
            // cbx_existe
            // 
            cbx_existe.AutoSize = true;
            cbx_existe.FlatStyle = FlatStyle.Flat;
            cbx_existe.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            cbx_existe.ForeColor = Color.DeepPink;
            cbx_existe.Location = new Point(709, 161);
            cbx_existe.Margin = new Padding(2);
            cbx_existe.Name = "cbx_existe";
            cbx_existe.Size = new Size(76, 21);
            cbx_existe.TabIndex = 25;
            cbx_existe.Text = "EXISTE ...";
            cbx_existe.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DeepPink;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(linkLabel2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(linkLabel1);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(btn_Iniciar);
            panel1.Controls.Add(tB_nombre);
            panel1.Controls.Add(tB_contrasena);
            panel1.Controls.Add(tB_email);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(322, 332);
            panel1.TabIndex = 26;
            panel1.Paint += panel1_Paint;
            // 
            // button1
            // 
            button1.BackColor = Color.PaleVioletRed;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.LightPink;
            button1.FlatAppearance.MouseOverBackColor = Color.Pink;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.FromArgb(15, 15, 15);
            button1.Location = new Point(73, 212);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(163, 38);
            button1.TabIndex = 28;
            button1.Text = "INICIAR JUEGO";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // linkLabel2
            // 
            linkLabel2.ActiveLinkColor = Color.FromArgb(15, 15, 15);
            linkLabel2.AutoSize = true;
            linkLabel2.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            linkLabel2.LinkColor = Color.Silver;
            linkLabel2.Location = new Point(103, 294);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(120, 20);
            linkLabel2.TabIndex = 14;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Eliminar cuenta";
            linkLabel2.Click += linkLabel2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.DeepPink;
            label1.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(103, 15);
            label1.Name = "label1";
            label1.Size = new Size(90, 30);
            label1.TabIndex = 13;
            label1.Text = "LOGIN";
            // 
            // linkLabel1
            // 
            linkLabel1.ActiveLinkColor = Color.FromArgb(15, 15, 15);
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            linkLabel1.LinkColor = Color.Silver;
            linkLabel1.Location = new Point(46, 262);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(234, 20);
            linkLabel1.TabIndex = 12;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "¿Todavía no te has registrado?";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            linkLabel1.MouseClick += linkLabel1_MouseClick;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(15, 15, 15);
            panel4.Location = new Point(37, 178);
            panel4.Name = "panel4";
            panel4.Size = new Size(226, 2);
            panel4.TabIndex = 11;
            panel4.Paint += panel4_Paint;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(15, 15, 15);
            panel3.Location = new Point(37, 134);
            panel3.Name = "panel3";
            panel3.Size = new Size(226, 2);
            panel3.TabIndex = 10;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(15, 15, 15);
            panel2.Location = new Point(37, 82);
            panel2.Name = "panel2";
            panel2.Size = new Size(226, 2);
            panel2.TabIndex = 9;
            panel2.Paint += panel2_Paint;
            // 
            // panel5
            // 
            panel5.BackColor = Color.DeepPink;
            panel5.Location = new Point(735, 205);
            panel5.Name = "panel5";
            panel5.Size = new Size(98, 2);
            panel5.TabIndex = 27;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 15, 15);
            ClientSize = new Size(939, 332);
            Controls.Add(panel5);
            Controls.Add(cbx_existe);
            Controls.Add(lbl_iniciado);
            Controls.Add(btn_invitar);
            Controls.Add(btn_enviar);
            Controls.Add(lbl_contar);
            Controls.Add(tB_peticion);
            Controls.Add(cbx_ganador);
            Controls.Add(cbx_jugadas);
            Controls.Add(cbx_ganadas);
            Controls.Add(lbl_peticiones);
            Controls.Add(btn_salir);
            Controls.Add(lbl_conectados);
            Controls.Add(dgv_conectados);
            Controls.Add(lbl_Bienvenido);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "Form1";
            Opacity = 0.98D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_conectados).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox tB_contrasena;
        private TextBox tB_email;
        private Button btn_Iniciar;
        private Label lbl_Bienvenido;
        private DataGridView dgv_conectados;
        private Label lbl_conectados;
        private Button btn_salir;
        private Label lbl_peticiones;
        private CheckBox cbx_ganadas;
        private CheckBox cbx_jugadas;
        private CheckBox cbx_ganador;
        private TextBox tB_peticion;
        private Label lbl_contar;
        private Button btn_enviar;
        private Button btn_invitar;
        public TextBox tB_nombre;
        private Label lbl_iniciado;
        private CheckBox cbx_existe;
        private Panel panel1;
        private Panel panel2;
        private Panel panel4;
        private Panel panel3;
        private LinkLabel linkLabel1;
        private Label label1;
        private LinkLabel linkLabel2;
        private Panel panel5;
        private Button button1;
    }
}