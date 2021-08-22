
namespace FuncaoMultRetorno
{
    partial class Exec03
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Exec03));
            this.dgHistorico = new System.Windows.Forms.DataGridView();
            this.idColun = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorEmCaixaCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DespesasDoMesCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GanhosDoMesCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorLiquidoCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SeLucrouCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSair = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtGanhos = new System.Windows.Forms.TextBox();
            this.txtDespesas = new System.Windows.Forms.TextBox();
            this.btnCalacula = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgHistorico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgHistorico
            // 
            this.dgHistorico.AllowUserToAddRows = false;
            this.dgHistorico.AllowUserToDeleteRows = false;
            this.dgHistorico.AllowUserToOrderColumns = true;
            this.dgHistorico.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(49)))), ((int)(((byte)(100)))));
            this.dgHistorico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgHistorico.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idColun,
            this.ValorEmCaixaCol,
            this.DespesasDoMesCol,
            this.GanhosDoMesCol,
            this.ValorLiquidoCol,
            this.SeLucrouCol});
            this.dgHistorico.Location = new System.Drawing.Point(9, 22);
            this.dgHistorico.Name = "dgHistorico";
            this.dgHistorico.ReadOnly = true;
            this.dgHistorico.RowTemplate.Height = 50;
            this.dgHistorico.Size = new System.Drawing.Size(651, 231);
            this.dgHistorico.TabIndex = 0;
            this.dgHistorico.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgHistorico_CellContentClick);
            // 
            // idColun
            // 
            this.idColun.HeaderText = "ID";
            this.idColun.Name = "idColun";
            this.idColun.ReadOnly = true;
            this.idColun.Width = 50;
            // 
            // ValorEmCaixaCol
            // 
            this.ValorEmCaixaCol.HeaderText = "ValorEmCaixa";
            this.ValorEmCaixaCol.Name = "ValorEmCaixaCol";
            this.ValorEmCaixaCol.ReadOnly = true;
            // 
            // DespesasDoMesCol
            // 
            this.DespesasDoMesCol.HeaderText = "DespesasDoMes";
            this.DespesasDoMesCol.Name = "DespesasDoMesCol";
            this.DespesasDoMesCol.ReadOnly = true;
            this.DespesasDoMesCol.Width = 150;
            // 
            // GanhosDoMesCol
            // 
            this.GanhosDoMesCol.HeaderText = "Ganhos Do Mes";
            this.GanhosDoMesCol.Name = "GanhosDoMesCol";
            this.GanhosDoMesCol.ReadOnly = true;
            // 
            // ValorLiquidoCol
            // 
            this.ValorLiquidoCol.HeaderText = "Valor Liquido";
            this.ValorLiquidoCol.Name = "ValorLiquidoCol";
            this.ValorLiquidoCol.ReadOnly = true;
            // 
            // SeLucrouCol
            // 
            this.SeLucrouCol.HeaderText = "Se Lucrou";
            this.SeLucrouCol.Name = "SeLucrouCol";
            this.SeLucrouCol.ReadOnly = true;
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(206, 410);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(91, 45);
            this.btnSair.TabIndex = 1;
            this.btnSair.Text = "SAIR";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(411, 259);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(244, 217);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 296);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ganhos Do Mês";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 333);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Despesas Do Mês";
            // 
            // txtGanhos
            // 
            this.txtGanhos.Location = new System.Drawing.Point(123, 296);
            this.txtGanhos.Name = "txtGanhos";
            this.txtGanhos.Size = new System.Drawing.Size(168, 23);
            this.txtGanhos.TabIndex = 5;
            // 
            // txtDespesas
            // 
            this.txtDespesas.Location = new System.Drawing.Point(123, 325);
            this.txtDespesas.Name = "txtDespesas";
            this.txtDespesas.Size = new System.Drawing.Size(168, 23);
            this.txtDespesas.TabIndex = 6;
            // 
            // btnCalacula
            // 
            this.btnCalacula.Location = new System.Drawing.Point(46, 410);
            this.btnCalacula.Name = "btnCalacula";
            this.btnCalacula.Size = new System.Drawing.Size(91, 45);
            this.btnCalacula.TabIndex = 7;
            this.btnCalacula.Text = "CALCULA";
            this.btnCalacula.UseVisualStyleBackColor = true;
            this.btnCalacula.Click += new System.EventHandler(this.btnCalacula_Click);
            // 
            // Exec03
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(112)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(667, 488);
            this.Controls.Add(this.btnCalacula);
            this.Controls.Add(this.txtDespesas);
            this.Controls.Add(this.txtGanhos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.dgHistorico);
            this.Name = "Exec03";
            this.Text = "Exec03";
            this.Load += new System.EventHandler(this.Exec03_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgHistorico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgHistorico;
        private System.Windows.Forms.DataGridViewTextBoxColumn idColun;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorEmCaixaCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn DespesasDoMesCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn GanhosDoMesCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorLiquidoCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn SeLucrouCol;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtGanhos;
        private System.Windows.Forms.TextBox txtDespesas;
        private System.Windows.Forms.Button btnCalacula;
    }
}