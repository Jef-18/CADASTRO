namespace Cadastro
{
    partial class frmEmpresa
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
            this.btnSalvar = new System.Windows.Forms.Button();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.mskTel = new System.Windows.Forms.MaskedTextBox();
            this.mskCNPJ = new System.Windows.Forms.MaskedTextBox();
            this.txtRazaoSocial = new System.Windows.Forms.TextBox();
            this.lblTel = new System.Windows.Forms.Label();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.lblCNPJ = new System.Windows.Forms.Label();
            this.lblRazaoSocial = new System.Windows.Forms.Label();
            this.btnVoltarE = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(434, 288);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(89, 29);
            this.btnSalvar.TabIndex = 22;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // txtEndereco
            // 
            this.txtEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtEndereco.Location = new System.Drawing.Point(140, 157);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(185, 23);
            this.txtEndereco.TabIndex = 21;
            // 
            // mskTel
            // 
            this.mskTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.mskTel.Location = new System.Drawing.Point(423, 95);
            this.mskTel.Mask = "(##)####-####";
            this.mskTel.Name = "mskTel";
            this.mskTel.Size = new System.Drawing.Size(100, 23);
            this.mskTel.TabIndex = 19;
            // 
            // mskCNPJ
            // 
            this.mskCNPJ.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.mskCNPJ.Location = new System.Drawing.Point(140, 92);
            this.mskCNPJ.Mask = "##.###.###/####-##";
            this.mskCNPJ.Name = "mskCNPJ";
            this.mskCNPJ.Size = new System.Drawing.Size(149, 23);
            this.mskCNPJ.TabIndex = 18;
            // 
            // txtRazaoSocial
            // 
            this.txtRazaoSocial.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtRazaoSocial.Location = new System.Drawing.Point(140, 43);
            this.txtRazaoSocial.Name = "txtRazaoSocial";
            this.txtRazaoSocial.Size = new System.Drawing.Size(383, 23);
            this.txtRazaoSocial.TabIndex = 17;
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblTel.Location = new System.Drawing.Point(349, 101);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(68, 17);
            this.lblTel.TabIndex = 16;
            this.lblTel.Text = "Telefone:";
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblEndereco.Location = new System.Drawing.Point(35, 163);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(73, 17);
            this.lblEndereco.TabIndex = 15;
            this.lblEndereco.Text = "Endereço:";
            // 
            // lblCNPJ
            // 
            this.lblCNPJ.AutoSize = true;
            this.lblCNPJ.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblCNPJ.Location = new System.Drawing.Point(74, 95);
            this.lblCNPJ.Name = "lblCNPJ";
            this.lblCNPJ.Size = new System.Drawing.Size(47, 17);
            this.lblCNPJ.TabIndex = 13;
            this.lblCNPJ.Text = "CNPJ:";
            // 
            // lblRazaoSocial
            // 
            this.lblRazaoSocial.AutoSize = true;
            this.lblRazaoSocial.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblRazaoSocial.Location = new System.Drawing.Point(43, 46);
            this.lblRazaoSocial.Name = "lblRazaoSocial";
            this.lblRazaoSocial.Size = new System.Drawing.Size(95, 17);
            this.lblRazaoSocial.TabIndex = 12;
            this.lblRazaoSocial.Text = "Razão Social:";
            this.lblRazaoSocial.Click += new System.EventHandler(this.lblRazaoSocial_Click);
            // 
            // btnVoltarE
            // 
            this.btnVoltarE.Location = new System.Drawing.Point(49, 288);
            this.btnVoltarE.Name = "btnVoltarE";
            this.btnVoltarE.Size = new System.Drawing.Size(89, 29);
            this.btnVoltarE.TabIndex = 23;
            this.btnVoltarE.Text = "Voltar";
            this.btnVoltarE.UseVisualStyleBackColor = true;
            this.btnVoltarE.Click += new System.EventHandler(this.btnVoltarE_Click);
            // 
            // frmEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.btnVoltarE);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.mskTel);
            this.Controls.Add(this.mskCNPJ);
            this.Controls.Add(this.txtRazaoSocial);
            this.Controls.Add(this.lblTel);
            this.Controls.Add(this.lblEndereco);
            this.Controls.Add(this.lblCNPJ);
            this.Controls.Add(this.lblRazaoSocial);
            this.MaximizeBox = false;
            this.Name = "frmEmpresa";
            this.Text = "frmEmpresa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.MaskedTextBox mskTel;
        private System.Windows.Forms.MaskedTextBox mskCNPJ;
        private System.Windows.Forms.TextBox txtRazaoSocial;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.Label lblCNPJ;
        private System.Windows.Forms.Label lblRazaoSocial;
        private System.Windows.Forms.Button btnVoltarE;
    }
}