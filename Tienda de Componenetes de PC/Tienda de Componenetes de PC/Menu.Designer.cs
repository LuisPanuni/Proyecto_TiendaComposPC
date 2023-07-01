namespace Tienda_de_Componenetes_de_PC
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(62, 142);
            button1.Name = "button1";
            button1.Size = new Size(145, 35);
            button1.TabIndex = 0;
            button1.Text = "Buscar Componente";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(399, 142);
            button2.Name = "button2";
            button2.Size = new Size(211, 35);
            button2.TabIndex = 1;
            button2.Text = "Reportes Componentes Defectuosos";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(49, 371);
            button3.Name = "button3";
            button3.Size = new Size(211, 35);
            button3.TabIndex = 2;
            button3.Text = "Ventas en Determinado Tiempo";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(399, 371);
            button4.Name = "button4";
            button4.Size = new Size(211, 35);
            button4.TabIndex = 3;
            button4.Text = "Tienda";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(222, 212);
            button5.Name = "button5";
            button5.Size = new Size(211, 35);
            button5.TabIndex = 4;
            button5.Text = "Reportes de Ventas";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(222, 253);
            button6.Name = "button6";
            button6.Size = new Size(211, 35);
            button6.TabIndex = 5;
            button6.Text = "Administración de Cuentas";
            button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Location = new Point(222, 294);
            button7.Name = "button7";
            button7.Size = new Size(211, 35);
            button7.TabIndex = 6;
            button7.Text = "Registro de Precio de Componentes";
            button7.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(222, 47);
            label1.Name = "label1";
            label1.Size = new Size(192, 25);
            label1.TabIndex = 7;
            label1.Text = "TechTonic Oruro";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(479, 23);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 89);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(632, 450);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Menu";
            Text = "Menu";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Label label1;
        private PictureBox pictureBox1;
    }
}