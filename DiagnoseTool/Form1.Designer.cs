namespace DiagnoseTool
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
            this.button1 = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.ODBCButton = new System.Windows.Forms.Button();
            this.PengvinButton = new System.Windows.Forms.Button();
            this.AccessButton = new System.Windows.Forms.Button();
            this.IISButton = new System.Windows.Forms.Button();
            this.TeamViewerButton = new System.Windows.Forms.Button();
            this.SQLServerAgentButton = new System.Windows.Forms.Button();
            this.ReportServerButton = new System.Windows.Forms.Button();
            this.SQLEngineButton = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label7 = new System.Windows.Forms.Label();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker3 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker4 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker5 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker6 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker7 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker8 = new System.ComponentModel.BackgroundWorker();
            this.OfficeInstallProcess = new System.Diagnostics.Process();
            this.PengvinInstallerProc1_5 = new System.Diagnostics.Process();
            this.PengvinInstallerProc2_5 = new System.Diagnostics.Process();
            this.PengvinInstallerProc3_5 = new System.Diagnostics.Process();
            this.PengvinInstallerProc4_5 = new System.Diagnostics.Process();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.AudioService = new System.ServiceProcess.ServiceController();
            this.TeamViewerService = new System.ServiceProcess.ServiceController();
            this.SQLServerAgentService = new System.ServiceProcess.ServiceController();
            this.ReportServerService = new System.ServiceProcess.ServiceController();
            this.SQLEngineService = new System.ServiceProcess.ServiceController();
            this.ODBCInstallProc = new System.Diagnostics.Process();
            this.PengvinInstallerProc5_5 = new System.Diagnostics.Process();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(319, 153);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 45);
            this.button1.TabIndex = 0;
            this.button1.Text = "Starta felsökning";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(181, 299);
            this.progressBar1.MarqueeAnimationSpeed = 50;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(404, 23);
            this.progressBar1.TabIndex = 1;
            this.progressBar1.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.label21);
            this.groupBox1.Controls.Add(this.label22);
            this.groupBox1.Controls.Add(this.label23);
            this.groupBox1.Controls.Add(this.label24);
            this.groupBox1.Controls.Add(this.label25);
            this.groupBox1.Controls.Add(this.ODBCButton);
            this.groupBox1.Controls.Add(this.PengvinButton);
            this.groupBox1.Controls.Add(this.AccessButton);
            this.groupBox1.Controls.Add(this.IISButton);
            this.groupBox1.Controls.Add(this.TeamViewerButton);
            this.groupBox1.Controls.Add(this.SQLServerAgentButton);
            this.groupBox1.Controls.Add(this.ReportServerButton);
            this.groupBox1.Controls.Add(this.SQLEngineButton);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(181, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(404, 237);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Status:";
            this.groupBox1.Visible = false;
            this.groupBox1.VisibleChanged += new System.EventHandler(this.progressBar1_VisibleChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(266, 203);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(71, 13);
            this.label18.TabIndex = 31;
            this.label18.Text = "Undersöker...";
            this.label18.Visible = false;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(266, 178);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(71, 13);
            this.label19.TabIndex = 30;
            this.label19.Text = "Undersöker...";
            this.label19.Visible = false;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(266, 153);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(71, 13);
            this.label20.TabIndex = 29;
            this.label20.Text = "Undersöker...";
            this.label20.Visible = false;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(266, 128);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(71, 13);
            this.label21.TabIndex = 28;
            this.label21.Text = "Undersöker...";
            this.label21.Visible = false;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(266, 102);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(71, 13);
            this.label22.TabIndex = 27;
            this.label22.Text = "Undersöker...";
            this.label22.Visible = false;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(266, 77);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(71, 13);
            this.label23.TabIndex = 26;
            this.label23.Text = "Undersöker...";
            this.label23.Visible = false;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(266, 26);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(71, 13);
            this.label24.TabIndex = 25;
            this.label24.Text = "Undersöker...";
            this.label24.Visible = false;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(266, 51);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(71, 13);
            this.label25.TabIndex = 24;
            this.label25.Text = "Undersöker...";
            this.label25.Visible = false;
            // 
            // ODBCButton
            // 
            this.ODBCButton.Location = new System.Drawing.Point(185, 196);
            this.ODBCButton.Name = "ODBCButton";
            this.ODBCButton.Size = new System.Drawing.Size(75, 26);
            this.ODBCButton.TabIndex = 23;
            this.ODBCButton.Text = "Åtgärda";
            this.ODBCButton.UseVisualStyleBackColor = true;
            this.ODBCButton.Visible = false;
            this.ODBCButton.Click += new System.EventHandler(this.ODBCButton_Click);
            // 
            // PengvinButton
            // 
            this.PengvinButton.Location = new System.Drawing.Point(185, 171);
            this.PengvinButton.Name = "PengvinButton";
            this.PengvinButton.Size = new System.Drawing.Size(75, 26);
            this.PengvinButton.TabIndex = 22;
            this.PengvinButton.Text = "Åtgärda";
            this.PengvinButton.UseVisualStyleBackColor = true;
            this.PengvinButton.Visible = false;
            this.PengvinButton.Click += new System.EventHandler(this.PengvinButton_Click);
            // 
            // AccessButton
            // 
            this.AccessButton.Location = new System.Drawing.Point(185, 146);
            this.AccessButton.Name = "AccessButton";
            this.AccessButton.Size = new System.Drawing.Size(75, 26);
            this.AccessButton.TabIndex = 21;
            this.AccessButton.Text = "Åtgärda";
            this.AccessButton.UseVisualStyleBackColor = true;
            this.AccessButton.Visible = false;
            this.AccessButton.Click += new System.EventHandler(this.AccessButton_Click);
            // 
            // IISButton
            // 
            this.IISButton.Location = new System.Drawing.Point(185, 121);
            this.IISButton.Name = "IISButton";
            this.IISButton.Size = new System.Drawing.Size(75, 26);
            this.IISButton.TabIndex = 20;
            this.IISButton.Text = "Åtgärda";
            this.IISButton.UseVisualStyleBackColor = true;
            this.IISButton.Visible = false;
            this.IISButton.Click += new System.EventHandler(this.IISButton_Click);
            // 
            // TeamViewerButton
            // 
            this.TeamViewerButton.Location = new System.Drawing.Point(185, 95);
            this.TeamViewerButton.Name = "TeamViewerButton";
            this.TeamViewerButton.Size = new System.Drawing.Size(75, 26);
            this.TeamViewerButton.TabIndex = 19;
            this.TeamViewerButton.Text = "Åtgärda";
            this.TeamViewerButton.UseVisualStyleBackColor = true;
            this.TeamViewerButton.Visible = false;
            // 
            // SQLServerAgentButton
            // 
            this.SQLServerAgentButton.Location = new System.Drawing.Point(185, 70);
            this.SQLServerAgentButton.Name = "SQLServerAgentButton";
            this.SQLServerAgentButton.Size = new System.Drawing.Size(75, 26);
            this.SQLServerAgentButton.TabIndex = 18;
            this.SQLServerAgentButton.Text = "Åtgärda";
            this.SQLServerAgentButton.UseVisualStyleBackColor = true;
            this.SQLServerAgentButton.Visible = false;
            // 
            // ReportServerButton
            // 
            this.ReportServerButton.Location = new System.Drawing.Point(185, 44);
            this.ReportServerButton.Name = "ReportServerButton";
            this.ReportServerButton.Size = new System.Drawing.Size(75, 26);
            this.ReportServerButton.TabIndex = 17;
            this.ReportServerButton.Text = "Åtgärda";
            this.ReportServerButton.UseVisualStyleBackColor = true;
            this.ReportServerButton.Visible = false;
            // 
            // SQLEngineButton
            // 
            this.SQLEngineButton.Location = new System.Drawing.Point(185, 19);
            this.SQLEngineButton.Name = "SQLEngineButton";
            this.SQLEngineButton.Size = new System.Drawing.Size(75, 26);
            this.SQLEngineButton.TabIndex = 16;
            this.SQLEngineButton.Text = "Åtgärda";
            this.SQLEngineButton.UseVisualStyleBackColor = true;
            this.SQLEngineButton.Visible = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(108, 203);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(71, 13);
            this.label16.TabIndex = 15;
            this.label16.Text = "Undersöker...";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(13, 203);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(86, 13);
            this.label17.TabIndex = 14;
            this.label17.Text = "ODBC Driver 13:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(108, 178);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(71, 13);
            this.label14.TabIndex = 13;
            this.label14.Text = "Undersöker...";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(13, 178);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(49, 13);
            this.label15.TabIndex = 12;
            this.label15.Text = "Pengvin:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(108, 153);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(71, 13);
            this.label12.TabIndex = 11;
            this.label12.Text = "Undersöker...";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(13, 153);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(45, 13);
            this.label13.TabIndex = 10;
            this.label13.Text = "Access:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(108, 128);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Undersöker...";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(13, 128);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 13);
            this.label11.TabIndex = 8;
            this.label11.Text = "IIS(AudioSrv):";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(108, 102);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Undersöker...";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 102);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "TeamViewer:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(108, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Undersöker...";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "SQLServerAgent:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(108, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Undersöker...";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(108, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Undersöker...";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "RapportServer:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "SQLServer:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(31, 120);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Avbryt";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(561, 325);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 13);
            this.label7.TabIndex = 4;
            this.label7.Visible = false;
            // 
            // backgroundWorker2
            // 
            this.backgroundWorker2.WorkerReportsProgress = true;
            this.backgroundWorker2.WorkerSupportsCancellation = true;
            this.backgroundWorker2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker2_DoWork);
            this.backgroundWorker2.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker2_RunWorkerCompleted);
            // 
            // backgroundWorker3
            // 
            this.backgroundWorker3.WorkerReportsProgress = true;
            this.backgroundWorker3.WorkerSupportsCancellation = true;
            this.backgroundWorker3.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker3_DoWork);
            this.backgroundWorker3.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker3_RunWorkerCompleted);
            // 
            // backgroundWorker4
            // 
            this.backgroundWorker4.WorkerReportsProgress = true;
            this.backgroundWorker4.WorkerSupportsCancellation = true;
            this.backgroundWorker4.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker4_DoWork);
            this.backgroundWorker4.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker4_RunWorkerCompleted);
            // 
            // backgroundWorker5
            // 
            this.backgroundWorker5.WorkerReportsProgress = true;
            this.backgroundWorker5.WorkerSupportsCancellation = true;
            this.backgroundWorker5.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker5_DoWork);
            this.backgroundWorker5.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker5_RunWorkerCompleted);
            // 
            // backgroundWorker6
            // 
            this.backgroundWorker6.WorkerReportsProgress = true;
            this.backgroundWorker6.WorkerSupportsCancellation = true;
            this.backgroundWorker6.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker6_DoWork);
            this.backgroundWorker6.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker6_RunWorkerCompleted);
            // 
            // backgroundWorker7
            // 
            this.backgroundWorker7.WorkerReportsProgress = true;
            this.backgroundWorker7.WorkerSupportsCancellation = true;
            this.backgroundWorker7.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker7_DoWork);
            this.backgroundWorker7.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker7_RunWorkerCompleted);
            // 
            // backgroundWorker8
            // 
            this.backgroundWorker8.WorkerReportsProgress = true;
            this.backgroundWorker8.WorkerSupportsCancellation = true;
            this.backgroundWorker8.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker8_DoWork);
            this.backgroundWorker8.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker8_RunWorkerCompleted);
            // 
            // OfficeInstallProcess
            // 
            this.OfficeInstallProcess.EnableRaisingEvents = true;
            this.OfficeInstallProcess.StartInfo.CreateNoWindow = true;
            this.OfficeInstallProcess.StartInfo.Domain = "";
            this.OfficeInstallProcess.StartInfo.ErrorDialog = true;
            this.OfficeInstallProcess.StartInfo.FileName = "\\...\\InstallationFiles\\OfficeInstaller.exe";
            this.OfficeInstallProcess.StartInfo.LoadUserProfile = false;
            this.OfficeInstallProcess.StartInfo.Password = null;
            this.OfficeInstallProcess.StartInfo.StandardErrorEncoding = null;
            this.OfficeInstallProcess.StartInfo.StandardOutputEncoding = null;
            this.OfficeInstallProcess.StartInfo.UserName = "";
            this.OfficeInstallProcess.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            this.OfficeInstallProcess.SynchronizingObject = this;
            this.OfficeInstallProcess.Exited += new System.EventHandler(this.OfficeInstallProcess_Exited);
            // 
            // PengvinInstallerProc1_5
            // 
            this.PengvinInstallerProc1_5.EnableRaisingEvents = true;
            this.PengvinInstallerProc1_5.StartInfo.Domain = "";
            this.PengvinInstallerProc1_5.StartInfo.FileName = "PengvinArbetsplatsInstaller.exe";
            this.PengvinInstallerProc1_5.StartInfo.LoadUserProfile = false;
            this.PengvinInstallerProc1_5.StartInfo.Password = null;
            this.PengvinInstallerProc1_5.StartInfo.StandardErrorEncoding = null;
            this.PengvinInstallerProc1_5.StartInfo.StandardOutputEncoding = null;
            this.PengvinInstallerProc1_5.StartInfo.UserName = "";
            this.PengvinInstallerProc1_5.SynchronizingObject = this;
            this.PengvinInstallerProc1_5.Exited += new System.EventHandler(this.PengvinInstallerProc1_4_Exited);
            // 
            // PengvinInstallerProc2_5
            // 
            this.PengvinInstallerProc2_5.EnableRaisingEvents = true;
            this.PengvinInstallerProc2_5.StartInfo.Domain = "";
            this.PengvinInstallerProc2_5.StartInfo.LoadUserProfile = false;
            this.PengvinInstallerProc2_5.StartInfo.Password = null;
            this.PengvinInstallerProc2_5.StartInfo.StandardErrorEncoding = null;
            this.PengvinInstallerProc2_5.StartInfo.StandardOutputEncoding = null;
            this.PengvinInstallerProc2_5.StartInfo.UserName = "";
            this.PengvinInstallerProc2_5.SynchronizingObject = this;
            this.PengvinInstallerProc2_5.Exited += new System.EventHandler(this.PengvinInstallerProc2_4_Exited);
            // 
            // PengvinInstallerProc3_5
            // 
            this.PengvinInstallerProc3_5.EnableRaisingEvents = true;
            this.PengvinInstallerProc3_5.StartInfo.Domain = "";
            this.PengvinInstallerProc3_5.StartInfo.LoadUserProfile = false;
            this.PengvinInstallerProc3_5.StartInfo.Password = null;
            this.PengvinInstallerProc3_5.StartInfo.StandardErrorEncoding = null;
            this.PengvinInstallerProc3_5.StartInfo.StandardOutputEncoding = null;
            this.PengvinInstallerProc3_5.StartInfo.UserName = "";
            this.PengvinInstallerProc3_5.SynchronizingObject = this;
            this.PengvinInstallerProc3_5.Exited += new System.EventHandler(this.PengvinInstallerProc3_4_Exited);
            // 
            // PengvinInstallerProc4_5
            // 
            this.PengvinInstallerProc4_5.EnableRaisingEvents = true;
            this.PengvinInstallerProc4_5.StartInfo.Domain = "";
            this.PengvinInstallerProc4_5.StartInfo.LoadUserProfile = false;
            this.PengvinInstallerProc4_5.StartInfo.Password = null;
            this.PengvinInstallerProc4_5.StartInfo.StandardErrorEncoding = null;
            this.PengvinInstallerProc4_5.StartInfo.StandardOutputEncoding = null;
            this.PengvinInstallerProc4_5.StartInfo.UserName = "";
            this.PengvinInstallerProc4_5.SynchronizingObject = this;
            this.PengvinInstallerProc4_5.Exited += new System.EventHandler(this.PengvinInstallerProc4_4_Exited);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(31, 229);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(105, 17);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "Utvecklarknapp:";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.Visible = false;
            // 
            // AudioService
            // 
            this.AudioService.MachineName = "192.168.0.117";
            this.AudioService.ServiceName = "AudioSrv";
            // 
            // TeamViewerService
            // 
            this.TeamViewerService.MachineName = "192.168.0.117";
            this.TeamViewerService.ServiceName = "Teamviewer";
            // 
            // SQLServerAgentService
            // 
            this.SQLServerAgentService.MachineName = "192.168.0.117";
            this.SQLServerAgentService.ServiceName = "SQLServerAgent";
            // 
            // ReportServerService
            // 
            this.ReportServerService.MachineName = "192.168.0.117";
            this.ReportServerService.ServiceName = "ReportServer";
            // 
            // SQLEngineService
            // 
            this.SQLEngineService.MachineName = "192.168.0.117";
            this.SQLEngineService.ServiceName = "MSSQLSERVER";
            // 
            // ODBCInstallProc
            // 
            this.ODBCInstallProc.EnableRaisingEvents = true;
            this.ODBCInstallProc.StartInfo.Domain = "";
            this.ODBCInstallProc.StartInfo.LoadUserProfile = false;
            this.ODBCInstallProc.StartInfo.Password = null;
            this.ODBCInstallProc.StartInfo.StandardErrorEncoding = null;
            this.ODBCInstallProc.StartInfo.StandardOutputEncoding = null;
            this.ODBCInstallProc.StartInfo.UserName = "";
            this.ODBCInstallProc.SynchronizingObject = this;
            this.ODBCInstallProc.Exited += new System.EventHandler(this.ODBCInstallProc_Exited);
            // 
            // PengvinInstallerProc5_5
            // 
            this.PengvinInstallerProc5_5.EnableRaisingEvents = true;
            this.PengvinInstallerProc5_5.StartInfo.Domain = "";
            this.PengvinInstallerProc5_5.StartInfo.LoadUserProfile = false;
            this.PengvinInstallerProc5_5.StartInfo.Password = null;
            this.PengvinInstallerProc5_5.StartInfo.StandardErrorEncoding = null;
            this.PengvinInstallerProc5_5.StartInfo.StandardOutputEncoding = null;
            this.PengvinInstallerProc5_5.StartInfo.UserName = "";
            this.PengvinInstallerProc5_5.SynchronizingObject = this;
            this.PengvinInstallerProc5_5.Exited += new System.EventHandler(this.PengvinInstallerProc5_5_Exited);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 386);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Felsökarverktyg";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.ServiceProcess.ServiceController SQLEngineService;
        private System.ServiceProcess.ServiceController SQLServerAgentService;
        private System.ServiceProcess.ServiceController TeamViewerService;
        private System.ServiceProcess.ServiceController AudioService;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.ServiceProcess.ServiceController ReportServerService;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.ComponentModel.BackgroundWorker backgroundWorker3;
        private System.ComponentModel.BackgroundWorker backgroundWorker4;
        private System.ComponentModel.BackgroundWorker backgroundWorker5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.ComponentModel.BackgroundWorker backgroundWorker6;
        private System.ComponentModel.BackgroundWorker backgroundWorker7;
        private System.Windows.Forms.Button ODBCButton;
        private System.Windows.Forms.Button PengvinButton;
        private System.Windows.Forms.Button AccessButton;
        private System.Windows.Forms.Button IISButton;
        private System.Windows.Forms.Button TeamViewerButton;
        private System.Windows.Forms.Button SQLServerAgentButton;
        private System.Windows.Forms.Button ReportServerButton;
        private System.Windows.Forms.Button SQLEngineButton;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.ComponentModel.BackgroundWorker backgroundWorker8;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Diagnostics.Process OfficeInstallProcess;
        private System.Diagnostics.Process PengvinInstallerProc1_5;
        private System.Diagnostics.Process PengvinInstallerProc2_5;
        private System.Diagnostics.Process PengvinInstallerProc3_5;
        private System.Diagnostics.Process PengvinInstallerProc4_5;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Diagnostics.Process ODBCInstallProc;
        private System.Diagnostics.Process PengvinInstallerProc5_5;
    }
}

