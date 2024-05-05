
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ADO.NET_Spotify
{
    public partial class Form1 : Form
    {
        const string connectionString = "Server=DESKTOP-8ABCEA9\\SQLEXPRESS;Database=ADONETSpotify;Trusted_Connect;";
        public Form1()
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Users", conn);
            SqlDataReader datas = cmd.ExecuteReader();
            DataGridView.Columns.Add();
            while (datas.Read())
            {
                dataGridView1.Rows.Add(datas[0], datas[1], (datas[2], (datas[3]);
            }

            InitializeComponent();
        }
        void GetDatas()
        {
            ResetTable();
            using SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            using SqlCommand command = new SqlCommand("SELECT * FROM People", conn);
            using SqlDataReader datas = command.ExecuteReader();
            while (datas.Read())
            {
                dataGridView1.Rows.Add(datas[0], datas[1], datas[2], (Convert.ToInt32(datas[3]) == 1 ? "Kişi" : "Qadın"));
            }
        }
        bool InsertData(string name, string surname, int genderId)
        {
            if (name.Length < 3 || surname.Length < 3 || genderId < 1 || genderId > 2)
            {
                MessageBox.Show("Daxil olunan dəyərlərdə yalnışlıq var.");
                return false;
            }
            using SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            using SqlCommand command = new SqlCommand($"INSERT INTO People VALUES (N'{name}',N'{surname}',{genderId})", conn);
            int count = command.ExecuteNonQuery();
            if (count > 0)
            {
                return true;
            }
            return false;

        }
        private void deleteBtn_Click(object sender, EventArgs e)
        {
            var data = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex];
            string id = data.Cells[0].Value.ToString();
            Delete(id);
            GetDatas();
        }
        void Delete(string id)
        {
            using SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            using SqlCommand command = new SqlCommand($"DELETE People WHERE Id = {id}", conn);
            var result = command.ExecuteNonQuery();
            if (result > 0)
            {
                MessageBox.Show("Silindi");
            }
            else
            {
                MessageBox.Show("Gözlənilməz xəta baş verdi");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        
     
    }
}
