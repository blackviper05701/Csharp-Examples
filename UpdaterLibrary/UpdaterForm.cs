using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UpdaterLibrary
{
    partial class UpdaterForm : Form
    {
        public UpdaterForm(IUpdatable applicationInfo, UpdaterXml updateInfo)
        {
            InitializeComponent();
            if (applicationInfo.ApplicationIcon != null)
                this.Icon = applicationInfo.ApplicationIcon;
            this.Text = applicationInfo.ApplicationName + "- Update Info";
            this.lblVersions.Text = String.Format("Current version: {0}\nUpdate version:{1}", applicationInfo.ApplicationAssembly.GetName().Version.ToString(), updateInfo._version.ToString());
            this.rtxtbxDescription.Text = updateInfo._description;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rtxtbxDescription_KeyDown(object sender, KeyEventArgs e)
        {
            if (!(e.Control && e.KeyCode == Keys.C))
                e.SuppressKeyPress = true;
        }
    }
}
