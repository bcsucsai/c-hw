namespace GenericPriorityQueueDemo
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.taskTextBox = new System.Windows.Forms.TextBox();
            this.priorityTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.enqueueButton = new System.Windows.Forms.Button();
            this.dequeueButton = new System.Windows.Forms.Button();
            this.priorityQueueCountLabel = new System.Windows.Forms.Label();
            this.dequeuedItemsListBox = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.resetButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.enqueuedItemsListBox = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // taskTextBox
            // 
            this.taskTextBox.Location = new System.Drawing.Point(99, 23);
            this.taskTextBox.Name = "taskTextBox";
            this.taskTextBox.Size = new System.Drawing.Size(100, 20);
            this.taskTextBox.TabIndex = 0;
            // 
            // priorityTextBox
            // 
            this.priorityTextBox.Location = new System.Drawing.Point(99, 55);
            this.priorityTextBox.Name = "priorityTextBox";
            this.priorityTextBox.Size = new System.Drawing.Size(100, 20);
            this.priorityTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter Task:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Enter Priority:";
            // 
            // enqueueButton
            // 
            this.enqueueButton.Location = new System.Drawing.Point(226, 18);
            this.enqueueButton.Name = "enqueueButton";
            this.enqueueButton.Size = new System.Drawing.Size(75, 23);
            this.enqueueButton.TabIndex = 4;
            this.enqueueButton.Text = "Enqueue";
            this.enqueueButton.UseVisualStyleBackColor = true;
            this.enqueueButton.Click += new System.EventHandler(this.enqueueButton_Click);
            // 
            // dequeueButton
            // 
            this.dequeueButton.Location = new System.Drawing.Point(226, 54);
            this.dequeueButton.Name = "dequeueButton";
            this.dequeueButton.Size = new System.Drawing.Size(75, 23);
            this.dequeueButton.TabIndex = 5;
            this.dequeueButton.Text = "Dequeue";
            this.dequeueButton.UseVisualStyleBackColor = true;
            this.dequeueButton.Click += new System.EventHandler(this.dequeueButton_Click);
            // 
            // priorityQueueCountLabel
            // 
            this.priorityQueueCountLabel.AutoSize = true;
            this.priorityQueueCountLabel.Location = new System.Drawing.Point(19, 92);
            this.priorityQueueCountLabel.Name = "priorityQueueCountLabel";
            this.priorityQueueCountLabel.Size = new System.Drawing.Size(35, 13);
            this.priorityQueueCountLabel.TabIndex = 6;
            this.priorityQueueCountLabel.Text = "label3";
            // 
            // dequeuedItemsListBox
            // 
            this.dequeuedItemsListBox.Enabled = false;
            this.dequeuedItemsListBox.FormattingEnabled = true;
            this.dequeuedItemsListBox.Location = new System.Drawing.Point(192, 142);
            this.dequeuedItemsListBox.Name = "dequeuedItemsListBox";
            this.dequeuedItemsListBox.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.dequeuedItemsListBox.Size = new System.Drawing.Size(145, 95);
            this.dequeuedItemsListBox.TabIndex = 7;
            this.dequeuedItemsListBox.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(194, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Dequeued Items:";
            // 
            // resetButton
            // 
            this.resetButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.resetButton.Location = new System.Drawing.Point(226, 89);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(75, 23);
            this.resetButton.TabIndex = 9;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Enqueued Items:";
            // 
            // enqueuedItemsListBox
            // 
            this.enqueuedItemsListBox.Enabled = false;
            this.enqueuedItemsListBox.FormattingEnabled = true;
            this.enqueuedItemsListBox.Location = new System.Drawing.Point(22, 142);
            this.enqueuedItemsListBox.Name = "enqueuedItemsListBox";
            this.enqueuedItemsListBox.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.enqueuedItemsListBox.Size = new System.Drawing.Size(145, 95);
            this.enqueuedItemsListBox.TabIndex = 10;
            this.enqueuedItemsListBox.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(109, 246);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 12;
            // 
            // Form1
            // 
            this.AcceptButton = this.enqueueButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.resetButton;
            this.ClientSize = new System.Drawing.Size(361, 267);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.enqueuedItemsListBox);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dequeuedItemsListBox);
            this.Controls.Add(this.priorityQueueCountLabel);
            this.Controls.Add(this.dequeueButton);
            this.Controls.Add(this.enqueueButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.priorityTextBox);
            this.Controls.Add(this.taskTextBox);
            this.Name = "Form1";
            this.Text = "Generic Priority Queue Demo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox taskTextBox;
        private System.Windows.Forms.TextBox priorityTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button enqueueButton;
        private System.Windows.Forms.Button dequeueButton;
        private System.Windows.Forms.Label priorityQueueCountLabel;
        private System.Windows.Forms.ListBox dequeuedItemsListBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox enqueuedItemsListBox;
        private System.Windows.Forms.Label label5;
    }
}

