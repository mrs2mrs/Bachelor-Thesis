namespace SubcarrierAllocation2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.trackBarNrUsers = new System.Windows.Forms.TrackBar();
            this.trackBarUsrDemand = new System.Windows.Forms.TrackBar();
            this.demandLbl = new System.Windows.Forms.Label();
            this.nrUsrsLbl = new System.Windows.Forms.Label();
            this.sizeLbl = new System.Windows.Forms.Label();
            this.trackBarCellSize = new System.Windows.Forms.TrackBar();
            this.nrRelayLbl = new System.Windows.Forms.Label();
            this.trackBarNrRelays = new System.Windows.Forms.TrackBar();
            this.distLbl = new System.Windows.Forms.Label();
            this.trackBarRelayDistance = new System.Windows.Forms.TrackBar();
            this.LoadDataButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.FRFcomboBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.TemperatureTrackBar = new System.Windows.Forms.TrackBar();
            this.label10 = new System.Windows.Forms.Label();
            this.tempDecreaseTrackBar = new System.Windows.Forms.TrackBar();
            this.label11 = new System.Windows.Forms.Label();
            this.unchangedTempTrackBar = new System.Windows.Forms.TrackBar();
            this.insignificantChTrackBar = new System.Windows.Forms.TrackBar();
            this.stepsInsignificantTrackBar = new System.Windows.Forms.TrackBar();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.initialTemp = new System.Windows.Forms.Label();
            this.tempDecrease = new System.Windows.Forms.Label();
            this.unchangedTemp = new System.Windows.Forms.Label();
            this.insignificantCh = new System.Windows.Forms.Label();
            this.stepsInsignificant = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.BandwidthComboBox = new System.Windows.Forms.ComboBox();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarNrUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarUsrDemand)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarCellSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarNrRelays)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRelayDistance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TemperatureTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tempDecreaseTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unchangedTempTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.insignificantChTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stepsInsignificantTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 54);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number of users";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 146);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Demand per user [kbps]";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 265);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cell radius [m]";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 373);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Number of relays";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 494);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(212, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Relays\' distance from cell center";
            // 
            // trackBarNrUsers
            // 
            this.trackBarNrUsers.Location = new System.Drawing.Point(16, 87);
            this.trackBarNrUsers.Margin = new System.Windows.Forms.Padding(4);
            this.trackBarNrUsers.Maximum = 200;
            this.trackBarNrUsers.Minimum = 1;
            this.trackBarNrUsers.Name = "trackBarNrUsers";
            this.trackBarNrUsers.Size = new System.Drawing.Size(343, 56);
            this.trackBarNrUsers.TabIndex = 5;
            this.trackBarNrUsers.Value = 1;
            this.trackBarNrUsers.ValueChanged += new System.EventHandler(this.trackBarNrUsers_ValueChanged);
            // 
            // trackBarUsrDemand
            // 
            this.trackBarUsrDemand.LargeChange = 100;
            this.trackBarUsrDemand.Location = new System.Drawing.Point(21, 190);
            this.trackBarUsrDemand.Margin = new System.Windows.Forms.Padding(4);
            this.trackBarUsrDemand.Maximum = 8000;
            this.trackBarUsrDemand.Minimum = 1;
            this.trackBarUsrDemand.Name = "trackBarUsrDemand";
            this.trackBarUsrDemand.Size = new System.Drawing.Size(341, 56);
            this.trackBarUsrDemand.TabIndex = 6;
            this.trackBarUsrDemand.Value = 64;
            this.trackBarUsrDemand.ValueChanged += new System.EventHandler(this.trackBarUsrDemand_ValueChanged);
            // 
            // demandLbl
            // 
            this.demandLbl.AutoSize = true;
            this.demandLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.demandLbl.Location = new System.Drawing.Point(187, 146);
            this.demandLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.demandLbl.Name = "demandLbl";
            this.demandLbl.Size = new System.Drawing.Size(26, 19);
            this.demandLbl.TabIndex = 7;
            this.demandLbl.Text = "64";
            // 
            // nrUsrsLbl
            // 
            this.nrUsrsLbl.AutoSize = true;
            this.nrUsrsLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.nrUsrsLbl.Location = new System.Drawing.Point(139, 54);
            this.nrUsrsLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nrUsrsLbl.Name = "nrUsrsLbl";
            this.nrUsrsLbl.Size = new System.Drawing.Size(18, 19);
            this.nrUsrsLbl.TabIndex = 8;
            this.nrUsrsLbl.Text = "1";
            // 
            // sizeLbl
            // 
            this.sizeLbl.AutoSize = true;
            this.sizeLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.sizeLbl.Location = new System.Drawing.Point(139, 265);
            this.sizeLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sizeLbl.Name = "sizeLbl";
            this.sizeLbl.Size = new System.Drawing.Size(26, 19);
            this.sizeLbl.TabIndex = 9;
            this.sizeLbl.Text = "35";
            // 
            // trackBarCellSize
            // 
            this.trackBarCellSize.LargeChange = 20;
            this.trackBarCellSize.Location = new System.Drawing.Point(21, 297);
            this.trackBarCellSize.Margin = new System.Windows.Forms.Padding(4);
            this.trackBarCellSize.Maximum = 2000;
            this.trackBarCellSize.Minimum = 35;
            this.trackBarCellSize.Name = "trackBarCellSize";
            this.trackBarCellSize.Size = new System.Drawing.Size(341, 56);
            this.trackBarCellSize.TabIndex = 10;
            this.trackBarCellSize.Value = 35;
            this.trackBarCellSize.ValueChanged += new System.EventHandler(this.trackBarCellSize_ValueChanged);
            // 
            // nrRelayLbl
            // 
            this.nrRelayLbl.AutoSize = true;
            this.nrRelayLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.nrRelayLbl.Location = new System.Drawing.Point(141, 373);
            this.nrRelayLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nrRelayLbl.Name = "nrRelayLbl";
            this.nrRelayLbl.Size = new System.Drawing.Size(18, 19);
            this.nrRelayLbl.TabIndex = 11;
            this.nrRelayLbl.Text = "0";
            // 
            // trackBarNrRelays
            // 
            this.trackBarNrRelays.LargeChange = 2;
            this.trackBarNrRelays.Location = new System.Drawing.Point(21, 412);
            this.trackBarNrRelays.Margin = new System.Windows.Forms.Padding(4);
            this.trackBarNrRelays.Name = "trackBarNrRelays";
            this.trackBarNrRelays.Size = new System.Drawing.Size(341, 56);
            this.trackBarNrRelays.TabIndex = 12;
            this.trackBarNrRelays.ValueChanged += new System.EventHandler(this.trackBarNrRelays_ValueChanged);
            // 
            // distLbl
            // 
            this.distLbl.AutoSize = true;
            this.distLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.distLbl.Location = new System.Drawing.Point(271, 494);
            this.distLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.distLbl.Name = "distLbl";
            this.distLbl.Size = new System.Drawing.Size(50, 19);
            this.distLbl.TabIndex = 13;
            this.distLbl.Text = "100 %";
            // 
            // trackBarRelayDistance
            // 
            this.trackBarRelayDistance.Location = new System.Drawing.Point(21, 513);
            this.trackBarRelayDistance.Margin = new System.Windows.Forms.Padding(4);
            this.trackBarRelayDistance.Maximum = 100;
            this.trackBarRelayDistance.Name = "trackBarRelayDistance";
            this.trackBarRelayDistance.Size = new System.Drawing.Size(341, 56);
            this.trackBarRelayDistance.TabIndex = 14;
            this.trackBarRelayDistance.Value = 100;
            this.trackBarRelayDistance.ValueChanged += new System.EventHandler(this.trackBarRelayDistance_ValueChanged);
            // 
            // LoadDataButton
            // 
            this.LoadDataButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LoadDataButton.Location = new System.Drawing.Point(241, 757);
            this.LoadDataButton.Margin = new System.Windows.Forms.Padding(4);
            this.LoadDataButton.Name = "LoadDataButton";
            this.LoadDataButton.Size = new System.Drawing.Size(327, 33);
            this.LoadDataButton.TabIndex = 15;
            this.LoadDataButton.Text = "Start simulation";
            this.LoadDataButton.UseVisualStyleBackColor = true;
            this.LoadDataButton.Click += new System.EventHandler(this.LoadDataButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 577);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(164, 17);
            this.label6.TabIndex = 16;
            this.label6.Text = "Frequency Reuse Factor";
            // 
            // FRFcomboBox
            // 
            this.FRFcomboBox.FormattingEnabled = true;
            this.FRFcomboBox.Items.AddRange(new object[] {
            "1",
            "# of Relays + 1"});
            this.FRFcomboBox.Location = new System.Drawing.Point(31, 598);
            this.FRFcomboBox.Margin = new System.Windows.Forms.Padding(4);
            this.FRFcomboBox.Name = "FRFcomboBox";
            this.FRFcomboBox.Size = new System.Drawing.Size(160, 24);
            this.FRFcomboBox.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(31, 16);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(169, 25);
            this.label7.TabIndex = 18;
            this.label7.Text = "Model parameters";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(437, 16);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(284, 25);
            this.label8.TabIndex = 19;
            this.label8.Text = "Simulated Annaling parameters";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(443, 54);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(126, 17);
            this.label9.TabIndex = 20;
            this.label9.Text = "Initial Temperature";
            // 
            // TemperatureTrackBar
            // 
            this.TemperatureTrackBar.Location = new System.Drawing.Point(452, 87);
            this.TemperatureTrackBar.Margin = new System.Windows.Forms.Padding(4);
            this.TemperatureTrackBar.Maximum = 100;
            this.TemperatureTrackBar.Name = "TemperatureTrackBar";
            this.TemperatureTrackBar.Size = new System.Drawing.Size(303, 56);
            this.TemperatureTrackBar.TabIndex = 21;
            this.TemperatureTrackBar.Value = 100;
            this.TemperatureTrackBar.ValueChanged += new System.EventHandler(this.TemperatureTrackBar_ValueChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(443, 146);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(157, 17);
            this.label10.TabIndex = 22;
            this.label10.Text = "Temperature decrease ";
            // 
            // tempDecreaseTrackBar
            // 
            this.tempDecreaseTrackBar.Location = new System.Drawing.Point(451, 190);
            this.tempDecreaseTrackBar.Margin = new System.Windows.Forms.Padding(4);
            this.tempDecreaseTrackBar.Maximum = 100;
            this.tempDecreaseTrackBar.Minimum = 1;
            this.tempDecreaseTrackBar.Name = "tempDecreaseTrackBar";
            this.tempDecreaseTrackBar.Size = new System.Drawing.Size(295, 56);
            this.tempDecreaseTrackBar.TabIndex = 23;
            this.tempDecreaseTrackBar.Value = 1;
            this.tempDecreaseTrackBar.ValueChanged += new System.EventHandler(this.tempDecreaseTrackBar_ValueChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(443, 265);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(337, 17);
            this.label11.TabIndex = 24;
            this.label11.Text = "Number of steps to run with unchanged temperature";
            // 
            // unchangedTempTrackBar
            // 
            this.unchangedTempTrackBar.Location = new System.Drawing.Point(447, 297);
            this.unchangedTempTrackBar.Margin = new System.Windows.Forms.Padding(4);
            this.unchangedTempTrackBar.Maximum = 100;
            this.unchangedTempTrackBar.Minimum = 1;
            this.unchangedTempTrackBar.Name = "unchangedTempTrackBar";
            this.unchangedTempTrackBar.Size = new System.Drawing.Size(299, 56);
            this.unchangedTempTrackBar.TabIndex = 25;
            this.unchangedTempTrackBar.Value = 1;
            this.unchangedTempTrackBar.ValueChanged += new System.EventHandler(this.unchangedTempTrackBar_ValueChanged);
            // 
            // insignificantChTrackBar
            // 
            this.insignificantChTrackBar.Location = new System.Drawing.Point(452, 412);
            this.insignificantChTrackBar.Margin = new System.Windows.Forms.Padding(4);
            this.insignificantChTrackBar.Maximum = 100;
            this.insignificantChTrackBar.Minimum = 1;
            this.insignificantChTrackBar.Name = "insignificantChTrackBar";
            this.insignificantChTrackBar.Size = new System.Drawing.Size(293, 56);
            this.insignificantChTrackBar.TabIndex = 26;
            this.insignificantChTrackBar.Value = 1;
            this.insignificantChTrackBar.ValueChanged += new System.EventHandler(this.insignificantChTrackBar_ValueChanged);
            // 
            // stepsInsignificantTrackBar
            // 
            this.stepsInsignificantTrackBar.Location = new System.Drawing.Point(447, 526);
            this.stepsInsignificantTrackBar.Margin = new System.Windows.Forms.Padding(4);
            this.stepsInsignificantTrackBar.Maximum = 100;
            this.stepsInsignificantTrackBar.Minimum = 1;
            this.stepsInsignificantTrackBar.Name = "stepsInsignificantTrackBar";
            this.stepsInsignificantTrackBar.Size = new System.Drawing.Size(299, 56);
            this.stepsInsignificantTrackBar.TabIndex = 27;
            this.stepsInsignificantTrackBar.Value = 1;
            this.stepsInsignificantTrackBar.ValueChanged += new System.EventHandler(this.stepsInsignificantTrackBar_ValueChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(443, 373);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(133, 17);
            this.label12.TabIndex = 28;
            this.label12.Text = "Insignificant change";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(443, 494);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(282, 17);
            this.label13.TabIndex = 29;
            this.label13.Text = "Max. steps to run without significant change";
            // 
            // initialTemp
            // 
            this.initialTemp.AutoSize = true;
            this.initialTemp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.initialTemp.Location = new System.Drawing.Point(565, 54);
            this.initialTemp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.initialTemp.Name = "initialTemp";
            this.initialTemp.Size = new System.Drawing.Size(34, 19);
            this.initialTemp.TabIndex = 30;
            this.initialTemp.Text = "100";
            // 
            // tempDecrease
            // 
            this.tempDecrease.AutoSize = true;
            this.tempDecrease.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tempDecrease.Location = new System.Drawing.Point(596, 145);
            this.tempDecrease.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tempDecrease.Name = "tempDecrease";
            this.tempDecrease.Size = new System.Drawing.Size(38, 19);
            this.tempDecrease.TabIndex = 31;
            this.tempDecrease.Text = "0,01";
            // 
            // unchangedTemp
            // 
            this.unchangedTemp.AutoSize = true;
            this.unchangedTemp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.unchangedTemp.Location = new System.Drawing.Point(787, 265);
            this.unchangedTemp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.unchangedTemp.Name = "unchangedTemp";
            this.unchangedTemp.Size = new System.Drawing.Size(18, 19);
            this.unchangedTemp.TabIndex = 32;
            this.unchangedTemp.Text = "1";
            // 
            // insignificantCh
            // 
            this.insignificantCh.AutoSize = true;
            this.insignificantCh.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.insignificantCh.Location = new System.Drawing.Point(588, 372);
            this.insignificantCh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.insignificantCh.Name = "insignificantCh";
            this.insignificantCh.Size = new System.Drawing.Size(34, 19);
            this.insignificantCh.TabIndex = 33;
            this.insignificantCh.Text = "1 %";
            // 
            // stepsInsignificant
            // 
            this.stepsInsignificant.AutoSize = true;
            this.stepsInsignificant.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.stepsInsignificant.Location = new System.Drawing.Point(737, 494);
            this.stepsInsignificant.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.stepsInsignificant.Name = "stepsInsignificant";
            this.stepsInsignificant.Size = new System.Drawing.Size(18, 19);
            this.stepsInsignificant.TabIndex = 34;
            this.stepsInsignificant.Text = "1";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(31, 645);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(162, 17);
            this.label14.TabIndex = 35;
            this.label14.Text = "System bandwidth [MHz]";
            // 
            // BandwidthComboBox
            // 
            this.BandwidthComboBox.FormattingEnabled = true;
            this.BandwidthComboBox.Items.AddRange(new object[] {
            "1,4",
            "3",
            "5",
            "10",
            "15",
            "20"});
            this.BandwidthComboBox.Location = new System.Drawing.Point(31, 679);
            this.BandwidthComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.BandwidthComboBox.Name = "BandwidthComboBox";
            this.BandwidthComboBox.Size = new System.Drawing.Size(160, 24);
            this.BandwidthComboBox.TabIndex = 36;
            // 
            // folderBrowserDialog
            // 
            this.folderBrowserDialog.Description = "Choose folder for output file";
            this.folderBrowserDialog.HelpRequest += new System.EventHandler(this.folderBrowserDialog_HelpRequest);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 826);
            this.Controls.Add(this.BandwidthComboBox);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.stepsInsignificant);
            this.Controls.Add(this.insignificantCh);
            this.Controls.Add(this.unchangedTemp);
            this.Controls.Add(this.tempDecrease);
            this.Controls.Add(this.initialTemp);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.stepsInsignificantTrackBar);
            this.Controls.Add(this.insignificantChTrackBar);
            this.Controls.Add(this.unchangedTempTrackBar);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tempDecreaseTrackBar);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.TemperatureTrackBar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.FRFcomboBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.LoadDataButton);
            this.Controls.Add(this.trackBarRelayDistance);
            this.Controls.Add(this.distLbl);
            this.Controls.Add(this.trackBarNrRelays);
            this.Controls.Add(this.nrRelayLbl);
            this.Controls.Add(this.trackBarCellSize);
            this.Controls.Add(this.sizeLbl);
            this.Controls.Add(this.nrUsrsLbl);
            this.Controls.Add(this.demandLbl);
            this.Controls.Add(this.trackBarUsrDemand);
            this.Controls.Add(this.trackBarNrUsers);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainWindow";
            this.Text = "LTE resource allocation";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarNrUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarUsrDemand)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarCellSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarNrRelays)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRelayDistance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TemperatureTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tempDecreaseTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unchangedTempTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.insignificantChTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stepsInsignificantTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TrackBar trackBarNrUsers;
        private System.Windows.Forms.TrackBar trackBarUsrDemand;
        private System.Windows.Forms.Label demandLbl;
        private System.Windows.Forms.Label nrUsrsLbl;
        private System.Windows.Forms.Label sizeLbl;
        private System.Windows.Forms.TrackBar trackBarCellSize;
        private System.Windows.Forms.Label nrRelayLbl;
        private System.Windows.Forms.TrackBar trackBarNrRelays;
        private System.Windows.Forms.Label distLbl;
        private System.Windows.Forms.TrackBar trackBarRelayDistance;
        private System.Windows.Forms.Button LoadDataButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox FRFcomboBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TrackBar TemperatureTrackBar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TrackBar tempDecreaseTrackBar;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TrackBar unchangedTempTrackBar;
        private System.Windows.Forms.TrackBar insignificantChTrackBar;
        private System.Windows.Forms.TrackBar stepsInsignificantTrackBar;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label initialTemp;
        private System.Windows.Forms.Label tempDecrease;
        private System.Windows.Forms.Label unchangedTemp;
        private System.Windows.Forms.Label insignificantCh;
        private System.Windows.Forms.Label stepsInsignificant;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox BandwidthComboBox;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
    }
}

