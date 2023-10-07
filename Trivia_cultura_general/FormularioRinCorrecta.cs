using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trivia_cultura_general
{
    public partial class FormularioRinCorrecta : Form
    {
        public FormularioRinCorrecta()
        {
            InitializeComponent();
            resproducirSoniddo();
        }

        private void BotonCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        string rutaAudio = "C:/sonidos/incorrecto.wav";
        private void resproducirSoniddo()
        {
            SoundPlayer player = new SoundPlayer();
            player.SoundLocation = rutaAudio;
            player.Play();
        }
    }
}
