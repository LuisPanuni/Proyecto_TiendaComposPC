﻿namespace Tienda_de_Componenetes_de_PC
{
    partial class PrecioCompos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrecioCompos));
            label1 = new Label();
            pictureBox2 = new PictureBox();
            dateTimePicker1 = new DateTimePicker();
            label5 = new Label();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            textBox4 = new TextBox();
            label7 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(245, 31);
            label1.Name = "label1";
            label1.Size = new Size(192, 25);
            label1.TabIndex = 12;
            label1.Text = "TechTonic Oruro";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(595, 21);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(100, 89);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 29;
            pictureBox2.TabStop = false;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(95, 117);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(211, 23);
            dateTimePicker1.TabIndex = 37;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(14, 117);
            label5.Name = "label5";
            label5.Size = new Size(50, 20);
            label5.TabIndex = 36;
            label5.Text = "Fecha:";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(457, 76);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 35;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(304, 76);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(92, 23);
            textBox2.TabIndex = 34;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(95, 76);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(127, 23);
            textBox1.TabIndex = 33;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(402, 77);
            label4.Name = "label4";
            label4.Size = new Size(58, 20);
            label4.TabIndex = 32;
            label4.Text = "Celular:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(228, 77);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 31;
            label3.Text = "Telefono:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(14, 76);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 30;
            label2.Text = "Direccion:";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(14, 165);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(703, 197);
            dataGridView1.TabIndex = 38;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(141, 386);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(157, 23);
            textBox4.TabIndex = 40;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(19, 385);
            label7.Name = "label7";
            label7.Size = new Size(116, 20);
            label7.TabIndex = 39;
            label7.Text = "Total Ganancias:";
            // 
            // button1
            // 
            button1.Location = new Point(627, 429);
            button1.Name = "button1";
            button1.Size = new Size(90, 29);
            button1.TabIndex = 41;
            button1.Text = "Pedir";
            button1.UseVisualStyleBackColor = true;
            // 
            // PrecioCompos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(729, 470);
            Controls.Add(button1);
            Controls.Add(textBox4);
            Controls.Add(label7);
            Controls.Add(dataGridView1);
            Controls.Add(dateTimePicker1);
            Controls.Add(label5);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pictureBox2);
            Controls.Add(label1);
            Name = "PrecioCompos";
            Text = "PrecioCompos";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox2;
        private DateTimePicker dateTimePicker1;
        private Label label5;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label4;
        private Label label3;
        private Label label2;
        private DataGridView dataGridView1;
        private TextBox textBox4;
        private Label label7;
        private Button button1;
    }
}