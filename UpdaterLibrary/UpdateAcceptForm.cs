﻿using System;
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
    internal partial class UpdateAcceptForm : Form
    {
        private IUpdatable applicationInfo;
        private UpdaterXml updateInfo;
        private UpdaterForm updateForm;
        internal UpdateAcceptForm(IUpdatable applicationInfo,UpdaterXml updateInfo)
        {
            InitializeComponent();
            this.applicationInfo = applicationInfo;
            this.updateInfo = updateInfo;
            this.Text = this.applicationInfo.ApplicationName + " - Update Available";
            if (this.applicationInfo.ApplicationIcon != null)
                this.Icon = this.applicationInfo.ApplicationIcon;
            this.lblNewVersion.Text = string.Format("New version:{0}", this.updateInfo._version.ToString());
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Yes;
            this.Close();
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (this.updateForm == null)
                this.updateForm = new UpdaterForm(this.applicationInfo, this.updateInfo);
            this.updateForm.ShowDialog(this);
        }
    }
}
