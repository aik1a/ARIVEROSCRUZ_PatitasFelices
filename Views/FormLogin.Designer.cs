namespace RIVEROSCRUZ_PATITASFELICES.Views
{
    partial class FormLogin
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblClave;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Label lblError;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblClave = new System.Windows.Forms.Label();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // lblTitulo
            this.lblTitulo.AutoSize = false;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Location = new System.Drawing.Point(0, 15);
            this.lblTitulo.Size = new System.Drawing.Size(340, 30);
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTitulo.Text = "Patitas Felices";

            // lblUsuario
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(30, 65);
            this.lblUsuario.Text = "Usuario:";

            // txtUsuario
            this.txtUsuario.Location = new System.Drawing.Point(120, 62);
            this.txtUsuario.Size = new System.Drawing.Size(180, 22);

            // lblClave
            this.lblClave.AutoSize = true;
            this.lblClave.Location = new System.Drawing.Point(30, 100);
            this.lblClave.Text = "Contrasena:";

            // txtClave
            this.txtClave.Location = new System.Drawing.Point(120, 97);
            this.txtClave.Size = new System.Drawing.Size(180, 22);
            this.txtClave.PasswordChar = '*';

            // btnIngresar
            this.btnIngresar.Location = new System.Drawing.Point(120, 135);
            this.btnIngresar.Size = new System.Drawing.Size(100, 28);
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);

            // lblError
            this.lblError.AutoSize = false;
            this.lblError.Location = new System.Drawing.Point(20, 175);
            this.lblError.Size = new System.Drawing.Size(300, 20);
            this.lblError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Visible = false;
            this.lblError.Text = "";

            // FormLogin
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 220);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.lblClave);
            this.Controls.Add(this.txtClave);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.lblError);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Patitas Felices - Iniciar Sesion";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
