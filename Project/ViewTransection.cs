using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class ViewTransection : Form
    {
        public ViewTransection()
        {
            InitializeComponent();
        }

        private void ViewTransection_Load(object sender, EventArgs e)
        {
            LoadTransection();
        }
        public void LoadTransection()
        {
            dataGridView1.Rows.Clear();
            foreach (TransectionDetails Td in ApplicationDB.transectionDetails)
            {
                dataGridView1.Rows.Add(
                   Td.TransectionID,
                   Td.UserID,
                   Td.CarNo,
                   Td.LotID,
                   Td.StartingTime,
                   Td.EndingTime,
                   Td.Date,
                   Td.Fees
                );

            }
        }
    }
}