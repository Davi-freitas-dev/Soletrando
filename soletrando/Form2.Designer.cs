namespace soletrando
{
    partial class Form2
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
            panel1 = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            jogador1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            jogador2 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            checkBox1 = new CheckBox();
            checkBox4 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox5 = new CheckBox();
            checkBox6 = new CheckBox();
            checkBox7 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox8 = new CheckBox();
            label1 = new Label();
            button1 = new Button();
            checkBox9 = new CheckBox();
            panel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.soletrando;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(tableLayoutPanel2);
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 456);
            panel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.BackColor = Color.Transparent;
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(jogador1, 0, 0);
            tableLayoutPanel2.Controls.Add(textBox1, 0, 1);
            tableLayoutPanel2.Controls.Add(textBox2, 1, 1);
            tableLayoutPanel2.Controls.Add(jogador2, 1, 0);
            tableLayoutPanel2.Location = new Point(12, 12);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(349, 100);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // jogador1
            // 
            jogador1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            jogador1.AutoSize = true;
            jogador1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            jogador1.Location = new Point(77, 0);
            jogador1.Name = "jogador1";
            jogador1.Size = new Size(94, 50);
            jogador1.TabIndex = 1;
            jogador1.Text = "jogador1";
            jogador1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBox1.Location = new Point(71, 53);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 3;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(177, 53);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 4;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // jogador2
            // 
            jogador2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            jogador2.AutoSize = true;
            jogador2.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            jogador2.Location = new Point(177, 0);
            jogador2.Name = "jogador2";
            jogador2.Size = new Size(94, 50);
            jogador2.TabIndex = 2;
            jogador2.Text = "jogador2";
            jogador2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.BackColor = Color.Transparent;
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 56F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30.125F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 6.125F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 7.75F));
            tableLayoutPanel1.Controls.Add(checkBox1, 0, 1);
            tableLayoutPanel1.Controls.Add(checkBox4, 0, 2);
            tableLayoutPanel1.Controls.Add(checkBox2, 0, 3);
            tableLayoutPanel1.Controls.Add(checkBox5, 0, 4);
            tableLayoutPanel1.Controls.Add(checkBox6, 0, 5);
            tableLayoutPanel1.Controls.Add(checkBox7, 0, 6);
            tableLayoutPanel1.Controls.Add(checkBox3, 0, 7);
            tableLayoutPanel1.Controls.Add(checkBox8, 0, 8);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(button1, 1, 8);
            tableLayoutPanel1.Controls.Add(checkBox9, 1, 1);
            tableLayoutPanel1.Font = new Font("Segoe UI", 9F);
            tableLayoutPanel1.Location = new Point(0, 94);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 9;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 52.55396F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 5.93075275F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 5.93075275F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 5.93075275F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 5.93075275F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 5.93075275F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 5.93075275F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 5.93075275F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 5.93075275F));
            tableLayoutPanel1.Size = new Size(800, 362);
            tableLayoutPanel1.TabIndex = 0;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // checkBox1
            // 
            checkBox1.Anchor = AnchorStyles.Right;
            checkBox1.AutoSize = true;
            checkBox1.BackColor = Color.Transparent;
            checkBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            checkBox1.Location = new Point(298, 193);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(147, 15);
            checkBox1.TabIndex = 1;
            checkBox1.Text = "MAPAS                           ";
            checkBox1.UseVisualStyleBackColor = false;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // checkBox4
            // 
            checkBox4.Anchor = AnchorStyles.Right;
            checkBox4.AutoSize = true;
            checkBox4.BackColor = Color.Transparent;
            checkBox4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            checkBox4.Location = new Point(297, 214);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(148, 15);
            checkBox4.TabIndex = 4;
            checkBox4.Text = "TRANSPORTES             ";
            checkBox4.UseVisualStyleBackColor = false;
            checkBox4.CheckedChanged += checkBox4_CheckedChanged;
            // 
            // checkBox2
            // 
            checkBox2.Anchor = AnchorStyles.Right;
            checkBox2.AutoSize = true;
            checkBox2.BackColor = Color.Transparent;
            checkBox2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            checkBox2.Location = new Point(297, 235);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(148, 15);
            checkBox2.TabIndex = 2;
            checkBox2.Text = "ANIMAIS MARINHOS ";
            checkBox2.UseVisualStyleBackColor = false;
            checkBox2.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // checkBox5
            // 
            checkBox5.Anchor = AnchorStyles.Right;
            checkBox5.AutoSize = true;
            checkBox5.BackColor = Color.Transparent;
            checkBox5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            checkBox5.Location = new Point(296, 256);
            checkBox5.Name = "checkBox5";
            checkBox5.Size = new Size(149, 15);
            checkBox5.TabIndex = 5;
            checkBox5.Text = "FLORES                           ";
            checkBox5.UseVisualStyleBackColor = false;
            checkBox5.CheckedChanged += checkBox5_CheckedChanged;
            // 
            // checkBox6
            // 
            checkBox6.Anchor = AnchorStyles.Right;
            checkBox6.AutoSize = true;
            checkBox6.BackColor = Color.Transparent;
            checkBox6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            checkBox6.Location = new Point(295, 277);
            checkBox6.Name = "checkBox6";
            checkBox6.Size = new Size(150, 15);
            checkBox6.TabIndex = 6;
            checkBox6.Text = "VESTUARIOS                 ";
            checkBox6.UseVisualStyleBackColor = false;
            checkBox6.CheckedChanged += checkBox6_CheckedChanged;
            // 
            // checkBox7
            // 
            checkBox7.Anchor = AnchorStyles.Right;
            checkBox7.AutoSize = true;
            checkBox7.BackColor = Color.Transparent;
            checkBox7.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            checkBox7.Location = new Point(294, 298);
            checkBox7.Name = "checkBox7";
            checkBox7.Size = new Size(151, 15);
            checkBox7.TabIndex = 7;
            checkBox7.Text = "OS OUTROS ANIMAIS ";
            checkBox7.UseVisualStyleBackColor = false;
            checkBox7.CheckedChanged += checkBox7_CheckedChanged;
            // 
            // checkBox3
            // 
            checkBox3.Anchor = AnchorStyles.Right;
            checkBox3.AutoSize = true;
            checkBox3.BackColor = Color.Transparent;
            checkBox3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            checkBox3.Location = new Point(294, 319);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(151, 15);
            checkBox3.TabIndex = 3;
            checkBox3.Text = "OS OUTROS ITENS       ";
            checkBox3.UseVisualStyleBackColor = false;
            checkBox3.CheckedChanged += checkBox3_CheckedChanged;
            // 
            // checkBox8
            // 
            checkBox8.Anchor = AnchorStyles.Right;
            checkBox8.AutoSize = true;
            checkBox8.BackColor = Color.Transparent;
            checkBox8.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            checkBox8.Location = new Point(294, 340);
            checkBox8.Name = "checkBox8";
            checkBox8.Size = new Size(151, 19);
            checkBox8.TabIndex = 8;
            checkBox8.Text = "TODOS                            ";
            checkBox8.UseVisualStyleBackColor = false;
            checkBox8.CheckedChanged += checkBox8_CheckedChanged;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.ForeColor = Color.Chartreuse;
            label1.Location = new Point(290, 175);
            label1.Name = "label1";
            label1.Size = new Size(155, 15);
            label1.TabIndex = 9;
            label1.Text = "Escolha as opões de estudo";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button1.Location = new Point(451, 340);
            button1.Name = "button1";
            button1.Size = new Size(175, 19);
            button1.TabIndex = 10;
            button1.Text = "start";
            button1.TextAlign = ContentAlignment.TopCenter;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // checkBox9
            // 
            checkBox9.Anchor = AnchorStyles.Left;
            checkBox9.AutoSize = true;
            checkBox9.BackColor = Color.Transparent;
            checkBox9.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            checkBox9.Location = new Point(451, 193);
            checkBox9.Name = "checkBox9";
            checkBox9.Size = new Size(130, 15);
            checkBox9.TabIndex = 11;
            checkBox9.Text = "ERROS                      ";
            checkBox9.UseVisualStyleBackColor = false;
            checkBox9.CheckedChanged += checkBox9_CheckedChanged;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(800, 456);
            Controls.Add(panel1);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            panel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel1;
        private CheckBox checkBox1;
        private CheckBox checkBox5;
        private CheckBox checkBox4;
        private CheckBox checkBox3;
        private CheckBox checkBox2;
        private CheckBox checkBox8;
        private CheckBox checkBox6;
        private CheckBox checkBox7;
        private Label label1;
        private Button button1;
        private CheckBox checkBox9;
        private TableLayoutPanel tableLayoutPanel2;
        private Label jogador1;
        private TextBox textBox2;
        private Label jogador2;
        private TextBox textBox1;
    }
}