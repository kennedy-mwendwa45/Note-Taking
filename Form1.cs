using System.Data;

namespace Note_Taking
{
    public partial class Form1 : Form
    {

        DataTable table;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            table = new DataTable();
            table.Columns.Add("Title", typeof(string));
            table.Columns.Add("Messages", typeof(string));

            dataGridView1.DataSource = table;
            dataGridView1.Columns["Messages"].Visible = false;
            dataGridView1.Columns["Title"].Width = 150;
        }

        private void BttNew_Click(object sender, EventArgs e)
        {
            TxtTitle.Clear();
            TxtMessage.Clear();
        }

        private void BttSave_Click(object sender, EventArgs e)
        {
            table.Rows.Add(TxtTitle.Text, TxtMessage.Text);

            TxtTitle.Clear();
            TxtMessage.Clear();
        }

        private void BttRead_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentCell.RowIndex;

            if (index > -1)
            {
                TxtTitle.Text = table.Rows[index].ItemArray[0].ToString();
                TxtMessage.Text = table.Rows[index].ItemArray[1].ToString();
            }
        }

        private void BttDelete_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentCell.RowIndex;

            table.Rows[index].Delete();
        }
    }
}