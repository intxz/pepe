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
            btn_Olvidado = new Button();
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
            btn_baja = new Button();
            cbx_existe = new CheckBox();
            panel1 = new Panel();
            label1 = new Label();
            linkLabel1 = new LinkLabel();
            panel4 = new Panel();
            panel3 = new Panel();
            panel2 = new Panel();
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
            btn_Iniciar.Text = "INICIAR JUEGO";
            btn_Iniciar.UseVisualStyleBackColor = false;
            btn_Iniciar.Click += btn_Iniciar_Click;
            // 
            // btn_Olvidado
            // 
            btn_Olvidado.Location = new Point(56, 303);
            btn_Olvidado.Margin = new Padding(2);
            btn_Olvidado.Name = "btn_Olvidado";
            btn_Olvidado.Size = new Size(204, 20);
            btn_Olvidado.TabIndex = 8;
            btn_Olvidado.Text = "He olvidado mi contraseña";
            btn_Olvidado.UseVisualStyleBackColor = true;
            btn_Olvidado.Click += btn_Olvidado_Click;
            // 
            // lbl_Bienvenido
            // 
            lbl_Bienvenido.AutoSize = true;
            lbl_Bienvenido.Font = new Font("Papyrus", 28F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lbl_Bienvenido.Location = new Point(321, 9);
            lbl_Bienvenido.Margin = new Padding(2, 0, 2, 0);
            lbl_Bienvenido.Name = "lbl_Bienvenido";
            lbl_Bienvenido.Size = new Size(178, 60);
            lbl_Bienvenido.TabIndex = 9;
            lbl_Bienvenido.Text = "TABÚ";
            // 
            // dgv_conectados
            // 
            dgv_conectados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_conectados.Location = new Point(388, 121);
            dgv_conectados.Margin = new Padding(2);
            dgv_conectados.Name = "dgv_conectados";
            dgv_conectados.RowHeadersWidth = 62;
            dgv_conectados.RowTemplate.Height = 33;
            dgv_conectados.Size = new Size(270, 150);
            dgv_conectados.TabIndex = 10;
            // 
            // lbl_conectados
            // 
            lbl_conectados.AutoSize = true;
            lbl_conectados.Font = new Font("Bahnschrift SemiBold Condensed", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_conectados.Location = new Point(438, 88);
            lbl_conectados.Margin = new Padding(2, 0, 2, 0);
            lbl_conectados.Name = "lbl_conectados";
            lbl_conectados.Size = new Size(165, 17);
            lbl_conectados.TabIndex = 11;
            lbl_conectados.Text = "Usuarios actualmente conectados";
            // 
            // btn_salir
            // 
            btn_salir.Location = new Point(817, 302);
            btn_salir.Margin = new Padding(2);
            btn_salir.Name = "btn_salir";
            btn_salir.Size = new Size(64, 23);
            btn_salir.TabIndex = 12;
            btn_salir.Text = "Salir";
            btn_salir.UseVisualStyleBackColor = true;
            btn_salir.Click += btn_salir_Click;
            // 
            // lbl_peticiones
            // 
            lbl_peticiones.AutoSize = true;
            lbl_peticiones.Font = new Font("Bahnschrift SemiBold Condensed", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_peticiones.Location = new Point(729, 90);
            lbl_peticiones.Margin = new Padding(2, 0, 2, 0);
            lbl_peticiones.Name = "lbl_peticiones";
            lbl_peticiones.Size = new Size(54, 17);
            lbl_peticiones.TabIndex = 13;
            lbl_peticiones.Text = "Peticiones";
            // 
            // cbx_ganadas
            // 
            cbx_ganadas.AutoSize = true;
            cbx_ganadas.Location = new Point(709, 119);
            cbx_ganadas.Margin = new Padding(2);
            cbx_ganadas.Name = "cbx_ganadas";
            cbx_ganadas.Size = new Size(143, 19);
            cbx_ganadas.TabIndex = 15;
            cbx_ganadas.Text = "Partidas ganadas de ...";
            cbx_ganadas.UseVisualStyleBackColor = true;
            // 
            // cbx_jugadas
            // 
            cbx_jugadas.AutoSize = true;
            cbx_jugadas.Location = new Point(709, 140);
            cbx_jugadas.Margin = new Padding(2);
            cbx_jugadas.Name = "cbx_jugadas";
            cbx_jugadas.Size = new Size(140, 19);
            cbx_jugadas.TabIndex = 16;
            cbx_jugadas.Text = "Partidas jugadas de ...";
            cbx_jugadas.UseVisualStyleBackColor = true;
            // 
            // cbx_ganador
            // 
            cbx_ganador.AutoSize = true;
            cbx_ganador.Location = new Point(709, 212);
            cbx_ganador.Margin = new Padding(2);
            cbx_ganador.Name = "cbx_ganador";
            cbx_ganador.Size = new Size(156, 19);
            cbx_ganador.TabIndex = 17;
            cbx_ganador.Text = "Jugador con más puntos";
            cbx_ganador.UseVisualStyleBackColor = true;
            // 
            // tB_peticion
            // 
            tB_peticion.Location = new Point(735, 185);
            tB_peticion.Margin = new Padding(2);
            tB_peticion.Name = "tB_peticion";
            tB_peticion.Size = new Size(98, 23);
            tB_peticion.TabIndex = 18;
            // 
            // lbl_contar
            // 
            lbl_contar.BorderStyle = BorderStyle.FixedSingle;
            lbl_contar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_contar.Location = new Point(796, 88);
            lbl_contar.Margin = new Padding(2, 0, 2, 0);
            lbl_contar.Name = "lbl_contar";
            lbl_contar.Size = new Size(29, 21);
            lbl_contar.TabIndex = 19;
            // 
            // btn_enviar
            // 
            btn_enviar.Location = new Point(727, 240);
            btn_enviar.Margin = new Padding(2);
            btn_enviar.Name = "btn_enviar";
            btn_enviar.Size = new Size(120, 29);
            btn_enviar.TabIndex = 20;
            btn_enviar.Text = "Realizar petición";
            btn_enviar.UseVisualStyleBackColor = true;
            btn_enviar.Click += btn_enviar_Click;
            // 
            // btn_invitar
            // 
            btn_invitar.Location = new Point(480, 289);
            btn_invitar.Margin = new Padding(2);
            btn_invitar.Name = "btn_invitar";
            btn_invitar.Size = new Size(90, 20);
            btn_invitar.TabIndex = 22;
            btn_invitar.Text = "Invitar";
            btn_invitar.UseVisualStyleBackColor = true;
            btn_invitar.Click += btn_invitar_Click;
            // 
            // lbl_iniciado
            // 
            lbl_iniciado.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lbl_iniciado.AutoSize = true;
            lbl_iniciado.Font = new Font("Perpetua Titling MT", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_iniciado.Location = new Point(774, 13);
            lbl_iniciado.Margin = new Padding(2, 0, 2, 0);
            lbl_iniciado.Name = "lbl_iniciado";
            lbl_iniciado.Size = new Size(98, 32);
            lbl_iniciado.TabIndex = 23;
            lbl_iniciado.Text = "label1";
            lbl_iniciado.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btn_baja
            // 
            btn_baja.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            btn_baja.Location = new Point(762, 45);
            btn_baja.Margin = new Padding(2);
            btn_baja.Name = "btn_baja";
            btn_baja.Size = new Size(108, 19);
            btn_baja.TabIndex = 24;
            btn_baja.Text = "Darse de baja";
            btn_baja.UseVisualStyleBackColor = true;
            btn_baja.Click += btn_baja_Click;
            // 
            // cbx_existe
            // 
            cbx_existe.AutoSize = true;
            cbx_existe.Location = new Point(709, 161);
            cbx_existe.Margin = new Padding(2);
            cbx_existe.Name = "cbx_existe";
            cbx_existe.Size = new Size(68, 19);
            cbx_existe.TabIndex = 25;
            cbx_existe.Text = "Existe ...";
            cbx_existe.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DeepPink;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(linkLabel1);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(btn_Iniciar);
            panel1.Controls.Add(btn_Olvidado);
            panel1.Controls.Add(tB_nombre);
            panel1.Controls.Add(tB_contrasena);
            panel1.Controls.Add(tB_email);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(367, 332);
            panel1.TabIndex = 26;
            panel1.Paint += panel1_Paint;
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 15, 15);
            ClientSize = new Size(888, 332);
            Controls.Add(cbx_existe);
            Controls.Add(btn_baja);
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
        private Button btn_Olvidado;
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
        private Button btn_baja;
        private CheckBox cbx_existe;
        private Panel panel1;
        private Panel panel2;
        private Panel panel4;
        private Panel panel3;
        private LinkLabel linkLabel1;
        private Label label1;
    }
}