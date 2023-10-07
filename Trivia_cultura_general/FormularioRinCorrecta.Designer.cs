namespace Trivia_cultura_general
{
    partial class FormularioRinCorrecta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioRinCorrecta));
            bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(components);
            RespuestainCorrecta = new Label();
            BotonCerrar = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // bunifuElipse1
            // 
            bunifuElipse1.ElipseRadius = 5;
            bunifuElipse1.TargetControl = this;
            // 
            // RespuestainCorrecta
            // 
            RespuestainCorrecta.AutoSize = true;
            RespuestainCorrecta.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            RespuestainCorrecta.Location = new Point(175, 9);
            RespuestainCorrecta.Name = "RespuestainCorrecta";
            RespuestainCorrecta.Size = new Size(247, 25);
            RespuestainCorrecta.TabIndex = 0;
            RespuestainCorrecta.Text = "Tu Respuesta es Incorrecta";
            // 
            // BotonCerrar
            // 
            BotonCerrar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BotonCerrar.Location = new Point(514, 3);
            BotonCerrar.Name = "BotonCerrar";
            BotonCerrar.Size = new Size(49, 24);
            BotonCerrar.TabIndex = 1;
            BotonCerrar.Text = "X";
            BotonCerrar.UseVisualStyleBackColor = true;
            BotonCerrar.Click += BotonCerrar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(170, 65);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(252, 142);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // FormularioRinCorrecta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 128, 128);
            ClientSize = new Size(575, 254);
            Controls.Add(pictureBox1);
            Controls.Add(BotonCerrar);
            Controls.Add(RespuestainCorrecta);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormularioRinCorrecta";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormularioRinCorrecta";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Label RespuestainCorrecta;
        private Button BotonCerrar;
        private PictureBox pictureBox1;
    }
}