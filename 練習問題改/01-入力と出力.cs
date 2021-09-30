/*

入力と出力 - 問題文

文字列sが与えられた時、"sさんこんにちは!"と表示するプログラムを作成してください。

入力は以下の通りです。
s

出力は以下の通りです。
sさんこんにちは!

*/

//解答例

using System;

namespace practices {
    class Program {
        static void Main (string[] args) {
            string s = Console.ReadLine(); //文字列としてsを宣言し、コンソール画面に入力された値を代入
            Console.WriteLine(s + "さんこんにちは!"); //変数sに「さんこんにちは」を付け加えたものをコンソール画面上に出力
        }
    }
}