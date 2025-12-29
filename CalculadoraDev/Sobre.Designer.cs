namespace CalculadoraDev
{
    partial class Sobre
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            linklblLinkedin = new LinkLabel();
            linklblGit = new LinkLabel();
            btnVoltar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ImageAlign = ContentAlignment.TopCenter;
            label1.Location = new Point(71, 9);
            label1.Name = "label1";
            label1.Size = new Size(150, 29);
            label1.TabIndex = 0;
            label1.Text = "Calculadora Dev";
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ImageAlign = ContentAlignment.TopCenter;
            label2.Location = new Point(49, 40);
            label2.Name = "label2";
            label2.Size = new Size(193, 29);
            label2.TabIndex = 1;
            label2.Text = " (C# - Windows Forms App) ";
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ImageAlign = ContentAlignment.TopCenter;
            label3.Location = new Point(12, 97);
            label3.Name = "label3";
            label3.Size = new Size(270, 67);
            label3.TabIndex = 2;
            label3.Text = " Projeto desenvolvido para prática de lógica de programação, interface gráfica e manipulação de eventos. ";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ImageAlign = ContentAlignment.TopCenter;
            label4.Location = new Point(12, 189);
            label4.Name = "label4";
            label4.Size = new Size(270, 37);
            label4.TabIndex = 3;
            label4.Text = "Criado por: Erick Ygor Teodoro Gonçalves";
            label4.TextAlign = ContentAlignment.TopCenter;
            // 
            // linklblLinkedin
            // 
            linklblLinkedin.Location = new Point(12, 235);
            linklblLinkedin.Name = "linklblLinkedin";
            linklblLinkedin.Size = new Size(257, 23);
            linklblLinkedin.TabIndex = 4;
            linklblLinkedin.TabStop = true;
            linklblLinkedin.Text = "LinkedIn: www.linkedin.com/in/erick-ygor";
            linklblLinkedin.TextAlign = ContentAlignment.TopCenter;
            linklblLinkedin.LinkClicked += linklblLinkedin_LinkClicked;
            // 
            // linklblGit
            // 
            linklblGit.Location = new Point(12, 212);
            linklblGit.Name = "linklblGit";
            linklblGit.Size = new Size(257, 23);
            linklblGit.TabIndex = 5;
            linklblGit.TabStop = true;
            linklblGit.Text = "GitHub: https://github.com/ErickYgor\r\n";
            linklblGit.TextAlign = ContentAlignment.TopCenter;
            linklblGit.LinkClicked += linklblGit_LinkClicked;
            // 
            // btnVoltar
            // 
            btnVoltar.BackColor = SystemColors.GradientActiveCaption;
            btnVoltar.Location = new Point(114, 261);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(75, 23);
            btnVoltar.TabIndex = 6;
            btnVoltar.Text = "VOLTAR";
            btnVoltar.UseVisualStyleBackColor = false;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // Sobre
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(294, 293);
            ControlBox = false;
            Controls.Add(btnVoltar);
            Controls.Add(linklblGit);
            Controls.Add(linklblLinkedin);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Sobre";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sobre";
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private LinkLabel linklblLinkedin;
        private LinkLabel linklblGit;
        private Button btnVoltar;
    }
}