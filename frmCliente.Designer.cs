namespace Cadastro
{
    partial class frmCliente
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
            this.lblNome = new System.Windows.Forms.Label();
            this.lblCPF = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.lblTel = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.mskCPF = new System.Windows.Forms.MaskedTextBox();
            this.mskTel = new System.Windows.Forms.MaskedTextBox();
            this.mskData = new System.Windows.Forms.MaskedTextBox();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnVoltarE = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblNome.Location = new System.Drawing.Point(59, 33);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(49, 17);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome:";
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblCPF.Location = new System.Drawing.Point(67, 107);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(38, 17);
            this.lblCPF.TabIndex = 1;
            this.lblCPF.Text = "CPF:";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblData.Location = new System.Drawing.Point(275, 104);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(140, 17);
            this.lblData.TabIndex = 2;
            this.lblData.Text = "Data de Nascimento:";
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblEndereco.Location = new System.Drawing.Point(253, 183);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(73, 17);
            this.lblEndereco.TabIndex = 4;
            this.lblEndereco.Text = "Endereço:";
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblTel.Location = new System.Drawing.Point(40, 179);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(68, 17);
            this.lblTel.TabIndex = 5;
            this.lblTel.Text = "Telefone:";
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtNome.Location = new System.Drawing.Point(138, 33);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(383, 23);
            this.txtNome.TabIndex = 6;
            // 
            // mskCPF
            // 
            this.mskCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.mskCPF.Location = new System.Drawing.Point(133, 107);
            this.mskCPF.Mask = "###.###.###-##";
            this.mskCPF.Name = "mskCPF";
            this.mskCPF.Size = new System.Drawing.Size(100, 23);
            this.mskCPF.TabIndex = 7;
            // 
            // mskTel
            // 
            this.mskTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.mskTel.Location = new System.Drawing.Point(133, 177);
            this.mskTel.Mask = "(##)####-####";
            this.mskTel.Name = "mskTel";
            this.mskTel.Size = new System.Drawing.Size(100, 23);
            this.mskTel.TabIndex = 8;
            this.mskTel.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mskTel_MaskInputRejected);
            // 
            // mskData
            // 
            this.mskData.Location = new System.Drawing.Point(412, 102);
            this.mskData.Mask = "##/##/####";
            this.mskData.Name = "mskData";
            this.mskData.Size = new System.Drawing.Size(109, 20);
            this.mskData.TabIndex = 9;
            // 
            // txtEndereco
            // 
            this.txtEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtEndereco.Location = new System.Drawing.Point(336, 176);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(185, 23);
            this.txtEndereco.TabIndex = 10;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(432, 276);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(89, 29);
            this.btnSalvar.TabIndex = 11;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnVoltarE
            // 
            this.btnVoltarE.Location = new System.Drawing.Point(53, 276);
            this.btnVoltarE.Name = "btnVoltarE";
            this.btnVoltarE.Size = new System.Drawing.Size(89, 29);
            this.btnVoltarE.TabIndex = 24;
            this.btnVoltarE.Text = "Voltar";
            this.btnVoltarE.UseVisualStyleBackColor = true;
            this.btnVoltarE.Click += new System.EventHandler(this.btnVoltarE_Click);
            // 
            // frmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.btnVoltarE);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.mskData);
            this.Controls.Add(this.mskTel);
            this.Controls.Add(this.mskCPF);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblTel);
            this.Controls.Add(this.lblEndereco);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.lblCPF);
            this.Controls.Add(this.lblNome);
            this.MaximizeBox = false;
            this.Name = "frmCliente";
            this.Text = "frmCliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.MaskedTextBox mskCPF;
        private System.Windows.Forms.MaskedTextBox mskTel;
        private System.Windows.Forms.MaskedTextBox mskData;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnVoltarE;
    }
}