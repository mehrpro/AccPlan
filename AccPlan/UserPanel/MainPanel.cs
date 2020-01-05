using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccPlan.UserPanel
{
    public partial class MainPanel : Form
    {
        public MainPanel()
        {
            InitializeComponent();
        }

        private void btnNewPerson_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var frmPersons = new FrmPersons();
            frmPersons.ShowDialog();
        }

        private void btnPayment_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var frmpayment = new FrmPayments();
            frmpayment.ShowDialog();
        }

        private void btnSalary_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var frmSalary = new FrmSalary();
            frmSalary.Show();
        }
    }
}
