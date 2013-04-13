namespace COPP
{
    partial class ParamCalibrationForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxk = new System.Windows.Forms.TextBox();
            this.textBoxLambda_x = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxLambda_e = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxPe_x = new System.Windows.Forms.TextBox();
            this.textBoxSigma_e = new System.Windows.Forms.TextBox();
            this.textBoxSigma_x = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxMu_e = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxx0 = new System.Windows.Forms.TextBox();
            this.textBoxe0 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonOk = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.numericUpDownMaxIter = new System.Windows.Forms.NumericUpDown();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxIter)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.label9, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBoxk, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBoxLambda_x, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBoxLambda_e, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.textBoxPe_x, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.textBoxSigma_e, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.textBoxSigma_x, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.textBoxMu_e, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.textBoxx0, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.textBoxe0, 1, 9);
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.buttonOk, 0, 11);
            this.tableLayoutPanel1.Controls.Add(this.button1, 1, 11);
            this.tableLayoutPanel1.Controls.Add(this.label10, 0, 10);
            this.tableLayoutPanel1.Controls.Add(this.numericUpDownMaxIter, 1, 10);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 12;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(352, 341);
            this.tableLayoutPanel1.TabIndex = 43;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(79, 193);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 13);
            this.label7.TabIndex = 41;
            this.label7.Text = "x0";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(81, 6);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(13, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "k";
            // 
            // textBoxk
            // 
            this.textBoxk.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxk.Location = new System.Drawing.Point(214, 3);
            this.textBoxk.Name = "textBoxk";
            this.textBoxk.Size = new System.Drawing.Size(100, 20);
            this.textBoxk.TabIndex = 25;
            this.textBoxk.Text = "1.0";
            // 
            // textBoxLambda_x
            // 
            this.textBoxLambda_x.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxLambda_x.Location = new System.Drawing.Point(214, 159);
            this.textBoxLambda_x.Name = "textBoxLambda_x";
            this.textBoxLambda_x.Size = new System.Drawing.Size(100, 20);
            this.textBoxLambda_x.TabIndex = 40;
            this.textBoxLambda_x.Text = "0.1";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "mu_e";
            // 
            // textBoxLambda_e
            // 
            this.textBoxLambda_e.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxLambda_e.Location = new System.Drawing.Point(214, 133);
            this.textBoxLambda_e.Name = "textBoxLambda_e";
            this.textBoxLambda_e.Size = new System.Drawing.Size(100, 20);
            this.textBoxLambda_e.TabIndex = 38;
            this.textBoxLambda_e.Text = "0";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(62, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 39;
            this.label6.Text = "lambda_x";
            // 
            // textBoxPe_x
            // 
            this.textBoxPe_x.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxPe_x.Location = new System.Drawing.Point(214, 107);
            this.textBoxPe_x.Name = "textBoxPe_x";
            this.textBoxPe_x.Size = new System.Drawing.Size(100, 20);
            this.textBoxPe_x.TabIndex = 32;
            this.textBoxPe_x.Text = "0.5";
            // 
            // textBoxSigma_e
            // 
            this.textBoxSigma_e.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxSigma_e.Location = new System.Drawing.Point(214, 81);
            this.textBoxSigma_e.Name = "textBoxSigma_e";
            this.textBoxSigma_e.Size = new System.Drawing.Size(100, 20);
            this.textBoxSigma_e.TabIndex = 34;
            this.textBoxSigma_e.Text = "0.1";
            // 
            // textBoxSigma_x
            // 
            this.textBoxSigma_x.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxSigma_x.Location = new System.Drawing.Point(214, 55);
            this.textBoxSigma_x.Name = "textBoxSigma_x";
            this.textBoxSigma_x.Size = new System.Drawing.Size(100, 20);
            this.textBoxSigma_x.TabIndex = 36;
            this.textBoxSigma_x.Text = "0.1";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(65, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 35;
            this.label4.Text = "sigma_x";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 33;
            this.label3.Text = "sigma_e";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(61, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 37;
            this.label5.Text = "lambda_e";
            // 
            // textBoxMu_e
            // 
            this.textBoxMu_e.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxMu_e.Location = new System.Drawing.Point(214, 29);
            this.textBoxMu_e.Name = "textBoxMu_e";
            this.textBoxMu_e.Size = new System.Drawing.Size(100, 20);
            this.textBoxMu_e.TabIndex = 30;
            this.textBoxMu_e.Text = "0.05";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "p_xe";
            // 
            // textBoxx0
            // 
            this.textBoxx0.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxx0.Location = new System.Drawing.Point(214, 189);
            this.textBoxx0.Name = "textBoxx0";
            this.textBoxx0.Size = new System.Drawing.Size(100, 20);
            this.textBoxx0.TabIndex = 42;
            this.textBoxx0.Text = "0.1";
            // 
            // textBoxe0
            // 
            this.textBoxe0.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxe0.Location = new System.Drawing.Point(214, 225);
            this.textBoxe0.Name = "textBoxe0";
            this.textBoxe0.Size = new System.Drawing.Size(100, 20);
            this.textBoxe0.TabIndex = 44;
            this.textBoxe0.Text = "0.1";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(78, 229);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(19, 13);
            this.label8.TabIndex = 43;
            this.label8.Text = "e0";
            // 
            // buttonOk
            // 
            this.buttonOk.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOk.Location = new System.Drawing.Point(41, 304);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(94, 23);
            this.buttonOk.TabIndex = 45;
            this.buttonOk.Text = "Set";
            this.buttonOk.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Location = new System.Drawing.Point(217, 304);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 23);
            this.button1.TabIndex = 47;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(51, 265);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 13);
            this.label10.TabIndex = 48;
            this.label10.Text = "Max Iterations";
            // 
            // numericUpDownMaxIter
            // 
            this.numericUpDownMaxIter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numericUpDownMaxIter.Location = new System.Drawing.Point(204, 262);
            this.numericUpDownMaxIter.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownMaxIter.Name = "numericUpDownMaxIter";
            this.numericUpDownMaxIter.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownMaxIter.TabIndex = 49;
            // 
            // ParamCalibrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 341);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ParamCalibrationForm";
            this.Text = "ParamCalibrationForm";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxIter)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxk;
        private System.Windows.Forms.TextBox textBoxLambda_x;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxLambda_e;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxPe_x;
        private System.Windows.Forms.TextBox textBoxSigma_e;
        private System.Windows.Forms.TextBox textBoxSigma_x;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxMu_e;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxx0;
        private System.Windows.Forms.TextBox textBoxe0;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown numericUpDownMaxIter;
    }
}