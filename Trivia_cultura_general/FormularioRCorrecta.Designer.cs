namespace Trivia_cultura_general
{
    partial class FormularioRCorrecta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioRCorrecta));
            bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(components);
            BotonCerrar = new Button();
            TextoPrincipal = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // bunifuElipse1
            // 
            bunifuElipse1.ElipseRadius = 5;
            bunifuElipse1.TargetControl = this;
            // 
            // BotonCerrar
            // 
            BotonCerrar.Location = new Point(515, 2);
            BotonCerrar.Name = "BotonCerrar";
            BotonCerrar.Size = new Size(46, 23);
            BotonCerrar.TabIndex = 0;
            BotonCerrar.Text = "X";
            BotonCerrar.UseVisualStyleBackColor = true;
            BotonCerrar.Click += BotonCerrar_Click;
            // 
            // TextoPrincipal
            // 
            TextoPrincipal.AutoSize = true;
            TextoPrincipal.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            TextoPrincipal.Location = new Point(167, 9);
            TextoPrincipal.Name = "TextoPrincipal";
            TextoPrincipal.Size = new Size(232, 25);
            TextoPrincipal.TabIndex = 1;
            TextoPrincipal.Text = "Tu Respuesta es Correcta";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(139, 55);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(296, 160);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // FormularioRCorrecta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 255, 128);
            ClientSize = new Size(573, 256);
            Controls.Add(pictureBox1);
            Controls.Add(TextoPrincipal);
            Controls.Add(BotonCerrar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormularioRCorrecta";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormularioRCorrecta";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Button BotonCerrar;
        private PictureBox pictureBox1;
        private Label TextoPrincipal;
    }
}