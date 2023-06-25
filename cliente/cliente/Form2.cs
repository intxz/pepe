using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Reflection.Emit;

namespace cliente
{
    public partial class Form2 : Form
    {
        int nform;
        Socket server;
        public Form2(int nf, Socket serv)
        {
            InitializeComponent();
            this.nform = nf;
            this.server = serv;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            numform.Text = nform.ToString();
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label6.Text = "0";
            button2.Visible = false;
            button3.Visible = false;
            button5.Visible = false;
            richTextBox1.Visible = false;
            if (numform.Text == "0")
            {
                button1.Visible = true;
                button4.Visible = false;
                label11.Text = "Te toca preguntar";
                label11.BackColor = Color.Green;
            }
            else if (numform.Text == "1")
            {
                button1.Visible = false;
                button4.Visible = true;
                label11.Text = "Te toca adivinar";
                label11.BackColor = Color.Red;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            timer1.Start();
            //Random rnd1 = new Random();
            //int numero1 = rnd1.Next(0, 50);
            int numero1 = 0;
            if (numero1 == 0) //YO CAMBIARIA ESTA CARTA 
            {
                label1.Text = "PEPE"; // PERSONA
                label2.Text = "PACO"; // NOMBRE
                label3.Text = "MIGUEL"; // HUMANO
                label4.Text = "KAKASHI"; // MUNDO
                button1.Enabled = false;
                string env = "11/" + nform + "/" + label1.Text + "/" + label2.Text + "/" + label3.Text + "/" + label4.Text;
                byte[] msg = System.Text.Encoding.UTF8.GetBytes(env);
                server.Send(msg);
            }
            else if (numero1 == 1)
            {
                label1.Text = "PADRE";
                label2.Text = "PAPA";
                label3.Text = "HOMBRE";
                label4.Text = "HIJO";
                button1.Enabled = false;
                string env = "11/" + nform + "/" + label1.Text + "/" + label2.Text + "/" + label3.Text + "/" + label4.Text;
                byte[] msg = System.Text.Encoding.UTF8.GetBytes(env);
                server.Send(msg);
            }
            else if (numero1 == 2)
            {
                label1.Text = "HAMACA";
                label2.Text = "CAMA";
                label3.Text = "DORMIR";
                label4.Text = "COLGAR";
                button1.Enabled = false;
                string env = "11/" + nform + "/" + label1.Text + "/" + label2.Text + "/" + label3.Text + "/" + label4.Text;
                byte[] msg = System.Text.Encoding.UTF8.GetBytes(env);
                server.Send(msg);
            }
            else if (numero1 == 3)
            {
                label1.Text = "ARMARIO";
                label2.Text = "ROPA";
                label3.Text = "SALIR";
                label4.Text = "DISFRAZ";
                button1.Enabled = false;
                string env = "11/" + nform + "/" + label1.Text + "/" + label2.Text + "/" + label3.Text + "/" + label4.Text;
                byte[] msg = System.Text.Encoding.UTF8.GetBytes(env);
                server.Send(msg);
            }
            else if (numero1 == 4)
            {
                label1.Text = "PULGAR";
                label2.Text = "DEDO";
                label3.Text = "MANO";
                label4.Text = "TOCAR";
                button1.Enabled = false;
                string env = "11/" + nform + "/" + label1.Text + "/" + label2.Text + "/" + label3.Text + "/" + label4.Text;
                byte[] msg = System.Text.Encoding.UTF8.GetBytes(env);
                server.Send(msg);
            }
            else if (numero1 == 5)
            {
                label1.Text = "FARMACO";
                label2.Text = "MEDICO";
                label3.Text = "MEDICINA";
                label4.Text = "ANESTESIA";
                button1.Enabled = false;
                string env = "11/" + nform + "/" + label1.Text + "/" + label2.Text + "/" + label3.Text + "/" + label4.Text;
                byte[] msg = System.Text.Encoding.UTF8.GetBytes(env);
                server.Send(msg);
            }
            else if (numero1 == 6)
            {
                label1.Text = "ESTORNUDAR";
                label2.Text = "SALUD";
                label3.Text = "FRIO";
                label4.Text = "NARIZ";
                button1.Enabled = false;
                string env = "11/" + nform + "/" + label1.Text + "/" + label2.Text + "/" + label3.Text + "/" + label4.Text;
                byte[] msg = System.Text.Encoding.UTF8.GetBytes(env);
                server.Send(msg);
            }
            else if (numero1 == 7)
            {
                label1.Text = "FALDA";
                label2.Text = "ROPA";
                label3.Text = "BLUSA";
                label4.Text = "VESTIDO";
                button1.Enabled = false;
                string env = "11/" + nform + "/" + label1.Text + "/" + label2.Text + "/" + label3.Text + "/" + label4.Text;
                byte[] msg = System.Text.Encoding.UTF8.GetBytes(env);
                server.Send(msg);
            }
            else if (numero1 == 8)
            {
                label1.Text = "HERENCIA";
                label2.Text = "TESTAMENTO";
                label3.Text = "PADRES";
                label4.Text = "VOLUNTAD";
                button1.Enabled = false;
                string env = "11/" + nform + "/" + label1.Text + "/" + label2.Text + "/" + label3.Text + "/" + label4.Text;
                byte[] msg = System.Text.Encoding.UTF8.GetBytes(env);
                server.Send(msg);
            }
            else if (numero1 == 9)
            {
                label1.Text = "PANTANO";
                label2.Text = "AGUA";
                label3.Text = "SUR";
                label4.Text = "LANCHA";
                button1.Enabled = false;
                string env = "11/" + nform + "/" + label1.Text + "/" + label2.Text + "/" + label3.Text + "/" + label4.Text;
                byte[] msg = System.Text.Encoding.UTF8.GetBytes(env);
                server.Send(msg);
            }
            else if (numero1 == 10)
            {
                label1.Text = "TRIANGULO";
                label2.Text = "PIRAMIDE";
                label3.Text = "FORMA";
                label4.Text = "PUNTOS";
                button1.Enabled = false;
                string env = "11/" + nform + "/" + label1.Text + "/" + label2.Text + "/" + label3.Text + "/" + label4.Text;
                byte[] msg = System.Text.Encoding.UTF8.GetBytes(env);
                server.Send(msg);
            }
            else if (numero1 == 11)
            {
                label1.Text = "TIRANTES";
                label2.Text = "HOMBROS";
                label3.Text = "ROPA";
                label4.Text = "TOP";
                button1.Enabled = false;
                string env = "11/" + nform + "/" + label1.Text + "/" + label2.Text + "/" + label3.Text + "/" + label4.Text;
                byte[] msg = System.Text.Encoding.UTF8.GetBytes(env);
                server.Send(msg);
            }
            else if (numero1 == 12)
            {
                label1.Text = "DINERO";
                label2.Text = "EURO";
                label3.Text = "DIVISA";
                label4.Text = "LIBRA";
                button1.Enabled = false;
                string env = "11/" + nform + "/" + label1.Text + "/" + label2.Text + "/" + label3.Text + "/" + label4.Text;
                byte[] msg = System.Text.Encoding.UTF8.GetBytes(env);
                server.Send(msg);
            }
            else if (numero1 == 13)
            {
                label1.Text = "RIFAR";
                label2.Text = "LOTERIA";
                label3.Text = "ENTRADA";
                label4.Text = "BOLETO";
                button1.Enabled = false;
                string env = "11/" + nform + "/" + label1.Text + "/" + label2.Text + "/" + label3.Text + "/" + label4.Text;
                byte[] msg = System.Text.Encoding.UTF8.GetBytes(env);
                server.Send(msg);
            }
            else if (numero1 == 14)
            {
                label1.Text = "HABLAR";
                label2.Text = "CONVERSAR";
                label3.Text = "DECIR";
                label4.Text = "IDIOMA";
                button1.Enabled = false;
                string env = "11/" + nform + "/" + label1.Text + "/" + label2.Text + "/" + label3.Text + "/" + label4.Text;
                byte[] msg = System.Text.Encoding.UTF8.GetBytes(env);
                server.Send(msg);
            }
            else if (numero1 == 15)
            {
                label1.Text = "HORIZONTE";
                label2.Text = "LINEA";
                label3.Text = "MAR";
                label4.Text = "CUIDAD";
                button1.Enabled = false;
                string env = "11/" + nform + "/" + label1.Text + "/" + label2.Text + "/" + label3.Text + "/" + label4.Text;
                byte[] msg = System.Text.Encoding.UTF8.GetBytes(env);
                server.Send(msg);
            }
            else if (numero1 == 16)
            {
                label1.Text = "BATALLA";
                label2.Text = "GUERRA";
                label3.Text = "PELEA";
                label4.Text = "EJERCITO";
                button1.Enabled = false;
                string env = "11/" + nform + "/" + label1.Text + "/" + label2.Text + "/" + label3.Text + "/" + label4.Text;
                byte[] msg = System.Text.Encoding.UTF8.GetBytes(env);
                server.Send(msg);
            }
            else if (numero1 == 17)
            {
                label1.Text = "TRUFA";
                label2.Text = "CHOCOLATE";
                label3.Text = "SETA";
                label4.Text = "JABALI";
                button1.Enabled = false;
                string env = "11/" + nform + "/" + label1.Text + "/" + label2.Text + "/" + label3.Text + "/" + label4.Text;
                byte[] msg = System.Text.Encoding.UTF8.GetBytes(env);
                server.Send(msg);
            }
            else if (numero1 == 18)
            {
                label1.Text = "PROCESION";
                label2.Text = "SANTO";
                label3.Text = "SEVILLA";
                label4.Text = "IGLESIA";
                button1.Enabled = false;
                string env = "11/" + nform + "/" + label1.Text + "/" + label2.Text + "/" + label3.Text + "/" + label4.Text;
                byte[] msg = System.Text.Encoding.UTF8.GetBytes(env);
                server.Send(msg);
            }
            else if (numero1 == 19)
            {
                label1.Text = "ROSA";
                label2.Text = "COLOR";
                label3.Text = "CHICA";
                label4.Text = "BEBE";
                button1.Enabled = false;
                string env = "11/" + nform + "/" + label1.Text + "/" + label2.Text + "/" + label3.Text + "/" + label4.Text;
                byte[] msg = System.Text.Encoding.UTF8.GetBytes(env);
                server.Send(msg);
            }
            else if (numero1 == 20)
            {
                label1.Text = "IDIOTA";
                label2.Text = "ESTUPIDO";
                label3.Text = "IMBECIL";
                label4.Text = "INSULTO";
                button1.Enabled = false;
                string env = "11/" + nform + "/" + label1.Text + "/" + label2.Text + "/" + label3.Text + "/" + label4.Text;
                byte[] msg = System.Text.Encoding.UTF8.GetBytes(env);
                server.Send(msg);
            }
            else if (numero1 == 21)
            {
                label1.Text = "CONFERENCIA";
                label2.Text = "DISCURSO";
                label3.Text = "HABLAR";
                label4.Text = "CHARLA";
                button1.Enabled = false;
                string env = "11/" + nform + "/" + label1.Text + "/" + label2.Text + "/" + label3.Text + "/" + label4.Text;
                byte[] msg = System.Text.Encoding.UTF8.GetBytes(env);
                server.Send(msg);
            }
            else if (numero1 == 22)
            {
                label1.Text = "CONTENDIENTE";
                label2.Text = "PARTICIPANTE";
                label3.Text = "FAVORITO";
                label4.Text = "OPONENTE";
                button1.Enabled = false;
                string env = "11/" + nform + "/" + label1.Text + "/" + label2.Text + "/" + label3.Text + "/" + label4.Text;
                byte[] msg = System.Text.Encoding.UTF8.GetBytes(env);
                server.Send(msg);
            }
            else if (numero1 == 23)
            {
                label1.Text = "BARAJAR";
                label2.Text = "CARTAS";
                label3.Text = "JUEGO";
                label4.Text = "MESA";
                button1.Enabled = false;
                string env = "11/" + nform + "/" + label1.Text + "/" + label2.Text + "/" + label3.Text + "/" + label4.Text;
                byte[] msg = System.Text.Encoding.UTF8.GetBytes(env);
                server.Send(msg);
            }
            else if (numero1 == 24)
            {
                label1.Text = "ESTACA";
                label2.Text = "MADERA";
                label3.Text = "VAMPIRO";
                label4.Text = "MATAR";
                button1.Enabled = false;
                string env = "11/" + nform + "/" + label1.Text + "/" + label2.Text + "/" + label3.Text + "/" + label4.Text;
                byte[] msg = System.Text.Encoding.UTF8.GetBytes(env);
                server.Send(msg);
            }
            else if (numero1 == 25)
            {
                label1.Text = "ANIMAR";
                label2.Text = "APOYAR";
                label3.Text = "ESTADIO";
                label4.Text = "AFICIONADOS";
                button1.Enabled = false;
                string env = "11/" + nform + "/" + label1.Text + "/" + label2.Text + "/" + label3.Text + "/" + label4.Text;
                byte[] msg = System.Text.Encoding.UTF8.GetBytes(env);
                server.Send(msg);
            }
            else if (numero1 == 26)
            {
                label1.Text = "DESTINO";
                label2.Text = "VIAJE";
                label3.Text = "RUTA";
                label4.Text = "COCHE";
                button1.Enabled = false;
                string env = "11/" + nform + "/" + label1.Text + "/" + label2.Text + "/" + label3.Text + "/" + label4.Text;
                byte[] msg = System.Text.Encoding.UTF8.GetBytes(env);
                server.Send(msg);
            }
            else if (numero1 == 27)
            {
                label1.Text = "CHOZA";
                label2.Text = "CASA";
                label3.Text = "CABAÑA";
                label4.Text = "INESTABLE";
                button1.Enabled = false;
                string env = "11/" + nform + "/" + label1.Text + "/" + label2.Text + "/" + label3.Text + "/" + label4.Text;
                byte[] msg = System.Text.Encoding.UTF8.GetBytes(env);
                server.Send(msg);
            }
            else if (numero1 == 28)
            {
                label1.Text = "PRUEBA";
                label2.Text = "EXAMEN";
                label3.Text = "EVALUAR";
                label4.Text = "ESCUELA";
                button1.Enabled = false;
                string env = "11/" + nform + "/" + label1.Text + "/" + label2.Text + "/" + label3.Text + "/" + label4.Text;
                byte[] msg = System.Text.Encoding.UTF8.GetBytes(env);
                server.Send(msg);
            }
            else if (numero1 == 29)
            {
                label1.Text = "PORTON";
                label2.Text = "JARDIN";
                label3.Text = "PUERTA";
                label4.Text = "VALLA";
                button1.Enabled = false;
                string env = "11/" + nform + "/" + label1.Text + "/" + label2.Text + "/" + label3.Text + "/" + label4.Text;
                byte[] msg = System.Text.Encoding.UTF8.GetBytes(env);
                server.Send(msg);
            }
            else if (numero1 == 30)
            {
                label1.Text = "SUEGRO";
                label2.Text = "FAMILIA";
                label3.Text = "ESPOSO";
                label4.Text = "PADRES";
                button1.Enabled = false;
                string env = "11/" + nform + "/" + label1.Text + "/" + label2.Text + "/" + label3.Text + "/" + label4.Text;
                byte[] msg = System.Text.Encoding.UTF8.GetBytes(env);
                server.Send(msg);
            }
            else if (numero1 == 31)
            {
                label1.Text = "MAYOR";
                label2.Text = "HERMANO";
                label3.Text = "INCREMENTAR";
                label4.Text = "SUPERIOR";
                button1.Enabled = false;
                string env = "11/" + nform + "/" + label1.Text + "/" + label2.Text + "/" + label3.Text + "/" + label4.Text;
                byte[] msg = System.Text.Encoding.UTF8.GetBytes(env);
                server.Send(msg);
            }
            else if (numero1 == 32)
            {
                label1.Text = "PROPINA";
                label2.Text = "DINERO";
                label3.Text = "RESTAURANTE";
                label4.Text = "COMIDA";
                button1.Enabled = false;
                string env = "11/" + nform + "/" + label1.Text + "/" + label2.Text + "/" + label3.Text + "/" + label4.Text;
                byte[] msg = System.Text.Encoding.UTF8.GetBytes(env);
                server.Send(msg);
            }
            else if (numero1 == 33)
            {
                label1.Text = "HIPO";
                label2.Text = "COMER";
                label3.Text = "BEBER";
                label4.Text = "AIRE";
                button1.Enabled = false;
                string env = "11/" + nform + "/" + label1.Text + "/" + label2.Text + "/" + label3.Text + "/" + label4.Text;
                byte[] msg = System.Text.Encoding.UTF8.GetBytes(env);
                server.Send(msg);
            }
            else if (numero1 == 34)
            {
                label1.Text = "MAPA";
                label2.Text = "VIAJE";
                label3.Text = "CARRETERA";
                label4.Text = "ENCONTRAR";
                button1.Enabled = false;
                string env = "11/" + nform + "/" + label1.Text + "/" + label2.Text + "/" + label3.Text + "/" + label4.Text;
                byte[] msg = System.Text.Encoding.UTF8.GetBytes(env);
                server.Send(msg);
            }
            else if (numero1 == 35)
            {
                label1.Text = "APAGAR";
                label2.Text = "ENCENDER";
                label3.Text = "LUZ";
                label4.Text = "INTERRUPTOR";
                button1.Enabled = false;
                string env = "11/" + nform + "/" + label1.Text + "/" + label2.Text + "/" + label3.Text + "/" + label4.Text;
                byte[] msg = System.Text.Encoding.UTF8.GetBytes(env);
                server.Send(msg);
            }
            else if (numero1 == 36)
            {
                label1.Text = "CALLE";
                label2.Text = "CARRETERA";
                label3.Text = "AVENIDA";
                label4.Text = "DIRECCION";
                button1.Enabled = false;
                string env = "11/" + nform + "/" + label1.Text + "/" + label2.Text + "/" + label3.Text + "/" + label4.Text;
                byte[] msg = System.Text.Encoding.UTF8.GetBytes(env);
                server.Send(msg);
            }
            else if (numero1 == 37)
            {
                label1.Text = "IRA";
                label2.Text = "LOCURA";
                label3.Text = "ENFADO";
                label4.Text = "CALMA";
                button1.Enabled = false;
                string env = "11/" + nform + "/" + label1.Text + "/" + label2.Text + "/" + label3.Text + "/" + label4.Text;
                byte[] msg = System.Text.Encoding.UTF8.GetBytes(env);
                server.Send(msg);
            }
            else if (numero1 == 38)
            {
                label1.Text = "PELO";
                label2.Text = "CORTAR";
                label3.Text = "TEÑIR";
                label4.Text = "PELUCA";
                button1.Enabled = false;
                string env = "11/" + nform + "/" + label1.Text + "/" + label2.Text + "/" + label3.Text + "/" + label4.Text;
                byte[] msg = System.Text.Encoding.UTF8.GetBytes(env);
                server.Send(msg);
            }
            else if (numero1 == 39)
            {
                label1.Text = "CINTA";
                label2.Text = "GRABACION";
                label3.Text = "PEGAR";
                label4.Text = "CASETE";
                button1.Enabled = false;
                string env = "11/" + nform + "/" + label1.Text + "/" + label2.Text + "/" + label3.Text + "/" + label4.Text;
                byte[] msg = System.Text.Encoding.UTF8.GetBytes(env);
                server.Send(msg);
            }
            else if (numero1 == 40)
            {
                label1.Text = "MASTICAR";
                label2.Text = "DIENTES";
                label3.Text = "COMIDA";
                label4.Text = "CHICLE";
                button1.Enabled = false;
                string env = "11/" + nform + "/" + label1.Text + "/" + label2.Text + "/" + label3.Text + "/" + label4.Text;
                byte[] msg = System.Text.Encoding.UTF8.GetBytes(env);
                server.Send(msg);
            }
            else if (numero1 == 41)
            {
                label1.Text = "ASTROLOGIA";
                label2.Text = "ESTRELLAS";
                label3.Text = "FUTURO";
                label4.Text = "ZODIACO";
                button1.Enabled = false;
                string env = "11/" + nform + "/" + label1.Text + "/" + label2.Text + "/" + label3.Text + "/" + label4.Text;
                byte[] msg = System.Text.Encoding.UTF8.GetBytes(env);
                server.Send(msg);
            }
            else if (numero1 == 42)
            {
                label1.Text = "ARENA";
                label2.Text = "PLAYA";
                label3.Text = "MAR";
                label4.Text = "COLISEO";
                button1.Enabled = false;
                string env = "11/" + nform + "/" + label1.Text + "/" + label2.Text + "/" + label3.Text + "/" + label4.Text;
                byte[] msg = System.Text.Encoding.UTF8.GetBytes(env);
                server.Send(msg);
            }
            else if (numero1 == 43)
            {
                label1.Text = "GIGANTE";
                label2.Text = "GRANDE";
                label3.Text = "ENORME";
                label4.Text = "PEQUEÑO";
                button1.Enabled = false;
                string env = "11/" + nform + "/" + label1.Text + "/" + label2.Text + "/" + label3.Text + "/" + label4.Text;
                byte[] msg = System.Text.Encoding.UTF8.GetBytes(env);
                server.Send(msg);
            }
            else if (numero1 == 44)
            {
                label1.Text = "ERROR";
                label2.Text = "FALLO";
                label3.Text = "ACCIDENTE";
                label4.Text = "CORRECTO";
                button1.Enabled = false;
                string env = "11/" + nform + "/" + label1.Text + "/" + label2.Text + "/" + label3.Text + "/" + label4.Text;
                byte[] msg = System.Text.Encoding.UTF8.GetBytes(env);
                server.Send(msg);
            }
            else if (numero1 == 45)
            {
                label1.Text = "PLATANO";
                label2.Text = "FRUTA";
                label3.Text = "AMARILLO";
                label4.Text = "CANARIAS";
                button1.Enabled = false;
                string env = "11/" + nform + "/" + label1.Text + "/" + label2.Text + "/" + label3.Text + "/" + label4.Text;
                byte[] msg = System.Text.Encoding.UTF8.GetBytes(env);
                server.Send(msg);
            }
            else if (numero1 == 46)
            {
                label1.Text = "BRIE";
                label2.Text = "QUESO";
                label3.Text = "FRANCES";
                label4.Text = "COMER";
                button1.Enabled = false;
                string env = "11/" + nform + "/" + label1.Text + "/" + label2.Text + "/" + label3.Text + "/" + label4.Text;
                byte[] msg = System.Text.Encoding.UTF8.GetBytes(env);
                server.Send(msg);
            }
            else if (numero1 == 47)
            {
                label1.Text = "AMBULANCIA";
                label2.Text = "HOSPITAL";
                label3.Text = "VEHICULO";
                label4.Text = "PARAMEDICO";
                button1.Enabled = false;
                string env = "11/" + nform + "/" + label1.Text + "/" + label2.Text + "/" + label3.Text + "/" + label4.Text;
                byte[] msg = System.Text.Encoding.UTF8.GetBytes(env);
                server.Send(msg);
            }
            else if (numero1 == 48)
            {
                label1.Text = "REVISTA";
                label2.Text = "DIARIO";
                label3.Text = "NOTICIAS";
                label4.Text = "ARTICULO";
                button1.Enabled = false;
                string env = "11/" + nform + "/" + label1.Text + "/" + label2.Text + "/" + label3.Text + "/" + label4.Text;
                byte[] msg = System.Text.Encoding.UTF8.GetBytes(env);
                server.Send(msg);
            }
            else if (numero1 == 49)
            {
                label1.Text = "FLOTAR";
                label2.Text = "NADAR";
                label3.Text = "AGUA";
                label4.Text = "PISCINA";
                button1.Enabled = false;
                string env = "11/" + nform + "/" + label1.Text + "/" + label2.Text + "/" + label3.Text + "/" + label4.Text;
                byte[] msg = System.Text.Encoding.UTF8.GetBytes(env);
                server.Send(msg);
            }
            else if (numero1 == 50)
            {
                label1.Text = "ANTIDOTO";
                label2.Text = "VENENO";
                label3.Text = "CURA";
                label4.Text = "REMEDIO";
                button1.Enabled = false;
                string env = "11/" + nform + "/" + label1.Text + "/" + label2.Text + "/" + label3.Text + "/" + label4.Text;
                byte[] msg = System.Text.Encoding.UTF8.GetBytes(env);
                server.Send(msg);
            }
            button1.Visible = false;
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string text = richTextBox1.Text;
            string[] trozos = text.Split();
            int x = 0;
            for (int i = 0; i < trozos.Length; i++)
            {
                if (trozos[i] == label2.Text || trozos[i] == label3.Text || trozos[i] == label4.Text)
                {
                    x = 1;
                }
                else if (trozos[i] == label1.Text)
                {
                    x = 2;
                }
                else
                {
                    x = 0;
                }
            }
            if (x == 1)
            {
                MessageBox.Show("Esto esta mal");
                int y = Convert.ToInt32(label6.Text);
                y = y - 1;
                label6.Text = Convert.ToString(y);
            }
            else if (x == 0) //envia la descrpcion
            {
                string env = "14/" + nform + "/" + richTextBox1.Text;
                byte[] msg = System.Text.Encoding.UTF8.GetBytes(env);
                server.Send(msg);
            }
            else if (x == 2)
            {
                MessageBox.Show("¿Te caiste de pequeño?");
                int y = Convert.ToInt32(label6.Text);
                y = y - 9999999;
                label6.Text = Convert.ToString(y);
            }
            richTextBox1.Clear();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            richTextBox1.Visible = true;
            button2.Visible = true;
            timer1.Stop();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string text = richTextBox1.Text;
            string[] trozos = text.Split();
            int x = 0;
            for (int i = 0; i < trozos.Length; i++)
            {
                if (trozos[i] == label8.Text || trozos[i] == label9.Text || trozos[i] == label10.Text)
                {
                    x = 1;
                }
                else if (trozos[i] == label7.Text)
                {
                    x = 2;
                }
                else
                {
                    x = 0;
                }
            }
            if (x == 1)
            {
                MessageBox.Show("Casi, vas por buen camino");
                int y = Convert.ToInt32(label6.Text);
                y = y + 1;
                label6.Text = Convert.ToString(y);
                button3.Enabled = false;
                button5.Enabled = true;
            }
            else if (x == 0)
            {
                MessageBox.Show("No es jeje");
                int y = Convert.ToInt32(label6.Text);
                y = y - 1;
                label6.Text = Convert.ToString(y);
                //futura implementacion para sumar puntos al que pregunta cuando se equivocan
                //string env = "X/1"; 
                //MessageBox.Show(env);
                button3.Enabled = false;
                button5.Enabled = true;
            }
            else if (x == 2)
            {
                MessageBox.Show("Tienes demasiada inteligencia");
                int y = Convert.ToInt32(label6.Text);
                y = y + 3;
                label6.Text = Convert.ToString(y);
                button1.Enabled = true;
                label11.Text = "Te toca preguntar";
                label11.BackColor = Color.Green;
            }

            richTextBox1.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            timer2.Start();
            //string rec = "8/COCHE/RUEDAS/AUTOMOVIL/COMBUSTIBLE";
            //string[] trozos = rec.Split('/');
            //label7.Text = trozos[1];
            //label8.Text = trozos[2];
            //label9.Text = trozos[3];
            //label10.Text = trozos[4];
            //MessageBox.Show(trozos[1]);
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            button3.Visible = true;
            button5.Visible = true;
            button3.Enabled = false;
            richTextBox1.Visible = true;
            button4.Visible = false;
            timer2.Stop();
            MessageBox.Show("Pide una pista");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string env = "12/"+nform+"/" + richTextBox1.Text;
            byte[] msg = System.Text.Encoding.UTF8.GetBytes(env);
            server.Send(msg);
            button3.Enabled = true;
            button5.Enabled = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int z = e.RowIndex;
            string rec = (string)dataGridView1.Rows[z].Cells[0].Value;
            DialogResult x = MessageBox.Show(rec, "PISTA", MessageBoxButtons.YesNo);
            if (x == DialogResult.Yes)
            {
                string env = "13/" + nform + "SI";
                byte[] msg = System.Text.Encoding.UTF8.GetBytes(env);
                server.Send(msg);
            }
            else
            {
                string env = "13/" + nform + "NO";
                byte[] msg = System.Text.Encoding.UTF8.GetBytes(env);
                server.Send(msg);
            }
        }

        public void RecibirCarta(string mesaje)
        {
            string[] trozos = mesaje.Split('/');
            trozos[0] = label7.Text;
            trozos[1] = label8.Text;
            trozos[2] = label9.Text;
            trozos[3] = label10.Text;
        }

        public void RecibirPista(string mesaje)
        {
            int x = dataGridView1.Rows.Add();
            dataGridView1.Rows[x].Cells[0].Value = mesaje;
            richTextBox1.Clear();
        }

        public void RecibirYesNo(string mesaje)
        {
            if (mesaje == "SI")
            {
                MessageBox.Show("La respuesta a tu pista es SI");
            }
            if (mesaje == "NO")
            {
                MessageBox.Show("La respuesta a tu pista es NO");
            }

        }

        public void RecibirDescripcion(string mesaje)
        {
            MessageBox.Show(mesaje);
        }
    }
}
