using System.Drawing;
using System.Windows.Forms;

namespace task8_tapsiriq4
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabBooks = new System.Windows.Forms.TabPage();
            this.tabLoans = new System.Windows.Forms.TabPage();

           
            this.lblBTitle = new System.Windows.Forms.Label();
            this.txtBTitle = new System.Windows.Forms.TextBox();
            this.lblBAuthor = new System.Windows.Forms.Label();
            this.cmbBAuthor = new System.Windows.Forms.ComboBox();
            this.btnBAdd = new System.Windows.Forms.Button();
            this.btnBUpdate = new System.Windows.Forms.Button();
            this.btnBDelete = new System.Windows.Forms.Button();
            this.dgvBooks = new System.Windows.Forms.DataGridView();

          
            this.lblLBook = new System.Windows.Forms.Label();
            this.cmbLBook = new System.Windows.Forms.ComboBox();
            this.lblLMember = new System.Windows.Forms.Label();
            this.cmbLMember = new System.Windows.Forms.ComboBox();
            this.btnLend = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.lblActive = new System.Windows.Forms.Label();
            this.dgvActive = new System.Windows.Forms.DataGridView();

            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActive)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabBooks.SuspendLayout();
            this.tabLoans.SuspendLayout();
            this.SuspendLayout();

            
            this.tabControl1.Controls.Add(this.tabBooks);
            this.tabControl1.Controls.Add(this.tabLoans);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(784, 511);
            this.tabControl1.TabIndex = 0;

           
            this.tabBooks.Controls.Add(this.lblBTitle);
            this.tabBooks.Controls.Add(this.txtBTitle);
            this.tabBooks.Controls.Add(this.lblBAuthor);
            this.tabBooks.Controls.Add(this.cmbBAuthor);
            this.tabBooks.Controls.Add(this.btnBAdd);
            this.tabBooks.Controls.Add(this.btnBUpdate);
            this.tabBooks.Controls.Add(this.btnBDelete);
            this.tabBooks.Controls.Add(this.dgvBooks);
            this.tabBooks.Location = new System.Drawing.Point(4, 29);
            this.tabBooks.Name = "tabBooks";
            this.tabBooks.Padding = new System.Windows.Forms.Padding(3);
            this.tabBooks.Size = new System.Drawing.Size(776, 478);
            this.tabBooks.Text = "Kitablar";
            this.tabBooks.UseVisualStyleBackColor = true;
            //
            this.lblBTitle.AutoSize = true;
            this.lblBTitle.Location = new System.Drawing.Point(20, 20);
            this.lblBTitle.Name = "lblBTitle";
            this.lblBTitle.Text = "Kitabın adı:";
            //
            this.txtBTitle.Location = new System.Drawing.Point(20, 43);
            this.txtBTitle.MaxLength = 150;
            this.txtBTitle.Name = "txtBTitle";
            this.txtBTitle.Size = new System.Drawing.Size(300, 27);
            //
            this.lblBAuthor.AutoSize = true;
            this.lblBAuthor.Location = new System.Drawing.Point(340, 20);
            this.lblBAuthor.Name = "lblBAuthor";
            this.lblBAuthor.Text = "Müəllif:";
            //
            this.cmbBAuthor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBAuthor.Location = new System.Drawing.Point(340, 43);
            this.cmbBAuthor.Name = "cmbBAuthor";
            this.cmbBAuthor.Size = new System.Drawing.Size(250, 28);
            //
            this.btnBAdd.Location = new System.Drawing.Point(20, 90);
            this.btnBAdd.Name = "btnBAdd";
            this.btnBAdd.Size = new System.Drawing.Size(120, 35);
            this.btnBAdd.Text = "Əlavə et";
            this.btnBAdd.UseVisualStyleBackColor = true;
            this.btnBAdd.Click += new System.EventHandler(this.btnBAdd_Click);
            //
            this.btnBUpdate.Location = new System.Drawing.Point(150, 90);
            this.btnBUpdate.Name = "btnBUpdate";
            this.btnBUpdate.Size = new System.Drawing.Size(120, 35);
            this.btnBUpdate.Text = "Düzəlt";
            this.btnBUpdate.UseVisualStyleBackColor = true;
            this.btnBUpdate.Click += new System.EventHandler(this.btnBUpdate_Click);
            //
            this.btnBDelete.Location = new System.Drawing.Point(280, 90);
            this.btnBDelete.Name = "btnBDelete";
            this.btnBDelete.Size = new System.Drawing.Size(120, 35);
            this.btnBDelete.Text = "Sil";
            this.btnBDelete.UseVisualStyleBackColor = true;
            this.btnBDelete.Click += new System.EventHandler(this.btnBDelete_Click);
            //
            this.dgvBooks.AllowUserToAddRows = false;
            this.dgvBooks.AllowUserToDeleteRows = false;
            this.dgvBooks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBooks.Location = new System.Drawing.Point(20, 145);
            this.dgvBooks.MultiSelect = false;
            this.dgvBooks.Name = "dgvBooks";
            this.dgvBooks.ReadOnly = true;
            this.dgvBooks.RowHeadersWidth = 51;
            this.dgvBooks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBooks.Size = new System.Drawing.Size(730, 300);
            this.dgvBooks.SelectionChanged += new System.EventHandler(this.dgvBooks_SelectionChanged);

            // ================= TAB 2: İcarə =================
            this.tabLoans.Controls.Add(this.lblLBook);
            this.tabLoans.Controls.Add(this.cmbLBook);
            this.tabLoans.Controls.Add(this.lblLMember);
            this.tabLoans.Controls.Add(this.cmbLMember);
            this.tabLoans.Controls.Add(this.btnLend);
            this.tabLoans.Controls.Add(this.btnReturn);
            this.tabLoans.Controls.Add(this.lblActive);
            this.tabLoans.Controls.Add(this.dgvActive);
            this.tabLoans.Location = new System.Drawing.Point(4, 29);
            this.tabLoans.Name = "tabLoans";
            this.tabLoans.Padding = new System.Windows.Forms.Padding(3);
            this.tabLoans.Size = new System.Drawing.Size(776, 478);
            this.tabLoans.Text = "İcarə";
            this.tabLoans.UseVisualStyleBackColor = true;
            //
            this.lblLBook.AutoSize = true;
            this.lblLBook.Location = new System.Drawing.Point(20, 20);
            this.lblLBook.Name = "lblLBook";
            this.lblLBook.Text = "Kitab (boş olanlar):";
            //
            this.cmbLBook.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLBook.Location = new System.Drawing.Point(20, 43);
            this.cmbLBook.Name = "cmbLBook";
            this.cmbLBook.Size = new System.Drawing.Size(300, 28);
            //
            this.lblLMember.AutoSize = true;
            this.lblLMember.Location = new System.Drawing.Point(340, 20);
            this.lblLMember.Name = "lblLMember";
            this.lblLMember.Text = "Üzv:";
            //
            this.cmbLMember.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLMember.Location = new System.Drawing.Point(340, 43);
            this.cmbLMember.Name = "cmbLMember";
            this.cmbLMember.Size = new System.Drawing.Size(250, 28);
            //
            this.btnLend.Location = new System.Drawing.Point(20, 90);
            this.btnLend.Name = "btnLend";
            this.btnLend.Size = new System.Drawing.Size(140, 35);
            this.btnLend.Text = "İcarəyə ver";
            this.btnLend.UseVisualStyleBackColor = true;
            this.btnLend.Click += new System.EventHandler(this.btnLend_Click);
            //
            this.btnReturn.Location = new System.Drawing.Point(170, 90);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(140, 35);
            this.btnReturn.Text = "Qaytar";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            //
            this.lblActive.AutoSize = true;
            this.lblActive.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblActive.Location = new System.Drawing.Point(20, 135);
            this.lblActive.Name = "lblActive";
            this.lblActive.Text = "Hələ qaytarılmamış kitablar (qaytarmaq üçün sətri seçin):";
            //
            this.dgvActive.AllowUserToAddRows = false;
            this.dgvActive.AllowUserToDeleteRows = false;
            this.dgvActive.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvActive.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvActive.Location = new System.Drawing.Point(20, 165);
            this.dgvActive.MultiSelect = false;
            this.dgvActive.Name = "dgvActive";
            this.dgvActive.ReadOnly = true;
            this.dgvActive.RowHeadersWidth = 51;
            this.dgvActive.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvActive.Size = new System.Drawing.Size(730, 280);

            //
            
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 511);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Kitabxana proqramı";
            this.Load += new System.EventHandler(this.Form1_Load);

            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActive)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabBooks.ResumeLayout(false);
            this.tabBooks.PerformLayout();
            this.tabLoans.ResumeLayout(false);
            this.tabLoans.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabBooks;
        private TabPage tabLoans;

        private Label lblBTitle;
        private TextBox txtBTitle;
        private Label lblBAuthor;
        private ComboBox cmbBAuthor;
        private Button btnBAdd;
        private Button btnBUpdate;
        private Button btnBDelete;
        private DataGridView dgvBooks;

        private Label lblLBook;
        private ComboBox cmbLBook;
        private Label lblLMember;
        private ComboBox cmbLMember;
        private Button btnLend;
        private Button btnReturn;
        private Label lblActive;
        private DataGridView dgvActive;
    }
}
