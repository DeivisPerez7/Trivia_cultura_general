namespace Trivia_cultura_general
{
    partial class FormularioPreguntas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioPreguntas));
            panel1 = new Panel();
            Botoncerrar = new Button();
            panelPregunta1 = new Panel();
            panelResultados = new Panel();
            labelpuntosfinales = new Label();
            labelpuntajefinal = new Label();
            pictureBox3 = new PictureBox();
            label1 = new Label();
            panelPregunta2 = new Panel();
            btnRumania = new Button();
            btnHungria = new Button();
            btnServia = new Button();
            pictureBox2 = new PictureBox();
            labelPregunta2 = new Label();
            btnMigueldeCervantes = new Button();
            btnIsabeldeSaavedra = new Button();
            btnGabrielGarcíaMárquez = new Button();
            pictureBox1 = new PictureBox();
            labelPregunta1 = new Label();
            labelparapuntaje = new Label();
            labelCantidadPuntos = new Label();
            bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(components);
            bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(components);
            panel1.SuspendLayout();
            panelPregunta1.SuspendLayout();
            panelResultados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panelPregunta2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.PaleTurquoise;
            panel1.Controls.Add(Botoncerrar);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 23);
            panel1.TabIndex = 0;
            // 
            // Botoncerrar
            // 
            Botoncerrar.BackColor = SystemColors.Control;
            Botoncerrar.Location = new Point(756, -1);
            Botoncerrar.Name = "Botoncerrar";
            Botoncerrar.Size = new Size(41, 24);
            Botoncerrar.TabIndex = 0;
            Botoncerrar.Text = "X";
            Botoncerrar.UseVisualStyleBackColor = false;
            Botoncerrar.Click += Botoncerrar_Click;
            // 
            // panelPregunta1
            // 
            panelPregunta1.BackColor = SystemColors.GradientActiveCaption;
            panelPregunta1.Controls.Add(panelPregunta2);
            panelPregunta1.Controls.Add(btnMigueldeCervantes);
            panelPregunta1.Controls.Add(btnIsabeldeSaavedra);
            panelPregunta1.Controls.Add(btnGabrielGarcíaMárquez);
            panelPregunta1.Controls.Add(pictureBox1);
            panelPregunta1.Controls.Add(labelPregunta1);
            panelPregunta1.Location = new Point(57, 29);
            panelPregunta1.Name = "panelPregunta1";
            panelPregunta1.Size = new Size(697, 387);
            panelPregunta1.TabIndex = 1;
            // 
            // panelResultados
            // 
            panelResultados.BackColor = Color.DarkGoldenrod;
            panelResultados.Controls.Add(labelpuntosfinales);
            panelResultados.Controls.Add(labelpuntajefinal);
            panelResultados.Controls.Add(pictureBox3);
            panelResultados.Controls.Add(label1);
            panelResultados.Location = new Point(57, 30);
            panelResultados.Name = "panelResultados";
            panelResultados.Size = new Size(697, 388);
            panelResultados.TabIndex = 5;
            // 
            // labelpuntosfinales
            // 
            labelpuntosfinales.AutoSize = true;
            labelpuntosfinales.Location = new Point(395, 357);
            labelpuntosfinales.Name = "labelpuntosfinales";
            labelpuntosfinales.Size = new Size(13, 15);
            labelpuntosfinales.TabIndex = 3;
            labelpuntosfinales.Text = "0";
            // 
            // labelpuntajefinal
            // 
            labelpuntajefinal.AutoSize = true;
            labelpuntajefinal.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelpuntajefinal.Location = new Point(244, 352);
            labelpuntajefinal.Name = "labelpuntajefinal";
            labelpuntajefinal.Size = new Size(148, 21);
            labelpuntajefinal.TabIndex = 2;
            labelpuntajefinal.Text = "Puntos obtenidos:";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(177, 78);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(343, 254);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 1;
            pictureBox3.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Script MT Bold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(144, 15);
            label1.Name = "label1";
            label1.Size = new Size(397, 29);
            label1.TabIndex = 0;
            label1.Text = "Felicidades por la Puntuacion Obtenida";
            // 
            // panelPregunta2
            // 
            panelPregunta2.Controls.Add(btnRumania);
            panelPregunta2.Controls.Add(btnHungria);
            panelPregunta2.Controls.Add(btnServia);
            panelPregunta2.Controls.Add(pictureBox2);
            panelPregunta2.Controls.Add(labelPregunta2);
            panelPregunta2.Location = new Point(0, 1);
            panelPregunta2.Name = "panelPregunta2";
            panelPregunta2.Size = new Size(697, 387);
            panelPregunta2.TabIndex = 5;
            // 
            // btnRumania
            // 
            btnRumania.Location = new Point(111, 352);
            btnRumania.Name = "btnRumania";
            btnRumania.Size = new Size(75, 23);
            btnRumania.TabIndex = 4;
            btnRumania.Text = "Rumanía";
            btnRumania.UseVisualStyleBackColor = true;
            btnRumania.Click += btnRumania_Click;
            // 
            // btnHungria
            // 
            btnHungria.Location = new Point(312, 352);
            btnHungria.Name = "btnHungria";
            btnHungria.Size = new Size(75, 23);
            btnHungria.TabIndex = 3;
            btnHungria.Text = "Hungría";
            btnHungria.UseVisualStyleBackColor = true;
            btnHungria.Click += btnHungria_Click;
            // 
            // btnServia
            // 
            btnServia.Location = new Point(497, 352);
            btnServia.Name = "btnServia";
            btnServia.Size = new Size(75, 23);
            btnServia.TabIndex = 2;
            btnServia.Text = "Servia";
            btnServia.UseVisualStyleBackColor = true;
            btnServia.Click += btnServia_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(111, 77);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(461, 254);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // labelPregunta2
            // 
            labelPregunta2.AutoSize = true;
            labelPregunta2.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point);
            labelPregunta2.Location = new Point(213, 17);
            labelPregunta2.Name = "labelPregunta2";
            labelPregunta2.Size = new Size(253, 25);
            labelPregunta2.TabIndex = 0;
            labelPregunta2.Text = "¿Dónde está Transilvania?";
            // 
            // btnMigueldeCervantes
            // 
            btnMigueldeCervantes.Location = new Point(111, 338);
            btnMigueldeCervantes.Name = "btnMigueldeCervantes";
            btnMigueldeCervantes.Size = new Size(127, 21);
            btnMigueldeCervantes.TabIndex = 4;
            btnMigueldeCervantes.Text = "Miguel de Cervantes";
            btnMigueldeCervantes.UseVisualStyleBackColor = true;
            btnMigueldeCervantes.Click += btnMigueldeCervantes_Click;
            // 
            // btnIsabeldeSaavedra
            // 
            btnIsabeldeSaavedra.Location = new Point(275, 338);
            btnIsabeldeSaavedra.Name = "btnIsabeldeSaavedra";
            btnIsabeldeSaavedra.Size = new Size(112, 23);
            btnIsabeldeSaavedra.TabIndex = 3;
            btnIsabeldeSaavedra.Text = "Isabel de Saavedra";
            btnIsabeldeSaavedra.UseVisualStyleBackColor = true;
            btnIsabeldeSaavedra.Click += btnIsabeldeSaavedra_Click;
            // 
            // btnGabrielGarcíaMárquez
            // 
            btnGabrielGarcíaMárquez.Location = new Point(424, 338);
            btnGabrielGarcíaMárquez.Name = "btnGabrielGarcíaMárquez";
            btnGabrielGarcíaMárquez.Size = new Size(148, 23);
            btnGabrielGarcíaMárquez.TabIndex = 2;
            btnGabrielGarcíaMárquez.Text = "Gabriel García Márquez";
            btnGabrielGarcíaMárquez.UseVisualStyleBackColor = true;
            btnGabrielGarcíaMárquez.Click += btnGabrielGarcíaMárquez_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(111, 60);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(461, 254);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // labelPregunta1
            // 
            labelPregunta1.AutoSize = true;
            labelPregunta1.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point);
            labelPregunta1.Location = new Point(177, 15);
            labelPregunta1.Name = "labelPregunta1";
            labelPregunta1.Size = new Size(317, 25);
            labelPregunta1.TabIndex = 0;
            labelPregunta1.Text = " ¿Quién es el autor de el Quijote?";
            // 
            // labelparapuntaje
            // 
            labelparapuntaje.AutoSize = true;
            labelparapuntaje.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            labelparapuntaje.Location = new Point(323, 416);
            labelparapuntaje.Name = "labelparapuntaje";
            labelparapuntaje.Size = new Size(154, 25);
            labelparapuntaje.TabIndex = 2;
            labelparapuntaje.Text = "Puntos Actuales:";
            // 
            // labelCantidadPuntos
            // 
            labelCantidadPuntos.AutoSize = true;
            labelCantidadPuntos.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelCantidadPuntos.Location = new Point(471, 420);
            labelCantidadPuntos.Name = "labelCantidadPuntos";
            labelCantidadPuntos.Size = new Size(19, 21);
            labelCantidadPuntos.TabIndex = 3;
            labelCantidadPuntos.Text = "0";
            // 
            // bunifuElipse1
            // 
            bunifuElipse1.ElipseRadius = 5;
            bunifuElipse1.TargetControl = this;
            // 
            // bunifuDragControl1
            // 
            bunifuDragControl1.Fixed = true;
            bunifuDragControl1.Horizontal = true;
            bunifuDragControl1.TargetControl = null;
            bunifuDragControl1.Vertical = true;
            // 
            // FormularioPreguntas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(panelResultados);
            Controls.Add(labelCantidadPuntos);
            Controls.Add(labelparapuntaje);
            Controls.Add(panelPregunta1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormularioPreguntas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormularioPreguntas";
            Load += FormularioPreguntas_Load;
            panel1.ResumeLayout(false);
            panelPregunta1.ResumeLayout(false);
            panelPregunta1.PerformLayout();
            panelResultados.ResumeLayout(false);
            panelResultados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panelPregunta2.ResumeLayout(false);
            panelPregunta2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button Botoncerrar;
        private Panel panelPregunta1;
        private Label labelPregunta1;
        private PictureBox pictureBox1;
        private Button btnMigueldeCervantes;
        private Button btnIsabeldeSaavedra;
        private Button btnGabrielGarcíaMárquez;
        private Label labelparapuntaje;
        private Label labelCantidadPuntos;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Panel panelPregunta2;
        private Button btnRumania;
        private Button btnHungria;
        private Button btnServia;
        private PictureBox pictureBox2;
        private Label labelPregunta2;
        private Panel panelResultados;
        private Label labelpuntosfinales;
        private Label labelpuntajefinal;
        private PictureBox pictureBox3;
        private Label label1;
    }
}