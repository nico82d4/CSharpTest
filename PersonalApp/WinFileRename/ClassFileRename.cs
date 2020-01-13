using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;


//*******************************************************************
//* ファイル名の変換用クラス
//*
//*******************************************************************

namespace WinFileRename
{
    class ClassFileRename
    {
        // 実行結果文字列を格納する読み出し専用プロパティ
        public string ResultString { get; private set; } = "";

        // エラーメッセージを格納する読み出し専用プロパティ
        public string ErrorMessage { get; private set; } = "";



        // ファイル名変更処理の実行
        public Boolean Execute(string path)
        {
            // 戻り値の初期値をFalseとする。
            Boolean returnValue = false;

            // 入力・変換件数カウンタ
            int inputCount = 0;
            int replaceCount = 0;

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
                            // 入力件数カウンタのインクリメント
                            inputCount += 1;

                            // ファイルのパス、拡張子、更新日時を取得
                            // （作成日時だとコピーした日付になる模様）
                            string filePath = lst.DirectoryName;
                            string oldFileName = lst.Name;
                            string ext = Path.GetExtension(oldFileName);
                            string dt = Directory.GetLastWriteTime(lst.FullName).ToString("yyyy-MM-dd-HHmmss");

                            // 変換後ファイル名。初期値は変換前ファイル名。
                            string newFIleName = oldFileName;

                            // 拡張子チェックのため、正規表現を使用。
                            string pattern = "^\\.(?:bmp|jpg|jpeg|png)$";
                            Regex rex = new Regex(pattern, RegexOptions.IgnoreCase);

                            // 変換対象の拡張子である場合
                            if (rex.IsMatch(ext))
                            {
                                // 変換後ファイル名の生成
                                // （2020-01-13 時点では、固定された変換方法を行う。）
                                newFIleName = dt + ext;
                                string newFilePath = filePath + "\\" + newFIleName;
                                Console.WriteLine(newFilePath); // debug

                                // 変換後のファイルが存在しない場合
                                if (! File.Exists(newFilePath))
                                {
                                    // File.Move メソッドを使ってファイル名を変更する。
                                    File.Move(lst.FullName, newFilePath);

                                    // 変換件数カウンタのインクリメント
                                    replaceCount += 1;
                                }

                            }
                        }

                        // 変換件数カウンタが 0 より大きい場合、戻り値をTrueとする。
                        if (replaceCount > 0)
                        {
                            returnValue = true;
                        }

                        // 置換件数カウンタが 0 の場合
                        else
                        {
                            ErrorMessage = "対象ファイルが見つかりませんでした。";
                        }
                    }

                    // 入力ファイル件数が0の場合
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

            // 最後に、入力・置換件数を結果文字列に格納する。
            string lastMessage = $"入力件数：{inputCount}\r\n置換件数：{replaceCount}";
            ResultString += lastMessage;

            // 戻り値を返す。
            return returnValue;

        }
    }
}
