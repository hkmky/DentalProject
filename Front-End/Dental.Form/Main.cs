using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Dental.Core.Functions;
using Dental.Form.Patient;

namespace Dental.Form
{
    public partial class Main : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Main()
        {
            InitializeComponent();
            if (!ConnectionStringInfo.Check())
            {
                SetupConnectionForm form = new SetupConnectionForm();
                form.ShowDialog();
            }
        }

        private void btnPatient_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            PatientForm form = new PatientForm {MdiParent = this};
            form.Show();
        }
    }
}
