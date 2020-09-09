using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Delegates
{
    public partial class Form1 : Form
    {
        Account account = new Account { balance = 100 };
        private SoftwareProject softwareProject;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            MessageBox.Show("common event handler triggered");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            softwareProject = new SoftwareProject() { name = "Priority Status", status = ReviewStatus.pending };
            softwareProject.addReviewHandler(5, Project_EventHandler);
            softwareProject.addReviewHandler(9, Project_EventHandler);
            softwareProject.addReviewHandler(1, Project_EventHandler);
            textBox2.Text = account.balance.ToString();
            account.Overdrawn += Account_Overdrawn;
        }
        private void Project_EventHandler(SoftwareProject project, ReviewEventArgs args)
        {
            string message = "Priority Review" + args.Priority.ToString();
            switch(MessageBox.Show(message,"Review",MessageBoxButtons.YesNoCancel))
            {
                case DialogResult.Yes:
                    args.Project.status = ReviewStatus.Approved;
                    break;
                case DialogResult.No:
                    args.Project.status = ReviewStatus.rejected;
                    break;
            }

        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            int balance =Convert.ToInt32(textBox1.Text);
            account.balance += balance;
            textBox2.Text = account.balance.ToString();

        }

        private void Account_Overdrawn(Object sender,OverdrawnEventArgs e)
        {
            if (!e.isOverDrawnAllowed)
            {
                e.isOverDrawnAllowed= MessageBox.Show("overdrawn","Allow Overdrawn",MessageBoxButtons.YesNo)==DialogResult.Yes;
            }
        }

        private void btn_review_Click(object sender, EventArgs e)
        {
            softwareProject.OnReviewEvent();
            txtBx_status.Text = softwareProject.status.ToString() ;
        }

        private void btn_process_file_Click(object sender, EventArgs e)
        {
            int count = 0;
            Thread thread = new Thread(() =>
            {
            count = countCharacters();
            Action action = () => lblCount.Text = "characters:" + count.ToString();
            this.BeginInvoke(action);
            });
            thread.Start();
            lblCount.Text = "Please wait for the process";    
        }

        private int countCharacters()
        {
            int count = 0;
            using (StreamReader reader = new StreamReader("c:\\data.txt"))
            {
                string content = reader.ReadToEnd();
                count = content.Length;
                Thread.Sleep(5000);  
            }
            return count;

        }
        Updater updater;
        private void btn_update_Click(object sender, EventArgs e)
        {
            Program.updater = new Updater();
            Program.updater.Show();
            
        }
    }
}
