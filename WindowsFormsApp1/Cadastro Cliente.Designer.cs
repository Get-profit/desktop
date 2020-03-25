namespace WindowsFormsApp1
{
    partial class Cadastro_Cliente
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
            this.materialSingleLineTextField5 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialSingleLineTextField4 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblnome = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btncadastrar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.label1 = new System.Windows.Forms.Label();
            this.materialSingleLineTextField2 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.SuspendLayout();
            // 
            // materialSingleLineTextField5
            // 
            this.materialSingleLineTextField5.Depth = 0;
            this.materialSingleLineTextField5.Hint = "";
            this.materialSingleLineTextField5.Location = new System.Drawing.Point(329, 339);
            this.materialSingleLineTextField5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField5.Name = "materialSingleLineTextField5";
            this.materialSingleLineTextField5.PasswordChar = '\0';
            this.materialSingleLineTextField5.SelectedText = "";
            this.materialSingleLineTextField5.SelectionLength = 0;
            this.materialSingleLineTextField5.SelectionStart = 0;
            this.materialSingleLineTextField5.Size = new System.Drawing.Size(247, 23);
            this.materialSingleLineTextField5.TabIndex = 13;
            this.materialSingleLineTextField5.Text = "Telefone";
            this.materialSingleLineTextField5.UseSystemPasswordChar = false;
            // 
            // materialSingleLineTextField4
            // 
            this.materialSingleLineTextField4.Depth = 0;
            this.materialSingleLineTextField4.Hint = "";
            this.materialSingleLineTextField4.Location = new System.Drawing.Point(329, 219);
            this.materialSingleLineTextField4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField4.Name = "materialSingleLineTextField4";
            this.materialSingleLineTextField4.PasswordChar = '\0';
            this.materialSingleLineTextField4.SelectedText = "";
            this.materialSingleLineTextField4.SelectionLength = 0;
            this.materialSingleLineTextField4.SelectionStart = 0;
            this.materialSingleLineTextField4.Size = new System.Drawing.Size(247, 23);
            this.materialSingleLineTextField4.TabIndex = 12;
            this.materialSingleLineTextField4.Text = "E-mail";
            this.materialSingleLineTextField4.UseSystemPasswordChar = false;
            // 
            // lblnome
            // 
            this.lblnome.Depth = 0;
            this.lblnome.Hint = "";
            this.lblnome.Location = new System.Drawing.Point(329, 162);
            this.lblnome.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblnome.Name = "lblnome";
            this.lblnome.PasswordChar = '\0';
            this.lblnome.SelectedText = "";
            this.lblnome.SelectionLength = 0;
            this.lblnome.SelectionStart = 0;
            this.lblnome.Size = new System.Drawing.Size(247, 23);
            this.lblnome.TabIndex = 9;
            this.lblnome.Text = "Nome";
            this.lblnome.UseSystemPasswordChar = false;
            // 
            // btncadastrar
            // 
            this.btncadastrar.Depth = 0;
            this.btncadastrar.Location = new System.Drawing.Point(375, 416);
            this.btncadastrar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btncadastrar.Name = "btncadastrar";
            this.btncadastrar.Primary = true;
            this.btncadastrar.Size = new System.Drawing.Size(162, 28);
            this.btncadastrar.TabIndex = 8;
            this.btncadastrar.Text = "Cadastrar";
            this.btncadastrar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(156)))), ((int)(((byte)(86)))));
            this.label1.Location = new System.Drawing.Point(303, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(328, 38);
            this.label1.TabIndex = 7;
            this.label1.Text = "Cadastro de Cliente";
            // 
            // materialSingleLineTextField2
            // 
            this.materialSingleLineTextField2.Depth = 0;
            this.materialSingleLineTextField2.Hint = "";
            this.materialSingleLineTextField2.Location = new System.Drawing.Point(329, 277);
            this.materialSingleLineTextField2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField2.Name = "materialSingleLineTextField2";
            this.materialSingleLineTextField2.PasswordChar = '\0';
            this.materialSingleLineTextField2.SelectedText = "";
            this.materialSingleLineTextField2.SelectionLength = 0;
            this.materialSingleLineTextField2.SelectionStart = 0;
            this.materialSingleLineTextField2.Size = new System.Drawing.Size(247, 23);
            this.materialSingleLineTextField2.TabIndex = 10;
            this.materialSingleLineTextField2.Text = "CPF";
            this.materialSingleLineTextField2.UseSystemPasswordChar = false;
            // 
            // Cadastro_Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 572);
            this.Controls.Add(this.materialSingleLineTextField5);
            this.Controls.Add(this.materialSingleLineTextField4);
            this.Controls.Add(this.materialSingleLineTextField2);
            this.Controls.Add(this.lblnome);
            this.Controls.Add(this.btncadastrar);
            this.Controls.Add(this.label1);
            this.Name = "Cadastro_Cliente";
            this.Text = "Cadastro_Cliente";
            this.Load += new System.EventHandler(this.Cadastro_Cliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField5;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField4;
        private MaterialSkin.Controls.MaterialSingleLineTextField lblnome;
        private MaterialSkin.Controls.MaterialRaisedButton btncadastrar;
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField2;
    }
}