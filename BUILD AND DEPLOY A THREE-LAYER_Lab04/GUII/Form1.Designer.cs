namespace GUII
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
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Location = new Point(11, 228);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(623, 308);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBox3);
            groupBox2.Controls.Add(textBox2);
            groupBox2.Controls.Add(textBox1);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.Location = new Point(11, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(623, 193);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Student Information";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(28, 42);
            label1.Name = "label1";
            label1.Size = new Size(102, 23);
            label1.TabIndex = 0;
            label1.Text = "Student ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(28, 92);
            label2.Name = "label2";
            label2.Size = new Size(88, 23);
            label2.TabIndex = 1;
            label2.Text = "FullName";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(28, 146);
            label3.Name = "label3";
            label3.Size = new Size(77, 23);
            label3.TabIndex = 2;
            label3.Text = "Class ID";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Tahoma", 11F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(157, 39);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(373, 30);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Tahoma", 11F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(157, 89);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(373, 30);
            textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Tahoma", 11F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.Location = new Point(157, 143);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(373, 30);
            textBox3.TabIndex = 5;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 23);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(617, 282);
            dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(741, 27);
            button1.Name = "button1";
            button1.Size = new Size(143, 54);
            button1.TabIndex = 1;
            button1.Text = "Insert";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(741, 109);
            button2.Name = "button2";
            button2.Size = new Size(143, 53);
            button2.TabIndex = 3;
            button2.Text = "Update";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(741, 188);
            button3.Name = "button3";
            button3.Size = new Size(143, 51);
            button3.TabIndex = 4;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(899, 548);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private DataGridView dataGridView1;
        private GroupBox groupBox2;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}