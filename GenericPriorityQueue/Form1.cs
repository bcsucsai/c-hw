using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GenericPriorityQueueDemo
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dequeueButton.Enabled = false;
        }

        // created object as a field variable
        private PriorityQueue<string> myPriorityQueue = new PriorityQueue<string>();

        private void enqueueButton_Click(object sender, EventArgs e)
        {
            int qValue = 0;
            string taskValue = "";

            // validation
            if (int.TryParse(priorityTextBox.Text, out qValue))
            {
                // success !
            }
            else
            {
                MessageBox.Show("Must enter a valid priority");
                return;
            }

            if (taskTextBox.Text == "")
            {
                MessageBox.Show("Must enter a valid task value");
                return;
            }
            else
            {
                // success !
                taskValue = taskTextBox.Text;
            }

            // send items to your list
            if (myPriorityQueue.Enqueue(taskValue, qValue))
            {
                enqueuedItemsListBox.Items.Add(taskValue);
            }
            else
            {
                // if it doesnt work
                MessageBox.Show("Failed to add to que; check for duplicate priorities.");
            }

            // check to see there are items in our list box
            // if so, enable the dequeu button
            if (enqueuedItemsListBox.Items.Count > 0)
            {
                dequeueButton.Enabled = true;
            }
            else
            {
                dequeueButton.Enabled = false;
            }
        }


        private void dequeueButton_Click(object sender, EventArgs e)
        {
            int priorityDequeued = 0;
            string valueDequeued = "";

            if (myPriorityQueue.Dequeue(ref valueDequeued, ref priorityDequeued))
            {
                
                dequeuedItemsListBox.Items.Add(valueDequeued);

                for (int i = enqueuedItemsListBox.Items.Count - 1; i >= 0; --i)
                {
                    if (enqueuedItemsListBox.Items[i].ToString().Contains(valueDequeued))
                    {
                        enqueuedItemsListBox.Items.RemoveAt(i);
                    }
                }
            }
            else
            {
                // if it doesnt work
                MessageBox.Show("Failed to dequeu; check that there are items in queu.");
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            /// clear everything
            myPriorityQueue.Clear();
            enqueuedItemsListBox.Items.Clear();
            dequeuedItemsListBox.Items.Clear();
            priorityTextBox.Text = "";
            taskTextBox.Text = "";
            dequeueButton.Enabled = false;


        }

    }
}
