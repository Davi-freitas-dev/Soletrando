namespace soletrando
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
            resposta = new TextBox();
            button3 = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            pictureBox2 = new PictureBox();
            button2 = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            listBox1 = new ListBox();
            tableLayoutPanel4 = new TableLayoutPanel();
            label3 = new Label();
            button1 = new Button();
            tableLayoutPanel3 = new TableLayoutPanel();
            p1 = new Label();
            lblVez = new Label();
            lblPontos2 = new Label();
            jogador2 = new Label();
            lblPontos1 = new Label();
            p2 = new Label();
            jogador1 = new Label();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // resposta
            // 
            resposta.Anchor = AnchorStyles.Right;
            resposta.Location = new Point(172, 3);
            resposta.Name = "resposta";
            resposta.Size = new Size(183, 23);
            resposta.TabIndex = 1;
            resposta.TextChanged += textBox1_TextChanged;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.None;
            button3.Location = new Point(361, 3);
            button3.Name = "button3";
            button3.Size = new Size(37, 22);
            button3.TabIndex = 4;
            button3.Text = "ok";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.None;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 55F));
            tableLayoutPanel1.Controls.Add(pictureBox1, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 1);
            tableLayoutPanel1.Location = new Point(0, 80);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 90.8888855F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 9.111111F));
            tableLayoutPanel1.Size = new Size(853, 370);
            tableLayoutPanel1.TabIndex = 5;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 5;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 42.3728828F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5.084746F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5.084746F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5.084746F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 42.3728828F));
            tableLayoutPanel2.Controls.Add(button3, 1, 0);
            tableLayoutPanel2.Controls.Add(pictureBox2, 2, 0);
            tableLayoutPanel2.Controls.Add(button2, 3, 0);
            tableLayoutPanel2.Controls.Add(resposta, 0, 0);
            tableLayoutPanel2.Controls.Add(label1, 4, 0);
            tableLayoutPanel2.Dock = DockStyle.Bottom;
            tableLayoutPanel2.Location = new Point(3, 339);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(847, 28);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.None;
            pictureBox2.Image = Properties.Resources.som;
            pictureBox2.Location = new Point(404, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(37, 22);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Left;
            button2.Location = new Point(447, 3);
            button2.Name = "button2";
            button2.Size = new Size(37, 22);
            button2.TabIndex = 7;
            button2.Text = "NEXT";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(490, 3);
            label1.Name = "label1";
            label1.Size = new Size(19, 21);
            label1.TabIndex = 8;
            label1.Text = "0";
            label1.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(847, 330);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // listBox1
            // 
            listBox1.BackColor = SystemColors.Control;
            listBox1.BorderStyle = BorderStyle.None;
            listBox1.Dock = DockStyle.Fill;
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(3, 134);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(138, 313);
            listBox1.TabIndex = 0;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.BackColor = Color.Transparent;
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Controls.Add(listBox1, 0, 3);
            tableLayoutPanel4.Controls.Add(label3, 0, 2);
            tableLayoutPanel4.Controls.Add(button1, 0, 1);
            tableLayoutPanel4.Dock = DockStyle.Right;
            tableLayoutPanel4.Location = new Point(709, 0);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 4;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 18.4444447F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 6.66666651F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 4F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 70.8888855F));
            tableLayoutPanel4.Size = new Size(144, 450);
            tableLayoutPanel4.TabIndex = 7;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.ForeColor = Color.OrangeRed;
            label3.Location = new Point(3, 113);
            label3.Name = "label3";
            label3.Size = new Size(54, 18);
            label3.TabIndex = 1;
            label3.Text = "Erros:";
            label3.TextAlign = ContentAlignment.BottomLeft;
            label3.Click += label3_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button1.Location = new Point(3, 88);
            button1.Name = "button1";
            button1.Size = new Size(46, 22);
            button1.TabIndex = 2;
            button1.Text = "VER";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 6;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 13F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 13F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.Controls.Add(p1, 0, 1);
            tableLayoutPanel3.Controls.Add(lblVez, 0, 0);
            tableLayoutPanel3.Controls.Add(lblPontos2, 5, 0);
            tableLayoutPanel3.Controls.Add(jogador2, 4, 0);
            tableLayoutPanel3.Controls.Add(lblPontos1, 3, 0);
            tableLayoutPanel3.Controls.Add(p2, 1, 0);
            tableLayoutPanel3.Controls.Add(jogador1, 2, 0);
            tableLayoutPanel3.Location = new Point(0, 2);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Size = new Size(853, 80);
            tableLayoutPanel3.TabIndex = 8;
            tableLayoutPanel3.Paint += tableLayoutPanel3_Paint;
            // 
            // p1
            // 
            p1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            p1.AutoSize = true;
            p1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            p1.Location = new Point(3, 60);
            p1.Name = "p1";
            p1.Size = new Size(0, 20);
            p1.TabIndex = 3;
            p1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblVez
            // 
            lblVez.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            lblVez.AutoSize = true;
            lblVez.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblVez.Location = new Point(169, 0);
            lblVez.Name = "lblVez";
            lblVez.Size = new Size(41, 60);
            lblVez.TabIndex = 6;
            lblVez.Text = "vez";
            lblVez.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblPontos2
            // 
            lblPontos2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lblPontos2.AutoSize = true;
            lblPontos2.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblPontos2.Location = new Point(640, 0);
            lblPontos2.Name = "lblPontos2";
            lblPontos2.Size = new Size(23, 60);
            lblPontos2.TabIndex = 5;
            lblPontos2.Text = "0";
            lblPontos2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // jogador2
            // 
            jogador2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            jogador2.AutoSize = true;
            jogador2.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            jogador2.Location = new Point(540, 0);
            jogador2.Name = "jogador2";
            jogador2.Size = new Size(94, 60);
            jogador2.TabIndex = 1;
            jogador2.Text = "jogador2";
            jogador2.TextAlign = ContentAlignment.MiddleLeft;
            jogador2.Click += jogador2_Click;
            // 
            // lblPontos1
            // 
            lblPontos1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lblPontos1.AutoSize = true;
            lblPontos1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblPontos1.Location = new Point(428, 0);
            lblPontos1.Name = "lblPontos1";
            lblPontos1.Size = new Size(23, 60);
            lblPontos1.TabIndex = 4;
            lblPontos1.Text = "0";
            lblPontos1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // p2
            // 
            p2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            p2.AutoSize = true;
            p2.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            p2.Location = new Point(320, 0);
            p2.Name = "p2";
            p2.Size = new Size(0, 60);
            p2.TabIndex = 2;
            p2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // jogador1
            // 
            jogador1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            jogador1.AutoSize = true;
            jogador1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            jogador1.Location = new Point(328, 0);
            jogador1.Name = "jogador1";
            jogador1.Size = new Size(94, 60);
            jogador1.TabIndex = 0;
            jogador1.Text = "jogador1";
            jogador1.TextAlign = ContentAlignment.MiddleRight;
            jogador1.Click += label2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(853, 450);
            Controls.Add(tableLayoutPanel3);
            Controls.Add(tableLayoutPanel4);
            Controls.Add(tableLayoutPanel1);
            Name = "Form1";
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TextBox resposta;
        private Button button3;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private PictureBox pictureBox2;
        private Button button2;
        private PictureBox pictureBox1;
        private ListBox listBox1;
        private TableLayoutPanel tableLayoutPanel4;
        private Label label3;
        private Button button1;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel3;
        private Label jogador1;
        private Label jogador2;
        private Label p2;
        private Label p1;
        private Label lblPontos1;
        private Label lblPontos2;
        private Label lblVez;
    }
}
