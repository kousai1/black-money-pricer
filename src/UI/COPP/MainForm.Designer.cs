namespace COPP
{
    partial class MainForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonCalibrate = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridViewOption = new System.Windows.Forms.DataGridView();
            this.UnderlyingColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StrikeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExpiryColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonSaveOption = new System.Windows.Forms.Button();
            this.buttonLoadOption = new System.Windows.Forms.Button();
            this.buttonRemoveOption = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonAddOption = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.curveViewer = new COPP.CurveViewer();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.labelXY = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.numericUpDownYmax = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownYmin = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownXMas = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownXMin = new System.Windows.Forms.NumericUpDown();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridViewFutures = new System.Windows.Forms.DataGridView();
            this.Maturity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonSaveFutures = new System.Windows.Forms.Button();
            this.buttonLoadFutures = new System.Windows.Forms.Button();
            this.buttonRemoveFuture = new System.Windows.Forms.Button();
            this.buttonClearFuture = new System.Windows.Forms.Button();
            this.buttonAddFuture = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOption)).BeginInit();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownYmax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownYmin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownXMas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownXMin)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFutures)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.buttonCalibrate);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(935, 61);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Calibration";
            // 
            // buttonCalibrate
            // 
            this.buttonCalibrate.Location = new System.Drawing.Point(15, 19);
            this.buttonCalibrate.Name = "buttonCalibrate";
            this.buttonCalibrate.Size = new System.Drawing.Size(75, 23);
            this.buttonCalibrate.TabIndex = 0;
            this.buttonCalibrate.Text = "Calibrate";
            this.buttonCalibrate.UseVisualStyleBackColor = true;
            this.buttonCalibrate.Click += new System.EventHandler(this.buttonCalibrate_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridViewOption);
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(921, 524);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pricing";
            // 
            // dataGridViewOption
            // 
            this.dataGridViewOption.AllowUserToAddRows = false;
            this.dataGridViewOption.AllowUserToDeleteRows = false;
            this.dataGridViewOption.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewOption.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewOption.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewOption.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOption.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UnderlyingColumn,
            this.StrikeColumn,
            this.ExpiryColumn,
            this.Column1,
            this.PriceColumn});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewOption.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewOption.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewOption.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewOption.Name = "dataGridViewOption";
            this.dataGridViewOption.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewOption.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewOption.Size = new System.Drawing.Size(915, 446);
            this.dataGridViewOption.TabIndex = 0;
            // 
            // UnderlyingColumn
            // 
            this.UnderlyingColumn.HeaderText = "Spot price";
            this.UnderlyingColumn.Name = "UnderlyingColumn";
            this.UnderlyingColumn.ReadOnly = true;
            // 
            // StrikeColumn
            // 
            this.StrikeColumn.HeaderText = "Strike Price";
            this.StrikeColumn.Name = "StrikeColumn";
            this.StrikeColumn.ReadOnly = true;
            // 
            // ExpiryColumn
            // 
            this.ExpiryColumn.HeaderText = "Days Until Expiry";
            this.ExpiryColumn.Name = "ExpiryColumn";
            this.ExpiryColumn.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Call/Put";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // PriceColumn
            // 
            this.PriceColumn.HeaderText = "Price";
            this.PriceColumn.Name = "PriceColumn";
            this.PriceColumn.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonSaveOption);
            this.panel1.Controls.Add(this.buttonLoadOption);
            this.panel1.Controls.Add(this.buttonRemoveOption);
            this.panel1.Controls.Add(this.buttonClear);
            this.panel1.Controls.Add(this.buttonAddOption);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(3, 462);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(915, 59);
            this.panel1.TabIndex = 5;
            // 
            // buttonSaveOption
            // 
            this.buttonSaveOption.Location = new System.Drawing.Point(485, 13);
            this.buttonSaveOption.Name = "buttonSaveOption";
            this.buttonSaveOption.Size = new System.Drawing.Size(95, 23);
            this.buttonSaveOption.TabIndex = 9;
            this.buttonSaveOption.Text = "Save Options";
            this.buttonSaveOption.UseVisualStyleBackColor = true;
            this.buttonSaveOption.Click += new System.EventHandler(this.buttonSaveOption_Click);
            // 
            // buttonLoadOption
            // 
            this.buttonLoadOption.Location = new System.Drawing.Point(384, 13);
            this.buttonLoadOption.Name = "buttonLoadOption";
            this.buttonLoadOption.Size = new System.Drawing.Size(95, 23);
            this.buttonLoadOption.TabIndex = 8;
            this.buttonLoadOption.Text = "Load Options";
            this.buttonLoadOption.UseVisualStyleBackColor = true;
            this.buttonLoadOption.Click += new System.EventHandler(this.buttonLoadOption_Click);
            // 
            // buttonRemoveOption
            // 
            this.buttonRemoveOption.Location = new System.Drawing.Point(237, 13);
            this.buttonRemoveOption.Name = "buttonRemoveOption";
            this.buttonRemoveOption.Size = new System.Drawing.Size(140, 23);
            this.buttonRemoveOption.TabIndex = 5;
            this.buttonRemoveOption.Text = "Remove selected Option";
            this.buttonRemoveOption.UseVisualStyleBackColor = true;
            this.buttonRemoveOption.Click += new System.EventHandler(this.buttonRemoveOption_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(20, 13);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(110, 23);
            this.buttonClear.TabIndex = 4;
            this.buttonClear.Text = "Clear table";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonAddOption
            // 
            this.buttonAddOption.Location = new System.Drawing.Point(136, 13);
            this.buttonAddOption.Name = "buttonAddOption";
            this.buttonAddOption.Size = new System.Drawing.Size(95, 23);
            this.buttonAddOption.TabIndex = 2;
            this.buttonAddOption.Text = "Add Option...";
            this.buttonAddOption.UseVisualStyleBackColor = true;
            this.buttonAddOption.Click += new System.EventHandler(this.buttonAddOption_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 61);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(935, 556);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(927, 530);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Option pricing";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.curveViewer);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(927, 530);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Generated Spot";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // curveViewer
            // 
            this.curveViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.curveViewer.Location = new System.Drawing.Point(215, 3);
            this.curveViewer.Name = "curveViewer";
            this.curveViewer.Size = new System.Drawing.Size(709, 524);
            this.curveViewer.TabIndex = 4;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.labelXY);
            this.groupBox3.Controls.Add(this.button7);
            this.groupBox3.Controls.Add(this.button6);
            this.groupBox3.Controls.Add(this.button5);
            this.groupBox3.Controls.Add(this.button4);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.numericUpDownYmax);
            this.groupBox3.Controls.Add(this.numericUpDownYmin);
            this.groupBox3.Controls.Add(this.numericUpDownXMas);
            this.groupBox3.Controls.Add(this.numericUpDownXMin);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox3.Location = new System.Drawing.Point(3, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(212, 524);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Axis options";
            // 
            // labelXY
            // 
            this.labelXY.AutoSize = true;
            this.labelXY.Location = new System.Drawing.Point(6, 217);
            this.labelXY.Name = "labelXY";
            this.labelXY.Size = new System.Drawing.Size(0, 13);
            this.labelXY.TabIndex = 13;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(3, 153);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(100, 23);
            this.button7.TabIndex = 12;
            this.button7.Text = "Clear curves";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.buttonClearCurve_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(3, 182);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(100, 23);
            this.button6.TabIndex = 11;
            this.button6.Text = "Load curves";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.buttonLoadCurve_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(106, 153);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(100, 23);
            this.button5.TabIndex = 10;
            this.button5.Text = "Export to image";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.buttonExportImage_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(106, 182);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 23);
            this.button4.TabIndex = 9;
            this.button4.Text = "Save curves";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.buttonSaveCurve_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "YMax:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "YMin:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "XMax:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "XMin:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(86, 124);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Set";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonSetAxis_Click);
            // 
            // numericUpDownYmax
            // 
            this.numericUpDownYmax.Location = new System.Drawing.Point(86, 97);
            this.numericUpDownYmax.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numericUpDownYmax.Name = "numericUpDownYmax";
            this.numericUpDownYmax.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownYmax.TabIndex = 3;
            // 
            // numericUpDownYmin
            // 
            this.numericUpDownYmin.Location = new System.Drawing.Point(86, 71);
            this.numericUpDownYmin.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numericUpDownYmin.Name = "numericUpDownYmin";
            this.numericUpDownYmin.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownYmin.TabIndex = 2;
            // 
            // numericUpDownXMas
            // 
            this.numericUpDownXMas.Location = new System.Drawing.Point(86, 45);
            this.numericUpDownXMas.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.numericUpDownXMas.Name = "numericUpDownXMas";
            this.numericUpDownXMas.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownXMas.TabIndex = 1;
            // 
            // numericUpDownXMin
            // 
            this.numericUpDownXMin.Location = new System.Drawing.Point(86, 19);
            this.numericUpDownXMin.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownXMin.Name = "numericUpDownXMin";
            this.numericUpDownXMin.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownXMin.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox4);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(927, 530);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Future Pricing";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridViewFutures);
            this.groupBox4.Controls.Add(this.panel2);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(3, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(921, 524);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Pricing";
            // 
            // dataGridViewFutures
            // 
            this.dataGridViewFutures.AllowUserToAddRows = false;
            this.dataGridViewFutures.AllowUserToDeleteRows = false;
            this.dataGridViewFutures.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewFutures.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewFutures.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewFutures.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFutures.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Maturity,
            this.dataGridViewTextBoxColumn5});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewFutures.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewFutures.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewFutures.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewFutures.Name = "dataGridViewFutures";
            this.dataGridViewFutures.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewFutures.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewFutures.Size = new System.Drawing.Size(915, 446);
            this.dataGridViewFutures.TabIndex = 0;
            // 
            // Maturity
            // 
            this.Maturity.HeaderText = "Maturity";
            this.Maturity.Name = "Maturity";
            this.Maturity.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Price";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.buttonSaveFutures);
            this.panel2.Controls.Add(this.buttonLoadFutures);
            this.panel2.Controls.Add(this.buttonRemoveFuture);
            this.panel2.Controls.Add(this.buttonClearFuture);
            this.panel2.Controls.Add(this.buttonAddFuture);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(3, 462);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(915, 59);
            this.panel2.TabIndex = 5;
            // 
            // buttonSaveFutures
            // 
            this.buttonSaveFutures.Location = new System.Drawing.Point(484, 13);
            this.buttonSaveFutures.Name = "buttonSaveFutures";
            this.buttonSaveFutures.Size = new System.Drawing.Size(95, 23);
            this.buttonSaveFutures.TabIndex = 7;
            this.buttonSaveFutures.Text = "Save Futures";
            this.buttonSaveFutures.UseVisualStyleBackColor = true;
            this.buttonSaveFutures.Click += new System.EventHandler(this.buttonSaveFutures_Click);
            // 
            // buttonLoadFutures
            // 
            this.buttonLoadFutures.Location = new System.Drawing.Point(383, 13);
            this.buttonLoadFutures.Name = "buttonLoadFutures";
            this.buttonLoadFutures.Size = new System.Drawing.Size(95, 23);
            this.buttonLoadFutures.TabIndex = 6;
            this.buttonLoadFutures.Text = "Load Futures";
            this.buttonLoadFutures.UseVisualStyleBackColor = true;
            this.buttonLoadFutures.Click += new System.EventHandler(this.buttonLoadFutures_Click);
            // 
            // buttonRemoveFuture
            // 
            this.buttonRemoveFuture.Location = new System.Drawing.Point(237, 13);
            this.buttonRemoveFuture.Name = "buttonRemoveFuture";
            this.buttonRemoveFuture.Size = new System.Drawing.Size(140, 23);
            this.buttonRemoveFuture.TabIndex = 5;
            this.buttonRemoveFuture.Text = "Remove selected Future";
            this.buttonRemoveFuture.UseVisualStyleBackColor = true;
            this.buttonRemoveFuture.Click += new System.EventHandler(this.buttonRemoveFuture_Click);
            // 
            // buttonClearFuture
            // 
            this.buttonClearFuture.Location = new System.Drawing.Point(20, 13);
            this.buttonClearFuture.Name = "buttonClearFuture";
            this.buttonClearFuture.Size = new System.Drawing.Size(110, 23);
            this.buttonClearFuture.TabIndex = 4;
            this.buttonClearFuture.Text = "Clear table";
            this.buttonClearFuture.UseVisualStyleBackColor = true;
            this.buttonClearFuture.Click += new System.EventHandler(this.buttonClearFuture_Click);
            // 
            // buttonAddFuture
            // 
            this.buttonAddFuture.Location = new System.Drawing.Point(136, 13);
            this.buttonAddFuture.Name = "buttonAddFuture";
            this.buttonAddFuture.Size = new System.Drawing.Size(95, 23);
            this.buttonAddFuture.TabIndex = 2;
            this.buttonAddFuture.Text = "Add Future...";
            this.buttonAddFuture.UseVisualStyleBackColor = true;
            this.buttonAddFuture.Click += new System.EventHandler(this.buttonAddFuture_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(935, 617);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainForm";
            this.Text = "Crude Oil Product Pricing";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOption)).EndInit();
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownYmax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownYmin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownXMas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownXMin)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFutures)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonCalibrate;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridViewOption;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonAddOption;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
       
        private System.Windows.Forms.TabPage tabPage2;
      
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown numericUpDownYmax;
        private System.Windows.Forms.NumericUpDown numericUpDownYmin;
        private System.Windows.Forms.NumericUpDown numericUpDownXMas;
        private System.Windows.Forms.NumericUpDown numericUpDownXMin;
        private CurveViewer curveViewer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button buttonRemoveOption;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataGridViewFutures;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonRemoveFuture;
        private System.Windows.Forms.Button buttonClearFuture;
        private System.Windows.Forms.Button buttonAddFuture;
        private System.Windows.Forms.DataGridViewTextBoxColumn Maturity;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Button buttonSaveFutures;
        private System.Windows.Forms.Button buttonLoadFutures;
        private System.Windows.Forms.Button buttonSaveOption;
        private System.Windows.Forms.Button buttonLoadOption;
        private System.Windows.Forms.Label labelXY;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnderlyingColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn StrikeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExpiryColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceColumn;
    }
}