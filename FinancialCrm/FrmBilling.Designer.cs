namespace FinancialCrm
{
    partial class FrmBilling
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.btnBillsForm = new System.Windows.Forms.Button();
            this.btnInvoicesForm = new System.Windows.Forms.Button();
            this.btnBanksForm = new System.Windows.Forms.Button();
            this.btnCategoriesForm = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBillId = new System.Windows.Forms.TextBox();
            this.txtBillTitle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBillPeriod = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBillAmount = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnBillList = new System.Windows.Forms.Button();
            this.btnBillCreate = new System.Windows.Forms.Button();
            this.btnBillUpdate = new System.Windows.Forms.Button();
            this.btnBillDelete = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.button8);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.btnBillsForm);
            this.panel1.Controls.Add(this.btnInvoicesForm);
            this.panel1.Controls.Add(this.btnBanksForm);
            this.panel1.Controls.Add(this.btnCategoriesForm);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(237, 537);
            this.panel1.TabIndex = 1;
            // 
            // button7
            // 
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button7.Location = new System.Drawing.Point(43, 317);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(173, 37);
            this.button7.TabIndex = 7;
            this.button7.Text = "Çıkış Yap";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button8.Location = new System.Drawing.Point(43, 274);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(173, 37);
            this.button8.TabIndex = 6;
            this.button8.Text = "Ayarlar";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button5.Location = new System.Drawing.Point(43, 231);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(173, 37);
            this.button5.TabIndex = 5;
            this.button5.Text = "Dashboard";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button6.Location = new System.Drawing.Point(43, 188);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(173, 37);
            this.button6.TabIndex = 4;
            this.button6.Text = "Banka Hareketleri";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // btnBillsForm
            // 
            this.btnBillsForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBillsForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBillsForm.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnBillsForm.Location = new System.Drawing.Point(43, 145);
            this.btnBillsForm.Name = "btnBillsForm";
            this.btnBillsForm.Size = new System.Drawing.Size(173, 37);
            this.btnBillsForm.TabIndex = 3;
            this.btnBillsForm.Text = "Giderler";
            this.btnBillsForm.UseVisualStyleBackColor = true;
            this.btnBillsForm.Click += new System.EventHandler(this.btnBillsForm_Click);
            // 
            // btnInvoicesForm
            // 
            this.btnInvoicesForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInvoicesForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnInvoicesForm.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnInvoicesForm.Location = new System.Drawing.Point(43, 102);
            this.btnInvoicesForm.Name = "btnInvoicesForm";
            this.btnInvoicesForm.Size = new System.Drawing.Size(173, 37);
            this.btnInvoicesForm.TabIndex = 2;
            this.btnInvoicesForm.Text = "Faturalar";
            this.btnInvoicesForm.UseVisualStyleBackColor = true;
            // 
            // btnBanksForm
            // 
            this.btnBanksForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBanksForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBanksForm.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnBanksForm.Location = new System.Drawing.Point(43, 59);
            this.btnBanksForm.Name = "btnBanksForm";
            this.btnBanksForm.Size = new System.Drawing.Size(173, 37);
            this.btnBanksForm.TabIndex = 1;
            this.btnBanksForm.Text = "Bankalar";
            this.btnBanksForm.UseVisualStyleBackColor = true;
            this.btnBanksForm.Click += new System.EventHandler(this.btnBanksForm_Click);
            // 
            // btnCategoriesForm
            // 
            this.btnCategoriesForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategoriesForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCategoriesForm.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCategoriesForm.Location = new System.Drawing.Point(43, 16);
            this.btnCategoriesForm.Name = "btnCategoriesForm";
            this.btnCategoriesForm.Size = new System.Drawing.Size(173, 37);
            this.btnCategoriesForm.TabIndex = 0;
            this.btnCategoriesForm.Text = "Kategoriler";
            this.btnCategoriesForm.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnBillUpdate);
            this.panel2.Controls.Add(this.btnBillDelete);
            this.panel2.Controls.Add(this.btnBillCreate);
            this.panel2.Controls.Add(this.btnBillList);
            this.panel2.Controls.Add(this.txtBillPeriod);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtBillAmount);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtBillTitle);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtBillId);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(237, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(700, 182);
            this.panel2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(3, 188);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(700, 349);
            this.panel3.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ödeme Id :";
            // 
            // txtBillId
            // 
            this.txtBillId.BackColor = System.Drawing.Color.Gold;
            this.txtBillId.Location = new System.Drawing.Point(93, 17);
            this.txtBillId.Name = "txtBillId";
            this.txtBillId.Size = new System.Drawing.Size(592, 20);
            this.txtBillId.TabIndex = 5;
            // 
            // txtBillTitle
            // 
            this.txtBillTitle.BackColor = System.Drawing.Color.Gold;
            this.txtBillTitle.Location = new System.Drawing.Point(93, 45);
            this.txtBillTitle.Name = "txtBillTitle";
            this.txtBillTitle.Size = new System.Drawing.Size(592, 20);
            this.txtBillTitle.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(31, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "Başlık :";
            // 
            // txtBillPeriod
            // 
            this.txtBillPeriod.BackColor = System.Drawing.Color.Gold;
            this.txtBillPeriod.Location = new System.Drawing.Point(93, 106);
            this.txtBillPeriod.Name = "txtBillPeriod";
            this.txtBillPeriod.Size = new System.Drawing.Size(592, 20);
            this.txtBillPeriod.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(24, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 19);
            this.label3.TabIndex = 10;
            this.label3.Text = "Periyot :";
            // 
            // txtBillAmount
            // 
            this.txtBillAmount.BackColor = System.Drawing.Color.Gold;
            this.txtBillAmount.Location = new System.Drawing.Point(93, 78);
            this.txtBillAmount.Name = "txtBillAmount";
            this.txtBillAmount.Size = new System.Drawing.Size(592, 20);
            this.txtBillAmount.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(27, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = "Miktar :";
            // 
            // btnBillList
            // 
            this.btnBillList.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnBillList.Location = new System.Drawing.Point(93, 141);
            this.btnBillList.Name = "btnBillList";
            this.btnBillList.Size = new System.Drawing.Size(132, 34);
            this.btnBillList.TabIndex = 12;
            this.btnBillList.Text = "Ödeme Listesi";
            this.btnBillList.UseVisualStyleBackColor = false;
            this.btnBillList.Click += new System.EventHandler(this.btnBillList_Click);
            // 
            // btnBillCreate
            // 
            this.btnBillCreate.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnBillCreate.Location = new System.Drawing.Point(231, 141);
            this.btnBillCreate.Name = "btnBillCreate";
            this.btnBillCreate.Size = new System.Drawing.Size(132, 34);
            this.btnBillCreate.TabIndex = 13;
            this.btnBillCreate.Text = "Yeni Ödeme";
            this.btnBillCreate.UseVisualStyleBackColor = false;
            this.btnBillCreate.Click += new System.EventHandler(this.btnBillCreate_Click);
            // 
            // btnBillUpdate
            // 
            this.btnBillUpdate.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnBillUpdate.Location = new System.Drawing.Point(507, 141);
            this.btnBillUpdate.Name = "btnBillUpdate";
            this.btnBillUpdate.Size = new System.Drawing.Size(132, 34);
            this.btnBillUpdate.TabIndex = 15;
            this.btnBillUpdate.Text = "Ödeme Güncelle";
            this.btnBillUpdate.UseVisualStyleBackColor = false;
            this.btnBillUpdate.Click += new System.EventHandler(this.btnBillUpdate_Click);
            // 
            // btnBillDelete
            // 
            this.btnBillDelete.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnBillDelete.Location = new System.Drawing.Point(369, 141);
            this.btnBillDelete.Name = "btnBillDelete";
            this.btnBillDelete.Size = new System.Drawing.Size(132, 34);
            this.btnBillDelete.TabIndex = 14;
            this.btnBillDelete.Text = "Ödeme Sil";
            this.btnBillDelete.UseVisualStyleBackColor = false;
            this.btnBillDelete.Click += new System.EventHandler(this.btnBillDelete_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(237, 182);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(700, 353);
            this.dataGridView1.TabIndex = 3;
            // 
            // FrmBilling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(949, 539);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FrmBilling";
            this.Text = "Ödeme & Fatura Formu";
            this.Load += new System.EventHandler(this.FrmBilling_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button btnBillsForm;
        private System.Windows.Forms.Button btnInvoicesForm;
        private System.Windows.Forms.Button btnBanksForm;
        private System.Windows.Forms.Button btnCategoriesForm;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtBillPeriod;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBillAmount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBillTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBillId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnBillUpdate;
        private System.Windows.Forms.Button btnBillDelete;
        private System.Windows.Forms.Button btnBillCreate;
        private System.Windows.Forms.Button btnBillList;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}