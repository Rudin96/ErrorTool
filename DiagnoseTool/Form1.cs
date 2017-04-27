using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiagnoseTool
{
    public partial class Form1 : Form
    {
        public string SQLEngineIsRunning { get; private set; }
        public string ReportServerServiceIsRunning { get; private set; }
        public string SQLAgentIsRunning { get; private set; }
        public string TeamViewerIsRunning { get; private set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
            progressBar1.Visible = true;
            progressBar1.Style = ProgressBarStyle.Marquee;
            groupBox1.Visible = true;

            backgroundWorker1.RunWorkerAsync();
            label7.Text = "0" + "%";
            label7.Visible = true;
        }

        private void progressBar1_VisibleChanged(object sender, EventArgs e)
        {
           
        }

        

        

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
            label7.Text = (e.ProgressPercentage.ToString() + "%");
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            SQLEngineIsRunning = SQLEngineService.Status.ToString();
            backgroundWorker1.ReportProgress(20);
            ReportServerServiceIsRunning = ReportServerService.Status.ToString();
            backgroundWorker1.ReportProgress(40);
            SQLAgentIsRunning = SQLServerAgentService.Status.ToString();
            backgroundWorker1.ReportProgress(60);
            TeamViewerIsRunning = TeamViewerService.Status.ToString();
            backgroundWorker1.ReportProgress(100);

            //label3.Text = "Test";
            //label4.Text = "Test";
            //label5.Text = "Test";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            backgroundWorker1.CancelAsync();
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            
            label4.Text = SQLEngineIsRunning;
            label3.Text = ReportServerServiceIsRunning;
            label5.Text = SQLAgentIsRunning;
            label8.Text = TeamViewerIsRunning;
            progressBar1.Style = ProgressBarStyle.Blocks;
            
        }
    }
}
