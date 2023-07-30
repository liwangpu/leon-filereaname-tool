namespace FileRename
{
    partial class FileRenameForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtSource = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPrefix = new System.Windows.Forms.TextBox();
            this.btnSelectSource = new System.Windows.Forms.Button();
            this.btnHandle = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDest = new System.Windows.Forms.TextBox();
            this.btnSelectDest = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFileFilter = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "源文件:";
            // 
            // txtSource
            // 
            this.txtSource.Enabled = false;
            this.txtSource.Location = new System.Drawing.Point(81, 32);
            this.txtSource.Name = "txtSource";
            this.txtSource.Size = new System.Drawing.Size(202, 23);
            this.txtSource.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "前缀:";
            // 
            // txtPrefix
            // 
            this.txtPrefix.Location = new System.Drawing.Point(81, 81);
            this.txtPrefix.Name = "txtPrefix";
            this.txtPrefix.Size = new System.Drawing.Size(283, 23);
            this.txtPrefix.TabIndex = 1;
            // 
            // btnSelectSource
            // 
            this.btnSelectSource.Location = new System.Drawing.Point(289, 32);
            this.btnSelectSource.Name = "btnSelectSource";
            this.btnSelectSource.Size = new System.Drawing.Size(75, 23);
            this.btnSelectSource.TabIndex = 2;
            this.btnSelectSource.Text = "选择";
            this.btnSelectSource.UseVisualStyleBackColor = true;
            this.btnSelectSource.Click += new System.EventHandler(this.btnSelectSource_Click);
            // 
            // btnHandle
            // 
            this.btnHandle.Enabled = false;
            this.btnHandle.Location = new System.Drawing.Point(289, 215);
            this.btnHandle.Name = "btnHandle";
            this.btnHandle.Size = new System.Drawing.Size(75, 23);
            this.btnHandle.TabIndex = 3;
            this.btnHandle.Text = "开始处理";
            this.btnHandle.UseVisualStyleBackColor = true;
            this.btnHandle.Click += new System.EventHandler(this.btnHandle_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "源文件:";
            // 
            // txtDest
            // 
            this.txtDest.Enabled = false;
            this.txtDest.Location = new System.Drawing.Point(81, 170);
            this.txtDest.Name = "txtDest";
            this.txtDest.Size = new System.Drawing.Size(202, 23);
            this.txtDest.TabIndex = 1;
            // 
            // btnSelectDest
            // 
            this.btnSelectDest.Location = new System.Drawing.Point(289, 170);
            this.btnSelectDest.Name = "btnSelectDest";
            this.btnSelectDest.Size = new System.Drawing.Size(75, 23);
            this.btnSelectDest.TabIndex = 2;
            this.btnSelectDest.Text = "选择";
            this.btnSelectDest.UseVisualStyleBackColor = true;
            this.btnSelectDest.Click += new System.EventHandler(this.btnSelectDest_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "过滤文件:";
            // 
            // txtFileFilter
            // 
            this.txtFileFilter.Location = new System.Drawing.Point(81, 124);
            this.txtFileFilter.Name = "txtFileFilter";
            this.txtFileFilter.Size = new System.Drawing.Size(283, 23);
            this.txtFileFilter.TabIndex = 1;
            this.txtFileFilter.Text = "*.mp4";
            // 
            // FileRenameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.btnHandle);
            this.Controls.Add(this.btnSelectDest);
            this.Controls.Add(this.btnSelectSource);
            this.Controls.Add(this.txtDest);
            this.Controls.Add(this.txtFileFilter);
            this.Controls.Add(this.txtPrefix);
            this.Controls.Add(this.txtSource);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(400, 300);
            this.MinimumSize = new System.Drawing.Size(400, 300);
            this.Name = "FileRenameForm";
            this.Text = "文件更名";
            this.Load += new System.EventHandler(this.FileRenameForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txtSource;
        private Label label2;
        private TextBox txtPrefix;
        private Button btnSelectSource;
        private Button btnHandle;
        private Label label3;
        private TextBox txtDest;
        private Button btnSelectDest;
        private Label label4;
        private TextBox txtFileFilter;
    }
}