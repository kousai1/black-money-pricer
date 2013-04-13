namespace COPP
{
    partial class AddOptionForm
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
            this.labelStrike = new System.Windows.Forms.Label();
            this.labelHistorical = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePickerexpiry = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerBuy = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDownnbDays = new System.Windows.Forms.NumericUpDown();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButtonDate = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButtonCall = new System.Windows.Forms.RadioButton();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBoxVolatility = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownnbDays)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelStrike
            // 
            this.labelStrike.AutoSize = true;
            this.labelStrike.Location = new System.Drawing.Point(14, 39);
            this.labelStrike.Name = "labelStrike";
            this.labelStrike.Size = new System.Drawing.Size(63, 13);
            this.labelStrike.TabIndex = 0;
            this.labelStrike.Text = "Strike price:";
            // 
            // labelHistorical
            // 
            this.labelHistorical.AutoSize = true;
            this.labelHistorical.Location = new System.Drawing.Point(13, 286);
            this.labelHistorical.Name = "labelHistorical";
            this.labelHistorical.Size = new System.Drawing.Size(93, 13);
            this.labelHistorical.TabIndex = 2;
            this.labelHistorical.Text = "Historical volatility:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePickerexpiry);
            this.groupBox1.Controls.Add(this.dateTimePickerBuy);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.numericUpDownnbDays);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButtonDate);
            this.groupBox1.Location = new System.Drawing.Point(6, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(365, 132);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Maturity";
            // 
            // dateTimePickerexpiry
            // 
            this.dateTimePickerexpiry.Location = new System.Drawing.Point(142, 92);
            this.dateTimePickerexpiry.Name = "dateTimePickerexpiry";
            this.dateTimePickerexpiry.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerexpiry.TabIndex = 7;
            // 
            // dateTimePickerBuy
            // 
            this.dateTimePickerBuy.Location = new System.Drawing.Point(142, 66);
            this.dateTimePickerBuy.Name = "dateTimePickerBuy";
            this.dateTimePickerBuy.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerBuy.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Expiry Date:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Buying Date:";
            // 
            // numericUpDownnbDays
            // 
            this.numericUpDownnbDays.Location = new System.Drawing.Point(85, 19);
            this.numericUpDownnbDays.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownnbDays.Name = "numericUpDownnbDays";
            this.numericUpDownnbDays.Size = new System.Drawing.Size(65, 20);
            this.numericUpDownnbDays.TabIndex = 3;
            this.numericUpDownnbDays.Value = new decimal(new int[] {
            140,
            0,
            0,
            0});
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(10, 68);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(51, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Date:";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButtonDate
            // 
            this.radioButtonDate.AutoSize = true;
            this.radioButtonDate.Location = new System.Drawing.Point(10, 21);
            this.radioButtonDate.Name = "radioButtonDate";
            this.radioButtonDate.Size = new System.Drawing.Size(69, 17);
            this.radioButtonDate.TabIndex = 0;
            this.radioButtonDate.TabStop = true;
            this.radioButtonDate.Text = "Days left:";
            this.radioButtonDate.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton4);
            this.groupBox2.Controls.Add(this.radioButtonCall);
            this.groupBox2.Location = new System.Drawing.Point(6, 200);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(365, 71);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Option Type";
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(10, 42);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(41, 17);
            this.radioButton4.TabIndex = 2;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Put";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButtonCall
            // 
            this.radioButtonCall.AutoSize = true;
            this.radioButtonCall.Checked = true;
            this.radioButtonCall.Location = new System.Drawing.Point(9, 19);
            this.radioButtonCall.Name = "radioButtonCall";
            this.radioButtonCall.Size = new System.Drawing.Size(42, 17);
            this.radioButtonCall.TabIndex = 1;
            this.radioButtonCall.TabStop = true;
            this.radioButtonCall.Text = "Call";
            this.radioButtonCall.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(213, 281);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 8;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonAdd
            // 
            this.buttonAdd.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonAdd.Location = new System.Drawing.Point(294, 281);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 9;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(112, 35);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(82, 20);
            this.textBox1.TabIndex = 10;
            this.textBox1.Text = "25";
            // 
            // textBoxVolatility
            // 
            this.textBoxVolatility.Location = new System.Drawing.Point(112, 282);
            this.textBoxVolatility.Name = "textBoxVolatility";
            this.textBoxVolatility.Size = new System.Drawing.Size(82, 20);
            this.textBoxVolatility.TabIndex = 11;
            this.textBoxVolatility.Text = "0.22";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(112, 5);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(82, 20);
            this.textBox2.TabIndex = 13;
            this.textBox2.Text = "20";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Spot price at t = 0:";
            // 
            // AddOptionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 310);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxVolatility);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelHistorical);
            this.Controls.Add(this.labelStrike);
            this.Name = "AddOptionForm";
            this.Text = "Add option";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownnbDays)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelStrike;
        private System.Windows.Forms.Label labelHistorical;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButtonDate;
        private System.Windows.Forms.NumericUpDown numericUpDownnbDays;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePickerexpiry;
        private System.Windows.Forms.DateTimePicker dateTimePickerBuy;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButtonCall;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBoxVolatility;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
    }
}