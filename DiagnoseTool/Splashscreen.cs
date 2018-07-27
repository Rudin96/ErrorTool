using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Deployment.Application;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiagnoseTool
{
    public partial class Splashscreen : Form
    {
        public Splashscreen()
        {
            InitializeComponent();
            label2.Text = "Felsökningsverktyg";

            long sizeOfUpdate = 0;

            UpdateApplication();
            void UpdateApplication()
            {
                if (ApplicationDeployment.IsNetworkDeployed)
                {
                    ApplicationDeployment ad = ApplicationDeployment.CurrentDeployment;
                    ad.CheckForUpdateCompleted += new CheckForUpdateCompletedEventHandler(ad_CheckForUpdateCompleted);
                    ad.CheckForUpdateProgressChanged += new DeploymentProgressChangedEventHandler(ad_CheckForUpdateProgressChanged);

                    ad.CheckForUpdateAsync();
                    label3.Text = "Kollar efter uppdateringar";
                }
            }

            void ad_CheckForUpdateProgressChanged(object sender, DeploymentProgressChangedEventArgs e)
            {
                downloadStatus.Text = String.Format("Downloading: {0}. {1:D}K of {2:D}K downloaded.", GetProgressString(e.State), e.BytesCompleted / 1024, e.BytesTotal / 1024);
            }

            string GetProgressString(DeploymentProgressState state)
            {
                if (state == DeploymentProgressState.DownloadingApplicationFiles)
                {
                    return "application files";
                }
                else if (state == DeploymentProgressState.DownloadingApplicationInformation)
                {
                    return "application manifest";
                }
                else
                {
                    return "deployment manifest";
                }
            }

            void ad_CheckForUpdateCompleted(object sender, CheckForUpdateCompletedEventArgs e)
            {
                if (e.Error != null)
                {
                    MessageBox.Show("ERROR: Could not retrieve new version of the application. Reason: \n" + e.Error.Message + "\nPlease report this error to the system administrator.");
                    return;
                }
                else if (e.Cancelled == true)
                {
                    MessageBox.Show("The update was cancelled.");
                }

                // Ask the user if they would like to update the application now.
                if (e.UpdateAvailable)
                {
                    sizeOfUpdate = e.UpdateSizeBytes;

                    if (!e.IsUpdateRequired)
                    {
                        DialogResult dr = MessageBox.Show("An update is available. Would you like to update the application now?\n\nEstimated Download Time: ", "Update Available", MessageBoxButtons.OKCancel);
                        if (DialogResult.OK == dr)
                        {
                            BeginUpdate();
                        }
                    }
                    else
                    {
                        MessageBox.Show("A mandatory update is available for your application. We will install the update now, after which we will save all of your in-progress data and restart your application.");
                        BeginUpdate();
                    }
                }
                else
                {
                    this.Hide();
                    Form1 newfrm = new Form1();
                    newfrm.Show();

                }
            }

            void BeginUpdate()
            {
                ApplicationDeployment ad = ApplicationDeployment.CurrentDeployment;
                ad.UpdateCompleted += new AsyncCompletedEventHandler(ad_UpdateCompleted);

                // Indicate progress in the application's status bar.
                ad.UpdateProgressChanged += new DeploymentProgressChangedEventHandler(ad_UpdateProgressChanged);
                ad.UpdateAsync();
            }

            void ad_UpdateProgressChanged(object sender, DeploymentProgressChangedEventArgs e)
            {
                String progressText = String.Format("{0:D}K out of {1:D}K downloaded - {2:D}% complete", e.BytesCompleted / 1024, e.BytesTotal / 1024, e.ProgressPercentage);
                downloadStatus.Text = progressText;
            }

            void ad_UpdateCompleted(object sender, AsyncCompletedEventArgs e)
            {
                if (e.Cancelled)
                {
                    MessageBox.Show("The update of the application's latest version was cancelled.");
                    return;
                }
                else if (e.Error != null)
                {
                    MessageBox.Show("ERROR: Could not install the latest version of the application. Reason: \n" + e.Error.Message + "\nPlease report this error to the system administrator.");
                    return;
                }

                DialogResult dr = MessageBox.Show("The application has been updated. Restart? (If you do not restart now, the new version will not take effect until after you quit and launch the application again.)", "Restart Application", MessageBoxButtons.OKCancel);
                if (DialogResult.OK == dr)
                {
                    Application.Restart();
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Splashscreen_Load(object sender, EventArgs e)
        {

        }
    }
}
