using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;
using System.Windows.Forms.DataVisualization.Charting;
using System.Collections;


namespace Desafio1_JuegoMemoria
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            

        }
        int edad;
        int segun;
        int minu;
        int TamanioColumnasFilas = 4;
        int Movimientos = 0;
        int index = 0;
        string[] jugadas = new string[10];
        int CantidadDeCartasVolteadas = 0;
        List<string> CartasEnumeradas;
        List<string> CartasRevueltas;
        ArrayList CartasSeleccionadas;
        PictureBox CartaTemporal1;
        PictureBox CartaTemporal2;
        int CartaActual = 0;

        public void iniciarJuego()
        {
            timer1.Enabled = false;
            timer1.Stop();
            timer1.Start();//El timer empieza
            CantidadDeCartasVolteadas = 0;
            Movimientos = 0;
            pictureBox1.Controls.Clear();
            CartasEnumeradas = new List<string>();
            CartasRevueltas = new List<string>();
            CartasSeleccionadas = new ArrayList();
            for (int i = 0; i < 8; i++)
            {
                CartasEnumeradas.Add(i.ToString());
                CartasEnumeradas.Add(i.ToString());
            }
            var NumeroAleatorio = new Random();
            var Resultado = CartasEnumeradas.OrderBy(item => NumeroAleatorio.Next());
            foreach (string ValorCarta in Resultado)
            {
                CartasRevueltas.Add(ValorCarta);
            }
            var tablaPanel = new TableLayoutPanel();
            tablaPanel.RowCount = TamanioColumnasFilas;
            tablaPanel.ColumnCount = TamanioColumnasFilas;
            for (int i = 0; i < TamanioColumnasFilas; i++)
            {
                var Porcentaje = 150f / (float)TamanioColumnasFilas - 10;
                tablaPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, Porcentaje));
                tablaPanel.RowStyles.Add(new RowStyle(SizeType.Percent, Porcentaje));
            }
            int contadorFichas = 1;

            for (var i = 0; i < TamanioColumnasFilas; i++)
            {
                for (var j = 0; j < TamanioColumnasFilas; j++)
                {
                    var CartasJuego = new PictureBox();
                    CartasJuego.Name = string.Format("{0}", contadorFichas);
                    CartasJuego.Dock = DockStyle.Fill;
                    CartasJuego.SizeMode = PictureBoxSizeMode.StretchImage;
                    CartasJuego.Image = Properties.Resources.signo;
                    CartasJuego.Cursor = Cursors.Hand;
                    CartasJuego.Click += btnCarta_Click;
                    tablaPanel.Controls.Add(CartasJuego, j, i);
                    contadorFichas++;
                }
            }
            tablaPanel.Dock = DockStyle.Fill;
            pictureBox1.Controls.Add(tablaPanel);


        }
        private void btnCarta_Click(object sender, EventArgs e)
        {
            if (CartasSeleccionadas.Count < 2)
            {
                Movimientos++;
                label5.Text = Convert.ToString(Movimientos);
                var CartasSeleccionadasUsuario = (PictureBox)sender;

                CartaActual = Convert.ToInt32(CartasRevueltas[Convert.ToInt32(CartasSeleccionadasUsuario.Name) - 1]);
                CartasSeleccionadasUsuario.Image = RecuperarImagen(CartaActual);
                CartasSeleccionadas.Add(CartasSeleccionadasUsuario);
                //  2 Veces se realizo el evento del click
                if (CartasSeleccionadas.Count == 2)
                {
                    CartaTemporal1 = (PictureBox)CartasSeleccionadas[0];
                    CartaTemporal2 = (PictureBox)CartasSeleccionadas[1];
                    int Carta1 = Convert.ToInt32(CartasRevueltas[Convert.ToInt32(CartaTemporal1.Name) - 1]);
                    int Carta2 = Convert.ToInt32(CartasRevueltas[Convert.ToInt32(CartaTemporal2.Name) - 1]);

                    if (Carta1 != Carta2)
                    {
                        timer2.Enabled = true;
                        timer2.Start();
                    }
                    else
                    {
                        CantidadDeCartasVolteadas++;
                        if (CantidadDeCartasVolteadas > 7)
                        {
                            timer1.Stop();
                            MessageBox.Show("El juego ha terminado \n Has Ganado");
                            tabControl1.SelectTab(2);//Se selecciona la pestaña siguiente
                            resultados();

                        }
                        CartaTemporal1.Enabled = false; CartaTemporal2.Enabled = false;
                        CartasSeleccionadas.Clear();

                    }


                }
            }

        }
        public Bitmap RecuperarImagen(int NumeroImagen)
        {
            Bitmap TmpImg = new Bitmap(100, 100);
            switch (NumeroImagen)
            {
                case 0:
                    TmpImg = Properties.Resources.img10;
                    break;
                default:
                    TmpImg = (Bitmap)Properties.Resources.ResourceManager.GetObject("img" + NumeroImagen);
                    break;
            }
            return TmpImg;

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            segun += 1;
            if (segun == 60)//condición cuando se cumplan los 60 segundos
            {

                minu += 1;//suma 1 a 1 los minutos
                segun = 0;
            }
            else if (minu == 2)//condicion para que el limite sean 2 minutos
            {
                timer1.Stop();//Se detiene el timer cuando llegue a 2 minutos
                MessageBox.Show("Tiempo a terminado", "Juego de Memoria", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tabControl1.SelectTab(2);//Se selecciona la pestaña siguiente
                ((Control)this.tabresultado).Enabled = true;
                resultados();
                minu = 0;
            }

            lbltiempo2.Text = minu.ToString() + ":" + segun.ToString();//formato en que se muestra el timer


        }
        private Boolean validar(string nombre)//Inicio función validar campos
        {
            string clave = nombre;



            if (string.IsNullOrEmpty(txtnombre.Text))//Condición para que el nombre no sea vacio
            {

                MessageBox.Show("Debe completar la infomación", "Acceso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtnombre.Focus();
            }

            else if (nombre == clave)//Condición cuando se llene el campo del nombre
            {
               
                edad = (DateTime.Today.AddTicks(-dtfecha.Value.Ticks).Year);
                lbledad2.Text = edad.ToString();
                if (edad > 0 && edad <= 5)
                {
                    tabControl1.SelectTab(1);//Se selecciona la pestaña siguiente
                    ((Control)this.tabjuego).Enabled = true;
                    ((Control)this.tabregistro).Enabled = false;
                    
                    lblnombre2.Text = nombre;
                }else
                {
                    MessageBox.Show("ERROR. Debe ingresar una fecha de nacimiento valida");
                }
                


            }
            //Fin de if

            return false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            iniciarJuego();
           


            if (validar(txtnombre.Text))
            {
                if (index > 10)
                    return;
                jugadas[index] = txtnombre.Text.ToString();
                index++;
                // Se llama la función validar  declarada.

                this.Hide();
            }


        }
        public void Nueva_Partida(string n, int e)
        {
            ((Control)this.tabjuego).Enabled = true;
            tabControl1.SelectTab(1);//Se selecciona la pestaña siguiente
            timer1.Stop();
           
            lblnombre2.Text = n;
            lbledad2.Text = e.ToString();
            iniciarJuego();

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            txtnombre.Focus();
            ((Control)this.tabjuego).Enabled = false;
            ((Control)this.tabresultado).Enabled = false;

        }
        //Función para deshabilitar y habilitar el tab page
        public static void EnableTab(TabPage page, bool enable)
        {
            foreach (Control ctl in page.Controls) ctl.Enabled = enable;
        }
        public void resultados()
        {
            chart1.Series.Clear();
            chart1.Titles.Clear();
            chart1.Titles.Add("Jugadas VS Movimientos");
            Series juego = chart1.Series.Add(txtnombre.Text);
                juego.Label = Movimientos.ToString();
                juego.Points.Add(Movimientos);
            ((Control)this.tabjuego).Enabled = false;
            ((Control)this.tabregistro).Enabled = false;
            
        }

        private void tabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {
            this.tabControl1.SelectedTab = this.tabjuego;
        }
        private void tabjuego_Click(object sender, EventArgs e)
        {
        }

        private void btnnuevaP_Click(object sender, EventArgs e)
        {
            Nueva_Partida(txtnombre.Text, edad);
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            int TiempoVirarCarta = 1;
            if (TiempoVirarCarta == 1)
            {
                CartaTemporal1.Image = Properties.Resources.signo;
                CartaTemporal2.Image = Properties.Resources.signo;
                CartasSeleccionadas.Clear();
                TiempoVirarCarta = 0;
                timer2.Stop();
            }
            ((Control)this.tabresultado).Enabled = true;
            ((Control)this.tabregistro).Enabled = true;
        }

        private void lbledad_Click(object sender, EventArgs e)
        {

        }
    }
    }

