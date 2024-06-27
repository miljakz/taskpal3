namespace TaskPalApp
{
    partial class TaskForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.CheckBox chkIsCompleted;
        private System.Windows.Forms.DateTimePicker dtpDueDate;
        private System.Windows.Forms.NumericUpDown numPriority;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.chkIsCompleted = new System.Windows.Forms.CheckBox();
            this.dtpDueDate = new System.Windows.Forms.DateTimePicker();
            this.numPriority = new System.Windows.Forms.NumericUpDown();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numPriority)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(12, 12);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(260, 20);
            this.txtTitle.TabIndex = 0;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(12, 38);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(260, 60);
            this.txtDescription.TabIndex = 1;
            // 
            // chkIsCompleted
            // 
            this.chkIsCompleted.AutoSize = true;
            this.chkIsCompleted.Location = new System.Drawing.Point(12, 104);
            this.chkIsCompleted.Name = "chkIsCompleted";
            this.chkIsCompleted.Size = new System.Drawing.Size(87, 17);
            this.chkIsCompleted.TabIndex = 2;
            this.chkIsCompleted.Text = "Is Completed";
            this.chkIsCompleted.UseVisualStyleBackColor = true;
            // 
            // dtpDueDate
            // 
            this.dtpDueDate.Location = new System.Drawing.Point(12, 153);
            this.dtpDueDate.Name = "dtpDueDate";
            this.dtpDueDate.Size = new System.Drawing.Size(200, 20);
            this.dtpDueDate.TabIndex = 3;
            // 
            // numPriority
            // 
            this.numPriority.Location = new System.Drawing.Point(12, 127);
            this.numPriority.Name = "numPriority";
            this.numPriority.Size = new System.Drawing.Size(120, 20);
            this.numPriority.TabIndex = 4;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(116, 179);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 5;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(197, 179);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // TaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 211);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.numPriority);
            this.Controls.Add(this.dtpDueDate);
            this.Controls.Add(this.chkIsCompleted);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtTitle);
            this.Name = "TaskForm";
            this.Text = "TaskForm";
            ((System.ComponentModel.ISupportInitialize)(this.numPriority)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
