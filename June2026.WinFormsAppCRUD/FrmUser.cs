using June2026.EFCoreAssignmentDB.AppDbContextModels;
using Microsoft.VisualBasic.ApplicationServices;

namespace June2026.WinFormsAppCRUD
{
    public partial class FrmUser : Form
    {
        private readonly AppDbContext _db;
        private int editUserId = 0;
        public FrmUser()
        {
            InitializeComponent();
            _db = new AppDbContext();
        }

        private void FrmUser_Load(object sender, EventArgs e)
        {
            BindData();
        }

        public class UserDto
        {
            public int RowNo { get; set; }
            public int UserId { get; set; }
            public string Username { get; set; }
            public string Password { get; set; }
            public string Bio { get; set; }
        }

        private void BindData()
        {
            var lst = _db.TblUsers.ToList();
            List<UserDto> users = new List<UserDto>();
            int rowNo = 1;

            foreach (var item in lst)
            {
                users.Add(new UserDto()
                {
                    RowNo = rowNo++,
                    Username = item.Username,
                    Password = item.Password,
                    Bio = item.Bio,
                    UserId = item.Id
                });
            }

            dgvData.DataSource = users;
            txtUsername.Focus();
        }

        private void ClearControls()
        {
            txtUsername.Clear();
            txtPassword.Clear();
            txtBio.Clear();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (editUserId == 0)
            {
                _db.TblUsers.Add(new TblUser()
                {
                    Username = txtUsername.Text.Trim(),
                    Password = txtPassword.Text.Trim(),
                    Bio = txtBio.Text.Trim()
                });
            }

            else if (editUserId > 0)
            {
                var item = _db.TblUsers.Where(x => x.Id == editUserId).FirstOrDefault();
                if (item is null) return;

                item.Username = txtUsername.Text.Trim();
                item.Password = txtPassword.Text.Trim();
                item.Bio = txtBio.Text.Trim();
            }
            _db.SaveChanges();
            ClearControls();
            BindData();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearControls();
        }

        private void dgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;

            if (e.ColumnIndex == 0) // edit 
            {
                int userId = Convert.ToInt32(dgvData.Rows[e.RowIndex].Cells[nameof(colUserId)].Value);
                var item = _db.TblUsers.Where(x => x.Id == userId).FirstOrDefault();
                if (item is null) return;

                txtUsername.Text = item.Username;
                txtPassword.Text = item.Password;
                txtBio.Text = item.Bio;
                editUserId = item.Id;
            }

            else if (e.ColumnIndex == 1) // delete
            {
                var result = MessageBox.Show("Are you sure to delete?",
                    "Confirm",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    int userId = Convert.ToInt32(dgvData.Rows[e.RowIndex].Cells[nameof(colUserId)].Value);
                    var item = _db.TblUsers.Where(x => x.Id == userId).FirstOrDefault();

                    if (item is null) return;
                    _db.Remove(item);
                    _db.SaveChanges();
                    BindData();
                }
            }
        }
    }
}
