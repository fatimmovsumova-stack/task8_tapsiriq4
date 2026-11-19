using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace task8_tapsiriq4
{
    public partial class Form1 : Form
    {
        private const string ConnStr =
            "Server=DESKTOP-DGFSF26;Database=LibraryDB;Trusted_Connection=True;";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadAuthors();
            LoadMembers();
            LoadBooks();
            LoadAvailableBooks();
            LoadActiveLoans();
        }

  
        private DataTable GetTable(string sql)
        {
            using (SqlConnection conn = new SqlConnection(ConnStr))
            {
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }


        private void LoadAuthors()
        {
            cmbBAuthor.DisplayMember = "FullName";
            cmbBAuthor.ValueMember = "AuthorId";
            cmbBAuthor.DataSource = GetTable("SELECT AuthorId, FullName FROM Authors ORDER BY FullName");
        }

        private void LoadMembers()
        {
            cmbLMember.DisplayMember = "FullName";
            cmbLMember.ValueMember = "MemberId";
            cmbLMember.DataSource = GetTable("SELECT MemberId, FullName FROM Members ORDER BY FullName");
        }

       
        private void LoadBooks()
        {
            string sql = @"
                SELECT b.BookId, b.Title AS [Kitab], a.FullName AS [Müəllif], b.AuthorId
                FROM Books b
                INNER JOIN Authors a ON b.AuthorId = a.AuthorId
                ORDER BY b.Title";

            dgvBooks.DataSource = GetTable(sql);
            dgvBooks.Columns["BookId"].Visible = false;
            dgvBooks.Columns["AuthorId"].Visible = false;
        }

     
        private void dgvBooks_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvBooks.CurrentRow == null) return;
            if (dgvBooks.CurrentRow.Cells["Kitab"].Value == null) return;

            txtBTitle.Text = dgvBooks.CurrentRow.Cells["Kitab"].Value.ToString();
            cmbBAuthor.SelectedValue = Convert.ToInt32(dgvBooks.CurrentRow.Cells["AuthorId"].Value);
        }

        private void btnBAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBTitle.Text))
            {
                MessageBox.Show("Kitabın adını yazın.");
                return;
            }
            if (cmbBAuthor.SelectedValue == null)
            {
                MessageBox.Show("Müəllif seçin.");
                return;
            }

            using (SqlConnection conn = new SqlConnection(ConnStr))
            using (SqlCommand cmd = new SqlCommand(
                "INSERT INTO Books (Title, AuthorId) VALUES (@title, @aid)", conn))
            {
                cmd.Parameters.AddWithValue("@title", txtBTitle.Text.Trim());
                cmd.Parameters.AddWithValue("@aid", cmbBAuthor.SelectedValue);
                conn.Open();
                cmd.ExecuteNonQuery();
            }

            txtBTitle.Clear();
            LoadBooks();
            LoadAvailableBooks();
        }

        private void btnBUpdate_Click(object sender, EventArgs e)
        {
            if (dgvBooks.CurrentRow == null)
            {
                MessageBox.Show("Cədvəldən kitab seçin.");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtBTitle.Text))
            {
                MessageBox.Show("Kitabın adını yazın.");
                return;
            }

            int bookId = Convert.ToInt32(dgvBooks.CurrentRow.Cells["BookId"].Value);

            using (SqlConnection conn = new SqlConnection(ConnStr))
            using (SqlCommand cmd = new SqlCommand(
                "UPDATE Books SET Title = @title, AuthorId = @aid WHERE BookId = @id", conn))
            {
                cmd.Parameters.AddWithValue("@title", txtBTitle.Text.Trim());
                cmd.Parameters.AddWithValue("@aid", cmbBAuthor.SelectedValue);
                cmd.Parameters.AddWithValue("@id", bookId);
                conn.Open();
                cmd.ExecuteNonQuery();
            }

            LoadBooks();
            LoadAvailableBooks();
            LoadActiveLoans();
        }

        private void btnBDelete_Click(object sender, EventArgs e)
        {
            if (dgvBooks.CurrentRow == null)
            {
                MessageBox.Show("Cədvəldən kitab seçin.");
                return;
            }

            if (MessageBox.Show("Bu kitabı silmək istədiyinizə əminsiniz?", "Təsdiq",
                MessageBoxButtons.YesNo) != DialogResult.Yes) return;

            int bookId = Convert.ToInt32(dgvBooks.CurrentRow.Cells["BookId"].Value);

            try
            {
                using (SqlConnection conn = new SqlConnection(ConnStr))
                using (SqlCommand cmd = new SqlCommand("DELETE FROM Books WHERE BookId = @id", conn))
                {
                    cmd.Parameters.AddWithValue("@id", bookId);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }

                LoadBooks();
                LoadAvailableBooks();
            }
            catch (SqlException ex)
            {
                if (ex.Number == 547)
                {
                    MessageBox.Show("Bu kitabı silmək olmaz, çünki o icarə tarixçəsində var.",
                        "Silmək mümkün deyil", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Database xətası: " + ex.Message);
                }
            }
        }

        private void LoadAvailableBooks()
        {
            string sql = @"
                SELECT BookId, Title
                FROM Books
                WHERE BookId NOT IN (SELECT BookId FROM Loans WHERE ReturnDate IS NULL)
                ORDER BY Title";

            cmbLBook.DisplayMember = "Title";
            cmbLBook.ValueMember = "BookId";
            cmbLBook.DataSource = GetTable(sql);
        }

        private void LoadActiveLoans()
        {
            string sql = @"
                SELECT l.LoanId, b.Title AS [Kitab], m.FullName AS [Üzv], l.LoanDate AS [İcarə tarixi]
                FROM Loans l
                INNER JOIN Books   b ON l.BookId   = b.BookId
                INNER JOIN Members m ON l.MemberId = m.MemberId
                WHERE l.ReturnDate IS NULL
                ORDER BY l.LoanDate";

            dgvActive.DataSource = GetTable(sql);
            dgvActive.Columns["LoanId"].Visible = false;
        }

      
        private void btnLend_Click(object sender, EventArgs e)
        {
            if (cmbLBook.SelectedValue == null)
            {
                MessageBox.Show("İcarəyə veriləcək boş kitab yoxdur.");
                return;
            }
            if (cmbLMember.SelectedValue == null)
            {
                MessageBox.Show("Üzv seçin.");
                return;
            }

            using (SqlConnection conn = new SqlConnection(ConnStr))
            using (SqlCommand cmd = new SqlCommand(
                "INSERT INTO Loans (BookId, MemberId, LoanDate) VALUES (@bid, @mid, GETDATE())", conn))
            {
                cmd.Parameters.AddWithValue("@bid", cmbLBook.SelectedValue);
                cmd.Parameters.AddWithValue("@mid", cmbLMember.SelectedValue);
                conn.Open();
                cmd.ExecuteNonQuery();
            }

            LoadAvailableBooks();
            LoadActiveLoans();
            MessageBox.Show("Kitab icarəyə verildi.");
        }

      
        private void btnReturn_Click(object sender, EventArgs e)
        {
            if (dgvActive.CurrentRow == null)
            {
                MessageBox.Show("Siyahıdan qaytarılan kitabı seçin.");
                return;
            }

            int loanId = Convert.ToInt32(dgvActive.CurrentRow.Cells["LoanId"].Value);

            using (SqlConnection conn = new SqlConnection(ConnStr))
            using (SqlCommand cmd = new SqlCommand(
                "UPDATE Loans SET ReturnDate = GETDATE() WHERE LoanId = @id AND ReturnDate IS NULL", conn))
            {
                cmd.Parameters.AddWithValue("@id", loanId);
                conn.Open();
                cmd.ExecuteNonQuery();
            }

            LoadAvailableBooks();
            LoadActiveLoans();
            MessageBox.Show("Kitab qaytarıldı.");
        }
    }
}
