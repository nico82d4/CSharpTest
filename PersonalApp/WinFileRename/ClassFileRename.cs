using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFileRename
{
    class ClassFileRename
    {
        // 実行結果文字列を格納する読み出し専用プロパティ
        public string ResultString { get; private set; } = "";

        // エラーメッセージを格納する読み出し専用プロパティ
        public string ErrorMessage { get; private set; } = "";



        // ファイルリネームの実行
        public Boolean Execute(string path)
        {
            // 戻り値の初期値をFalseとする。
            Boolean returnValue = false;

            try
            {
                // ディレクトリが存在する場合
                if (Directory.Exists(path))
                {
                    // ファイルの一覧を取得
                    DirectoryInfo dirInfo = new DirectoryInfo(@path);
                    IEnumerable<FileInfo> lists = dirInfo.EnumerateFiles();

                    // 取得件数が0件より大きい場合
                    if (lists.Count() > 0)
                    {
                        // ループ処理で個別ファイルの対応を行う
                        foreach (var lst in lists)
                        {
                            // ファイル名をフルパスで取得する。
                            this.ResultString += lst.FullName + "\r\n";
                        }

                        // 2020-01-12時点では、結果文字列が格納されていれば、
                        // 処理成功とする。
                        if (this.ResultString != "")
                        {
                            returnValue = true;
                        }
                    }

                    // ファイル数が0件の場合
                    else
                    {
                        ErrorMessage = "ディレクトリの中にファイルがありませんでした。";
                    }
                }

                // 指定されたディレクトリが存在しない場合
                else
                {
                    ErrorMessage = "指定されたディレクトリが存在しません。";
                }
            }

            // 例外が発生した時は、例外メッセージをエラー文字列に格納する。
            catch (Exception ex)
            {
                ErrorMessage = ex.Message;
            }

            // 戻り値を返す。
            return returnValue;

        }
    }
}
