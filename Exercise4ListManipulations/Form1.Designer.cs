
namespace Exercise4ListManipulations
{
    partial class MainForm
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
            this.SearchGB = new System.Windows.Forms.GroupBox();
            this.ActivitiesGB = new System.Windows.Forms.GroupBox();
            this.CompletedGB = new System.Windows.Forms.GroupBox();
            this.tbAddActivity = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.cLBActivities = new System.Windows.Forms.CheckedListBox();
            this.lBCompleted = new System.Windows.Forms.ListBox();
            this.SearchGB.SuspendLayout();
            this.ActivitiesGB.SuspendLayout();
            this.CompletedGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // SearchGB
            // 
            this.SearchGB.Controls.Add(this.btnAdd);
            this.SearchGB.Controls.Add(this.tbAddActivity);
            this.SearchGB.ForeColor = System.Drawing.SystemColors.Highlight;
            this.SearchGB.Location = new System.Drawing.Point(12, 24);
            this.SearchGB.Name = "SearchGB";
            this.SearchGB.Size = new System.Drawing.Size(618, 100);
            this.SearchGB.TabIndex = 0;
            this.SearchGB.TabStop = false;
            this.SearchGB.Text = "Add an activity";
            // 
            // ActivitiesGB
            // 
            this.ActivitiesGB.Controls.Add(this.cLBActivities);
            this.ActivitiesGB.Controls.Add(this.btnUpdate);
            this.ActivitiesGB.ForeColor = System.Drawing.SystemColors.Highlight;
            this.ActivitiesGB.Location = new System.Drawing.Point(12, 179);
            this.ActivitiesGB.Name = "ActivitiesGB";
            this.ActivitiesGB.Size = new System.Drawing.Size(363, 836);
            this.ActivitiesGB.TabIndex = 1;
            this.ActivitiesGB.TabStop = false;
            this.ActivitiesGB.Text = "Activities";
            // 
            // CompletedGB
            // 
            this.CompletedGB.Controls.Add(this.lBCompleted);
            this.CompletedGB.Controls.Add(this.btnClear);
            this.CompletedGB.ForeColor = System.Drawing.SystemColors.Highlight;
            this.CompletedGB.Location = new System.Drawing.Point(381, 179);
            this.CompletedGB.Name = "CompletedGB";
            this.CompletedGB.Size = new System.Drawing.Size(384, 836);
            this.CompletedGB.TabIndex = 1;
            this.CompletedGB.TabStop = false;
            this.CompletedGB.Text = "Completed Activities";
            // 
            // tbAddActivity
            // 
            this.tbAddActivity.Location = new System.Drawing.Point(20, 43);
            this.tbAddActivity.Name = "tbAddActivity";
            this.tbAddActivity.Size = new System.Drawing.Size(437, 31);
            this.tbAddActivity.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAdd.Location = new System.Drawing.Point(463, 41);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(131, 42);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnUpdate.Location = new System.Drawing.Point(122, 784);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(131, 46);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnClear
            // 
            this.btnClear.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnClear.Location = new System.Drawing.Point(118, 784);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(131, 46);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // cLBActivities
            // 
            this.cLBActivities.FormattingEnabled = true;
            this.cLBActivities.Location = new System.Drawing.Point(6, 30);
            this.cLBActivities.Name = "cLBActivities";
            this.cLBActivities.Size = new System.Drawing.Size(351, 732);
            this.cLBActivities.TabIndex = 3;
            // 
            // lBCompleted
            // 
            this.lBCompleted.FormattingEnabled = true;
            this.lBCompleted.ItemHeight = 25;
            this.lBCompleted.Location = new System.Drawing.Point(7, 30);
            this.lBCompleted.Name = "lBCompleted";
            this.lBCompleted.Size = new System.Drawing.Size(371, 729);
            this.lBCompleted.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 1059);
            this.Controls.Add(this.ActivitiesGB);
            this.Controls.Add(this.CompletedGB);
            this.Controls.Add(this.SearchGB);
            this.Name = "MainForm";
            this.Text = "Activity List";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.SearchGB.ResumeLayout(false);
            this.SearchGB.PerformLayout();
            this.ActivitiesGB.ResumeLayout(false);
            this.CompletedGB.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox SearchGB;
        private System.Windows.Forms.GroupBox ActivitiesGB;
        private System.Windows.Forms.GroupBox CompletedGB;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox tbAddActivity;
        private System.Windows.Forms.CheckedListBox cLBActivities;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ListBox lBCompleted;
    }
}

