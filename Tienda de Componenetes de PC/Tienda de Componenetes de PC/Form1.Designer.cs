namespace Tienda_de_Componenetes_de_PC
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            btn_ingresar = new Button();
            textBox1 = new TextBox();
            txt_usuario = new TextBox();
            txt_contrasena = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(56, 203);
            label1.Name = "label1";
            label1.Size = new Size(68, 21);
            label1.TabIndex = 0;
            label1.Text = "Cuenta:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(56, 252);
            label2.Name = "label2";
            label2.Size = new Size(86, 21);
            label2.TabIndex = 1;
            label2.Text = "Password:";
            // 
            // btn_ingresar
            // 
            btn_ingresar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_ingresar.Location = new Point(151, 357);
            btn_ingresar.Name = "btn_ingresar";
            btn_ingresar.Size = new Size(102, 32);
            btn_ingresar.TabIndex = 2;
            btn_ingresar.Text = "INGRESAR";
            btn_ingresar.UseVisualStyleBackColor = true;
            btn_ingresar.Click += btn_ingresar_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(275, 827);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(211, 23);
            textBox1.TabIndex = 3;
            // 
            // txt_usuario
            // 
            txt_usuario.Location = new Point(130, 226);
            txt_usuario.Name = "txt_usuario";
            txt_usuario.Size = new Size(178, 23);
            txt_usuario.TabIndex = 4;
            // 
            // txt_contrasena
            // 
            txt_contrasena.Location = new Point(130, 276);
            txt_contrasena.Name = "txt_contrasena";
            txt_contrasena.PasswordChar = '*';
            txt_contrasena.Size = new Size(178, 23);
            txt_contrasena.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(381, 422);
            Controls.Add(txt_contrasena);
            Controls.Add(txt_usuario);
            Controls.Add(textBox1);
            Controls.Add(btn_ingresar);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Seguridad del Sistema";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button btn_ingresar;
        private TextBox textBox1;
        private TextBox txt_usuario;
        private TextBox txt_contrasena;
    }
}