﻿namespace WindowsFormsApp1
{
    partial class Frm_Dashboard
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
            this.Pnl_PainelEsquerda = new System.Windows.Forms.Panel();
            this.Pnl_Nav = new System.Windows.Forms.Panel();
            this.Btn_Configuracoes = new System.Windows.Forms.Button();
            this.Btn_Gastos = new System.Windows.Forms.Button();
            this.Btn_Analise = new System.Windows.Forms.Button();
            this.Btn_Calendario = new System.Windows.Forms.Button();
            this.Btn_Dashboard = new System.Windows.Forms.Button();
            this.Pnl_PainelTopo = new System.Windows.Forms.Panel();
            this.Lbl_TextoUsuario = new System.Windows.Forms.Label();
            this.Lbl_NomeUsuario = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Txt_Procurar = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Pnl_ = new System.Windows.Forms.Panel();
            this.Lbl_UltimosTrintaDias = new System.Windows.Forms.Label();
            this.Lbl_KwhAtual = new System.Windows.Forms.Label();
            this.Lbl_CosumoAtual = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Lbl_ConsumoAnterior = new System.Windows.Forms.Label();
            this.Pnl_Comparacao = new System.Windows.Forms.Panel();
            this.Lbl_Comparacao = new System.Windows.Forms.Label();
            this.Pnl_Grafico = new System.Windows.Forms.Panel();
            this.Lbl_Grafico = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.Lbl_TerminarDepois = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Lbl_Preencher = new System.Windows.Forms.Label();
            this.Pnl_PainelEsquerda.SuspendLayout();
            this.Pnl_PainelTopo.SuspendLayout();
            this.Pnl_.SuspendLayout();
            this.panel1.SuspendLayout();
            this.Pnl_Comparacao.SuspendLayout();
            this.Pnl_Grafico.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Pnl_PainelEsquerda
            // 
            this.Pnl_PainelEsquerda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.Pnl_PainelEsquerda.Controls.Add(this.Pnl_Nav);
            this.Pnl_PainelEsquerda.Controls.Add(this.Btn_Configuracoes);
            this.Pnl_PainelEsquerda.Controls.Add(this.Btn_Gastos);
            this.Pnl_PainelEsquerda.Controls.Add(this.Btn_Analise);
            this.Pnl_PainelEsquerda.Controls.Add(this.Btn_Calendario);
            this.Pnl_PainelEsquerda.Controls.Add(this.Btn_Dashboard);
            this.Pnl_PainelEsquerda.Controls.Add(this.Pnl_PainelTopo);
            this.Pnl_PainelEsquerda.Dock = System.Windows.Forms.DockStyle.Left;
            this.Pnl_PainelEsquerda.Location = new System.Drawing.Point(0, 0);
            this.Pnl_PainelEsquerda.Name = "Pnl_PainelEsquerda";
            this.Pnl_PainelEsquerda.Size = new System.Drawing.Size(186, 577);
            this.Pnl_PainelEsquerda.TabIndex = 0;
            // 
            // Pnl_Nav
            // 
            this.Pnl_Nav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.Pnl_Nav.Location = new System.Drawing.Point(1, 193);
            this.Pnl_Nav.Name = "Pnl_Nav";
            this.Pnl_Nav.Size = new System.Drawing.Size(1, 100);
            this.Pnl_Nav.TabIndex = 3;
            // 
            // Btn_Configuracoes
            // 
            this.Btn_Configuracoes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Btn_Configuracoes.FlatAppearance.BorderSize = 0;
            this.Btn_Configuracoes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Configuracoes.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Configuracoes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.Btn_Configuracoes.Location = new System.Drawing.Point(0, 535);
            this.Btn_Configuracoes.Name = "Btn_Configuracoes";
            this.Btn_Configuracoes.Size = new System.Drawing.Size(186, 42);
            this.Btn_Configuracoes.TabIndex = 6;
            this.Btn_Configuracoes.Text = "Configurações";
            this.Btn_Configuracoes.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.Btn_Configuracoes.UseVisualStyleBackColor = true;
            this.Btn_Configuracoes.Click += new System.EventHandler(this.Btn_Configuracoes_Click);
            this.Btn_Configuracoes.Leave += new System.EventHandler(this.Btn_Configuracoes_Leave);
            // 
            // Btn_Gastos
            // 
            this.Btn_Gastos.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_Gastos.FlatAppearance.BorderSize = 0;
            this.Btn_Gastos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Gastos.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Gastos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.Btn_Gastos.Location = new System.Drawing.Point(0, 270);
            this.Btn_Gastos.Name = "Btn_Gastos";
            this.Btn_Gastos.Size = new System.Drawing.Size(186, 42);
            this.Btn_Gastos.TabIndex = 5;
            this.Btn_Gastos.Text = "Gastos";
            this.Btn_Gastos.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.Btn_Gastos.UseVisualStyleBackColor = true;
            this.Btn_Gastos.Click += new System.EventHandler(this.Btn_Gastos_Click);
            this.Btn_Gastos.Leave += new System.EventHandler(this.Btn_Gastos_Leave);
            // 
            // Btn_Analise
            // 
            this.Btn_Analise.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_Analise.FlatAppearance.BorderSize = 0;
            this.Btn_Analise.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Analise.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Analise.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.Btn_Analise.Location = new System.Drawing.Point(0, 228);
            this.Btn_Analise.Name = "Btn_Analise";
            this.Btn_Analise.Size = new System.Drawing.Size(186, 42);
            this.Btn_Analise.TabIndex = 4;
            this.Btn_Analise.Text = "Análise";
            this.Btn_Analise.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.Btn_Analise.UseVisualStyleBackColor = true;
            this.Btn_Analise.Click += new System.EventHandler(this.Btn_Analise_Click);
            this.Btn_Analise.Leave += new System.EventHandler(this.Btn_Analise_Leave);
            // 
            // Btn_Calendario
            // 
            this.Btn_Calendario.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_Calendario.FlatAppearance.BorderSize = 0;
            this.Btn_Calendario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Calendario.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Calendario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.Btn_Calendario.Location = new System.Drawing.Point(0, 186);
            this.Btn_Calendario.Name = "Btn_Calendario";
            this.Btn_Calendario.Size = new System.Drawing.Size(186, 42);
            this.Btn_Calendario.TabIndex = 3;
            this.Btn_Calendario.Text = "Caléndario";
            this.Btn_Calendario.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.Btn_Calendario.UseVisualStyleBackColor = true;
            this.Btn_Calendario.Click += new System.EventHandler(this.button1_Click);
            this.Btn_Calendario.Leave += new System.EventHandler(this.Btn_Calendario_Leave);
            // 
            // Btn_Dashboard
            // 
            this.Btn_Dashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_Dashboard.FlatAppearance.BorderSize = 0;
            this.Btn_Dashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Dashboard.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Dashboard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.Btn_Dashboard.Location = new System.Drawing.Point(0, 144);
            this.Btn_Dashboard.Name = "Btn_Dashboard";
            this.Btn_Dashboard.Size = new System.Drawing.Size(186, 42);
            this.Btn_Dashboard.TabIndex = 2;
            this.Btn_Dashboard.Text = "Dashboard";
            this.Btn_Dashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.Btn_Dashboard.UseVisualStyleBackColor = true;
            this.Btn_Dashboard.Click += new System.EventHandler(this.Btn_Dashboard_Click);
            this.Btn_Dashboard.Leave += new System.EventHandler(this.Btn_Dashboard_Leave);
            // 
            // Pnl_PainelTopo
            // 
            this.Pnl_PainelTopo.Controls.Add(this.Lbl_TextoUsuario);
            this.Pnl_PainelTopo.Controls.Add(this.Lbl_NomeUsuario);
            this.Pnl_PainelTopo.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pnl_PainelTopo.Location = new System.Drawing.Point(0, 0);
            this.Pnl_PainelTopo.Name = "Pnl_PainelTopo";
            this.Pnl_PainelTopo.Size = new System.Drawing.Size(186, 144);
            this.Pnl_PainelTopo.TabIndex = 1;
            // 
            // Lbl_TextoUsuario
            // 
            this.Lbl_TextoUsuario.AutoSize = true;
            this.Lbl_TextoUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_TextoUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(178)))));
            this.Lbl_TextoUsuario.Location = new System.Drawing.Point(41, 118);
            this.Lbl_TextoUsuario.Name = "Lbl_TextoUsuario";
            this.Lbl_TextoUsuario.Size = new System.Drawing.Size(90, 12);
            this.Lbl_TextoUsuario.TabIndex = 2;
            this.Lbl_TextoUsuario.Text = "Texto do Usuário";
            // 
            // Lbl_NomeUsuario
            // 
            this.Lbl_NomeUsuario.AutoSize = true;
            this.Lbl_NomeUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_NomeUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(149)))));
            this.Lbl_NomeUsuario.Location = new System.Drawing.Point(40, 102);
            this.Lbl_NomeUsuario.Name = "Lbl_NomeUsuario";
            this.Lbl_NomeUsuario.Size = new System.Drawing.Size(128, 16);
            this.Lbl_NomeUsuario.TabIndex = 1;
            this.Lbl_NomeUsuario.Text = "Nome do Usuário";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.label1.Location = new System.Drawing.Point(192, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dashboard";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Txt_Procurar
            // 
            this.Txt_Procurar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.Txt_Procurar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_Procurar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Procurar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.Txt_Procurar.Location = new System.Drawing.Point(584, 20);
            this.Txt_Procurar.Multiline = true;
            this.Txt_Procurar.Name = "Txt_Procurar";
            this.Txt_Procurar.Size = new System.Drawing.Size(292, 20);
            this.Txt_Procurar.TabIndex = 1;
            this.Txt_Procurar.Text = "Procurar";
            this.Txt_Procurar.TextChanged += new System.EventHandler(this.Txt_Procurar_TextChanged);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(901, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(25, 25);
            this.button1.TabIndex = 2;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.botao_fechar);
            // 
            // Pnl_
            // 
            this.Pnl_.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.Pnl_.Controls.Add(this.Lbl_UltimosTrintaDias);
            this.Pnl_.Controls.Add(this.Lbl_KwhAtual);
            this.Pnl_.Controls.Add(this.Lbl_CosumoAtual);
            this.Pnl_.Location = new System.Drawing.Point(198, 67);
            this.Pnl_.Name = "Pnl_";
            this.Pnl_.Size = new System.Drawing.Size(258, 130);
            this.Pnl_.TabIndex = 3;
            // 
            // Lbl_UltimosTrintaDias
            // 
            this.Lbl_UltimosTrintaDias.AutoSize = true;
            this.Lbl_UltimosTrintaDias.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_UltimosTrintaDias.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(151)))), ((int)(((byte)(176)))));
            this.Lbl_UltimosTrintaDias.Location = new System.Drawing.Point(15, 102);
            this.Lbl_UltimosTrintaDias.Name = "Lbl_UltimosTrintaDias";
            this.Lbl_UltimosTrintaDias.Size = new System.Drawing.Size(99, 17);
            this.Lbl_UltimosTrintaDias.TabIndex = 2;
            this.Lbl_UltimosTrintaDias.Text = "Últimos 30 Dias";
            // 
            // Lbl_KwhAtual
            // 
            this.Lbl_KwhAtual.AutoSize = true;
            this.Lbl_KwhAtual.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_KwhAtual.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(249)))));
            this.Lbl_KwhAtual.Location = new System.Drawing.Point(12, 51);
            this.Lbl_KwhAtual.Name = "Lbl_KwhAtual";
            this.Lbl_KwhAtual.Size = new System.Drawing.Size(158, 32);
            this.Lbl_KwhAtual.TabIndex = 1;
            this.Lbl_KwhAtual.Text = "152,2 kWh";
            // 
            // Lbl_CosumoAtual
            // 
            this.Lbl_CosumoAtual.AutoSize = true;
            this.Lbl_CosumoAtual.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_CosumoAtual.ForeColor = System.Drawing.Color.White;
            this.Lbl_CosumoAtual.Location = new System.Drawing.Point(13, 11);
            this.Lbl_CosumoAtual.Name = "Lbl_CosumoAtual";
            this.Lbl_CosumoAtual.Size = new System.Drawing.Size(141, 25);
            this.Lbl_CosumoAtual.TabIndex = 0;
            this.Lbl_CosumoAtual.Text = "Consumo Atual";
            this.Lbl_CosumoAtual.Click += new System.EventHandler(this.Lbl_CosumoAtual_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.Lbl_ConsumoAnterior);
            this.panel1.Location = new System.Drawing.Point(489, 67);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(258, 130);
            this.panel1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(151)))), ((int)(((byte)(176)))));
            this.label2.Location = new System.Drawing.Point(15, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Último Mês";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(226)))), ((int)(((byte)(178)))));
            this.label3.Location = new System.Drawing.Point(12, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 32);
            this.label3.TabIndex = 1;
            this.label3.Text = "168,1 kWh";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Lbl_ConsumoAnterior
            // 
            this.Lbl_ConsumoAnterior.AutoSize = true;
            this.Lbl_ConsumoAnterior.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_ConsumoAnterior.ForeColor = System.Drawing.Color.White;
            this.Lbl_ConsumoAnterior.Location = new System.Drawing.Point(13, 11);
            this.Lbl_ConsumoAnterior.Name = "Lbl_ConsumoAnterior";
            this.Lbl_ConsumoAnterior.Size = new System.Drawing.Size(166, 25);
            this.Lbl_ConsumoAnterior.TabIndex = 0;
            this.Lbl_ConsumoAnterior.Text = "Consumo Anterior";
            this.Lbl_ConsumoAnterior.Click += new System.EventHandler(this.Lbl_ConsumoAnterior_Click);
            // 
            // Pnl_Comparacao
            // 
            this.Pnl_Comparacao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.Pnl_Comparacao.Controls.Add(this.Lbl_Comparacao);
            this.Pnl_Comparacao.Location = new System.Drawing.Point(198, 228);
            this.Pnl_Comparacao.Name = "Pnl_Comparacao";
            this.Pnl_Comparacao.Size = new System.Drawing.Size(258, 337);
            this.Pnl_Comparacao.TabIndex = 5;
            this.Pnl_Comparacao.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // Lbl_Comparacao
            // 
            this.Lbl_Comparacao.AutoSize = true;
            this.Lbl_Comparacao.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Comparacao.ForeColor = System.Drawing.Color.White;
            this.Lbl_Comparacao.Location = new System.Drawing.Point(13, 18);
            this.Lbl_Comparacao.Name = "Lbl_Comparacao";
            this.Lbl_Comparacao.Size = new System.Drawing.Size(119, 25);
            this.Lbl_Comparacao.TabIndex = 0;
            this.Lbl_Comparacao.Text = "Comparação";
            this.Lbl_Comparacao.Click += new System.EventHandler(this.label6_Click);
            // 
            // Pnl_Grafico
            // 
            this.Pnl_Grafico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.Pnl_Grafico.Controls.Add(this.Lbl_Grafico);
            this.Pnl_Grafico.Location = new System.Drawing.Point(489, 228);
            this.Pnl_Grafico.Name = "Pnl_Grafico";
            this.Pnl_Grafico.Size = new System.Drawing.Size(437, 229);
            this.Pnl_Grafico.TabIndex = 5;
            // 
            // Lbl_Grafico
            // 
            this.Lbl_Grafico.AutoSize = true;
            this.Lbl_Grafico.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Grafico.ForeColor = System.Drawing.Color.White;
            this.Lbl_Grafico.Location = new System.Drawing.Point(13, 11);
            this.Lbl_Grafico.Name = "Lbl_Grafico";
            this.Lbl_Grafico.Size = new System.Drawing.Size(73, 25);
            this.Lbl_Grafico.TabIndex = 0;
            this.Lbl_Grafico.Text = "Gráfico";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.Lbl_TerminarDepois);
            this.panel4.Location = new System.Drawing.Point(489, 490);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(437, 75);
            this.panel4.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(151)))), ((int)(((byte)(176)))));
            this.label4.Location = new System.Drawing.Point(15, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Último Mês";
            // 
            // Lbl_TerminarDepois
            // 
            this.Lbl_TerminarDepois.AccessibleRole = System.Windows.Forms.AccessibleRole.Clock;
            this.Lbl_TerminarDepois.AutoSize = true;
            this.Lbl_TerminarDepois.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_TerminarDepois.ForeColor = System.Drawing.Color.White;
            this.Lbl_TerminarDepois.Location = new System.Drawing.Point(13, 11);
            this.Lbl_TerminarDepois.Name = "Lbl_TerminarDepois";
            this.Lbl_TerminarDepois.Size = new System.Drawing.Size(166, 25);
            this.Lbl_TerminarDepois.TabIndex = 0;
            this.Lbl_TerminarDepois.Text = "Preencher Depois ";
            this.Lbl_TerminarDepois.Click += new System.EventHandler(this.label6_Click_1);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.Lbl_Preencher);
            this.panel2.Location = new System.Drawing.Point(771, 67);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(155, 130);
            this.panel2.TabIndex = 5;
            // 
            // Lbl_Preencher
            // 
            this.Lbl_Preencher.AutoSize = true;
            this.Lbl_Preencher.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Preencher.ForeColor = System.Drawing.Color.White;
            this.Lbl_Preencher.Location = new System.Drawing.Point(13, 11);
            this.Lbl_Preencher.Name = "Lbl_Preencher";
            this.Lbl_Preencher.Size = new System.Drawing.Size(98, 25);
            this.Lbl_Preencher.TabIndex = 0;
            this.Lbl_Preencher.Text = "Preencher";
            this.Lbl_Preencher.Click += new System.EventHandler(this.Lbl_Preencher_Click);
            // 
            // Frm_Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(951, 577);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.Pnl_Grafico);
            this.Controls.Add(this.Pnl_Comparacao);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Pnl_);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Txt_Procurar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Pnl_PainelEsquerda);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Frm_Dashboard_Load);
            this.Pnl_PainelEsquerda.ResumeLayout(false);
            this.Pnl_PainelTopo.ResumeLayout(false);
            this.Pnl_PainelTopo.PerformLayout();
            this.Pnl_.ResumeLayout(false);
            this.Pnl_.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.Pnl_Comparacao.ResumeLayout(false);
            this.Pnl_Comparacao.PerformLayout();
            this.Pnl_Grafico.ResumeLayout(false);
            this.Pnl_Grafico.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Pnl_PainelEsquerda;
        private System.Windows.Forms.Panel Pnl_PainelTopo;
        private System.Windows.Forms.Label Lbl_NomeUsuario;
        private System.Windows.Forms.Label Lbl_TextoUsuario;
        private System.Windows.Forms.Button Btn_Dashboard;
        private System.Windows.Forms.Button Btn_Analise;
        private System.Windows.Forms.Button Btn_Calendario;
        private System.Windows.Forms.Button Btn_Configuracoes;
        private System.Windows.Forms.Button Btn_Gastos;
        private System.Windows.Forms.Panel Pnl_Nav;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txt_Procurar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel Pnl_;
        private System.Windows.Forms.Label Lbl_CosumoAtual;
        private System.Windows.Forms.Label Lbl_KwhAtual;
        private System.Windows.Forms.Label Lbl_UltimosTrintaDias;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Lbl_ConsumoAnterior;
        private System.Windows.Forms.Panel Pnl_Comparacao;
        private System.Windows.Forms.Label Lbl_Comparacao;
        private System.Windows.Forms.Panel Pnl_Grafico;
        private System.Windows.Forms.Label Lbl_Grafico;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Lbl_TerminarDepois;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label Lbl_Preencher;
    }
}

