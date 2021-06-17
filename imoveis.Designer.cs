
namespace HouseDoor
{
    partial class imoveis
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
            this.dgv_imovel = new System.Windows.Forms.DataGridView();
            this.txt_buscar_imovel = new System.Windows.Forms.Button();
            this.txt_logradouro = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_imovel)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_imovel
            // 
            this.dgv_imovel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_imovel.Location = new System.Drawing.Point(408, 26);
            this.dgv_imovel.Name = "dgv_imovel";
            this.dgv_imovel.RowTemplate.Height = 25;
            this.dgv_imovel.Size = new System.Drawing.Size(672, 424);
            this.dgv_imovel.TabIndex = 0;
            this.dgv_imovel.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_imovel_CellContentDoubleClick);
            this.dgv_imovel.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_imovel_CellDoubleClick);
            // 
            // txt_buscar_imovel
            // 
            this.txt_buscar_imovel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.txt_buscar_imovel.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_buscar_imovel.ForeColor = System.Drawing.Color.White;
            this.txt_buscar_imovel.Location = new System.Drawing.Point(118, 199);
            this.txt_buscar_imovel.Name = "txt_buscar_imovel";
            this.txt_buscar_imovel.Size = new System.Drawing.Size(167, 63);
            this.txt_buscar_imovel.TabIndex = 1;
            this.txt_buscar_imovel.Text = "Buscar Imóvel";
            this.txt_buscar_imovel.UseVisualStyleBackColor = false;
            this.txt_buscar_imovel.Click += new System.EventHandler(this.txt_buscar_imovel_Click);
            // 
            // txt_logradouro
            // 
            this.txt_logradouro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txt_logradouro.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_logradouro.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_logradouro.Location = new System.Drawing.Point(139, 106);
            this.txt_logradouro.Name = "txt_logradouro";
            this.txt_logradouro.Size = new System.Drawing.Size(263, 21);
            this.txt_logradouro.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.label1.Location = new System.Drawing.Point(13, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Logradouro";
            // 
            // imoveis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1092, 480);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_logradouro);
            this.Controls.Add(this.txt_buscar_imovel);
            this.Controls.Add(this.dgv_imovel);
            this.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.Name = "imoveis";
            this.Text = "imoveis";
            this.Load += new System.EventHandler(this.imoveis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_imovel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_imovel;
        private System.Windows.Forms.Button txt_buscar_imovel;
        private System.Windows.Forms.TextBox txt_logradouro;
        private System.Windows.Forms.Label label1;
    }
}