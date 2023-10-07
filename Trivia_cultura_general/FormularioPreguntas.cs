using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trivia_cultura_general
{
    public partial class FormularioPreguntas : Form
    {
        public FormularioPreguntas()
        {
            InitializeComponent();
            panelPregunta2.Hide();
            panelResultados.Hide();
        }
        int puntos = 0;

        #region Manejo de la cantidad de puntos

        void respuestaIncorrecta()
        {
            FormularioRinCorrecta formularioIncorrecto = new FormularioRinCorrecta();
            formularioIncorrecto.ShowDialog();
            restarPuntos();
        }

        void respuestaCorrecta()
        {
            FormularioRCorrecta correcta = new FormularioRCorrecta();
            correcta.ShowDialog();
            sumarPuntos();
        }

        void sumarPuntos()
        {
            puntos = puntos + 500;
            labelCantidadPuntos.Text = puntos.ToString();
        }

        void restarPuntos()
        {
            if (puntos >= 200)
            {
                puntos = puntos - 100;
            }
            labelCantidadPuntos.Text = puntos.ToString();
        }
        #endregion
        private void FormularioPreguntas_Load(object sender, EventArgs e)
        {

        }

        private void Botoncerrar_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();

        }

        #region panel de la pregunta 2
        private void btnRumania_Click(object sender, EventArgs e)
        {
            respuestaCorrecta();
            panelResultados.Show();

            labelparapuntaje.Hide();
            labelCantidadPuntos.Hide();
            labelpuntosfinales.Text = puntos.ToString();
        }

        private void btnHungria_Click(object sender, EventArgs e)
        {
            respuestaIncorrecta();
        }

        private void btnServia_Click(object sender, EventArgs e)
        {
            respuestaIncorrecta();
        }
        #endregion

        private void btnGabrielGarcíaMárquez_Click(object sender, EventArgs e)
        {
            respuestaIncorrecta();
        }

        private void btnMigueldeCervantes_Click(object sender, EventArgs e)
        {
            respuestaCorrecta();
            panelPregunta2.Show();
        }

        private void btnIsabeldeSaavedra_Click(object sender, EventArgs e)
        {
            respuestaIncorrecta();
        }
    }
}
