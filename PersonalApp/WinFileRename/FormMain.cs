using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.IO;

namespace WinFileRename
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void ButtonExecute_Click(object sender, EventArgs e)
        {
            TextBoxProgress.Text = this.GetFileList();
        }

        private string SetAppPath()
        {
            // アプリケーションの実行パスを取得
            string returnValue = Application.ExecutablePath;

            return returnValue;
        }


        // ファイルの一覧を文字列で返す処理
        private string GetFileList()
        {
            string returnValue = "";

            try
            {
                // アプリの実行パスを取得し、ファイルの一覧を取得する。
                string searchPath = Path.GetDirectoryName(Application.ExecutablePath);
                DirectoryInfo dirInfo = new DirectoryInfo(@searchPath);
                IEnumerable<FileInfo> infos = dirInfo.EnumerateFiles();

                // foreachループで、個別のファイル名をフルパスで取得し、変数に格納する。
                // パスとパスとの間には、改行コードを挿入する。Windows用なのでCrLf。
                foreach (var info in infos)
                {
                    returnValue += info.FullName + "\r\n";
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (UnauthorizedAccessException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (DirectoryNotFoundException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message);
            }

            // 戻り値を返す。
            return returnValue;
        }
    }
}
