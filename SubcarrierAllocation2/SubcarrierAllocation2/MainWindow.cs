using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace SubcarrierAllocation2
{
    public partial class MainWindow : Form
    {
        SystemModel sm;

        string path = null;
        public MainWindow()
        {
            InitializeComponent();
            this.FRFcomboBox.SelectedIndex = 0;
            BandwidthComboBox.SelectedIndex = 3;
     
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {

        }

        private void trackBarUsrDemand_ValueChanged(object sender, EventArgs e)
        {
            System.Windows.Forms.TrackBar myTrackbar = (System.Windows.Forms.TrackBar)sender;
            demandLbl.Text = (myTrackbar.Value).ToString();
        }
            
        private void trackBarNrUsers_ValueChanged(object sender, EventArgs e)
        {
            System.Windows.Forms.TrackBar myTrackbar = (System.Windows.Forms.TrackBar)sender;
            nrUsrsLbl.Text = (myTrackbar.Value).ToString();
        }

        private void trackBarCellSize_ValueChanged(object sender, EventArgs e)
        {
            System.Windows.Forms.TrackBar myTrackbar = (System.Windows.Forms.TrackBar)sender;
            sizeLbl.Text = (myTrackbar.Value).ToString();
        }


        private void trackBarNrRelays_ValueChanged(object sender, EventArgs e)
        {
            System.Windows.Forms.TrackBar myTrackbar = (System.Windows.Forms.TrackBar)sender;
            nrRelayLbl.Text = (myTrackbar.Value).ToString();
            this.FRFcomboBox.Items[1] = (myTrackbar.Value + 1).ToString();
        }
        

        private void trackBarRelayDistance_ValueChanged(object sender, EventArgs e)
        {
            System.Windows.Forms.TrackBar myTrackbar = (System.Windows.Forms.TrackBar)sender;
            distLbl.Text = (myTrackbar.Value).ToString();
            distLbl.Text += " %";
        }

        private void LoadDataButton_Click(object sender, EventArgs e)
        {
            int numberOfUsers = trackBarNrUsers.Value;
            int userDemand = trackBarUsrDemand.Value;
            int cellSize = trackBarCellSize.Value;
            int numberOfRelays = trackBarNrRelays.Value;
            float distanceProportion = trackBarRelayDistance.Value/100.0f;
            int temperature = TemperatureTrackBar.Value;
            float decrease = tempDecreaseTrackBar.Value / 100.0f;
            int stepsUnchangedTemperature = unchangedTempTrackBar.Value;
            int insignificantChange = insignificantChTrackBar.Value;
            float stepsInsignificant = stepsInsignificantTrackBar.Value;
            int PRBnr = nrOfPRB();

            DialogResult result = folderBrowserDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                path = folderBrowserDialog.SelectedPath;
                Console.WriteLine(path);
            }
           
            sm = new SystemModel(numberOfUsers, userDemand, cellSize, numberOfRelays, distanceProportion, FRFcomboBox.SelectedIndex, PRBnr,
                                 temperature, decrease, stepsUnchangedTemperature, insignificantChange, stepsInsignificant, path );
            sm.Simmulate();

        }

        private int nrOfPRB()
        {
            switch (BandwidthComboBox.SelectedIndex)
            {
                case 0:
                    {
                        return 6;
                    }
                case 1:
                    {
                        return 15;
                    }
                case 2:
                    {
                        return 25;
                    }
                case 3:
                    {
                        return 50;
                    }
                case 4:
                    {
                        return 75;
                    }
                case 5:
                    {
                        return 100;
                    }
                default:
                    return 50;
            }
        }

        private void TemperatureTrackBar_ValueChanged(object sender, EventArgs e)
        {
            System.Windows.Forms.TrackBar myTrackbar = (System.Windows.Forms.TrackBar)sender;
            initialTemp.Text = (myTrackbar.Value).ToString();
        }

        private void tempDecreaseTrackBar_ValueChanged(object sender, EventArgs e)
        {
            System.Windows.Forms.TrackBar myTrackbar = (System.Windows.Forms.TrackBar)sender;
            tempDecrease.Text = (myTrackbar.Value / 100.0f).ToString();
            //tempDecrease.Text += " %";
        }

        private void unchangedTempTrackBar_ValueChanged(object sender, EventArgs e)
        {

            System.Windows.Forms.TrackBar myTrackbar = (System.Windows.Forms.TrackBar)sender;
            unchangedTemp.Text = (myTrackbar.Value).ToString();
        }

        private void insignificantChTrackBar_ValueChanged(object sender, EventArgs e)
        {
            System.Windows.Forms.TrackBar myTrackbar = (System.Windows.Forms.TrackBar)sender;
            insignificantCh.Text = (myTrackbar.Value).ToString();
            insignificantCh.Text += " %";
        }

        private void stepsInsignificantTrackBar_ValueChanged(object sender, EventArgs e)
        {
            System.Windows.Forms.TrackBar myTrackbar = (System.Windows.Forms.TrackBar)sender;
            stepsInsignificant.Text = (myTrackbar.Value).ToString();
        }

        private void folderBrowserDialog_HelpRequest(object sender, EventArgs e)
        {

        }

    }
}
