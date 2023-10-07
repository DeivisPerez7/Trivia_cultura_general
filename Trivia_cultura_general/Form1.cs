namespace Trivia_cultura_general
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TextoCerrarFormulario_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void botonIniciarQuiz_Click(object sender, EventArgs e)
        {
            FormularioPreguntas fr = new FormularioPreguntas();
            fr.Show();
            this.Hide();
        }
    }
}