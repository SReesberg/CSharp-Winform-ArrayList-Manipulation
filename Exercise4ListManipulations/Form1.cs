using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise4ListManipulations
{
    public partial class MainForm : Form
    {
        ArrayList activities = new ArrayList();
        ArrayList completed = new ArrayList();

        public MainForm()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(tbAddActivity.Text == "" || tbAddActivity.Text == null)
            {
                MessageBox.Show("You cannot insert an empty activity.", "Empty Field!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (activities.Contains(tbAddActivity.Text) || completed.Contains(tbAddActivity.Text) || cLBActivities.Items.Contains(tbAddActivity.Text) || lBCompleted.Items.Contains(tbAddActivity.Text))
            {
                MessageBox.Show("You have an activity like that already!", "Incomplete Activity!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                activities.Add(tbAddActivity.Text);
                cLBActivities.Items.Add(tbAddActivity.Text);

                
            }
            tbAddActivity.Text = "";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            
            foreach (var item in cLBActivities.CheckedItems)
            {
                activities.Remove(item);
                
                completed.Add(item);                
            }

            cLBActivities.Items.Clear();

            foreach (var item in completed)
            {
                if (lBCompleted.Items.Contains(item))
                {                    
                    
                }
                else
                {
                    lBCompleted.Items.Add(item);
                }
            }

            foreach (var item in activities)
            {
                cLBActivities.Items.Add(item);
            }


        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            completed.Clear();
            lBCompleted.Items.Clear();

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
