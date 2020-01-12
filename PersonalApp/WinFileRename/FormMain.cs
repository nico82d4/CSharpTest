using System;
using System.IO;
using System.Windows.Forms;

namespace WinFileRename
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }



        // 実行ボタンを押下した時の処理
        private void ButtonExecute_Click(object sender, EventArgs e)
        {
            // プログラム実行ディレクトリの取得
            string path = Path.GetDirectoryName(Application.ExecutablePath);

            // ファイルリネーム実行クラスのインスタンスを生成し、
            // 実行する。
            ClassFileRename fr = new ClassFileRename();
            Boolean result = fr.Execute(path);

            // 実行結果がTrueなら、テキストボックスに結果を出力する。
            if (result)
            {
                TextBoxProgress.Text = fr.ResultString;
            }
            // 実行結果がFalseの場合は、エラーメッセージを出力する。
            else
            {
                MessageBox.Show(fr.ErrorMessage, "エラー");
            }
        }
    }
}
