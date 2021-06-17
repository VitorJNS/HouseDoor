
namespace HouseDoor
{
    partial class avaliacoes_listar
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
            this.listar_avaliacoes = new System.Windows.Forms.Button();
            this.txt_id_imovel = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_avaliacoes = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_avaliacoes)).BeginInit();
            this.SuspendLayout();
            // 
            // listar_avaliacoes
            // 
            this.listar_avaliacoes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.listar_avaliacoes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listar_avaliacoes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.listar_avaliacoes.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.listar_avaliacoes.ForeColor = System.Drawing.Color.White;
            this.listar_avaliacoes.Location = new System.Drawing.Point(46, 216);
            this.listar_avaliacoes.Name = "listar_avaliacoes";
            this.listar_avaliacoes.Size = new System.Drawing.Size(303, 59);
            this.listar_avaliacoes.TabIndex = 0;
            this.listar_avaliacoes.Text = "Listar Avaliações do Imóvel X";
            this.listar_avaliacoes.UseVisualStyleBackColor = false;
            this.listar_avaliacoes.Click += new System.EventHandler(this.listar_avaliacoes_Click);
            // 
            // txt_id_imovel
            // 
            this.txt_id_imovel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txt_id_imovel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_id_imovel.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_id_imovel.Location = new System.Drawing.Point(168, 125);
            this.txt_id_imovel.Multiline = true;
            this.txt_id_imovel.Name = "txt_id_imovel";
            this.txt_id_imovel.Size = new System.Drawing.Size(181, 23);
            this.txt_id_imovel.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.label1.Location = new System.Drawing.Point(39, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID do Imóvel";
            // 
            // dgv_avaliacoes
            // 
            this.dgv_avaliacoes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_avaliacoes.Location = new System.Drawing.Point(385, 28);
            this.dgv_avaliacoes.Name = "dgv_avaliacoes";
            this.dgv_avaliacoes.RowTemplate.Height = 25;
            this.dgv_avaliacoes.Size = new System.Drawing.Size(391, 389);
            this.dgv_avaliacoes.TabIndex = 3;
            this.dgv_avaliacoes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_avaliacoes_CellContentClick);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.button2.Location = new System.Drawing.Point(108, 307);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(178, 44);
            this.button2.TabIndex = 41;
            this.button2.Text = "Página principal";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // avaliacoes_listar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dgv_avaliacoes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_id_imovel);
            this.Controls.Add(this.listar_avaliacoes);
            this.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.Name = "avaliacoes_listar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "avaliacoes_listar";
            this.Load += new System.EventHandler(this.avaliacoes_listar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_avaliacoes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button listar_avaliacoes;
        private System.Windows.Forms.TextBox txt_id_imovel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_avaliacoes;
        private System.Windows.Forms.Button button2;
    }
}