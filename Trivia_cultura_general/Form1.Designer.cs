namespace Trivia_cultura_general
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            textoTituloPrincipal = new Label();
            TextoCerrarFormulario = new Label();
            TextoDescriptivo = new Label();
            ImagenLogoTrivia = new PictureBox();
            PanelInferior = new Panel();
            label2 = new Label();
            label1 = new Label();
            botonIniciarQuiz = new Button();
            bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(components);
            ((System.ComponentModel.ISupportInitialize)ImagenLogoTrivia).BeginInit();
            PanelInferior.SuspendLayout();
            SuspendLayout();
            // 
            // textoTituloPrincipal
            // 
            textoTituloPrincipal.AutoSize = true;
            textoTituloPrincipal.Font = new Font("Showcard Gothic", 14F, FontStyle.Bold, GraphicsUnit.Point);
            textoTituloPrincipal.Location = new Point(415, 27);
            textoTituloPrincipal.Name = "textoTituloPrincipal";
            textoTituloPrincipal.Size = new Size(228, 23);
            textoTituloPrincipal.TabIndex = 0;
            textoTituloPrincipal.Text = "Bienvenidos al Quiz";
            // 
            // TextoCerrarFormulario
            // 
            TextoCerrarFormulario.AutoSize = true;
            TextoCerrarFormulario.Font = new Font("Verdana", 14F, FontStyle.Regular, GraphicsUnit.Point);
            TextoCerrarFormulario.Location = new Point(1025, 0);
            TextoCerrarFormulario.Name = "TextoCerrarFormulario";
            TextoCerrarFormulario.Size = new Size(23, 23);
            TextoCerrarFormulario.TabIndex = 1;
            TextoCerrarFormulario.Text = "X";
            TextoCerrarFormulario.Click += TextoCerrarFormulario_Click;
            // 
            // TextoDescriptivo
            // 
            TextoDescriptivo.AutoSize = true;
            TextoDescriptivo.BackColor = Color.LightCyan;
            TextoDescriptivo.Font = new Font("Showcard Gothic", 16F, FontStyle.Regular, GraphicsUnit.Point);
            TextoDescriptivo.Location = new Point(351, 108);
            TextoDescriptivo.Name = "TextoDescriptivo";
            TextoDescriptivo.Size = new Size(343, 28);
            TextoDescriptivo.TabIndex = 2;
            TextoDescriptivo.Text = "Trivia sobre culura general";
            // 
            // ImagenLogoTrivia
            // 
            ImagenLogoTrivia.Image = (Image)resources.GetObject("ImagenLogoTrivia.Image");
            ImagenLogoTrivia.Location = new Point(299, 173);
            ImagenLogoTrivia.Name = "ImagenLogoTrivia";
            ImagenLogoTrivia.Size = new Size(440, 266);
            ImagenLogoTrivia.SizeMode = PictureBoxSizeMode.Zoom;
            ImagenLogoTrivia.TabIndex = 3;
            ImagenLogoTrivia.TabStop = false;
            // 
            // PanelInferior
            // 
            PanelInferior.BackColor = SystemColors.ActiveCaption;
            PanelInferior.Controls.Add(label2);
            PanelInferior.Controls.Add(label1);
            PanelInferior.Dock = DockStyle.Bottom;
            PanelInferior.Location = new Point(0, 566);
            PanelInferior.Name = "PanelInferior";
            PanelInferior.Size = new Size(1047, 63);
            PanelInferior.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Script MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(964, 24);
            label2.Name = "label2";
            label2.Size = new Size(41, 19);
            label2.TabIndex = 1;
            label2.Text = "2023";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("MV Boli", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(32, 22);
            label1.Name = "label1";
            label1.Size = new Size(187, 21);
            label1.TabIndex = 0;
            label1.Text = "Amplia tu conocimiento";
            // 
            // botonIniciarQuiz
            // 
            botonIniciarQuiz.BackColor = SystemColors.MenuHighlight;
            botonIniciarQuiz.Location = new Point(453, 470);
            botonIniciarQuiz.Name = "botonIniciarQuiz";
            botonIniciarQuiz.Size = new Size(129, 44);
            botonIniciarQuiz.TabIndex = 5;
            botonIniciarQuiz.Text = "Iniciar el Quiz";
            botonIniciarQuiz.UseVisualStyleBackColor = false;
            botonIniciarQuiz.Click += botonIniciarQuiz_Click;
            // 
            // bunifuDragControl1
            // 
            bunifuDragControl1.Fixed = true;
            bunifuDragControl1.Horizontal = true;
            bunifuDragControl1.TargetControl = this;
            bunifuDragControl1.Vertical = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            ClientSize = new Size(1047, 629);
            Controls.Add(botonIniciarQuiz);
            Controls.Add(PanelInferior);
            Controls.Add(ImagenLogoTrivia);
            Controls.Add(TextoDescriptivo);
            Controls.Add(TextoCerrarFormulario);
            Controls.Add(textoTituloPrincipal);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)ImagenLogoTrivia).EndInit();
            PanelInferior.ResumeLayout(false);
            PanelInferior.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label textoTituloPrincipal;
        private Label TextoCerrarFormulario;
        private Label TextoDescriptivo;
        private PictureBox ImagenLogoTrivia;
        private Panel PanelInferior;
        private Label label2;
        private Label label1;
        private Button botonIniciarQuiz;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
    }
}