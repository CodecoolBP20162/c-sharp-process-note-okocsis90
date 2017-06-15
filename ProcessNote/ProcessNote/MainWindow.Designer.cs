namespace ProcessNote
{
    partial class MainWindow
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
            this.components = new System.ComponentModel.Container();
            this.processGrid = new System.Windows.Forms.DataGridView();
            this.procId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.procName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxComment = new System.Windows.Forms.TextBox();
            this.saveComment = new System.Windows.Forms.Button();
            this.mem = new System.Windows.Forms.Label();
            this.cpu = new System.Windows.Forms.Label();
            this.startTime = new System.Windows.Forms.Label();
            this.labelMem = new System.Windows.Forms.Label();
            this.labelCpu = new System.Windows.Forms.Label();
            this.labelStartTime = new System.Windows.Forms.Label();
            this.labelElapsedTime = new System.Windows.Forms.Label();
            this.elapsedTime = new System.Windows.Forms.Label();
            this.main = new System.Windows.Forms.TabControl();
            this.processes = new System.Windows.Forms.TabPage();
            this.comment = new System.Windows.Forms.TabPage();
            this.commentGrid = new System.Windows.Forms.DataGridView();
            this.commentProcId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commentDisplayed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.onTop = new System.Windows.Forms.Button();
            this.hide = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.processGrid)).BeginInit();
            this.main.SuspendLayout();
            this.processes.SuspendLayout();
            this.comment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.commentGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // processGrid
            // 
            this.processGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.processGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.procId,
            this.procName});
            this.processGrid.Location = new System.Drawing.Point(3, 3);
            this.processGrid.Name = "processGrid";
            this.processGrid.Size = new System.Drawing.Size(246, 434);
            this.processGrid.TabIndex = 1;
            // 
            // procId
            // 
            this.procId.HeaderText = "Process ID";
            this.procId.Name = "procId";
            // 
            // procName
            // 
            this.procName.HeaderText = "Process Name";
            this.procName.Name = "procName";
            // 
            // textBoxComment
            // 
            this.textBoxComment.Location = new System.Drawing.Point(258, 6);
            this.textBoxComment.Multiline = true;
            this.textBoxComment.Name = "textBoxComment";
            this.textBoxComment.Size = new System.Drawing.Size(322, 70);
            this.textBoxComment.TabIndex = 2;
            // 
            // saveComment
            // 
            this.saveComment.Location = new System.Drawing.Point(505, 92);
            this.saveComment.Name = "saveComment";
            this.saveComment.Size = new System.Drawing.Size(75, 23);
            this.saveComment.TabIndex = 3;
            this.saveComment.Text = "Save Comment";
            this.saveComment.UseVisualStyleBackColor = true;
            this.saveComment.Click += new System.EventHandler(this.SaveComment_Click);
            // 
            // mem
            // 
            this.mem.AutoSize = true;
            this.mem.Location = new System.Drawing.Point(255, 159);
            this.mem.Name = "mem";
            this.mem.Size = new System.Drawing.Size(10, 13);
            this.mem.TabIndex = 4;
            this.mem.Text = "-";
            // 
            // cpu
            // 
            this.cpu.AutoSize = true;
            this.cpu.Location = new System.Drawing.Point(373, 159);
            this.cpu.Name = "cpu";
            this.cpu.Size = new System.Drawing.Size(10, 13);
            this.cpu.TabIndex = 5;
            this.cpu.Text = "-";
            // 
            // startTime
            // 
            this.startTime.AutoSize = true;
            this.startTime.Location = new System.Drawing.Point(459, 159);
            this.startTime.Name = "startTime";
            this.startTime.Size = new System.Drawing.Size(10, 13);
            this.startTime.TabIndex = 6;
            this.startTime.Text = "-";
            // 
            // labelMem
            // 
            this.labelMem.AutoSize = true;
            this.labelMem.Location = new System.Drawing.Point(255, 130);
            this.labelMem.Name = "labelMem";
            this.labelMem.Size = new System.Drawing.Size(81, 13);
            this.labelMem.TabIndex = 7;
            this.labelMem.Text = "Memory Usage:";
            // 
            // labelCpu
            // 
            this.labelCpu.AutoSize = true;
            this.labelCpu.Location = new System.Drawing.Point(373, 130);
            this.labelCpu.Name = "labelCpu";
            this.labelCpu.Size = new System.Drawing.Size(32, 13);
            this.labelCpu.TabIndex = 8;
            this.labelCpu.Text = "CPU:";
            // 
            // labelStartTime
            // 
            this.labelStartTime.AutoSize = true;
            this.labelStartTime.Location = new System.Drawing.Point(459, 130);
            this.labelStartTime.Name = "labelStartTime";
            this.labelStartTime.Size = new System.Drawing.Size(58, 13);
            this.labelStartTime.TabIndex = 9;
            this.labelStartTime.Text = "Start Time:";
            // 
            // labelElapsedTime
            // 
            this.labelElapsedTime.AutoSize = true;
            this.labelElapsedTime.Location = new System.Drawing.Point(255, 212);
            this.labelElapsedTime.Name = "labelElapsedTime";
            this.labelElapsedTime.Size = new System.Drawing.Size(74, 13);
            this.labelElapsedTime.TabIndex = 10;
            this.labelElapsedTime.Text = "Elapsed Time:";
            // 
            // elapsedTime
            // 
            this.elapsedTime.AutoSize = true;
            this.elapsedTime.Location = new System.Drawing.Point(255, 244);
            this.elapsedTime.Name = "elapsedTime";
            this.elapsedTime.Size = new System.Drawing.Size(10, 13);
            this.elapsedTime.TabIndex = 11;
            this.elapsedTime.Text = "-";
            // 
            // main
            // 
            this.main.Controls.Add(this.processes);
            this.main.Controls.Add(this.comment);
            this.main.Location = new System.Drawing.Point(12, 12);
            this.main.Name = "main";
            this.main.SelectedIndex = 0;
            this.main.Size = new System.Drawing.Size(596, 469);
            this.main.TabIndex = 12;
            // 
            // processes
            // 
            this.processes.Controls.Add(this.processGrid);
            this.processes.Controls.Add(this.textBoxComment);
            this.processes.Controls.Add(this.labelElapsedTime);
            this.processes.Controls.Add(this.elapsedTime);
            this.processes.Controls.Add(this.saveComment);
            this.processes.Controls.Add(this.labelMem);
            this.processes.Controls.Add(this.startTime);
            this.processes.Controls.Add(this.labelStartTime);
            this.processes.Controls.Add(this.mem);
            this.processes.Controls.Add(this.labelCpu);
            this.processes.Controls.Add(this.cpu);
            this.processes.Location = new System.Drawing.Point(4, 22);
            this.processes.Name = "processes";
            this.processes.Padding = new System.Windows.Forms.Padding(3);
            this.processes.Size = new System.Drawing.Size(588, 443);
            this.processes.TabIndex = 0;
            this.processes.Text = "Processes";
            this.processes.UseVisualStyleBackColor = true;
            // 
            // comment
            // 
            this.comment.Controls.Add(this.commentGrid);
            this.comment.Location = new System.Drawing.Point(4, 22);
            this.comment.Name = "comment";
            this.comment.Padding = new System.Windows.Forms.Padding(3);
            this.comment.Size = new System.Drawing.Size(588, 443);
            this.comment.TabIndex = 1;
            this.comment.Text = "Comments";
            this.comment.UseVisualStyleBackColor = true;
            // 
            // commentGrid
            // 
            this.commentGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.commentGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.commentProcId,
            this.commentDisplayed});
            this.commentGrid.Location = new System.Drawing.Point(8, 3);
            this.commentGrid.Name = "commentGrid";
            this.commentGrid.Size = new System.Drawing.Size(576, 431);
            this.commentGrid.TabIndex = 0;
            // 
            // commentProcId
            // 
            this.commentProcId.HeaderText = "ID ";
            this.commentProcId.Name = "commentProcId";
            // 
            // commentDisplayed
            // 
            this.commentDisplayed.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.commentDisplayed.HeaderText = "Comment ";
            this.commentDisplayed.Name = "commentDisplayed";
            // 
            // onTop
            // 
            this.onTop.Location = new System.Drawing.Point(392, 6);
            this.onTop.Name = "onTop";
            this.onTop.Size = new System.Drawing.Size(107, 22);
            this.onTop.TabIndex = 13;
            this.onTop.Text = "Always on top";
            this.onTop.UseVisualStyleBackColor = true;
            this.onTop.Click += new System.EventHandler(this.OnTop_Click);
            // 
            // hide
            // 
            this.hide.Location = new System.Drawing.Point(506, 6);
            this.hide.Name = "hide";
            this.hide.Size = new System.Drawing.Size(102, 21);
            this.hide.TabIndex = 14;
            this.hide.Text = "Hide";
            this.hide.UseVisualStyleBackColor = true;
            this.hide.Click += new System.EventHandler(this.Hide_Click);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 490);
            this.Controls.Add(this.hide);
            this.Controls.Add(this.onTop);
            this.Controls.Add(this.main);
            this.Name = "MainWindow";
            this.Text = "ProcessNote 2000";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.Load += new System.EventHandler(this.MainWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.processGrid)).EndInit();
            this.main.ResumeLayout(false);
            this.processes.ResumeLayout(false);
            this.processes.PerformLayout();
            this.comment.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.commentGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView processGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn procId;
        private System.Windows.Forms.DataGridViewTextBoxColumn procName;
        private System.Windows.Forms.TextBox textBoxComment;
        private System.Windows.Forms.Button saveComment;
        private System.Windows.Forms.Label mem;
        private System.Windows.Forms.Label cpu;
        private System.Windows.Forms.Label startTime;
        private System.Windows.Forms.Label labelMem;
        private System.Windows.Forms.Label labelCpu;
        private System.Windows.Forms.Label labelStartTime;
        private System.Windows.Forms.Label labelElapsedTime;
        private System.Windows.Forms.Label elapsedTime;
        private System.Windows.Forms.TabControl main;
        private System.Windows.Forms.TabPage processes;
        private System.Windows.Forms.TabPage comment;
        private System.Windows.Forms.DataGridView commentGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn commentProcId;
        private System.Windows.Forms.DataGridViewTextBoxColumn commentDisplayed;
        private System.Windows.Forms.Button onTop;
        private System.Windows.Forms.Button hide;
        private System.Windows.Forms.Timer timer;
    }
}

