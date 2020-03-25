namespace WindowsFormsApp1
{
    partial class Login
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
            this.txtusuario = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtsenha = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnlogin = new MaterialSkin.Controls.MaterialRaisedButton();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtusuario
            // 
            this.txtusuario.Depth = 0;
            this.txtusuario.Hint = "";
            this.txtusuario.Location = new System.Drawing.Point(432, 238);
            this.txtusuario.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.PasswordChar = '\0';
            this.txtusuario.SelectedText = "";
            this.txtusuario.SelectionLength = 0;
            this.txtusuario.SelectionStart = 0;
            this.txtusuario.Size = new System.Drawing.Size(175, 23);
            this.txtusuario.TabIndex = 4;
            this.txtusuario.Text = "Usuário";
            this.txtusuario.UseSystemPasswordChar = false;
            // 
            // txtsenha
            // 
            this.txtsenha.Depth = 0;
            this.txtsenha.Hint = "";
            this.txtsenha.Location = new System.Drawing.Point(432, 294);
            this.txtsenha.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtsenha.Name = "txtsenha";
            this.txtsenha.PasswordChar = '\0';
            this.txtsenha.SelectedText = "";
            this.txtsenha.SelectionLength = 0;
            this.txtsenha.SelectionStart = 0;
            this.txtsenha.Size = new System.Drawing.Size(175, 23);
            this.txtsenha.TabIndex = 5;
            this.txtsenha.Text = "Senha";
            this.txtsenha.UseSystemPasswordChar = false;
            // 
            // btnlogin
            // 
            this.btnlogin.Depth = 0;
            this.btnlogin.Location = new System.Drawing.Point(457, 359);
            this.btnlogin.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Primary = true;
            this.btnlogin.Size = new System.Drawing.Size(117, 23);
            this.btnlogin.TabIndex = 6;
            this.btnlogin.Text = "Entrar";
            this.btnlogin.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(156)))), ((int)(((byte)(86)))));
            this.label1.Location = new System.Drawing.Point(473, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 32);
            this.label1.TabIndex = 7;
            this.label1.Text = "LOGIN";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 585);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(this.txtsenha);
            this.Controls.Add(this.txtusuario);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LOGIN;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtusuario;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtsenha;
        private MaterialSkin.Controls.MaterialRaisedButton btnlogin;
        private System.Windows.Forms.Label label1;
    }
}

