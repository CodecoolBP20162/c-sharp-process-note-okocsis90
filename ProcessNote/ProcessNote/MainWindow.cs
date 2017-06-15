using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Text;
using System.Windows.Forms;


namespace ProcessNote
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private Process[] allProcess;
        private List<String> comments = new List<string>();

        private void GetAllProcess()
        {
            allProcess = Process.GetProcesses();
            processGrid.Rows.Clear();
            foreach (var p in allProcess)
            {
                processGrid.Rows.Add(p.Id, p.ProcessName);
            }
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            GetAllProcess();
        }

        private void SetTimes(Process clickedProcess)
        {
            try
            {
                startTime.Text = clickedProcess.StartTime.ToString();
                elapsedTime.Text = (DateTime.UtcNow - clickedProcess.StartTime.ToUniversalTime()).ToString();
            }
            catch (Win32Exception exception)
            {
                startTime.Text = "N/A";
                elapsedTime.Text = "N/A";
            }
        }

        private int GetSelectedProcId()
        {
            int indexOfCurrentRow = processGrid.CurrentRow.Index;
            return (int)processGrid.Rows[indexOfCurrentRow].Cells["procId"].Value;
        }

        private void SetCpuInfo(string procName)
        {
            PerformanceCounter currentAppCPU = new PerformanceCounter("Process", "ID Process", procName, true);
            cpu.Text = (currentAppCPU.NextValue() / Environment.ProcessorCount).ToString();
        }
        
        private void ProcessGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedProcId = GetSelectedProcId();
            Process clickedProcess = Process.GetProcessById(selectedProcId);

            // Change Label fields for every Data
            mem.Text = clickedProcess.WorkingSet64.ToString();
            SetCpuInfo(clickedProcess.ProcessName);
            SetTimes(clickedProcess);
        }

        private void SaveComment_Click(object sender, EventArgs e)
        {
            int selectedProcId = GetSelectedProcId();

            StringBuilder commentStr = new StringBuilder();
            commentStr.Append("Comment: " + textBoxComment.Text);
            commentStr.Append("; Process Id: " + selectedProcId);
            comments.Add(commentStr.ToString());
            commentGrid.Rows.Add(selectedProcId, textBoxComment.Text);
            textBoxComment.Clear();
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (textBoxComment.Text.Length > 0)
            {
                MessageBox.Show("Please save before Exit!");
                e.Cancel = true;
            }

        }

        private void OnTop_Click(object sender, EventArgs e)
        {
            TopMost = true;
        }

        private void Hide_Click(object sender, EventArgs e)
        {
            TopMost = false;
        }
    }
}
