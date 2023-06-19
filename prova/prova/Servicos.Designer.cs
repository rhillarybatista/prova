namespace prova
{
    partial class Servicos
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
            lbcomp = new Label();
            lbcliente = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            cbpag = new ComboBox();
            cbser = new ComboBox();
            tbcomp = new TextBox();
            tbnome = new TextBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // lbcomp
            // 
            lbcomp.AutoSize = true;
            lbcomp.Location = new Point(57, 76);
            lbcomp.Name = "lbcomp";
            lbcomp.Size = new Size(75, 15);
            lbcomp.TabIndex = 0;
            lbcomp.Text = "Computador";
            // 
            // lbcliente
            // 
            lbcliente.AutoSize = true;
            lbcliente.Location = new Point(65, 47);
            lbcliente.Name = "lbcliente";
            lbcliente.Size = new Size(44, 15);
            lbcliente.TabIndex = 1;
            lbcliente.Text = "Cliente";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(65, 109);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 2;
            label1.Text = "Servicos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(68, 135);
            label2.Name = "label2";
            label2.Size = new Size(110, 15);
            label2.TabIndex = 3;
            label2.Text = "Tipo de pagamento";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(70, 164);
            label3.Name = "label3";
            label3.Size = new Size(62, 15);
            label3.TabIndex = 4;
            label3.Text = "Valor final:";
            // 
            // cbpag
            // 
            cbpag.FormattingEnabled = true;
            cbpag.Items.AddRange(new object[] { "dinheiro", "pix", "cartao" });
            cbpag.Location = new Point(184, 132);
            cbpag.Name = "cbpag";
            cbpag.Size = new Size(121, 23);
            cbpag.TabIndex = 5;
            // 
            // cbser
            // 
            cbser.FormattingEnabled = true;
            cbser.Items.AddRange(new object[] { "formatacao", "limpeza", "troca de peca" });
            cbser.Location = new Point(121, 103);
            cbser.Name = "cbser";
            cbser.Size = new Size(121, 23);
            cbser.TabIndex = 6;
            cbser.SelectedIndexChanged += cbser_SelectedIndexChanged;
            // 
            // tbcomp
            // 
            tbcomp.Location = new Point(138, 73);
            tbcomp.Name = "tbcomp";
            tbcomp.Size = new Size(104, 23);
            tbcomp.TabIndex = 7;
            // 
            // tbnome
            // 
            tbnome.Location = new Point(115, 44);
            tbnome.Name = "tbnome";
            tbnome.Size = new Size(127, 23);
            tbnome.TabIndex = 8;
            tbnome.TextChanged += tbnome_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(368, 68);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 9;
            button1.Text = "Salvar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(369, 106);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 10;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = true;
            // 
            // Servicos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(tbnome);
            Controls.Add(tbcomp);
            Controls.Add(cbser);
            Controls.Add(cbpag);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lbcliente);
            Controls.Add(lbcomp);
            Name = "Servicos";
            Text = "Servicos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbcomp;
        private Label lbcliente;
        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox cbpag;
        private ComboBox cbser;
        private TextBox tbcomp;
        private TextBox tbnome;
        private Button button1;
        private Button button2;
    }
}