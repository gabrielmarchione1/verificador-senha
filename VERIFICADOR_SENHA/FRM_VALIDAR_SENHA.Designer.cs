namespace VERIFICADOR_SENHA
{
    partial class FRM_VALIDAR_SENHA
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
            TXT_SENHA = new TextBox();
            BTN_RESET = new Button();
            BTN_VALIDAR = new Button();
            LBL_RESULTADO = new Label();
            SuspendLayout();
            // 
            // TXT_SENHA
            // 
            TXT_SENHA.Location = new Point(12, 12);
            TXT_SENHA.Name = "TXT_SENHA";
            TXT_SENHA.PasswordChar = '*';
            TXT_SENHA.Size = new Size(191, 23);
            TXT_SENHA.TabIndex = 0;
            TXT_SENHA.KeyDown += TXT_SENHA_KeyDown;
            // 
            // BTN_RESET
            // 
            BTN_RESET.Location = new Point(259, 12);
            BTN_RESET.Name = "BTN_RESET";
            BTN_RESET.Size = new Size(102, 23);
            BTN_RESET.TabIndex = 1;
            BTN_RESET.Text = "Limpar";
            BTN_RESET.UseVisualStyleBackColor = true;
            BTN_RESET.Click += BTN_RESET_Click;
            // 
            // BTN_VALIDAR
            // 
            BTN_VALIDAR.Location = new Point(259, 59);
            BTN_VALIDAR.Name = "BTN_VALIDAR";
            BTN_VALIDAR.Size = new Size(102, 23);
            BTN_VALIDAR.TabIndex = 2;
            BTN_VALIDAR.Text = "Ver Senha";
            BTN_VALIDAR.UseVisualStyleBackColor = true;
            BTN_VALIDAR.Click += BTN_VALIDAR_Click;
            // 
            // LBL_RESULTADO
            // 
            LBL_RESULTADO.AutoSize = true;
            LBL_RESULTADO.Font = new Font("Arial", 14.25F, FontStyle.Bold);
            LBL_RESULTADO.Location = new Point(22, 67);
            LBL_RESULTADO.Name = "LBL_RESULTADO";
            LBL_RESULTADO.Size = new Size(0, 22);
            LBL_RESULTADO.TabIndex = 3;
            // 
            // FRM_VALIDAR_SENHA
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(394, 127);
            Controls.Add(LBL_RESULTADO);
            Controls.Add(BTN_VALIDAR);
            Controls.Add(BTN_RESET);
            Controls.Add(TXT_SENHA);
            Name = "FRM_VALIDAR_SENHA";
            Text = "Verificar Senha";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TXT_SENHA;
        private Button BTN_RESET;
        private Button BTN_VALIDAR;
        private Label LBL_RESULTADO;
    }
}