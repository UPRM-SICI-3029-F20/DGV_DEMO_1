namespace DGV_DEMO_1
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
            this.BtnLoadData = new System.Windows.Forms.Button();
            this.listBoxInput = new System.Windows.Forms.ListBox();
            this.BtnSaveData = new System.Windows.Forms.Button();
            this.listBoxOutput = new System.Windows.Forms.ListBox();
            this.dgvDemo = new System.Windows.Forms.DataGridView();
            this.BtnDataToDGV = new System.Windows.Forms.Button();
            this.BtnDataFromDGV = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDemo)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnLoadData
            // 
            this.BtnLoadData.Location = new System.Drawing.Point(111, 21);
            this.BtnLoadData.Name = "BtnLoadData";
            this.BtnLoadData.Size = new System.Drawing.Size(142, 42);
            this.BtnLoadData.TabIndex = 0;
            this.BtnLoadData.Text = "Load data into ListBox";
            this.BtnLoadData.UseVisualStyleBackColor = true;
            this.BtnLoadData.Click += new System.EventHandler(this.BtnLoadData_Click);
            // 
            // listBoxInput
            // 
            this.listBoxInput.FormattingEnabled = true;
            this.listBoxInput.Location = new System.Drawing.Point(12, 85);
            this.listBoxInput.Name = "listBoxInput";
            this.listBoxInput.Size = new System.Drawing.Size(356, 212);
            this.listBoxInput.TabIndex = 1;
            // 
            // BtnSaveData
            // 
            this.BtnSaveData.Location = new System.Drawing.Point(101, 653);
            this.BtnSaveData.Name = "BtnSaveData";
            this.BtnSaveData.Size = new System.Drawing.Size(142, 44);
            this.BtnSaveData.TabIndex = 2;
            this.BtnSaveData.Text = "Save data from ListBox";
            this.BtnSaveData.UseVisualStyleBackColor = true;
            this.BtnSaveData.Click += new System.EventHandler(this.BtnSaveData_Click);
            // 
            // listBoxOutput
            // 
            this.listBoxOutput.FormattingEnabled = true;
            this.listBoxOutput.Location = new System.Drawing.Point(12, 454);
            this.listBoxOutput.Name = "listBoxOutput";
            this.listBoxOutput.Size = new System.Drawing.Size(356, 186);
            this.listBoxOutput.TabIndex = 3;
            // 
            // dgvDemo
            // 
            this.dgvDemo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDemo.Location = new System.Drawing.Point(400, 133);
            this.dgvDemo.Name = "dgvDemo";
            this.dgvDemo.Size = new System.Drawing.Size(711, 394);
            this.dgvDemo.TabIndex = 4;
            // 
            // BtnDataToDGV
            // 
            this.BtnDataToDGV.Location = new System.Drawing.Point(81, 313);
            this.BtnDataToDGV.Name = "BtnDataToDGV";
            this.BtnDataToDGV.Size = new System.Drawing.Size(215, 42);
            this.BtnDataToDGV.TabIndex = 5;
            this.BtnDataToDGV.Text = "Load above data into Data Grid View";
            this.BtnDataToDGV.UseVisualStyleBackColor = true;
            this.BtnDataToDGV.Click += new System.EventHandler(this.BtnDataToDGV_Click);
            // 
            // BtnDataFromDGV
            // 
            this.BtnDataFromDGV.Location = new System.Drawing.Point(81, 396);
            this.BtnDataFromDGV.Name = "BtnDataFromDGV";
            this.BtnDataFromDGV.Size = new System.Drawing.Size(215, 42);
            this.BtnDataFromDGV.TabIndex = 6;
            this.BtnDataFromDGV.Text = "Copy data from DGV into List Box below";
            this.BtnDataFromDGV.UseVisualStyleBackColor = true;
            this.BtnDataFromDGV.Click += new System.EventHandler(this.BtnDataFromDGV_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.Location = new System.Drawing.Point(719, 616);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(75, 23);
            this.BtnExit.TabIndex = 7;
            this.BtnExit.Text = "EXIT";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 709);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BtnDataFromDGV);
            this.Controls.Add(this.BtnDataToDGV);
            this.Controls.Add(this.dgvDemo);
            this.Controls.Add(this.listBoxOutput);
            this.Controls.Add(this.BtnSaveData);
            this.Controls.Add(this.listBoxInput);
            this.Controls.Add(this.BtnLoadData);
            this.Name = "Form1";
            this.Text = "DGV Demo 1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDemo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnLoadData;
        private System.Windows.Forms.ListBox listBoxInput;
        private System.Windows.Forms.Button BtnSaveData;
        private System.Windows.Forms.ListBox listBoxOutput;
        private System.Windows.Forms.DataGridView dgvDemo;
        private System.Windows.Forms.Button BtnDataToDGV;
        private System.Windows.Forms.Button BtnDataFromDGV;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}

