namespace Projeto_CRUD_Lançamentos_Financeiros
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
            lblvalor = new Label();
            txbvalor = new TextBox();
            txbdesc = new TextBox();
            lbldata = new Label();
            lbldesc = new Label();
            date = new DateTimePicker();
            btncredito = new Button();
            btndebito = new Button();
            lblsaldo = new Label();
            cbfiltros = new ComboBox();
            lblfiltro = new Label();
            btnfiltro = new Button();
            lbltipo = new Label();
            lbltipo2 = new Label();
            btnconsultar = new Button();
            dataGridView1 = new DataGridView();
            btngravar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lblvalor
            // 
            lblvalor.AutoSize = true;
            lblvalor.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblvalor.Location = new Point(27, 33);
            lblvalor.Name = "lblvalor";
            lblvalor.Size = new Size(62, 25);
            lblvalor.TabIndex = 2;
            lblvalor.Text = "Valor:";
            // 
            // txbvalor
            // 
            txbvalor.BorderStyle = BorderStyle.None;
            txbvalor.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txbvalor.Location = new Point(136, 37);
            txbvalor.Multiline = true;
            txbvalor.Name = "txbvalor";
            txbvalor.ScrollBars = ScrollBars.Both;
            txbvalor.Size = new Size(130, 21);
            txbvalor.TabIndex = 4;
            // 
            // txbdesc
            // 
            txbdesc.BorderStyle = BorderStyle.None;
            txbdesc.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txbdesc.Location = new Point(136, 76);
            txbdesc.Multiline = true;
            txbdesc.Name = "txbdesc";
            txbdesc.Size = new Size(174, 35);
            txbdesc.TabIndex = 17;
            txbdesc.TextAlign = HorizontalAlignment.Center;
            txbdesc.UseWaitCursor = true;
            // 
            // lbldata
            // 
            lbldata.AutoSize = true;
            lbldata.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbldata.Location = new Point(27, 129);
            lbldata.Name = "lbldata";
            lbldata.Size = new Size(56, 25);
            lbldata.TabIndex = 16;
            lbldata.Text = "Data:";
            // 
            // lbldesc
            // 
            lbldesc.AutoSize = true;
            lbldesc.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbldesc.Location = new Point(27, 76);
            lbldesc.Name = "lbldesc";
            lbldesc.Size = new Size(103, 25);
            lbldesc.TabIndex = 15;
            lbldesc.Text = "Descrição:";
            // 
            // date
            // 
            date.Location = new Point(136, 131);
            date.Name = "date";
            date.Size = new Size(200, 23);
            date.TabIndex = 18;
            // 
            // btncredito
            // 
            btncredito.BackColor = Color.FromArgb(192, 255, 192);
            btncredito.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btncredito.Location = new Point(27, 239);
            btncredito.Name = "btncredito";
            btncredito.Size = new Size(118, 51);
            btncredito.TabIndex = 19;
            btncredito.Text = "Crédito ➕";
            btncredito.UseVisualStyleBackColor = false;
            btncredito.Click += btncredito_Click;
            // 
            // btndebito
            // 
            btndebito.BackColor = Color.FromArgb(255, 128, 128);
            btndebito.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btndebito.Location = new Point(27, 308);
            btndebito.Name = "btndebito";
            btndebito.Size = new Size(118, 51);
            btndebito.TabIndex = 20;
            btndebito.Text = "Débito ➖";
            btndebito.UseVisualStyleBackColor = false;
            btndebito.Click += btndebito_Click;
            // 
            // lblsaldo
            // 
            lblsaldo.AutoSize = true;
            lblsaldo.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblsaldo.Location = new Point(27, 392);
            lblsaldo.Name = "lblsaldo";
            lblsaldo.Size = new Size(120, 25);
            lblsaldo.TabIndex = 21;
            lblsaldo.Text = "Saldo Atual: ";
            // 
            // cbfiltros
            // 
            cbfiltros.FormattingEnabled = true;
            cbfiltros.Items.AddRange(new object[] { "Todos", "Crédito", "Débito" });
            cbfiltros.Location = new Point(684, 449);
            cbfiltros.Name = "cbfiltros";
            cbfiltros.Size = new Size(121, 23);
            cbfiltros.TabIndex = 24;
            // 
            // lblfiltro
            // 
            lblfiltro.AutoSize = true;
            lblfiltro.Font = new Font("Arial", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblfiltro.Location = new Point(592, 449);
            lblfiltro.Name = "lblfiltro";
            lblfiltro.Size = new Size(66, 24);
            lblfiltro.TabIndex = 25;
            lblfiltro.Text = "Filtro:";
            // 
            // btnfiltro
            // 
            btnfiltro.BackColor = Color.LightBlue;
            btnfiltro.Location = new Point(843, 443);
            btnfiltro.Name = "btnfiltro";
            btnfiltro.Size = new Size(84, 33);
            btnfiltro.TabIndex = 26;
            btnfiltro.Text = "Filtrar";
            btnfiltro.UseVisualStyleBackColor = false;
            btnfiltro.Click += btnfiltro_Click;
            // 
            // lbltipo
            // 
            lbltipo.AutoSize = true;
            lbltipo.Font = new Font("Arial Narrow", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbltipo.Location = new Point(27, 184);
            lbltipo.Name = "lbltipo";
            lbltipo.Size = new Size(49, 24);
            lbltipo.TabIndex = 27;
            lbltipo.Text = "Tipo:";
            // 
            // lbltipo2
            // 
            lbltipo2.AutoSize = true;
            lbltipo2.Location = new Point(83, 193);
            lbltipo2.Name = "lbltipo2";
            lbltipo2.Size = new Size(0, 15);
            lbltipo2.TabIndex = 28;
            // 
            // btnconsultar
            // 
            btnconsultar.BackColor = Color.DeepSkyBlue;
            btnconsultar.Font = new Font("Arial Narrow", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnconsultar.Location = new Point(592, 28);
            btnconsultar.Name = "btnconsultar";
            btnconsultar.Size = new Size(111, 30);
            btnconsultar.TabIndex = 29;
            btnconsultar.Text = "Consultar";
            btnconsultar.UseVisualStyleBackColor = false;
            btnconsultar.Click += btnconsultar_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(592, 76);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(335, 341);
            dataGridView1.TabIndex = 0;
            // 
            // btngravar
            // 
            btngravar.Location = new Point(0, 0);
            btngravar.Name = "btngravar";
            btngravar.Size = new Size(75, 23);
            btngravar.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PowderBlue;
            ClientSize = new Size(1008, 830);
            Controls.Add(btngravar);
            Controls.Add(btnconsultar);
            Controls.Add(lbltipo2);
            Controls.Add(lbltipo);
            Controls.Add(btnfiltro);
            Controls.Add(lblfiltro);
            Controls.Add(cbfiltros);
            Controls.Add(lblsaldo);
            Controls.Add(btndebito);
            Controls.Add(btncredito);
            Controls.Add(date);
            Controls.Add(txbdesc);
            Controls.Add(lbldata);
            Controls.Add(lbldesc);
            Controls.Add(txbvalor);
            Controls.Add(lblvalor);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblvalor;
        private TextBox txbvalor;
        private TextBox txbdesc;
        private Label lbldata;
        private Label lbldesc;
        private DateTimePicker date;
        private Button btncredito;
        private Button btndebito;
        private Label lblsaldo;
        private ComboBox comboBox1;
        private Label lblfiltro;
        private Button btnfiltro;
        private Label lbltipo;
        private Label lbltipo2;
        private Button btnconsultar;
        private DataGridView dataGridView1;
        private Button btngravar;
        private ComboBox cbfiltros;
    }
}
