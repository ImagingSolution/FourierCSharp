namespace FourierTransform
{
    partial class MainForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileLoadData = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileSaveFourierData = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFourier = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFourierForward = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFourierBackward = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuWindow = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuWindowHamming = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuWindowHanning = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuWindowBlackman = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.chtData = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chtFourier = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvchtData = new System.Windows.Forms.DataGridView();
            this.dgvFourier = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chtData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chtFourier)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvchtData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFourier)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuFourier,
            this.mnuWindow});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(808, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFileLoadData,
            this.mnuFileSaveFourierData,
            this.toolStripMenuItem1,
            this.mnuFileExit});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(37, 20);
            this.mnuFile.Text = "File";
            // 
            // mnuFileLoadData
            // 
            this.mnuFileLoadData.Name = "mnuFileLoadData";
            this.mnuFileLoadData.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.mnuFileLoadData.Size = new System.Drawing.Size(199, 22);
            this.mnuFileLoadData.Text = "LoadData(*.csv)";
            this.mnuFileLoadData.Click += new System.EventHandler(this.mnuFileLoadData_Click);
            // 
            // mnuFileSaveFourierData
            // 
            this.mnuFileSaveFourierData.Name = "mnuFileSaveFourierData";
            this.mnuFileSaveFourierData.Size = new System.Drawing.Size(199, 22);
            this.mnuFileSaveFourierData.Text = "Save Fourier Data";
            this.mnuFileSaveFourierData.Click += new System.EventHandler(this.mnuFileSaveFourierData_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(196, 6);
            // 
            // mnuFileExit
            // 
            this.mnuFileExit.Name = "mnuFileExit";
            this.mnuFileExit.Size = new System.Drawing.Size(199, 22);
            this.mnuFileExit.Text = "Exit";
            this.mnuFileExit.Click += new System.EventHandler(this.mnuFileExit_Click);
            // 
            // mnuFourier
            // 
            this.mnuFourier.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFourierForward,
            this.mnuFourierBackward});
            this.mnuFourier.Name = "mnuFourier";
            this.mnuFourier.Size = new System.Drawing.Size(106, 20);
            this.mnuFourier.Text = "Fourier direction";
            // 
            // mnuFourierForward
            // 
            this.mnuFourierForward.Checked = true;
            this.mnuFourierForward.CheckOnClick = true;
            this.mnuFourierForward.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mnuFourierForward.Name = "mnuFourierForward";
            this.mnuFourierForward.Size = new System.Drawing.Size(125, 22);
            this.mnuFourierForward.Text = "Forward";
            this.mnuFourierForward.Click += new System.EventHandler(this.mnuFourierForward_Click);
            // 
            // mnuFourierBackward
            // 
            this.mnuFourierBackward.CheckOnClick = true;
            this.mnuFourierBackward.Name = "mnuFourierBackward";
            this.mnuFourierBackward.Size = new System.Drawing.Size(125, 22);
            this.mnuFourierBackward.Text = "Backward";
            this.mnuFourierBackward.Click += new System.EventHandler(this.mnuFourierBackward_Click);
            // 
            // mnuWindow
            // 
            this.mnuWindow.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuWindowHamming,
            this.mnuWindowHanning,
            this.mnuWindowBlackman});
            this.mnuWindow.Name = "mnuWindow";
            this.mnuWindow.Size = new System.Drawing.Size(63, 20);
            this.mnuWindow.Text = "Window";
            // 
            // mnuWindowHamming
            // 
            this.mnuWindowHamming.Name = "mnuWindowHamming";
            this.mnuWindowHamming.Size = new System.Drawing.Size(126, 22);
            this.mnuWindowHamming.Text = "Hamming";
            this.mnuWindowHamming.Click += new System.EventHandler(this.mnuWindowHamming_Click);
            // 
            // mnuWindowHanning
            // 
            this.mnuWindowHanning.Name = "mnuWindowHanning";
            this.mnuWindowHanning.Size = new System.Drawing.Size(126, 22);
            this.mnuWindowHanning.Text = "Hanning";
            this.mnuWindowHanning.Click += new System.EventHandler(this.mnuWindowHanning_Click);
            // 
            // mnuWindowBlackman
            // 
            this.mnuWindowBlackman.Name = "mnuWindowBlackman";
            this.mnuWindowBlackman.Size = new System.Drawing.Size(126, 22);
            this.mnuWindowBlackman.Text = "Blackman";
            this.mnuWindowBlackman.Click += new System.EventHandler(this.mnuWindowBlackman_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 503);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(808, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // chtData
            // 
            chartArea1.Name = "ChartArea1";
            this.chtData.ChartAreas.Add(chartArea1);
            this.chtData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chtData.Location = new System.Drawing.Point(3, 3);
            this.chtData.Name = "chtData";
            series1.ChartArea = "ChartArea1";
            series1.Name = "Series1";
            this.chtData.Series.Add(series1);
            this.chtData.Size = new System.Drawing.Size(402, 233);
            this.chtData.TabIndex = 0;
            this.chtData.Text = "chart1";
            // 
            // chtFourier
            // 
            chartArea2.Name = "ChartArea1";
            this.chtFourier.ChartAreas.Add(chartArea2);
            this.chtFourier.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chtFourier.Location = new System.Drawing.Point(3, 242);
            this.chtFourier.Name = "chtFourier";
            series2.ChartArea = "ChartArea1";
            series2.Name = "Series1";
            this.chtFourier.Series.Add(series2);
            this.chtFourier.Size = new System.Drawing.Size(402, 234);
            this.chtFourier.TabIndex = 1;
            this.chtFourier.Text = "chart1";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 400F));
            this.tableLayoutPanel1.Controls.Add(this.chtFourier, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.chtData, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dgvchtData, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.dgvFourier, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(808, 479);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // dgvchtData
            // 
            this.dgvchtData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvchtData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvchtData.Location = new System.Drawing.Point(411, 3);
            this.dgvchtData.Name = "dgvchtData";
            this.dgvchtData.RowTemplate.Height = 21;
            this.dgvchtData.Size = new System.Drawing.Size(394, 233);
            this.dgvchtData.TabIndex = 2;
            // 
            // dgvFourier
            // 
            this.dgvFourier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFourier.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvFourier.Location = new System.Drawing.Point(411, 242);
            this.dgvFourier.Name = "dgvFourier";
            this.dgvFourier.RowTemplate.Height = 21;
            this.dgvFourier.Size = new System.Drawing.Size(394, 234);
            this.dgvFourier.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(808, 525);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Fourier Transform";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chtData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chtFourier)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvchtData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFourier)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtData;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtFourier;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuFileLoadData;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mnuFileExit;
        private System.Windows.Forms.ToolStripMenuItem mnuFileSaveFourierData;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dgvchtData;
        private System.Windows.Forms.DataGridView dgvFourier;
        private System.Windows.Forms.ToolStripMenuItem mnuWindow;
        private System.Windows.Forms.ToolStripMenuItem mnuWindowHamming;
        private System.Windows.Forms.ToolStripMenuItem mnuWindowHanning;
        private System.Windows.Forms.ToolStripMenuItem mnuWindowBlackman;
        private System.Windows.Forms.ToolStripMenuItem mnuFourier;
        private System.Windows.Forms.ToolStripMenuItem mnuFourierForward;
        private System.Windows.Forms.ToolStripMenuItem mnuFourierBackward;
    }
}

