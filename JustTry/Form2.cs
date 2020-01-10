using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JustTry
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = true;

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "course_work_2DataSet.DataTable1". При необходимости она может быть перемещена или удалена.
            this.dataTable1TableAdapter.Fill(this.course_work_2DataSet.DataTable1);
            this.sectorsTableAdapter.Fill(this.course_work_2DataSet.Sectors);
            this.programOfProductionTableAdapter.Fill(this.course_work_2DataSet.ProgramOfProduction);
            this.detailsTableAdapter.Fill(this.course_work_2DataSet.Details);

        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        //private void toolStripButton1_Click(object sender, EventArgs e)
        //{
        //    if (toolStripLabel1.Text != "Секторы")
        //    {
        //        dataGridView1.Columns.Clear();
        //        dataGridView1.DataSource = sectorsBindingSource;
        //        bindingNavigator1.BindingSource = sectorsBindingSource;
        //        toolStripLabel1.Text = "Секторы";
        //    }
        //}

        //private void toolStripButton2_Click(object sender, EventArgs e)
        //{
        //    if (toolStripLabel1.Text != "Детали")
        //    {
        //        dataGridView1.Columns.Clear();
        //        dataGridView1.DataSource = detailsBindingSource;
        //        bindingNavigator1.BindingSource = detailsBindingSource;
        //        toolStripLabel1.Text = "Детали";
        //    }
        //}

        //private void toolStripButton3_Click(object sender, EventArgs e)
        //{
        //    if (toolStripLabel1.Text != "Производственная программа предприятия")
        //    {
        //        dataGridView1.Columns.Clear();
        //        dataGridView1.DataSource = programOfProductionBindingSource;
        //        bindingNavigator1.BindingSource = programOfProductionBindingSource;
        //        toolStripLabel1.Text = "Производственная программа предприятия";
        //    }
        //}

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            tableAdapterManager1.UpdateAll(course_work_2DataSet);
            MessageBox.Show("Changes saved");
        }
    }
}
