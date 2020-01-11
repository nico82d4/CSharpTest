namespace WinFileRename
{
    partial class FormMain
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
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
            this.ButtonExecute = new System.Windows.Forms.Button();
            this.TextBoxProgress = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ButtonExecute
            // 
            this.ButtonExecute.Location = new System.Drawing.Point(586, 65);
            this.ButtonExecute.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ButtonExecute.Name = "ButtonExecute";
            this.ButtonExecute.Size = new System.Drawing.Size(124, 47);
            this.ButtonExecute.TabIndex = 0;
            this.ButtonExecute.Text = "実行";
            this.ButtonExecute.UseVisualStyleBackColor = true;
            this.ButtonExecute.Click += new System.EventHandler(this.ButtonExecute_Click);
            // 
            // TextBoxProgress
            // 
            this.TextBoxProgress.Location = new System.Drawing.Point(34, 169);
            this.TextBoxProgress.Multiline = true;
            this.TextBoxProgress.Name = "TextBoxProgress";
            this.TextBoxProgress.ReadOnly = true;
            this.TextBoxProgress.Size = new System.Drawing.Size(676, 104);
            this.TextBoxProgress.TabIndex = 1;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 297);
            this.Controls.Add(this.TextBoxProgress);
            this.Controls.Add(this.ButtonExecute);
            this.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormMain";
            this.Text = "WinFileRename";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonExecute;
        private System.Windows.Forms.TextBox TextBoxProgress;
    }
}

