namespace MSiSViT_1
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
            richTextBox1 = new RichTextBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            Label_Volume = new Label();
            Label_Length = new Label();
            Label_Dictionary = new Label();
            tableLayoutPanel3 = new TableLayoutPanel();
            dataGridView2 = new DataGridView();
            Column_i = new DataGridViewTextBoxColumn();
            Column_Operand = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            Button_Parse = new Button();
            dataGridView1 = new DataGridView();
            Column_J = new DataGridViewTextBoxColumn();
            Column_Operator = new DataGridViewTextBoxColumn();
            Column_f1j = new DataGridViewTextBoxColumn();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Anchor = AnchorStyles.Top;
            richTextBox1.Location = new Point(3, 3);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(768, 371);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(richTextBox1, 1, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 2, 0);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(1008, 377);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(Label_Volume, 0, 2);
            tableLayoutPanel2.Controls.Add(Label_Length, 0, 1);
            tableLayoutPanel2.Controls.Add(Label_Dictionary, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(777, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.Size = new Size(228, 371);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // Label_Volume
            // 
            Label_Volume.Anchor = AnchorStyles.Left;
            Label_Volume.AutoSize = true;
            Label_Volume.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Label_Volume.Location = new Point(3, 301);
            Label_Volume.Name = "Label_Volume";
            Label_Volume.Size = new Size(16, 15);
            Label_Volume.TabIndex = 4;
            Label_Volume.Text = "...";
            // 
            // Label_Length
            // 
            Label_Length.Anchor = AnchorStyles.Left;
            Label_Length.AutoSize = true;
            Label_Length.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Label_Length.Location = new Point(3, 177);
            Label_Length.Name = "Label_Length";
            Label_Length.Size = new Size(16, 15);
            Label_Length.TabIndex = 3;
            Label_Length.Text = "...";
            // 
            // Label_Dictionary
            // 
            Label_Dictionary.Anchor = AnchorStyles.Left;
            Label_Dictionary.AutoSize = true;
            Label_Dictionary.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Label_Dictionary.Location = new Point(3, 54);
            Label_Dictionary.Name = "Label_Dictionary";
            Label_Dictionary.Size = new Size(16, 15);
            Label_Dictionary.TabIndex = 0;
            Label_Dictionary.Text = "...";
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(dataGridView2, 1, 0);
            tableLayoutPanel3.Controls.Add(Button_Parse, 0, 1);
            tableLayoutPanel3.Controls.Add(dataGridView1, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Bottom;
            tableLayoutPanel3.Location = new Point(0, 380);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 64F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Size = new Size(1008, 395);
            tableLayoutPanel3.TabIndex = 1;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { Column_i, Column_Operand, dataGridViewTextBoxColumn3 });
            dataGridView2.Dock = DockStyle.Fill;
            dataGridView2.Location = new Point(507, 3);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(498, 325);
            dataGridView2.TabIndex = 4;
            // 
            // Column_i
            // 
            Column_i.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column_i.HeaderText = "i";
            Column_i.Name = "Column_i";
            // 
            // Column_Operand
            // 
            Column_Operand.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column_Operand.HeaderText = "Операнд";
            Column_Operand.Name = "Column_Operand";
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn3.HeaderText = "f_2_i";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // Button_Parse
            // 
            Button_Parse.BackColor = Color.FromArgb(0, 192, 0);
            tableLayoutPanel3.SetColumnSpan(Button_Parse, 2);
            Button_Parse.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Button_Parse.ForeColor = SystemColors.ControlText;
            Button_Parse.Location = new Point(3, 334);
            Button_Parse.Name = "Button_Parse";
            Button_Parse.Size = new Size(1002, 58);
            Button_Parse.TabIndex = 2;
            Button_Parse.Text = "Parse";
            Button_Parse.UseVisualStyleBackColor = false;
            Button_Parse.Click += Button_Parse_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column_J, Column_Operator, Column_f1j });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(498, 325);
            dataGridView1.TabIndex = 3;
            // 
            // Column_J
            // 
            Column_J.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column_J.HeaderText = "j";
            Column_J.Name = "Column_J";
            // 
            // Column_Operator
            // 
            Column_Operator.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column_Operator.HeaderText = "Оператор";
            Column_Operator.Name = "Column_Operator";
            // 
            // Column_f1j
            // 
            Column_f1j.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column_f1j.HeaderText = "f_1_j";
            Column_f1j.Name = "Column_f1j";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1008, 775);
            Controls.Add(tableLayoutPanel3);
            Controls.Add(tableLayoutPanel1);
            Name = "Form1";
            Text = "Parser";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox richTextBox1;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Label Label_Volume;
        private Label Label_Length;
        private Label Label_Dictionary;
        private TableLayoutPanel tableLayoutPanel3;
        private Button Button_Parse;
        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn Column_i;
        private DataGridViewTextBoxColumn Column_Operand;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn Column_J;
        private DataGridViewTextBoxColumn Column_Operator;
        private DataGridViewTextBoxColumn Column_f1j;
    }
}
