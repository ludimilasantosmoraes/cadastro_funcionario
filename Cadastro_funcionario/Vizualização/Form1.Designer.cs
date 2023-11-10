namespace Cadastro_funcionario
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.funcao_tx = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.datanascimento_tx = new System.Windows.Forms.DateTimePicker();
            this.cpf_tx = new System.Windows.Forms.MaskedTextBox();
            this.rg_tx = new System.Windows.Forms.TextBox();
            this.estadocivil_tx = new System.Windows.Forms.TextBox();
            this.salario_tx = new System.Windows.Forms.TextBox();
            this.email_tx = new System.Windows.Forms.TextBox();
            this.telefone_tx = new System.Windows.Forms.TextBox();
            this.cidade_tx = new System.Windows.Forms.TextBox();
            this.endereco_tx = new System.Windows.Forms.TextBox();
            this.estado_tx = new System.Windows.Forms.TextBox();
            this.nome_tx = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.funcao_tx);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.datanascimento_tx);
            this.panel1.Controls.Add(this.cpf_tx);
            this.panel1.Controls.Add(this.rg_tx);
            this.panel1.Controls.Add(this.estadocivil_tx);
            this.panel1.Controls.Add(this.salario_tx);
            this.panel1.Controls.Add(this.email_tx);
            this.panel1.Controls.Add(this.telefone_tx);
            this.panel1.Controls.Add(this.cidade_tx);
            this.panel1.Controls.Add(this.endereco_tx);
            this.panel1.Controls.Add(this.estado_tx);
            this.panel1.Controls.Add(this.nome_tx);
            this.panel1.Location = new System.Drawing.Point(0, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1293, 672);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // funcao_tx
            // 
            this.funcao_tx.FormattingEnabled = true;
            this.funcao_tx.Items.AddRange(new object[] {
            "Administrador",
            "Atendimento",
            "Gerente",
            "Limpeza"});
            this.funcao_tx.Location = new System.Drawing.Point(234, 203);
            this.funcao_tx.Name = "funcao_tx";
            this.funcao_tx.Size = new System.Drawing.Size(517, 21);
            this.funcao_tx.TabIndex = 15;
            this.funcao_tx.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(1135, 571);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(111, 49);
            this.button2.TabIndex = 14;
            this.button2.Text = "SALVAR";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(160, 571);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 49);
            this.button1.TabIndex = 13;
            this.button1.Text = "EXCLUIR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // datanascimento_tx
            // 
            this.datanascimento_tx.Location = new System.Drawing.Point(1030, 316);
            this.datanascimento_tx.Name = "datanascimento_tx";
            this.datanascimento_tx.Size = new System.Drawing.Size(228, 20);
            this.datanascimento_tx.TabIndex = 12;
            // 
            // cpf_tx
            // 
            this.cpf_tx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cpf_tx.Location = new System.Drawing.Point(1093, 121);
            this.cpf_tx.Mask = "000,000,000-00";
            this.cpf_tx.Name = "cpf_tx";
            this.cpf_tx.Size = new System.Drawing.Size(189, 13);
            this.cpf_tx.TabIndex = 11;
            // 
            // rg_tx
            // 
            this.rg_tx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rg_tx.Location = new System.Drawing.Point(1093, 212);
            this.rg_tx.Name = "rg_tx";
            this.rg_tx.Size = new System.Drawing.Size(189, 13);
            this.rg_tx.TabIndex = 10;
            // 
            // estadocivil_tx
            // 
            this.estadocivil_tx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.estadocivil_tx.Location = new System.Drawing.Point(581, 485);
            this.estadocivil_tx.Name = "estadocivil_tx";
            this.estadocivil_tx.Size = new System.Drawing.Size(171, 13);
            this.estadocivil_tx.TabIndex = 8;
            // 
            // salario_tx
            // 
            this.salario_tx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.salario_tx.Location = new System.Drawing.Point(234, 495);
            this.salario_tx.Name = "salario_tx";
            this.salario_tx.Size = new System.Drawing.Size(106, 13);
            this.salario_tx.TabIndex = 7;
            // 
            // email_tx
            // 
            this.email_tx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.email_tx.Location = new System.Drawing.Point(234, 428);
            this.email_tx.Name = "email_tx";
            this.email_tx.Size = new System.Drawing.Size(238, 13);
            this.email_tx.TabIndex = 6;
            this.email_tx.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // telefone_tx
            // 
            this.telefone_tx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.telefone_tx.Location = new System.Drawing.Point(234, 384);
            this.telefone_tx.Name = "telefone_tx";
            this.telefone_tx.Size = new System.Drawing.Size(238, 13);
            this.telefone_tx.TabIndex = 5;
            // 
            // cidade_tx
            // 
            this.cidade_tx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cidade_tx.Location = new System.Drawing.Point(551, 260);
            this.cidade_tx.Name = "cidade_tx";
            this.cidade_tx.Size = new System.Drawing.Size(200, 13);
            this.cidade_tx.TabIndex = 4;
            this.cidade_tx.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // endereco_tx
            // 
            this.endereco_tx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.endereco_tx.Location = new System.Drawing.Point(234, 332);
            this.endereco_tx.Name = "endereco_tx";
            this.endereco_tx.Size = new System.Drawing.Size(504, 13);
            this.endereco_tx.TabIndex = 2;
            this.endereco_tx.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // estado_tx
            // 
            this.estado_tx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.estado_tx.Location = new System.Drawing.Point(234, 269);
            this.estado_tx.Name = "estado_tx";
            this.estado_tx.Size = new System.Drawing.Size(197, 13);
            this.estado_tx.TabIndex = 1;
            this.estado_tx.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // nome_tx
            // 
            this.nome_tx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nome_tx.Location = new System.Drawing.Point(234, 129);
            this.nome_tx.Name = "nome_tx";
            this.nome_tx.Size = new System.Drawing.Size(517, 13);
            this.nome_tx.TabIndex = 0;
            this.nome_tx.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1292, 669);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox nome_tx;
        private System.Windows.Forms.MaskedTextBox cpf_tx;
        private System.Windows.Forms.TextBox rg_tx;
        private System.Windows.Forms.TextBox estadocivil_tx;
        private System.Windows.Forms.TextBox salario_tx;
        private System.Windows.Forms.TextBox email_tx;
        private System.Windows.Forms.TextBox telefone_tx;
        private System.Windows.Forms.TextBox cidade_tx;
        private System.Windows.Forms.TextBox endereco_tx;
        private System.Windows.Forms.TextBox estado_tx;
        private System.Windows.Forms.DateTimePicker datanascimento_tx;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox funcao_tx;
    }
}

