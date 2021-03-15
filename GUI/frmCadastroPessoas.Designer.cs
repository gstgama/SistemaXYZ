
namespace GUI
{
    partial class frmCadastroPessoas
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
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.rbtnMasculino = new System.Windows.Forms.RadioButton();
            this.rbtnFeminino = new System.Windows.Forms.RadioButton();
            this.lblSexo = new System.Windows.Forms.Label();
            this.lblEstadoCivil = new System.Windows.Forms.Label();
            this.cbEstadosCivis = new System.Windows.Forms.ComboBox();
            this.chkRecebeEmail = new System.Windows.Forms.CheckBox();
            this.chkRecebeSMS = new System.Windows.Forms.CheckBox();
            this.btnInserir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblCodigo.Location = new System.Drawing.Point(128, 66);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(56, 17);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Código:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(128, 110);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(49, 17);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(128, 152);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(51, 17);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "E-mail:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(183, 66);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 22);
            this.txtCodigo.TabIndex = 3;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(183, 107);
            this.txtNome.MaxLength = 60;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(291, 22);
            this.txtNome.TabIndex = 4;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(183, 149);
            this.txtEmail.MaxLength = 100;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(291, 22);
            this.txtEmail.TabIndex = 5;
            // 
            // rbtnMasculino
            // 
            this.rbtnMasculino.AutoSize = true;
            this.rbtnMasculino.Checked = true;
            this.rbtnMasculino.Location = new System.Drawing.Point(183, 194);
            this.rbtnMasculino.Name = "rbtnMasculino";
            this.rbtnMasculino.Size = new System.Drawing.Size(92, 21);
            this.rbtnMasculino.TabIndex = 6;
            this.rbtnMasculino.TabStop = true;
            this.rbtnMasculino.Text = "Masculino";
            this.rbtnMasculino.UseVisualStyleBackColor = true;
            // 
            // rbtnFeminino
            // 
            this.rbtnFeminino.AutoSize = true;
            this.rbtnFeminino.Location = new System.Drawing.Point(364, 194);
            this.rbtnFeminino.Name = "rbtnFeminino";
            this.rbtnFeminino.Size = new System.Drawing.Size(86, 21);
            this.rbtnFeminino.TabIndex = 7;
            this.rbtnFeminino.Text = "Feminino";
            this.rbtnFeminino.UseVisualStyleBackColor = true;
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Location = new System.Drawing.Point(128, 196);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(43, 17);
            this.lblSexo.TabIndex = 8;
            this.lblSexo.Text = "Sexo:";
            // 
            // lblEstadoCivil
            // 
            this.lblEstadoCivil.AutoSize = true;
            this.lblEstadoCivil.Location = new System.Drawing.Point(86, 234);
            this.lblEstadoCivil.Name = "lblEstadoCivil";
            this.lblEstadoCivil.Size = new System.Drawing.Size(85, 17);
            this.lblEstadoCivil.TabIndex = 9;
            this.lblEstadoCivil.Text = "Estado Civil:";
            // 
            // cbEstadosCivis
            // 
            this.cbEstadosCivis.FormattingEnabled = true;
            this.cbEstadosCivis.Items.AddRange(new object[] {
            "Solteiro",
            "Casado",
            "Divorciado"});
            this.cbEstadosCivis.Location = new System.Drawing.Point(183, 231);
            this.cbEstadosCivis.Name = "cbEstadosCivis";
            this.cbEstadosCivis.Size = new System.Drawing.Size(267, 24);
            this.cbEstadosCivis.TabIndex = 10;
            // 
            // chkRecebeEmail
            // 
            this.chkRecebeEmail.AutoSize = true;
            this.chkRecebeEmail.Location = new System.Drawing.Point(183, 275);
            this.chkRecebeEmail.Name = "chkRecebeEmail";
            this.chkRecebeEmail.Size = new System.Drawing.Size(122, 21);
            this.chkRecebeEmail.TabIndex = 11;
            this.chkRecebeEmail.Text = "Recebe E-mail";
            this.chkRecebeEmail.UseVisualStyleBackColor = true;
            // 
            // chkRecebeSMS
            // 
            this.chkRecebeSMS.AutoSize = true;
            this.chkRecebeSMS.Location = new System.Drawing.Point(352, 275);
            this.chkRecebeSMS.Name = "chkRecebeSMS";
            this.chkRecebeSMS.Size = new System.Drawing.Size(112, 21);
            this.chkRecebeSMS.TabIndex = 12;
            this.chkRecebeSMS.Text = "Recebe SMS";
            this.chkRecebeSMS.UseVisualStyleBackColor = true;
            // 
            // btnInserir
            // 
            this.btnInserir.Location = new System.Drawing.Point(256, 327);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(122, 32);
            this.btnInserir.TabIndex = 13;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // frmCadastroPessoas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.chkRecebeSMS);
            this.Controls.Add(this.chkRecebeEmail);
            this.Controls.Add(this.cbEstadosCivis);
            this.Controls.Add(this.lblEstadoCivil);
            this.Controls.Add(this.lblSexo);
            this.Controls.Add(this.rbtnFeminino);
            this.Controls.Add(this.rbtnMasculino);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblCodigo);
            this.Name = "frmCadastroPessoas";
            this.Text = "Cadastro de Pessoas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.RadioButton rbtnMasculino;
        private System.Windows.Forms.RadioButton rbtnFeminino;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.Label lblEstadoCivil;
        private System.Windows.Forms.ComboBox cbEstadosCivis;
        private System.Windows.Forms.CheckBox chkRecebeEmail;
        private System.Windows.Forms.CheckBox chkRecebeSMS;
        private System.Windows.Forms.Button btnInserir;
    }
}