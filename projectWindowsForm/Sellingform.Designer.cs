
namespace projectWindowsForm
{
    partial class Sellingform
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.openFile_ID = new System.Windows.Forms.Button();
            this.btnSave_Id = new System.Windows.Forms.Button();
            this.btnLocation_ID = new System.Windows.Forms.Button();
            this.textPath_ID = new System.Windows.Forms.TextBox();
            this.sellerName = new System.Windows.Forms.TextBox();
            this.amount = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.PRICETEX = new System.Windows.Forms.TextBox();
            this.QUANTEX = new System.Windows.Forms.TextBox();
            this.Sproname = new System.Windows.Forms.TextBox();
            this.Sbilld = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.amtbl = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Chocolate;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.openFile_ID);
            this.panel1.Controls.Add(this.btnSave_Id);
            this.panel1.Controls.Add(this.btnLocation_ID);
            this.panel1.Controls.Add(this.textPath_ID);
            this.panel1.Controls.Add(this.sellerName);
            this.panel1.Controls.Add(this.amount);
            this.panel1.Controls.Add(this.amtbl);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.dataGridView2);
            this.panel1.Controls.Add(this.PRICETEX);
            this.panel1.Controls.Add(this.QUANTEX);
            this.panel1.Controls.Add(this.Sproname);
            this.panel1.Controls.Add(this.Sbilld);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(26, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1013, 628);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint_1);
            // 
            // openFile_ID
            // 
            this.openFile_ID.BackColor = System.Drawing.Color.White;
            this.openFile_ID.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openFile_ID.ForeColor = System.Drawing.Color.Chocolate;
            this.openFile_ID.Location = new System.Drawing.Point(334, 331);
            this.openFile_ID.Name = "openFile_ID";
            this.openFile_ID.Size = new System.Drawing.Size(148, 55);
            this.openFile_ID.TabIndex = 37;
            this.openFile_ID.Text = "Get File";
            this.openFile_ID.UseVisualStyleBackColor = false;
            this.openFile_ID.Click += new System.EventHandler(this.openFile_ID_Click);
            // 
            // btnSave_Id
            // 
            this.btnSave_Id.BackColor = System.Drawing.Color.White;
            this.btnSave_Id.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave_Id.ForeColor = System.Drawing.Color.Chocolate;
            this.btnSave_Id.Location = new System.Drawing.Point(498, 333);
            this.btnSave_Id.Name = "btnSave_Id";
            this.btnSave_Id.Size = new System.Drawing.Size(494, 53);
            this.btnSave_Id.TabIndex = 36;
            this.btnSave_Id.Text = "Save To File";
            this.btnSave_Id.UseVisualStyleBackColor = false;
            this.btnSave_Id.Click += new System.EventHandler(this.btnSave_Id_Click);
            // 
            // btnLocation_ID
            // 
            this.btnLocation_ID.BackColor = System.Drawing.Color.White;
            this.btnLocation_ID.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLocation_ID.ForeColor = System.Drawing.Color.Chocolate;
            this.btnLocation_ID.Location = new System.Drawing.Point(334, 79);
            this.btnLocation_ID.Name = "btnLocation_ID";
            this.btnLocation_ID.Size = new System.Drawing.Size(126, 42);
            this.btnLocation_ID.TabIndex = 35;
            this.btnLocation_ID.Text = "Choose Your Location";
            this.btnLocation_ID.UseVisualStyleBackColor = false;
            this.btnLocation_ID.Click += new System.EventHandler(this.btnLocation_ID_Click);
            // 
            // textPath_ID
            // 
            this.textPath_ID.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textPath_ID.Location = new System.Drawing.Point(466, 79);
            this.textPath_ID.Multiline = true;
            this.textPath_ID.Name = "textPath_ID";
            this.textPath_ID.ReadOnly = true;
            this.textPath_ID.Size = new System.Drawing.Size(526, 42);
            this.textPath_ID.TabIndex = 34;
            this.textPath_ID.TextChanged += new System.EventHandler(this.textPath_ID_TextChanged);
            // 
            // sellerName
            // 
            this.sellerName.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sellerName.Location = new System.Drawing.Point(137, 80);
            this.sellerName.Name = "sellerName";
            this.sellerName.Size = new System.Drawing.Size(161, 27);
            this.sellerName.TabIndex = 33;
            // 
            // amount
            // 
            this.amount.AutoSize = true;
            this.amount.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amount.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.amount.Location = new System.Drawing.Point(552, 296);
            this.amount.Name = "amount";
            this.amount.Size = new System.Drawing.Size(90, 24);
            this.amount.TabIndex = 32;
            this.amount.Text = "Amount";
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.White;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button5.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.Chocolate;
            this.button5.Location = new System.Drawing.Point(20, 333);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(278, 53);
            this.button5.TabIndex = 29;
            this.button5.Text = "Add product";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(15, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 24);
            this.label2.TabIndex = 28;
            this.label2.Text = "Seller";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Chocolate;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.PName,
            this.price,
            this.Quantity,
            this.Total});
            this.dataGridView1.Location = new System.Drawing.Point(334, 130);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Chocolate;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.Size = new System.Drawing.Size(658, 155);
            this.dataGridView1.TabIndex = 27;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataviewcreatrow_CellContentClick);
            // 
            // id
            // 
            this.id.HeaderText = "prod_id";
            this.id.Name = "id";
            // 
            // PName
            // 
            this.PName.HeaderText = "prodname";
            this.PName.Name = "PName";
            // 
            // price
            // 
            this.price.HeaderText = "price";
            this.price.Name = "price";
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Chocolate;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(19, 403);
            this.dataGridView2.Name = "dataGridView2";
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Chocolate;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridView2.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridView2.Size = new System.Drawing.Size(973, 195);
            this.dataGridView2.TabIndex = 25;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // PRICETEX
            // 
            this.PRICETEX.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PRICETEX.Location = new System.Drawing.Point(137, 184);
            this.PRICETEX.Name = "PRICETEX";
            this.PRICETEX.Size = new System.Drawing.Size(161, 27);
            this.PRICETEX.TabIndex = 20;
            // 
            // QUANTEX
            // 
            this.QUANTEX.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QUANTEX.Location = new System.Drawing.Point(137, 285);
            this.QUANTEX.Name = "QUANTEX";
            this.QUANTEX.Size = new System.Drawing.Size(161, 27);
            this.QUANTEX.TabIndex = 19;
            // 
            // Sproname
            // 
            this.Sproname.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sproname.Location = new System.Drawing.Point(137, 236);
            this.Sproname.Name = "Sproname";
            this.Sproname.Size = new System.Drawing.Size(161, 27);
            this.Sproname.TabIndex = 18;
            // 
            // Sbilld
            // 
            this.Sbilld.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sbilld.Location = new System.Drawing.Point(138, 131);
            this.Sbilld.Name = "Sbilld";
            this.Sbilld.Size = new System.Drawing.Size(161, 27);
            this.Sbilld.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label10.Location = new System.Drawing.Point(15, 235);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(113, 24);
            this.label10.TabIndex = 16;
            this.label10.Text = "Prodname";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label9.Location = new System.Drawing.Point(15, 284);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 24);
            this.label9.TabIndex = 15;
            this.label9.Text = "Quantity";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label8.Location = new System.Drawing.Point(15, 183);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 24);
            this.label8.TabIndex = 14;
            this.label8.Text = "Price";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(16, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "BillID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // amtbl
            // 
            this.amtbl.AutoSize = true;
            this.amtbl.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amtbl.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.amtbl.Location = new System.Drawing.Point(648, 296);
            this.amtbl.Name = "amtbl";
            this.amtbl.Size = new System.Drawing.Size(35, 24);
            this.amtbl.TabIndex = 31;
            this.amtbl.Text = "Rs";
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(1042, -2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(29, 31);
            this.button1.TabIndex = 8;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(363, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 42);
            this.label3.TabIndex = 38;
            this.label3.Text = "SELLING";
            // 
            // Sellingform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1071, 681);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Sellingform";
            this.Text = "Sellingform";
            this.Load += new System.EventHandler(this.Sellingform_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox PRICETEX;
        private System.Windows.Forms.TextBox QUANTEX;
        private System.Windows.Forms.TextBox Sproname;
        private System.Windows.Forms.TextBox Sbilld;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn PName;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.TextBox sellerName;
        private System.Windows.Forms.Button btnLocation_ID;
        private System.Windows.Forms.TextBox textPath_ID;
        private System.Windows.Forms.Button openFile_ID;
        private System.Windows.Forms.Button btnSave_Id;
        private System.Windows.Forms.Label amtbl;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
    }
}