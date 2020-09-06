namespace TestTaskCSharp
{
    partial class MainForm
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.pickInputFilesBtn = new System.Windows.Forms.Button();
            this.choosedFilesPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.pickInputFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editParamsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startBtn = new System.Windows.Forms.Button();
            this.pickOutputDirBtn = new System.Windows.Forms.Button();
            this.pickOutputFolderDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // pickInputFilesBtn
            // 
            this.pickInputFilesBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.pickInputFilesBtn.Location = new System.Drawing.Point(12, 30);
            this.pickInputFilesBtn.Name = "pickInputFilesBtn";
            this.pickInputFilesBtn.Size = new System.Drawing.Size(325, 42);
            this.pickInputFilesBtn.TabIndex = 0;
            this.pickInputFilesBtn.Text = "Выбрать входные файлы";
            this.pickInputFilesBtn.UseVisualStyleBackColor = true;
            this.pickInputFilesBtn.Click += new System.EventHandler(this.choseFilesBtn_Click);
            // 
            // choosedFilesPanel
            // 
            this.choosedFilesPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.choosedFilesPanel.AutoScroll = true;
            this.choosedFilesPanel.Location = new System.Drawing.Point(12, 153);
            this.choosedFilesPanel.Name = "choosedFilesPanel";
            this.choosedFilesPanel.Padding = new System.Windows.Forms.Padding(3);
            this.choosedFilesPanel.Size = new System.Drawing.Size(325, 289);
            this.choosedFilesPanel.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 132);
            this.label3.Margin = new System.Windows.Forms.Padding(3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "Выбранные файлы";
            // 
            // pickInputFileDialog
            // 
            this.pickInputFileDialog.Filter = "Текстовые|*.txt";
            this.pickInputFileDialog.Multiselect = true;
            this.pickInputFileDialog.Title = "Входные файлы";
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Margin = new System.Windows.Forms.Padding(3);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(349, 24);
            this.menuStrip.TabIndex = 9;
            this.menuStrip.Text = "menuStrip1";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editParamsToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.settingsToolStripMenuItem.Text = "Настройки";
            // 
            // editParamsToolStripMenuItem
            // 
            this.editParamsToolStripMenuItem.Name = "editParamsToolStripMenuItem";
            this.editParamsToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.editParamsToolStripMenuItem.Text = "Параметры обработки";
            this.editParamsToolStripMenuItem.Click += new System.EventHandler(this.editParamsToolStripMenuItem_Click);
            // 
            // startBtn
            // 
            this.startBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.startBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.startBtn.Location = new System.Drawing.Point(12, 448);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(325, 42);
            this.startBtn.TabIndex = 10;
            this.startBtn.Text = "Обработать";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // pickOutputDirBtn
            // 
            this.pickOutputDirBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.pickOutputDirBtn.Location = new System.Drawing.Point(12, 78);
            this.pickOutputDirBtn.Name = "pickOutputDirBtn";
            this.pickOutputDirBtn.Size = new System.Drawing.Size(325, 42);
            this.pickOutputDirBtn.TabIndex = 11;
            this.pickOutputDirBtn.Text = "Выбрать выходную папку";
            this.pickOutputDirBtn.UseVisualStyleBackColor = true;
            this.pickOutputDirBtn.Click += new System.EventHandler(this.pickOutputDirBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 500);
            this.Controls.Add(this.pickOutputDirBtn);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.choosedFilesPanel);
            this.Controls.Add(this.pickInputFilesBtn);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainForm";
            this.Text = "Тестовое задание";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button pickInputFilesBtn;
        private System.Windows.Forms.FlowLayoutPanel choosedFilesPanel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.OpenFileDialog pickInputFileDialog;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editParamsToolStripMenuItem;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Button pickOutputDirBtn;
        private System.Windows.Forms.FolderBrowserDialog pickOutputFolderDialog;
    }
}

