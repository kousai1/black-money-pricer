namespace COPP
{
    partial class DataOpenerForm
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
            this.radioButtonFile = new System.Windows.Forms.RadioButton();
            this.radioButtonURL = new System.Windows.Forms.RadioButton();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.textBoxFile = new System.Windows.Forms.TextBox();
            this.textBoxURL = new System.Windows.Forms.TextBox();
            this.buttonBrowse = new System.Windows.Forms.Button();
            this.buttonOpen = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // radioButtonFile
            // 
            this.radioButtonFile.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioButtonFile.AutoSize = true;
            this.radioButtonFile.Location = new System.Drawing.Point(6, 6);
            this.radioButtonFile.Name = "radioButtonFile";
            this.radioButtonFile.Size = new System.Drawing.Size(44, 17);
            this.radioButtonFile.TabIndex = 0;
            this.radioButtonFile.TabStop = true;
            this.radioButtonFile.Text = "File:";
            this.radioButtonFile.UseVisualStyleBackColor = true;
            // 
            // radioButtonURL
            // 
            this.radioButtonURL.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioButtonURL.AutoSize = true;
            this.radioButtonURL.Location = new System.Drawing.Point(3, 33);
            this.radioButtonURL.Name = "radioButtonURL";
            this.radioButtonURL.Size = new System.Drawing.Size(50, 17);
            this.radioButtonURL.TabIndex = 1;
            this.radioButtonURL.TabStop = true;
            this.radioButtonURL.Text = "URL:";
            this.radioButtonURL.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // textBoxFile
            // 
            this.textBoxFile.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxFile.Location = new System.Drawing.Point(59, 4);
            this.textBoxFile.Name = "textBoxFile";
            this.textBoxFile.Size = new System.Drawing.Size(165, 20);
            this.textBoxFile.TabIndex = 2;
            // 
            // textBoxURL
            // 
            this.textBoxURL.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxURL.Location = new System.Drawing.Point(59, 32);
            this.textBoxURL.Name = "textBoxURL";
            this.textBoxURL.Size = new System.Drawing.Size(165, 20);
            this.textBoxURL.TabIndex = 3;
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonBrowse.Location = new System.Drawing.Point(238, 3);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Size = new System.Drawing.Size(75, 23);
            this.buttonBrowse.TabIndex = 4;
            this.buttonBrowse.Text = "Browse...";
            this.buttonBrowse.UseVisualStyleBackColor = true;
            this.buttonBrowse.Click += new System.EventHandler(this.buttonBrowse_Click);
            // 
            // buttonOpen
            // 
            this.buttonOpen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonOpen.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOpen.Location = new System.Drawing.Point(104, 60);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(75, 23);
            this.buttonOpen.TabIndex = 5;
            this.buttonOpen.Text = "Open";
            this.buttonOpen.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(238, 60);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 6;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.radioButtonFile, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonCancel, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBoxFile, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonOpen, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.buttonBrowse, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBoxURL, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.radioButtonURL, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(324, 88);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // DataOpenerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 88);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "DataOpenerForm";
            this.Text = "Data Opener";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButtonFile;
        private System.Windows.Forms.RadioButton radioButtonURL;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox textBoxFile;
        private System.Windows.Forms.TextBox textBoxURL;
        private System.Windows.Forms.Button buttonBrowse;
        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}