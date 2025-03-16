namespace StockManagementApp
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
        private ComboBox comboBoxProducts;
        private Button btnDelete;
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            txtProductName = new TextBox();
            nudQuantity = new NumericUpDown();
            label1 = new Label();
            label2 = new Label();
            btnAdd = new Button();
            btnReduce = new Button();
            comboBoxProducts = new ComboBox();
            label3 = new Label();
            btnDelete = new Button();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudQuantity).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(21, 179);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(748, 152);
            dataGridView1.TabIndex = 0;
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(154, 49);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(125, 27);
            txtProductName.TabIndex = 1;
            // 
            // nudQuantity
            // 
            nudQuantity.Location = new Point(154, 97);
            nudQuantity.Name = "nudQuantity";
            nudQuantity.Size = new Size(125, 27);
            nudQuantity.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(67, 49);
            label1.Name = "label1";
            label1.Size = new Size(81, 25);
            label1.TabIndex = 3;
            label1.Text = "ชื่อสินค้า :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(41, 95);
            label2.Name = "label2";
            label2.Size = new Size(107, 25);
            label2.TabIndex = 4;
            label2.Text = "จำนวนสินค้า :";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(298, 49);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(76, 29);
            btnAdd.TabIndex = 5;
            btnAdd.Text = "เพิ่มสินค้า";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnReduce
            // 
            btnReduce.Location = new Point(298, 97);
            btnReduce.Name = "btnReduce";
            btnReduce.Size = new Size(76, 29);
            btnReduce.TabIndex = 6;
            btnReduce.Text = "ลดสินค้า";
            btnReduce.UseVisualStyleBackColor = true;
            btnReduce.Click += btnReduce_Click;
            // 
            // comboBoxProducts
            // 
            comboBoxProducts.Location = new Point(169, 350);
            comboBoxProducts.Name = "comboBoxProducts";
            comboBoxProducts.Size = new Size(167, 28);
            comboBoxProducts.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(21, 353);
            label3.Name = "label3";
            label3.Size = new Size(142, 25);
            label3.TabIndex = 8;
            label3.Text = "เลือกสินค้าเพื่อลบ :";
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(358, 349);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(100, 29);
            btnDelete.TabIndex = 8;
            btnDelete.Text = "ลบสินค้า";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(21, 153);
            label4.Name = "label4";
            label4.Size = new Size(139, 23);
            label4.TabIndex = 9;
            label4.Text = "ตารางแสดงสินค้า";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(67, 9);
            label5.Name = "label5";
            label5.Size = new Size(274, 23);
            label5.TabIndex = 10;
            label5.Text = "ใส่ชื่อสินค้าและจำนวนเพื่อเพิ่มสินค้า";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(154, 153);
            label6.Name = "label6";
            label6.Size = new Size(588, 23);
            label6.TabIndex = 11;
            label6.Text = "(ถ้าจะลดจำนวนให้เลือกสินค้าที่ตารางแล้วใส่จำนวที่จำนวนสินค้ากดปุ่มลดสินค้า)";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(btnDelete);
            Controls.Add(label3);
            Controls.Add(comboBoxProducts);
            Controls.Add(btnReduce);
            Controls.Add(btnAdd);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(nudQuantity);
            Controls.Add(txtProductName);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudQuantity).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox txtProductName;
        private NumericUpDown nudQuantity;
        private Label label1;
        private Label label2;
        private Button btnAdd;
        private Button btnReduce;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}
