namespace Practice_7___13._03._24
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.Mass_NoReply = new System.Windows.Forms.TextBox();
            this.VGruz_NoReply = new System.Windows.Forms.TextBox();
            this.Putb_NoReply = new System.Windows.Forms.TextBox();
            this.Putb = new System.Windows.Forms.TextBox();
            this.VGruz = new System.Windows.Forms.TextBox();
            this.Mass = new System.Windows.Forms.TextBox();
            this.Output = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(519, 135);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(269, 108);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Газель",
            "ЗИЛ",
            "МАЗ",
            "Scania",
            "Volvo"});
            this.checkedListBox1.Location = new System.Drawing.Point(519, 12);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(269, 106);
            this.checkedListBox1.TabIndex = 1;
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // Mass_NoReply
            // 
            this.Mass_NoReply.Location = new System.Drawing.Point(12, 36);
            this.Mass_NoReply.Name = "Mass_NoReply";
            this.Mass_NoReply.ReadOnly = true;
            this.Mass_NoReply.Size = new System.Drawing.Size(166, 22);
            this.Mass_NoReply.TabIndex = 2;
            this.Mass_NoReply.Text = "Масса (ton)";
            // 
            // VGruz_NoReply
            // 
            this.VGruz_NoReply.Location = new System.Drawing.Point(12, 64);
            this.VGruz_NoReply.Name = "VGruz_NoReply";
            this.VGruz_NoReply.ReadOnly = true;
            this.VGruz_NoReply.Size = new System.Drawing.Size(166, 22);
            this.VGruz_NoReply.TabIndex = 3;
            this.VGruz_NoReply.Text = "Объем груза (m3)";
            this.VGruz_NoReply.TextChanged += new System.EventHandler(this.VGruz_NoReply_TextChanged);
            // 
            // Putb_NoReply
            // 
            this.Putb_NoReply.Location = new System.Drawing.Point(12, 96);
            this.Putb_NoReply.Name = "Putb_NoReply";
            this.Putb_NoReply.ReadOnly = true;
            this.Putb_NoReply.Size = new System.Drawing.Size(166, 22);
            this.Putb_NoReply.TabIndex = 4;
            this.Putb_NoReply.Text = "Расстояние (km)";
            // 
            // Putb
            // 
            this.Putb.Location = new System.Drawing.Point(184, 96);
            this.Putb.Name = "Putb";
            this.Putb.Size = new System.Drawing.Size(166, 22);
            this.Putb.TabIndex = 7;
            this.Putb.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // VGruz
            // 
            this.VGruz.Location = new System.Drawing.Point(184, 64);
            this.VGruz.Name = "VGruz";
            this.VGruz.Size = new System.Drawing.Size(166, 22);
            this.VGruz.TabIndex = 6;
            this.VGruz.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // Mass
            // 
            this.Mass.Location = new System.Drawing.Point(184, 36);
            this.Mass.Name = "Mass";
            this.Mass.Size = new System.Drawing.Size(166, 22);
            this.Mass.TabIndex = 5;
            this.Mass.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // Output
            // 
            this.Output.Location = new System.Drawing.Point(12, 135);
            this.Output.Multiline = true;
            this.Output.Name = "Output";
            this.Output.ReadOnly = true;
            this.Output.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Output.Size = new System.Drawing.Size(469, 108);
            this.Output.TabIndex = 8;
            this.Output.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(169, 285);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(464, 137);
            this.button1.TabIndex = 9;
            this.button1.Text = "РАССЧИТАТЬ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Output);
            this.Controls.Add(this.Putb);
            this.Controls.Add(this.VGruz);
            this.Controls.Add(this.Mass);
            this.Controls.Add(this.Putb_NoReply);
            this.Controls.Add(this.VGruz_NoReply);
            this.Controls.Add(this.Mass_NoReply);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.TextBox Mass_NoReply;
        private System.Windows.Forms.TextBox VGruz_NoReply;
        private System.Windows.Forms.TextBox Putb_NoReply;
        private System.Windows.Forms.TextBox Putb;
        private System.Windows.Forms.TextBox VGruz;
        private System.Windows.Forms.TextBox Mass;
        private System.Windows.Forms.TextBox Output;
        private System.Windows.Forms.Button button1;
    }
}

