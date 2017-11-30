namespace GrayscaleConverting
{
	partial class Form1
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Выберите изображение";
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(201, 57);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(279, 24);
            this.button1.TabIndex = 2;
            this.button1.Text = "Обработать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 131);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(336, 282);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(354, 131);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(343, 282);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(112, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Исходное изображение";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(445, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Обработанное изображение";
            this.label3.Visible = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(485, 11);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(147, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Открыть";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(12, 463);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(336, 291);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Visible = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Location = new System.Drawing.Point(354, 463);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(343, 289);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 11;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(423, 435);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(201, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Разность обработанных изображений";
            this.label4.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(66, 435);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(207, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Обработанное изображение (c весами)";
            this.label5.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox1.Location = new System.Drawing.Point(237, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(218, 20);
            this.textBox1.TabIndex = 14;
            this.textBox1.TabStop = false;
            this.textBox1.Text = "<не выбрано>";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(253, 779);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(154, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Гистограмма интенсивности";
            this.label6.Visible = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Location = new System.Drawing.Point(76, 818);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(512, 200);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 16;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Visible = false;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Enabled = false;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(246, 1043);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(164, 21);
            this.comboBox1.TabIndex = 17;
            this.comboBox1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(732, 805);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.MenuText;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.PictureBox pictureBox4;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.ComboBox comboBox1;
	}
}

