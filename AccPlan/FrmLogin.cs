using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AccPlan.UserPanel;

namespace AccPlan
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
            DateTimeNow();

        }

        private void txtUsername_Enter(object sender, EventArgs e)
        {
            txtUsername.SelectAll();
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            txtPassword.SelectAll();
        }

        private void DateTimeNow()
        {
            PersianCalendar persianCalendar = new PersianCalendar();
            StringBuilder builder = new StringBuilder();
            builder.Append(persianCalendar.GetYear(DateTime.Now).ToString());
            builder.Append("/");
            builder.Append(persianCalendar.GetMonth(DateTime.Now).ToString());
            builder.Append("/");
            builder.Append(persianCalendar.GetDayOfMonth(DateTime.Now).ToString());
            lblData.Text = builder.ToString();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            UserPanel.MainPanel mainPanel = new MainPanel()
            {
                StartPosition = FormStartPosition.CenterScreen,
            };
            mainPanel.ShowDialog();
        }
    }
}
