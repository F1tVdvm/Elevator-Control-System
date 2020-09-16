using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.OleDb;

namespace Control_an_Elevator
{
    public partial class Form1 : Form
    {
        private DataSet ds = new DataSet();
        private string dbconnection;
        private string dbcommand;
        private OleDbConnection conn;
        private OleDbCommand comm;
        private OleDbDataAdapter adapter;
        private OleDbCommandBuilder builder;




        public Form1()
        {
            InitializeComponent();
            timer1.Interval = 15;
            timer1.Tick += new EventHandler(timer1_Tick);
            timer2.Interval = 15;
            timer2.Tick += new EventHandler(timer2_Tick);
            WindowDisplay2.Visible = false;
            btnWall0.Enabled = false;
            btnOnFirstFloor.Enabled = false;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            dbconnection = "Provider=Microsoft.ACE.OLEDB.12.0;" + @"data source = ..\Elevator-Control-System\Control an Elevator\bin\DatabaseElevator.accdb"; // your path to database
            dbcommand = "Select * from StoredLogs;";
            conn = new OleDbConnection(dbconnection);
            comm = new OleDbCommand(dbcommand, conn);
            adapter = new OleDbDataAdapter(comm);
            loadDataIntoDataset();
            update_dataGrid();
            builder = new OleDbCommandBuilder(adapter);

        }
        public void loadDataIntoDataset()             //load the data into the dataset
        {
            try
            {
                adapter.Fill(ds); //  Block of code to try

            }
            catch (Exception ex)
            {
                MessageBox.Show("The data has not been load", "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }


        public void reloadDataIntoDataset()             //force reload the data into the dataset
        {
            ds.Clear();
            loadDataIntoDataset();
        }

        public void saveDataIntoDatabase()       //save the change in dataset into the database
        {
            int rowsUpdatedInDB = 0;           //number or rows updated in the db
            if (ds.Tables[0].Rows.Count != 0)       //check the dataset is intitalised already or not
            {

                try
                {
                    
                    
                    DataSet DataSetChanged = ds.GetChanges();
                    if (DataSetChanged == null)
                    {
                        return;
                    }
                    rowsUpdatedInDB = adapter.Update(DataSetChanged);
                    ds.Tables[0].AcceptChanges();
                }
                catch (Exception ex)
                {
                    
                    MessageBox.Show("The new row has been deleted and database reloaded.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            if (rowsUpdatedInDB < 1)          // the database is not updated as expected due to unexpected reasons
            {
                reloadDataIntoDataset();                         //the local copy is not up to date anymore, load it from database again
            }
        }

        public void update_dataGrid()                            //update dataGrid
        {
           

            BindingSource source = new BindingSource { DataSource = ds.Tables[0].DefaultView };
            dataGrid.DataSource = source;
            //dataGrid.Columns["ID"].Visible = false;
            dataGrid.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            dataGrid.RowHeadersVisible = false;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void btnOnFirstFloor_Click(object sender, EventArgs e)
        {
            DisplayWindow.Visible = true;
            WindowDisplay2.Visible = false;
            pictureBox3.Show();
            timer2.Start();
            btnOnFirstFloor.Enabled = false;
            btnOnGroundFloor.Enabled = true;
            btnWall1.Enabled = true;
            btnWall0.Enabled = false;
            starty = pictureBox3.Location.Y;
            InsertData(0);
        }

        private void btnOnGroundFloor_Click(object sender, EventArgs e)
        {

            DisplayWindow.Visible = false;
            WindowDisplay2.Visible = true;
            pictureBox3.Show();
            timer1.Start();
            btnOnGroundFloor.Enabled = false;
            btnOnFirstFloor.Enabled = true;
            btnWall1.Enabled = false;
            btnWall0.Enabled = true;
            starty = pictureBox3.Location.Y;
            InsertData(1);
        }
        int starty = 0;


        public void timer1_Tick(object sender, EventArgs e)
        {
            int x = pictureBox3.Location.X;
            int y = pictureBox3.Location.Y;



            pictureBox3.Location = new Point(x, y - 1);
            if (y < starty - 228)
                timer1.Stop();
            else
            {
                //pictureBox3.Location = new Point(x, y + 120);
            }
        }

        public void timer2_Tick(object sender, EventArgs e)
        {
            int x = pictureBox3.Location.X;
            int y = pictureBox3.Location.Y;

            pictureBox3.Location = new Point(x, y + 1);

            if (y > starty + 228)
                timer2.Stop();
            else
            {
                //pictureBox3.Location = new Point(x, y + 120);
            }
        }


        private void btnDisplayLogs_Click(object sender, EventArgs e)
        {
            saveDataIntoDatabase();
            
            update_dataGrid();

            reloadDataIntoDataset();
        }







        private void btnClearLogs_Click(object sender, EventArgs e)
        {

            foreach (DataGridViewCell oneCell in dataGrid.SelectedCells)
            {
                try
                {
                    if (oneCell.Selected)
                        dataGrid.Rows.RemoveAt(oneCell.RowIndex);
                }
                catch { MessageBox.Show("You cannot delete a clear row.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                }

            saveDataIntoDatabase();

          
            update_dataGrid();
            


        }

        


        private void InsertData(int floorNumber)
        {

            // string date1 = DateTime.Now.ToShortDateString();
            // string time1 = DateTime.Now.ToShortTimeString();
            //Long
            // string time1 = DateTime.Now.ToString(); yyyy-MM-dd



            DataRow nextRow = ds.Tables[0].NewRow();

            nextRow["DateFloor"] = DateTime.Now.ToString("dd-MM-yyyy");
            nextRow["TimeFloor"] = DateTime.Now.ToString("HH:mm:ss"); 
            nextRow["Floor"] = floorNumber;




            //add the new DataRow to DataTable 
            ds.Tables[0].Rows.Add(nextRow);

            //save change to the db
            saveDataIntoDatabase();

            //update listBox1
            update_dataGrid();

            checkBox1.Checked = true;
        }

        private void btnWall1_Click(object sender, EventArgs e)
        {
            DisplayWindow.Visible = false;
            WindowDisplay2.Visible = true;
            pictureBox3.Show();
            timer1.Start();
            btnWall1.Enabled = false;
            btnWall0.Enabled = true;
            btnOnGroundFloor.Enabled = false;
            btnOnFirstFloor.Enabled = true;
            starty = pictureBox3.Location.Y;
            InsertData(1);
        }

        private void btnWall0_Click(object sender, EventArgs e)
        {
            DisplayWindow.Visible = true;
            WindowDisplay2.Visible = false;
            pictureBox3.Show();
            timer2.Start();
            btnWall0.Enabled = false;
            btnWall1.Enabled = true;
            btnOnFirstFloor.Enabled = false;
            btnOnGroundFloor.Enabled = true;
            starty = pictureBox3.Location.Y;
            InsertData(0);
        }
    }
}








