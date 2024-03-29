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
    public partial class ViewUser : Form
    {
        public ViewUser()
        {
            InitializeComponent();
        }

        private void ViewUser_Load(object sender, EventArgs e)
        {
            LoadViewUser();
        }

        public void LoadViewUser()
        {
            dataGridView1.Rows.Clear();
            foreach (UserData Ud in ApplicationDB.userDatas)
            {
                dataGridView1.Rows.Add(
                  Ud.Firstname,
                  Ud.Lastname,
                  Ud.Email,
                  Ud.Password,
                  Ud.IsAdmin
                );

            }
        }
    }
}