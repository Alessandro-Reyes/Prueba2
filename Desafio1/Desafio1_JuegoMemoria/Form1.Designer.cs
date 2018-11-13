namespace Desafio1_JuegoMemoria
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tabresultado = new System.Windows.Forms.TabPage();
            this.btnnuevaP = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabjuego = new System.Windows.Forms.TabPage();
            this.lbledad = new System.Windows.Forms.Label();
            this.lbltiempo = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblnombre = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabregistro = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.dtfecha = new System.Windows.Forms.DateTimePicker();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.lbltiempo2 = new System.Windows.Forms.Label();
            this.lbledad2 = new System.Windows.Forms.Label();
            this.lblnombre2 = new System.Windows.Forms.Label();
            this.tabresultado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.tabjuego.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabregistro.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tabresultado
            // 
            this.tabresultado.Controls.Add(this.btnnuevaP);
            this.tabresultado.Controls.Add(this.chart1);
            this.tabresultado.Location = new System.Drawing.Point(4, 22);
            this.tabresultado.Name = "tabresultado";
            this.tabresultado.Padding = new System.Windows.Forms.Padding(3);
            this.tabresultado.Size = new System.Drawing.Size(528, 368);
            this.tabresultado.TabIndex = 2;
            this.tabresultado.Text = "Resultado";
            this.tabresultado.UseVisualStyleBackColor = true;
            // 
            // btnnuevaP
            // 
            this.btnnuevaP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnnuevaP.Location = new System.Drawing.Point(412, 71);
            this.btnnuevaP.Name = "btnnuevaP";
            this.btnnuevaP.Size = new System.Drawing.Size(110, 36);
            this.btnnuevaP.TabIndex = 1;
            this.btnnuevaP.Text = "Nueva Partida.";
            this.btnnuevaP.UseVisualStyleBackColor = true;
            this.btnnuevaP.Click += new System.EventHandler(this.btnnuevaP_Click);
            // 
            // chart1
            // 
            this.chart1.BorderlineWidth = 0;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(11, 20);
            this.chart1.Margin = new System.Windows.Forms.Padding(1);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            this.chart1.Size = new System.Drawing.Size(395, 339);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // tabjuego
            // 
            this.tabjuego.Controls.Add(this.lblnombre2);
            this.tabjuego.Controls.Add(this.lbledad2);
            this.tabjuego.Controls.Add(this.lbltiempo2);
            this.tabjuego.Controls.Add(this.lbledad);
            this.tabjuego.Controls.Add(this.lbltiempo);
            this.tabjuego.Controls.Add(this.label5);
            this.tabjuego.Controls.Add(this.label4);
            this.tabjuego.Controls.Add(this.lblnombre);
            this.tabjuego.Controls.Add(this.pictureBox1);
            this.tabjuego.Location = new System.Drawing.Point(4, 22);
            this.tabjuego.Name = "tabjuego";
            this.tabjuego.Padding = new System.Windows.Forms.Padding(3);
            this.tabjuego.Size = new System.Drawing.Size(528, 368);
            this.tabjuego.TabIndex = 1;
            this.tabjuego.Text = "Juego";
            this.tabjuego.UseVisualStyleBackColor = true;
            this.tabjuego.Click += new System.EventHandler(this.tabjuego_Click);
            // 
            // lbledad
            // 
            this.lbledad.AutoSize = true;
            this.lbledad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbledad.Location = new System.Drawing.Point(253, 17);
            this.lbledad.Name = "lbledad";
            this.lbledad.Size = new System.Drawing.Size(44, 16);
            this.lbledad.TabIndex = 14;
            this.lbledad.Text = "Edad:";
            this.lbledad.Click += new System.EventHandler(this.lbledad_Click);
            // 
            // lbltiempo
            // 
            this.lbltiempo.AutoSize = true;
            this.lbltiempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltiempo.Location = new System.Drawing.Point(393, 17);
            this.lbltiempo.Name = "lbltiempo";
            this.lbltiempo.Size = new System.Drawing.Size(58, 16);
            this.lbltiempo.TabIndex = 13;
            this.lbltiempo.Text = "Tiempo:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(393, 344);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(299, 343);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Movimientos:";
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnombre.Location = new System.Drawing.Point(3, 17);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(128, 16);
            this.lblnombre.TabIndex = 10;
            this.lblnombre.Text = "Nombre de jugador:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(7, 49);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(515, 291);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tabregistro
            // 
            this.tabregistro.Controls.Add(this.button1);
            this.tabregistro.Controls.Add(this.dtfecha);
            this.tabregistro.Controls.Add(this.txtnombre);
            this.tabregistro.Controls.Add(this.label2);
            this.tabregistro.Controls.Add(this.label1);
            this.tabregistro.Location = new System.Drawing.Point(4, 22);
            this.tabregistro.Name = "tabregistro";
            this.tabregistro.Padding = new System.Windows.Forms.Padding(3);
            this.tabregistro.Size = new System.Drawing.Size(528, 368);
            this.tabregistro.TabIndex = 0;
            this.tabregistro.Text = "Registro";
            this.tabregistro.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(73, 208);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(347, 40);
            this.button1.TabIndex = 4;
            this.button1.Text = "Jugar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dtfecha
            // 
            this.dtfecha.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtfecha.Location = new System.Drawing.Point(220, 163);
            this.dtfecha.Name = "dtfecha";
            this.dtfecha.Size = new System.Drawing.Size(200, 20);
            this.dtfecha.TabIndex = 3;
            // 
            // txtnombre
            // 
            this.txtnombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtnombre.Location = new System.Drawing.Point(220, 100);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(200, 20);
            this.txtnombre.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(70, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fecha de Nacimiento:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(70, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre de jugador:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabregistro);
            this.tabControl1.Controls.Add(this.tabjuego);
            this.tabControl1.Controls.Add(this.tabresultado);
            this.tabControl1.Location = new System.Drawing.Point(3, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(536, 394);
            this.tabControl1.TabIndex = 0;
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // lbltiempo2
            // 
            this.lbltiempo2.AutoSize = true;
            this.lbltiempo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltiempo2.Location = new System.Drawing.Point(454, 17);
            this.lbltiempo2.Name = "lbltiempo2";
            this.lbltiempo2.Size = new System.Drawing.Size(55, 16);
            this.lbltiempo2.TabIndex = 15;
            this.lbltiempo2.Text = "Tiempo";
            // 
            // lbledad2
            // 
            this.lbledad2.AutoSize = true;
            this.lbledad2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbledad2.Location = new System.Drawing.Point(291, 17);
            this.lbledad2.Name = "lbledad2";
            this.lbledad2.Size = new System.Drawing.Size(55, 16);
            this.lbledad2.TabIndex = 16;
            this.lbledad2.Text = "Tiempo";
            // 
            // lblnombre2
            // 
            this.lblnombre2.AutoSize = true;
            this.lblnombre2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnombre2.Location = new System.Drawing.Point(128, 17);
            this.lblnombre2.Name = "lblnombre2";
            this.lblnombre2.Size = new System.Drawing.Size(128, 16);
            this.lblnombre2.TabIndex = 17;
            this.lblnombre2.Text = "Nombre de jugador:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 405);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabresultado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.tabjuego.ResumeLayout(false);
            this.tabjuego.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabregistro.ResumeLayout(false);
            this.tabregistro.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TabPage tabresultado;
        private System.Windows.Forms.Button btnnuevaP;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.TabPage tabjuego;
        private System.Windows.Forms.Label lbledad;
        private System.Windows.Forms.Label lbltiempo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabPage tabregistro;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dtfecha;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label lblnombre2;
        private System.Windows.Forms.Label lbledad2;
        private System.Windows.Forms.Label lbltiempo2;
    }
}

