namespace LP_supermercado
{
    partial class FormProduto
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
            this.components = new System.ComponentModel.Container();
            this.dtGridProdutos = new System.Windows.Forms.DataGridView();
            this.produtosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lpSupermercadoDataSet = new LP_supermercado.lpSupermercadoDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtQuantComprar = new System.Windows.Forms.TextBox();
            this.btnComprar = new System.Windows.Forms.Button();
            this.lblProdutoNome = new System.Windows.Forms.Label();
            this.lblProdutoDescri = new System.Windows.Forms.Label();
            this.lblProdutoPreco = new System.Windows.Forms.Label();
            this.lblProdutoQuant = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.produtosTableAdapter = new LP_supermercado.lpSupermercadoDataSetTableAdapters.produtosTableAdapter();
            this.nomeProdutoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridProdutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lpSupermercadoDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dtGridProdutos
            // 
            this.dtGridProdutos.AutoGenerateColumns = false;
            this.dtGridProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomeProdutoDataGridViewTextBoxColumn,
            this.descricao,
            this.preco,
            this.quantidade});
            this.dtGridProdutos.DataSource = this.produtosBindingSource;
            this.dtGridProdutos.Location = new System.Drawing.Point(22, 100);
            this.dtGridProdutos.Name = "dtGridProdutos";
            this.dtGridProdutos.RowHeadersWidth = 51;
            this.dtGridProdutos.RowTemplate.Height = 24;
            this.dtGridProdutos.Size = new System.Drawing.Size(553, 327);
            this.dtGridProdutos.TabIndex = 0;
            this.dtGridProdutos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGridProdutos_CellContentClick);
            // 
            // produtosBindingSource
            // 
            this.produtosBindingSource.DataMember = "produtos";
            this.produtosBindingSource.DataSource = this.lpSupermercadoDataSet;
            // 
            // lpSupermercadoDataSet
            // 
            this.lpSupermercadoDataSet.DataSetName = "lpSupermercadoDataSet";
            this.lpSupermercadoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(615, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(615, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Descrição";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(615, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Preço";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(615, 278);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(173, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Quantidade disponivel";
            // 
            // txtQuantComprar
            // 
            this.txtQuantComprar.Location = new System.Drawing.Point(619, 368);
            this.txtQuantComprar.Name = "txtQuantComprar";
            this.txtQuantComprar.Size = new System.Drawing.Size(100, 22);
            this.txtQuantComprar.TabIndex = 5;
            // 
            // btnComprar
            // 
            this.btnComprar.Location = new System.Drawing.Point(730, 387);
            this.btnComprar.Name = "btnComprar";
            this.btnComprar.Size = new System.Drawing.Size(75, 23);
            this.btnComprar.TabIndex = 6;
            this.btnComprar.Text = "Comprar";
            this.btnComprar.UseVisualStyleBackColor = true;
            // 
            // lblProdutoNome
            // 
            this.lblProdutoNome.AutoSize = true;
            this.lblProdutoNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProdutoNome.Location = new System.Drawing.Point(726, 91);
            this.lblProdutoNome.Name = "lblProdutoNome";
            this.lblProdutoNome.Size = new System.Drawing.Size(53, 20);
            this.lblProdutoNome.TabIndex = 7;
            this.lblProdutoNome.Text = "Nome";
            // 
            // lblProdutoDescri
            // 
            this.lblProdutoDescri.AutoSize = true;
            this.lblProdutoDescri.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProdutoDescri.Location = new System.Drawing.Point(726, 160);
            this.lblProdutoDescri.Name = "lblProdutoDescri";
            this.lblProdutoDescri.Size = new System.Drawing.Size(86, 20);
            this.lblProdutoDescri.TabIndex = 8;
            this.lblProdutoDescri.Text = "Descrição";
            // 
            // lblProdutoPreco
            // 
            this.lblProdutoPreco.AutoSize = true;
            this.lblProdutoPreco.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProdutoPreco.Location = new System.Drawing.Point(726, 233);
            this.lblProdutoPreco.Name = "lblProdutoPreco";
            this.lblProdutoPreco.Size = new System.Drawing.Size(86, 20);
            this.lblProdutoPreco.TabIndex = 9;
            this.lblProdutoPreco.Text = "Descrição";
            // 
            // lblProdutoQuant
            // 
            this.lblProdutoQuant.AutoSize = true;
            this.lblProdutoQuant.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProdutoQuant.Location = new System.Drawing.Point(726, 298);
            this.lblProdutoQuant.Name = "lblProdutoQuant";
            this.lblProdutoQuant.Size = new System.Drawing.Size(86, 20);
            this.lblProdutoQuant.TabIndex = 10;
            this.lblProdutoQuant.Text = "Descrição";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.OrangeRed;
            this.label9.Location = new System.Drawing.Point(358, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(164, 32);
            this.label9.TabIndex = 11;
            this.label9.Text = "Bem vindo, ";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblUserName.Location = new System.Drawing.Point(510, 23);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(24, 32);
            this.lblUserName.TabIndex = 12;
            this.lblUserName.Text = "-";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(22, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "LogOut";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // produtosTableAdapter
            // 
            this.produtosTableAdapter.ClearBeforeFill = true;
            // 
            // nomeProdutoDataGridViewTextBoxColumn
            // 
            this.nomeProdutoDataGridViewTextBoxColumn.DataPropertyName = "nomeProduto";
            this.nomeProdutoDataGridViewTextBoxColumn.HeaderText = "nomeProduto";
            this.nomeProdutoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nomeProdutoDataGridViewTextBoxColumn.Name = "nomeProdutoDataGridViewTextBoxColumn";
            this.nomeProdutoDataGridViewTextBoxColumn.Width = 125;
            // 
            // descricao
            // 
            this.descricao.DataPropertyName = "descricao";
            this.descricao.HeaderText = "Descrição";
            this.descricao.MinimumWidth = 6;
            this.descricao.Name = "descricao";
            this.descricao.Width = 125;
            // 
            // preco
            // 
            this.preco.DataPropertyName = "preco";
            this.preco.HeaderText = "Preço";
            this.preco.MinimumWidth = 6;
            this.preco.Name = "preco";
            this.preco.Width = 125;
            // 
            // quantidade
            // 
            this.quantidade.DataPropertyName = "quantidade";
            this.quantidade.HeaderText = "Quantidade";
            this.quantidade.MinimumWidth = 6;
            this.quantidade.Name = "quantidade";
            this.quantidade.Width = 125;
            // 
            // FormProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblProdutoQuant);
            this.Controls.Add(this.lblProdutoPreco);
            this.Controls.Add(this.lblProdutoDescri);
            this.Controls.Add(this.lblProdutoNome);
            this.Controls.Add(this.btnComprar);
            this.Controls.Add(this.txtQuantComprar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtGridProdutos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Supermercado";
            this.Load += new System.EventHandler(this.FormProduto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridProdutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lpSupermercadoDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtGridProdutos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtQuantComprar;
        private System.Windows.Forms.Button btnComprar;
        private System.Windows.Forms.Label lblProdutoNome;
        private System.Windows.Forms.Label lblProdutoDescri;
        private System.Windows.Forms.Label lblProdutoPreco;
        private System.Windows.Forms.Label lblProdutoQuant;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Button button1;
        private lpSupermercadoDataSet lpSupermercadoDataSet;
        private System.Windows.Forms.BindingSource produtosBindingSource;
        private lpSupermercadoDataSetTableAdapters.produtosTableAdapter produtosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeProdutoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn preco;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidade;
    }
}