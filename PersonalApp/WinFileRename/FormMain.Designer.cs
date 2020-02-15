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
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ButtonExecute
            // 
            this.ButtonExecute.Location = new System.Drawing.Point(586, 41);
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
            this.TextBoxProgress.Location = new System.Drawing.Point(34, 171);
            this.TextBoxProgress.Multiline = true;
            this.TextBoxProgress.Name = "TextBoxProgress";
            this.TextBoxProgress.ReadOnly = true;
            this.TextBoxProgress.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TextBoxProgress.Size = new System.Drawing.Size(676, 104);
            this.TextBoxProgress.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(503, 110);
            this.label1.TabIndex = 2;
            this.label1.Text = "現時点では、以下拡張子のファイル名だけを変換します。\r\n　画像ファイル：jpg, png, bmp\r\n　動画ファイル：mov, mp4\r\n変換後のファイルが存在す" +
    "る場合、ファイル名の変更は\r\n行われません。";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 318);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextBoxProgress);
            this.Controls.Add(this.ButtonExecute);
            this.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMain";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ファイル名変換";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonExecute;
        private System.Windows.Forms.TextBox TextBoxProgress;
        private System.Windows.Forms.Label label1;
    }
}

