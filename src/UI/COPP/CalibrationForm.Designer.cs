namespace COPP
{
    partial class CalibrationForm
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonSpotBrowser = new System.Windows.Forms.Button();
            this.buttonBrowser = new System.Windows.Forms.Button();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOk = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.buttonCalibrate = new System.Windows.Forms.Button();
            this.labele0 = new System.Windows.Forms.Label();
            this.labelx0 = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.labelk = new System.Windows.Forms.Label();
            this.labelmu_e = new System.Windows.Forms.Label();
            this.labelsigma_x = new System.Windows.Forms.Label();
            this.labelsigma_e = new System.Windows.Forms.Label();
            this.labelpxe = new System.Windows.Forms.Label();
            this.labellambdae = new System.Windows.Forms.Label();
            this.labellambdax = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.buttonDefault = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonSet = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.labelMaxIter = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(82, 2);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(16, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "k:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "mu_e";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "p_xe";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 33;
            this.label3.Text = "sigma_e";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(66, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 35;
            this.label4.Text = "sigma_x:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(63, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 37;
            this.label5.Text = "lambda_e";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(64, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 39;
            this.label6.Text = "lambda_x";
            // 
            // buttonSpotBrowser
            // 
            this.buttonSpotBrowser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonSpotBrowser.Location = new System.Drawing.Point(222, 262);
            this.buttonSpotBrowser.Name = "buttonSpotBrowser";
            this.buttonSpotBrowser.Size = new System.Drawing.Size(94, 23);
            this.buttonSpotBrowser.TabIndex = 51;
            this.buttonSpotBrowser.Text = "Select data...";
            this.buttonSpotBrowser.UseVisualStyleBackColor = true;
            this.buttonSpotBrowser.Click += new System.EventHandler(this.buttonLoadSpot_Click);
            // 
            // buttonBrowser
            // 
            this.buttonBrowser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonBrowser.Location = new System.Drawing.Point(222, 230);
            this.buttonBrowser.Name = "buttonBrowser";
            this.buttonBrowser.Size = new System.Drawing.Size(94, 21);
            this.buttonBrowser.TabIndex = 27;
            this.buttonBrowser.Text = "Select data...";
            this.buttonBrowser.UseVisualStyleBackColor = true;
            this.buttonBrowser.Click += new System.EventHandler(this.buttonLoadFutures_Click);
            // 
            // buttonLoad
            // 
            this.buttonLoad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonLoad.Location = new System.Drawing.Point(40, 364);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(100, 23);
            this.buttonLoad.TabIndex = 48;
            this.buttonLoad.Text = "Load parameters";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonSave.Location = new System.Drawing.Point(219, 364);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(100, 23);
            this.buttonSave.TabIndex = 49;
            this.buttonSave.Text = "Save parameters";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonCancel.Location = new System.Drawing.Point(222, 448);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(94, 23);
            this.buttonCancel.TabIndex = 47;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonOk
            // 
            this.buttonOk.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOk.Enabled = false;
            this.buttonOk.Location = new System.Drawing.Point(43, 448);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(94, 23);
            this.buttonOk.TabIndex = 45;
            this.buttonOk.Text = "Ok";
            this.buttonOk.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 267);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(159, 13);
            this.label10.TabIndex = 50;
            this.label10.Text = "Real spot prices(not mandatory):";
            // 
            // buttonCalibrate
            // 
            this.buttonCalibrate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonCalibrate.Enabled = false;
            this.buttonCalibrate.Location = new System.Drawing.Point(222, 295);
            this.buttonCalibrate.Name = "buttonCalibrate";
            this.buttonCalibrate.Size = new System.Drawing.Size(94, 22);
            this.buttonCalibrate.TabIndex = 46;
            this.buttonCalibrate.Text = "Calibrate";
            this.buttonCalibrate.UseVisualStyleBackColor = true;
            this.buttonCalibrate.Click += new System.EventHandler(this.buttonCalibration_Click);
            // 
            // labele0
            // 
            this.labele0.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labele0.AutoSize = true;
            this.labele0.Location = new System.Drawing.Point(248, 181);
            this.labele0.Name = "labele0";
            this.labele0.Size = new System.Drawing.Size(41, 13);
            this.labele0.TabIndex = 52;
            this.labele0.Text = "label11";
            // 
            // labelx0
            // 
            this.labelx0.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelx0.AutoSize = true;
            this.labelx0.Location = new System.Drawing.Point(248, 155);
            this.labelx0.Name = "labelx0";
            this.labelx0.Size = new System.Drawing.Size(41, 13);
            this.labelx0.TabIndex = 53;
            this.labelx0.Text = "label11";
            // 
            // labelk
            // 
            this.labelk.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelk.AutoSize = true;
            this.labelk.Location = new System.Drawing.Point(248, 2);
            this.labelk.Name = "labelk";
            this.labelk.Size = new System.Drawing.Size(41, 13);
            this.labelk.TabIndex = 54;
            this.labelk.Text = "label11";
            // 
            // labelmu_e
            // 
            this.labelmu_e.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelmu_e.AutoSize = true;
            this.labelmu_e.Location = new System.Drawing.Point(248, 39);
            this.labelmu_e.Name = "labelmu_e";
            this.labelmu_e.Size = new System.Drawing.Size(41, 13);
            this.labelmu_e.TabIndex = 55;
            this.labelmu_e.Text = "label11";
            // 
            // labelsigma_x
            // 
            this.labelsigma_x.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelsigma_x.AutoSize = true;
            this.labelsigma_x.Location = new System.Drawing.Point(248, 20);
            this.labelsigma_x.Name = "labelsigma_x";
            this.labelsigma_x.Size = new System.Drawing.Size(41, 13);
            this.labelsigma_x.TabIndex = 56;
            this.labelsigma_x.Text = "label11";
            // 
            // labelsigma_e
            // 
            this.labelsigma_e.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelsigma_e.AutoSize = true;
            this.labelsigma_e.Location = new System.Drawing.Point(248, 60);
            this.labelsigma_e.Name = "labelsigma_e";
            this.labelsigma_e.Size = new System.Drawing.Size(41, 13);
            this.labelsigma_e.TabIndex = 57;
            this.labelsigma_e.Text = "label11";
            // 
            // labelpxe
            // 
            this.labelpxe.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelpxe.AutoSize = true;
            this.labelpxe.Location = new System.Drawing.Point(248, 83);
            this.labelpxe.Name = "labelpxe";
            this.labelpxe.Size = new System.Drawing.Size(41, 13);
            this.labelpxe.TabIndex = 58;
            this.labelpxe.Text = "label11";
            // 
            // labellambdae
            // 
            this.labellambdae.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labellambdae.AutoSize = true;
            this.labellambdae.Location = new System.Drawing.Point(248, 108);
            this.labellambdae.Name = "labellambdae";
            this.labellambdae.Size = new System.Drawing.Size(41, 13);
            this.labellambdae.TabIndex = 59;
            this.labellambdae.Text = "label12";
            // 
            // labellambdax
            // 
            this.labellambdax.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labellambdax.AutoSize = true;
            this.labellambdax.Location = new System.Drawing.Point(248, 132);
            this.labellambdax.Name = "labellambdax";
            this.labellambdax.Size = new System.Drawing.Size(41, 13);
            this.labellambdax.TabIndex = 60;
            this.labellambdax.Text = "label13";
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(55, 234);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(69, 13);
            this.label14.TabIndex = 61;
            this.label14.Text = "Futures data:";
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(81, 155);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(18, 13);
            this.label15.TabIndex = 62;
            this.label15.Text = "x0";
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(80, 181);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(19, 13);
            this.label16.TabIndex = 54;
            this.label16.Text = "e0";
            // 
            // buttonDefault
            // 
            this.buttonDefault.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonDefault.Location = new System.Drawing.Point(43, 327);
            this.buttonDefault.Name = "buttonDefault";
            this.buttonDefault.Size = new System.Drawing.Size(94, 23);
            this.buttonDefault.TabIndex = 63;
            this.buttonDefault.Text = "Default";
            this.buttonDefault.UseVisualStyleBackColor = true;
            this.buttonDefault.Click += new System.EventHandler(this.buttonDefault_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label9, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelk, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelsigma_x, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelmu_e, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label15, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.labelsigma_e, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.labele0, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.labelpxe, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.labellambdae, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.labelx0, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.labellambdax, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.buttonCancel, 1, 15);
            this.tableLayoutPanel1.Controls.Add(this.buttonOk, 0, 15);
            this.tableLayoutPanel1.Controls.Add(this.buttonLoad, 0, 14);
            this.tableLayoutPanel1.Controls.Add(this.buttonSave, 1, 14);
            this.tableLayoutPanel1.Controls.Add(this.buttonSet, 1, 13);
            this.tableLayoutPanel1.Controls.Add(this.buttonDefault, 0, 13);
            this.tableLayoutPanel1.Controls.Add(this.buttonCalibrate, 1, 12);
            this.tableLayoutPanel1.Controls.Add(this.buttonSpotBrowser, 1, 11);
            this.tableLayoutPanel1.Controls.Add(this.label10, 0, 11);
            this.tableLayoutPanel1.Controls.Add(this.label14, 0, 10);
            this.tableLayoutPanel1.Controls.Add(this.buttonBrowser, 1, 10);
            this.tableLayoutPanel1.Controls.Add(this.label16, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.labelMaxIter, 1, 9);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 16;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.36842F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.63158F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 17F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 128F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(359, 525);
            this.tableLayoutPanel1.TabIndex = 64;
            // 
            // buttonSet
            // 
            this.buttonSet.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonSet.Location = new System.Drawing.Point(217, 327);
            this.buttonSet.Name = "buttonSet";
            this.buttonSet.Size = new System.Drawing.Size(104, 23);
            this.buttonSet.TabIndex = 64;
            this.buttonSet.Text = "Set parameters";
            this.buttonSet.UseVisualStyleBackColor = true;
            this.buttonSet.Click += new System.EventHandler(this.buttonSet_Click);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(52, 207);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 13);
            this.label7.TabIndex = 65;
            this.label7.Text = "Max iterations:";
            // 
            // labelMaxIter
            // 
            this.labelMaxIter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelMaxIter.AutoSize = true;
            this.labelMaxIter.Location = new System.Drawing.Point(251, 207);
            this.labelMaxIter.Name = "labelMaxIter";
            this.labelMaxIter.Size = new System.Drawing.Size(35, 13);
            this.labelMaxIter.TabIndex = 66;
            this.labelMaxIter.Text = "label8";
            // 
            // CalibrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(359, 525);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "CalibrationForm";
            this.Text = "Calibration";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CalibrationForm_FormClosing);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonCalibrate;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonBrowser;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button buttonSpotBrowser;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label labele0;
        private System.Windows.Forms.Label labelx0;
        private System.Windows.Forms.Label labelk;
        private System.Windows.Forms.Label labelmu_e;
        private System.Windows.Forms.Label labelsigma_x;
        private System.Windows.Forms.Label labelsigma_e;
        private System.Windows.Forms.Label labelpxe;
        private System.Windows.Forms.Label labellambdae;
        private System.Windows.Forms.Label labellambdax;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button buttonDefault;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button buttonSet;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelMaxIter;
    }
}

