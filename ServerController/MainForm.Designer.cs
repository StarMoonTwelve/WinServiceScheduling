namespace ServerController
{
    partial class MainForm
    {
        private System.Windows.Forms.ListBox lstTasks;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtServiceName;
        private System.Windows.Forms.TextBox txtHour;
        private System.Windows.Forms.TextBox txtMinute;
        private System.Windows.Forms.TextBox txtSecond;
        private System.Windows.Forms.ComboBox cmbDayOfWeek;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblServiceName;
        private System.Windows.Forms.Label lblHour;
        private System.Windows.Forms.Label lblMinute;
        private System.Windows.Forms.Label lblSecond;
        private System.Windows.Forms.Label lblDayOfWeek;
        private System.Windows.Forms.Label lblLog;

        private void InitializeComponent()
        {
            this.lstTasks = new System.Windows.Forms.ListBox();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtServiceName = new System.Windows.Forms.TextBox();
            this.txtHour = new System.Windows.Forms.TextBox();
            this.txtMinute = new System.Windows.Forms.TextBox();
            this.txtSecond = new System.Windows.Forms.TextBox();
            this.cmbDayOfWeek = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnRead = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.lblServiceName = new System.Windows.Forms.Label();
            this.lblHour = new System.Windows.Forms.Label();
            this.lblMinute = new System.Windows.Forms.Label();
            this.lblSecond = new System.Windows.Forms.Label();
            this.lblDayOfWeek = new System.Windows.Forms.Label();
            this.lblLog = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstTasks
            // 
            this.lstTasks.FormattingEnabled = true;
            this.lstTasks.ItemHeight = 15;
            this.lstTasks.Location = new System.Drawing.Point(20, 215);
            this.lstTasks.Name = "lstTasks";
            this.lstTasks.Size = new System.Drawing.Size(400, 139);
            this.lstTasks.TabIndex = 6;
            // 
            // txtLog
            // 
            this.txtLog.Location = new System.Drawing.Point(20, 386);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ReadOnly = true;
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLog.Size = new System.Drawing.Size(400, 100);
            this.txtLog.TabIndex = 7;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(20, 30);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(200, 25);
            this.txtName.TabIndex = 0;
            // 
            // txtServiceName
            // 
            this.txtServiceName.Location = new System.Drawing.Point(20, 80);
            this.txtServiceName.Name = "txtServiceName";
            this.txtServiceName.Size = new System.Drawing.Size(200, 25);
            this.txtServiceName.TabIndex = 1;
            // 
            // txtHour
            // 
            this.txtHour.Location = new System.Drawing.Point(20, 130);
            this.txtHour.Name = "txtHour";
            this.txtHour.Size = new System.Drawing.Size(60, 25);
            this.txtHour.TabIndex = 2;
            // 
            // txtMinute
            // 
            this.txtMinute.Location = new System.Drawing.Point(90, 130);
            this.txtMinute.Name = "txtMinute";
            this.txtMinute.Size = new System.Drawing.Size(60, 25);
            this.txtMinute.TabIndex = 3;
            // 
            // txtSecond
            // 
            this.txtSecond.Location = new System.Drawing.Point(160, 130);
            this.txtSecond.Name = "txtSecond";
            this.txtSecond.Size = new System.Drawing.Size(60, 25);
            this.txtSecond.TabIndex = 4;
            // 
            // cmbDayOfWeek
            // 
            this.cmbDayOfWeek.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDayOfWeek.FormattingEnabled = true;
            this.cmbDayOfWeek.Items.AddRange(new object[] {
            "Sunday",
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday"});
            this.cmbDayOfWeek.Location = new System.Drawing.Point(20, 180);
            this.cmbDayOfWeek.Name = "cmbDayOfWeek";
            this.cmbDayOfWeek.Size = new System.Drawing.Size(200, 23);
            this.cmbDayOfWeek.TabIndex = 5;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(230, 30);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(230, 60);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(230, 90);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(230, 120);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(75, 23);
            this.btnRead.TabIndex = 11;
            this.btnRead.Text = "Read";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.ReadButton_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(320, 30);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 12;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(320, 60);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 13;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(20, 10);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(39, 15);
            this.lblName.TabIndex = 8;
            this.lblName.Text = "Name";
            // 
            // lblServiceName
            // 
            this.lblServiceName.AutoSize = true;
            this.lblServiceName.Location = new System.Drawing.Point(20, 60);
            this.lblServiceName.Name = "lblServiceName";
            this.lblServiceName.Size = new System.Drawing.Size(103, 15);
            this.lblServiceName.TabIndex = 9;
            this.lblServiceName.Text = "Service Name";
            // 
            // lblHour
            // 
            this.lblHour.AutoSize = true;
            this.lblHour.Location = new System.Drawing.Point(20, 110);
            this.lblHour.Name = "lblHour";
            this.lblHour.Size = new System.Drawing.Size(39, 15);
            this.lblHour.TabIndex = 10;
            this.lblHour.Text = "Hour";
            // 
            // lblMinute
            // 
            this.lblMinute.AutoSize = true;
            this.lblMinute.Location = new System.Drawing.Point(90, 110);
            this.lblMinute.Name = "lblMinute";
            this.lblMinute.Size = new System.Drawing.Size(55, 15);
            this.lblMinute.TabIndex = 11;
            this.lblMinute.Text = "Minute";
            // 
            // lblSecond
            // 
            this.lblSecond.AutoSize = true;
            this.lblSecond.Location = new System.Drawing.Point(160, 110);
            this.lblSecond.Name = "lblSecond";
            this.lblSecond.Size = new System.Drawing.Size(55, 15);
            this.lblSecond.TabIndex = 12;
            this.lblSecond.Text = "Second";
            // 
            // lblDayOfWeek
            // 
            this.lblDayOfWeek.AutoSize = true;
            this.lblDayOfWeek.Location = new System.Drawing.Point(20, 160);
            this.lblDayOfWeek.Name = "lblDayOfWeek";
            this.lblDayOfWeek.Size = new System.Drawing.Size(95, 15);
            this.lblDayOfWeek.TabIndex = 13;
            this.lblDayOfWeek.Text = "Day of Week";
            // 
            // lblLog
            // 
            this.lblLog.AutoSize = true;
            this.lblLog.Location = new System.Drawing.Point(20, 366);
            this.lblLog.Name = "lblLog";
            this.lblLog.Size = new System.Drawing.Size(31, 15);
            this.lblLog.TabIndex = 14;
            this.lblLog.Text = "Log";
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(440, 502);
            this.Controls.Add(this.lblLog);
            this.Controls.Add(this.cmbDayOfWeek);
            this.Controls.Add(this.lblDayOfWeek);
            this.Controls.Add(this.txtSecond);
            this.Controls.Add(this.lblSecond);
            this.Controls.Add(this.txtMinute);
            this.Controls.Add(this.lblMinute);
            this.Controls.Add(this.txtHour);
            this.Controls.Add(this.lblHour);
            this.Controls.Add(this.txtServiceName);
            this.Controls.Add(this.lblServiceName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.lstTasks);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
