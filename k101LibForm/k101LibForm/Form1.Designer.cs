namespace k101LibForm
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtBook = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nmCount = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.dtgPublish = new System.Windows.Forms.DateTimePicker();
            this.cmbAuthors = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.dtgBook = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.nmCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgBook)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(15, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Book Name";
            // 
            // txtBook
            // 
            this.txtBook.BackColor = System.Drawing.SystemColors.Control;
            this.txtBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBook.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtBook.Location = new System.Drawing.Point(18, 68);
            this.txtBook.Name = "txtBook";
            this.txtBook.Size = new System.Drawing.Size(238, 26);
            this.txtBook.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label2.Location = new System.Drawing.Point(16, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Book Count";
            // 
            // nmCount
            // 
            this.nmCount.BackColor = System.Drawing.SystemColors.Control;
            this.nmCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nmCount.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.nmCount.Location = new System.Drawing.Point(20, 146);
            this.nmCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmCount.Name = "nmCount";
            this.nmCount.Size = new System.Drawing.Size(236, 26);
            this.nmCount.TabIndex = 3;
            this.nmCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label3.Location = new System.Drawing.Point(16, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Publish Date";
            // 
            // dtgPublish
            // 
            this.dtgPublish.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dtgPublish.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtgPublish.Location = new System.Drawing.Point(18, 226);
            this.dtgPublish.Name = "dtgPublish";
            this.dtgPublish.Size = new System.Drawing.Size(238, 26);
            this.dtgPublish.TabIndex = 5;
            // 
            // cmbAuthors
            // 
            this.cmbAuthors.BackColor = System.Drawing.SystemColors.Control;
            this.cmbAuthors.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbAuthors.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.cmbAuthors.FormattingEnabled = true;
            this.cmbAuthors.Location = new System.Drawing.Point(18, 301);
            this.cmbAuthors.Name = "cmbAuthors";
            this.cmbAuthors.Size = new System.Drawing.Size(238, 28);
            this.cmbAuthors.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label4.Location = new System.Drawing.Point(16, 272);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Authors";
            // 
            // btnAddBook
            // 
            this.btnAddBook.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAddBook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAddBook.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAddBook.Location = new System.Drawing.Point(18, 377);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(238, 47);
            this.btnAddBook.TabIndex = 8;
            this.btnAddBook.Text = "Add Book";
            this.btnAddBook.UseVisualStyleBackColor = false;
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblError.ForeColor = System.Drawing.Color.Firebrick;
            this.lblError.Location = new System.Drawing.Point(16, 351);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(49, 20);
            this.lblError.TabIndex = 9;
            this.lblError.Text = "Error";
            this.lblError.Visible = false;
            // 
            // dtgBook
            // 
            this.dtgBook.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgBook.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgBook.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dtgBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgBook.GridColor = System.Drawing.SystemColors.ControlText;
            this.dtgBook.Location = new System.Drawing.Point(475, 68);
            this.dtgBook.Name = "dtgBook";
            this.dtgBook.Size = new System.Drawing.Size(350, 356);
            this.dtgBook.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(860, 450);
            this.Controls.Add(this.dtgBook);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btnAddBook);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbAuthors);
            this.Controls.Add(this.dtgPublish);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nmCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBook);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nmCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgBook)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBook;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nmCount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtgPublish;
        private System.Windows.Forms.ComboBox cmbAuthors;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.DataGridView dtgBook;
    }
}

