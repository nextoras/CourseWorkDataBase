using Npgsql;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.sectorsTableAdapter.Fill(this.course_work_2DataSet.Sectors);
            this.sectorsTableAdapter.Fill(this.course_work_2DataSet.Sectors);
            this.detailsTableAdapter.Fill(this.course_work_2DataSet.Details);
        }

        //private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    this.detailsGridView.DataSource = detailsGridView;
        //    bindingNavigator1.BindingSource = detailsBindingSource;
        //    CurrentTable.Text = "Детали";
        //}

        //private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    this.sectorsGridView.DataSource = sectorsGridView;
        //    bindingNavigator1.BindingSource = sectorsBindingSource;
        //    CurrentTable.Text = "Секторы";
        //}

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            programOfProductionGridView.DataSource = programOfProductionBindingSource;
            //this.sectorsGridView.DataSource = sectorsBindingSource;
            //this.detailsGridView.DataSource = detailsBindingSource;
            //bindingNavigator1.BindingSource = programOfProductionBindingSource;
            CurrentTable.Text = "Программа производста";
        }

        private void Table1_Click(object sender, EventArgs e)
        {
            int nRow = programOfProductionGridView.CurrentCell.RowIndex;
            int nCol = programOfProductionGridView.CurrentCell.ColumnIndex;
            // Если строка – не последняя, увеличиваем номер строки на 1,
            // в противном случае соответству
            //if (nRow < programOfProductionGridView.RowCount - 1)
            //    programOfProductionGridView.CurrentCell = programOfProductionGridView[nCol,
            //    ++nRow];
        }

        private void ProgramOfProductions_CurrentCellChanged(object sender, EventArgs e)
        {

            if (programOfProductionGridView.CurrentCell != null)
            {
                int nRow = programOfProductionGridView.CurrentCell.RowIndex;                
            }
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            this.sectorsTableAdapter.Update(course_work_2DataSet.Sectors);
            this.detailsTableAdapter.Update(course_work_2DataSet.Details);
            this.ProgramOfProductions_CurrentCellChanged(programOfProductionGridView, e);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            

        }

        private void альтернативнаяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void detailsBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorMoveFirstItem_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void SectorsButton_Click(object sender, EventArgs e)
        {
            CurrentTable.Text = "Секторы";
            bindingNavigator1.BindingSource = sectorsBindingSource;
            programOfProductionGridView.DataSource = sectorsBindingSource;
        }

        private void DetailsButton_Click(object sender, EventArgs e)
        {
            CurrentTable.Text = "Детали";
            bindingNavigator1.BindingSource = detailsBindingSource;
            programOfProductionGridView.DataSource = detailsBindingSource;
        }

        private void ProgramOfProductionButton_Click(object sender, EventArgs e)
        {
            CurrentTable.Text = "Программа производста";
            programOfProductionGridView.DataSource = programOfProductionBindingSource;
            this.programOfProductionTableAdapter.Fill(this.course_work_2DataSet.ProgramOfProduction);
        }

        private void задача2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
        }

        private void задача3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.Show();
        }
    }
}
