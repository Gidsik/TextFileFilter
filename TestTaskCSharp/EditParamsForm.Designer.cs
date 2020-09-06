namespace TestTaskCSharp
{
    partial class EditParamsForm
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
            this.minLengthTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.deletePunctuationCheckBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.saveBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // minLengthTextBox
            // 
            this.minLengthTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minLengthTextBox.Location = new System.Drawing.Point(241, 39);
            this.minLengthTextBox.MaxLength = 7;
            this.minLengthTextBox.Name = "minLengthTextBox";
            this.minLengthTextBox.Size = new System.Drawing.Size(39, 20);
            this.minLengthTextBox.TabIndex = 4;
            this.minLengthTextBox.Text = "1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(210, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Удалить слова длиной менее символов";
            // 
            // deletePunctuationCheckBox
            // 
            this.deletePunctuationCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.deletePunctuationCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.deletePunctuationCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.deletePunctuationCheckBox.Location = new System.Drawing.Point(260, 9);
            this.deletePunctuationCheckBox.Name = "deletePunctuationCheckBox";
            this.deletePunctuationCheckBox.Size = new System.Drawing.Size(20, 20);
            this.deletePunctuationCheckBox.TabIndex = 3;
            this.deletePunctuationCheckBox.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Удалять знаки препинания";
            // 
            // saveBtn
            // 
            this.saveBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.saveBtn.Location = new System.Drawing.Point(111, 76);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(78, 23);
            this.saveBtn.TabIndex = 7;
            this.saveBtn.Text = "Сохранить";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // EditParamsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 111);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.minLengthTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.deletePunctuationCheckBox);
            this.Controls.Add(this.label1);
            this.Name = "EditParamsForm";
            this.Text = "Параметры обработки";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox minLengthTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox deletePunctuationCheckBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button saveBtn;
    }
}