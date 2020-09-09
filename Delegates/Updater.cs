using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutoUpdater;

namespace Delegates
{
    public partial class Updater : Form, IUpdatable
    {
        public Updater()
        {
            InitializeComponent();
        }

        public string ApplicationName
        {
            get { return "Delegates Application"; }
        }
        public string ApplicationID
        {
            get { return "Delegates Application"; }
        }
        public Assembly ApplicationAssembly
        {
            get { return Assembly.GetExecutingAssembly(); }
        }

        public Icon ApplicationIcon
        {
            get { return this.Icon; }
        }

        public Uri UpdateXmlLocation
        {
            get { return new Uri(""); }
        }

        public Form Context
        {
            get { return this; }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {

        }

        private void Updater_Load(object sender, EventArgs e)
        {
            lblVersion.Text = this.ApplicationAssembly.GetName().Version.ToString();
        }
    }
}
