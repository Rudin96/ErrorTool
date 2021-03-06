﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace DiagnoseTool
{
    public partial class Form1 : Form
    {
        public string SQLEngineIsRunning { get; private set; }
        public string ReportServerServiceIsRunning { get; private set; }
        public string SQLAgentIsRunning { get; private set; }
        public string TeamViewerIsRunning { get; private set; }
        public string AudioServiceIsRunning { get; private set; }
        public int BGWorkerProgress { get; private set; }
        public string AccessInstalledText { get; private set; }
        public string PengvinInstalledText { get; private set; }
        public string ODBCInstalledText { get; private set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
            progressBar1.Visible = true;
            //progressBar1.Style = ProgressBarStyle.Marquee;
            groupBox1.Visible = true;

            backgroundWorker1.RunWorkerAsync();
            backgroundWorker2.RunWorkerAsync();
            backgroundWorker3.RunWorkerAsync();
            backgroundWorker4.RunWorkerAsync();
            backgroundWorker5.RunWorkerAsync();
            backgroundWorker6.RunWorkerAsync();
            backgroundWorker7.RunWorkerAsync();
            backgroundWorker8.RunWorkerAsync();
            label7.Text = "0" + "%";
            label7.Visible = true;
        }

        private void progressBar1_VisibleChanged(object sender, EventArgs e)
        {
           
        }

        

        

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            //progressBar1.Value = e.ProgressPercentage;
            //label7.Text = (e.ProgressPercentage.ToString() + "%");
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            SQLEngineIsRunning = SQLEngineService.Status.ToString();
            //backgroundWorker1.ReportProgress(BGWorkerProgress + 20);
            
            
            

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

            if (SQLEngineIsRunning == "Running")
            {

                label4.Text = "Körs";

            }
            else
            {

                label4.Text = "Stoppad";
                SQLEngineButton.Visible = true;

            }


            progressBar1.Step = (100 / 8);
            progressBar1.PerformStep();
            label7.Text = progressBar1.Value.ToString() + "%";



            //progressBar1.Style = ProgressBarStyle.Blocks;

        }

        private void backgroundWorker4_DoWork(object sender, DoWorkEventArgs e)
        {
            ReportServerServiceIsRunning = ReportServerService.Status.ToString();
            
        }

        private void backgroundWorker3_DoWork(object sender, DoWorkEventArgs e)
        {
            SQLAgentIsRunning = SQLServerAgentService.Status.ToString();
           
        }

        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {
            TeamViewerIsRunning = TeamViewerService.Status.ToString();
            
        }

        private void backgroundWorker5_DoWork(object sender, DoWorkEventArgs e)
        {
            AudioServiceIsRunning = AudioService.Status.ToString();
            
        }

        private void backgroundWorker5_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (AudioServiceIsRunning == "Running")
            {

                label10.Text = "Körs";

            }
            else
            {

                label10.Text = "Stoppad";
                IISButton.Visible = true;

            }

            progressBar1.Step = (100 / 8);
            progressBar1.PerformStep();
            label7.Text = progressBar1.Value.ToString() + "%";
        }

        private void backgroundWorker4_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (ReportServerServiceIsRunning == "Running")
            {

                label3.Text = "Körs";

            }
            else
            {

                label3.Text = "Stoppad";
                ReportServerButton.Visible = true;

            }

            progressBar1.Step = (100 / 8);
            progressBar1.PerformStep();
            label7.Text = progressBar1.Value.ToString() + "%";
        }

        private void backgroundWorker3_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (SQLAgentIsRunning == "Running")
            {

                label5.Text = "Körs";

            }
            else
            {

                label5.Text = "Stoppad";
                SQLServerAgentButton.Visible = true;

            }

            progressBar1.Step = (100 / 8);
            progressBar1.PerformStep();
            label7.Text = progressBar1.Value.ToString() + "%";
        }

        private void backgroundWorker2_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (TeamViewerIsRunning == "Running")
            {

                label8.Text = "Körs";

            } else
            {
                TeamViewerButton.Visible = true;
                label8.Text = "Stoppad";

            }

            
            progressBar1.Step = (100 / 8);
            progressBar1.PerformStep();
            label7.Text = progressBar1.Value.ToString() + "%";
        }

        private void backgroundWorker6_DoWork(object sender, DoWorkEventArgs e)
        {
            if (System.IO.File.Exists(@"C:\Program Files (x86)\Microsoft Office\root\Office16\MSACCESS.EXE"))
            {

                AccessInstalledText = "Installerat";

            } else
            {

                AccessInstalledText = "Ej installerat";

            }
        }

        private void backgroundWorker6_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            label12.Text = AccessInstalledText;
            if (AccessInstalledText == "Ej installerat")
            {

                AccessButton.Visible = true;

            }
            progressBar1.Step = (100 / 8);
            progressBar1.PerformStep();
            label7.Text = progressBar1.Value.ToString() + "%";
        }

        private void backgroundWorker7_DoWork(object sender, DoWorkEventArgs e)
        {
            if (System.IO.File.Exists(@"C:\Pengvin32\User\1\PengProg32.accdb") && System.IO.Directory.Exists(@"C:\Program Files (x86)\Pengvin\PengVin BAXI Controller Client") && System.IO.Directory.Exists(@"C:\Program Files (x86)\Pengvin\Pengvin.Library102.dll (COM)") && System.IO.Directory.Exists(@"C:\Program Files (x86)\Pengvin\Pengvin.Scan (Com)") && System.IO.Directory.Exists(@"C:\Program Files (x86)\Pengvin\PVE_InteropControl"))
            {

                PengvinInstalledText = "Installerat";

            }
            else
            {

                PengvinInstalledText = "Ej installerat";

            }
        }

        private void backgroundWorker7_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            label14.Text = PengvinInstalledText;
            if (PengvinInstalledText == "Ej installerat")
            {

                PengvinButton.Visible = true;

            }
            progressBar1.Step = (100 / 8);
            progressBar1.PerformStep();
            label7.Text = progressBar1.Value.ToString() + "%";
        }

        private void backgroundWorker8_DoWork(object sender, DoWorkEventArgs e)
        {
            if (System.IO.File.Exists(@"C:\Windows\SysWOW64\msodbcsql13.dll"))
            {

                ODBCInstalledText = "Installerat";

            }
            else
            {

                ODBCInstalledText = "Ej installerat";

            }
        }

        private void backgroundWorker8_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            label16.Text = ODBCInstalledText;
            if (ODBCInstalledText == "Ej installerat")
            {

                ODBCButton.Visible = true;

            }
            progressBar1.Step = (100/8) + 4;
            progressBar1.PerformStep();
            label7.Text = progressBar1.Value.ToString() + "%";
        }

        private void IISButton_Click(object sender, EventArgs e)
        {
            try
            {
                IISButton.Visible = false;
                label21.Visible = true;
                label21.Text = "Startar Tjänst";
                AudioService.Start();
                AudioService.WaitForStatus(System.ServiceProcess.ServiceControllerStatus.Running);


                if (AudioService.Status.ToString() == "Running")
                {

                    label21.Text = "Startad";
                    label10.Text = "Körs";
                }
                
            }
            catch (InvalidOperationException)
            {

                label21.Text = "Kan inte starta tjänst";
                IISButton.Visible = true;
            }
        }

        private void AccessButton_Click(object sender, EventArgs e)
        {
            OfficeInstallProcess.StartInfo.FileName = Application.StartupPath.ToString() + @"\InstallationFiles\OfficeInstaller.exe";
            OfficeInstallProcess.Start();
            label12.Text = "Reparerar";
            AccessButton.Visible = false;
        }

        private void PengvinButton_Click(object sender, EventArgs e)
        {

            if (checkBox1.Checked)
            {
                PengvinInstallerProc1_5.StartInfo.FileName = Application.StartupPath.ToString() + @"\InstallationFiles\PengvinArbetsplatsInstaller.exe";
                PengvinInstallerProc1_5.StartInfo.Arguments = @"/S" + Application.StartupPath.ToString() + @"\setupvars.ini";

            } else
            {
                PengvinInstallerProc1_5.StartInfo.FileName = @"D:\DiagnoseTool_Repo\DiagnoseTool\DiagnoseTool\InstallationFiles\PengvinArbetsplatsInstaller.exe";
                PengvinInstallerProc1_5.StartInfo.Arguments = @"/S" + @"\setupvars.ini";

            }
            
            PengvinInstallerProc1_5.Start();
            PengvinButton.Visible = false;
            label14.Text = "Reparerar";
            label19.Visible = true;
            label19.Text = "Steg 1 av 5...";
        }

        private void PengvinInstallerProc1_4_Exited(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                PengvinInstallerProc2_5.StartInfo.FileName = Application.StartupPath.ToString() + @"\InstallationFiles\InstallPVE_InteropControl.msi";
                PengvinInstallerProc2_5.StartInfo.Arguments = @"/q";

            }
            else
            {
                PengvinInstallerProc2_5.StartInfo.FileName = @"D:\DiagnoseTool_Repo\DiagnoseTool\DiagnoseTool\InstallationFiles\InstallPVE_InteropControl.msi";
                PengvinInstallerProc2_5.StartInfo.Arguments = @"/q";

            }
            
            PengvinInstallerProc2_5.Start();
            label19.Text = "Steg 2 av 5...";
        }

        private void PengvinInstallerProc2_4_Exited(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                PengvinInstallerProc3_5.StartInfo.FileName = Application.StartupPath.ToString() + @"\InstallationFiles\PengVin BAXI Controller Client.msi";
                PengvinInstallerProc3_5.StartInfo.Arguments = @"/q";

            }
            else
            {
                PengvinInstallerProc3_5.StartInfo.FileName = @"D:\DiagnoseTool_Repo\DiagnoseTool\DiagnoseTool\InstallationFiles\PengVin BAXI Controller Client.msi";
                PengvinInstallerProc3_5.StartInfo.Arguments = @"/q";

            }
            
            PengvinInstallerProc3_5.Start();
            label19.Text = "Steg 3 av 5...";
        }

        private void PengvinInstallerProc3_4_Exited(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                PengvinInstallerProc4_5.StartInfo.FileName = Application.StartupPath.ToString() + @"\InstallationFiles\PengVin.Library10.dllSetup.msi";
                PengvinInstallerProc4_5.StartInfo.Arguments = @"/q";

            }
            else
            {
                PengvinInstallerProc4_5.StartInfo.FileName = @"D:\DiagnoseTool_Repo\DiagnoseTool\DiagnoseTool\InstallationFiles\PengVin.Library10.dllSetup.msi";
                PengvinInstallerProc4_5.StartInfo.Arguments = @"/q";

            }
            
            PengvinInstallerProc4_5.Start();
            label19.Text = "Steg 4 av 5...";
        }

        private void PengvinInstallerProc4_4_Exited(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                PengvinInstallerProc5_5.StartInfo.FileName = Application.StartupPath.ToString() + @"\InstallationFiles\Pengvin.Scan.dllSetup.msi";
                PengvinInstallerProc5_5.StartInfo.Arguments = @"/q";

            }
            else
            {
                PengvinInstallerProc5_5.StartInfo.FileName = @"D:\DiagnoseTool_Repo\DiagnoseTool\DiagnoseTool\InstallationFiles\PengVin.Scan.dllSetup.msi";
                PengvinInstallerProc5_5.StartInfo.Arguments = @"/q";

            }
            PengvinInstallerProc5_5.Start();

            label19.Visible = true;
            label19.Text = "Steg 5 av 5...";
            
        }

        private void OfficeInstallProcess_Exited(object sender, EventArgs e)
        {
            label20.Visible = true;
            label20.Text = "Reparation Slutförd";
        }

        private void ODBCButton_Click(object sender, EventArgs e)
        {
            ODBCButton.Visible = false;
            ODBCInstallProc.StartInfo.Arguments = @"/quiet /passive /qn /fp" +  Application.StartupPath.ToString() + @"\InstallationFiles\msodbcsql.msi IACCEPTMSODBCSQLLICENSETERMS=YES";
            ODBCInstallProc.StartInfo.FileName = "msiexec";

            ODBCInstallProc.Start();
        }

        private void ODBCInstallProc_Exited(object sender, EventArgs e)
        {
            label18.Visible = true;
            label18.Text = "Reparation Slutförd";
        }

        private void PengvinInstallerProc5_5_Exited(object sender, EventArgs e)
        {
            label19.Text = "Reparation Slutförd";
        }
    }
}
