namespace TestTaskCSharp
{
    partial class FileInfoControl
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.inputFileNameLabel = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.stateLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.outputFileNameLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.startStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.editInputStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editOuputStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.chooseFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // inputFileNameLabel
            // 
            this.inputFileNameLabel.AutoEllipsis = true;
            this.inputFileNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.inputFileNameLabel.Location = new System.Drawing.Point(107, 6);
            this.inputFileNameLabel.Margin = new System.Windows.Forms.Padding(3);
            this.inputFileNameLabel.Name = "inputFileNameLabel";
            this.inputFileNameLabel.Size = new System.Drawing.Size(184, 13);
            this.inputFileNameLabel.TabIndex = 0;
            this.inputFileNameLabel.Text = "FileName.txt";
            this.inputFileNameLabel.DoubleClick += new System.EventHandler(this.editOuputStripMenuItem_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.progressBar1.Location = new System.Drawing.Point(6, 62);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(282, 10);
            this.progressBar1.TabIndex = 2;
            // 
            // stateLabel
            // 
            this.stateLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.stateLabel.Location = new System.Drawing.Point(12, 46);
            this.stateLabel.Name = "stateLabel";
            this.stateLabel.Size = new System.Drawing.Size(276, 13);
            this.stateLabel.TabIndex = 3;
            this.stateLabel.Text = "in progress";
            this.stateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.stateLabel.DoubleClick += new System.EventHandler(this.editOuputStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(9, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Выходной файл:";
            this.label1.DoubleClick += new System.EventHandler(this.editOuputStripMenuItem_Click);
            // 
            // outputFileNameLabel
            // 
            this.outputFileNameLabel.AutoEllipsis = true;
            this.outputFileNameLabel.Location = new System.Drawing.Point(107, 26);
            this.outputFileNameLabel.Name = "outputFileNameLabel";
            this.outputFileNameLabel.Size = new System.Drawing.Size(184, 13);
            this.outputFileNameLabel.TabIndex = 5;
            this.outputFileNameLabel.Text = "FileName.txt";
            this.outputFileNameLabel.DoubleClick += new System.EventHandler(this.editOuputStripMenuItem_Click);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(9, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Входной файл:";
            this.label3.DoubleClick += new System.EventHandler(this.editOuputStripMenuItem_Click);
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startStripMenuItem,
            this.toolStripSeparator1,
            this.editInputStripMenuItem,
            this.editOuputStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(219, 76);
            // 
            // startStripMenuItem
            // 
            this.startStripMenuItem.Name = "startStripMenuItem";
            this.startStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.startStripMenuItem.Text = "Обработать";
            this.startStripMenuItem.Click += new System.EventHandler(this.startStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(215, 6);
            // 
            // editInputStripMenuItem
            // 
            this.editInputStripMenuItem.Name = "editInputStripMenuItem";
            this.editInputStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.editInputStripMenuItem.Text = "Изменить входной файл";
            this.editInputStripMenuItem.Click += new System.EventHandler(this.editInputStripMenuItem_Click);
            // 
            // editOuputStripMenuItem
            // 
            this.editOuputStripMenuItem.Name = "editOuputStripMenuItem";
            this.editOuputStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.editOuputStripMenuItem.Text = "Изменить выходной файл";
            this.editOuputStripMenuItem.Click += new System.EventHandler(this.editOuputStripMenuItem_Click);
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.WorkerReportsProgress = true;
            this.backgroundWorker.WorkerSupportsCancellation = true;
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_DoWork);
            this.backgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker_ProgressChanged);
            this.backgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_RunWorkerCompleted);
            // 
            // chooseFileDialog
            // 
            this.chooseFileDialog.FileName = "openFileDialog1";
            this.chooseFileDialog.Filter = "Текстовые|*.txt";
            this.chooseFileDialog.Title = "Входные файлы";
            // 
            // FileInfoControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ContextMenuStrip = this.contextMenuStrip;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.outputFileNameLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.stateLabel);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.inputFileNameLabel);
            this.Name = "FileInfoControl";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.Size = new System.Drawing.Size(297, 78);
            this.DoubleClick += new System.EventHandler(this.editOuputStripMenuItem_Click);
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label inputFileNameLabel;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label stateLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label outputFileNameLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem startStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem editInputStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editOuputStripMenuItem;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
        private System.Windows.Forms.OpenFileDialog chooseFileDialog;
    }
}
