/*

if文 - 問題文

整数nが与えられる。nが20未満の時には"あなたは未成年です"と、nが20以上の時には"あなたは成人です"と表示するプログラムを作成してください。

入力は以下の通りです。
n

*/

//解答例

using System;

namespace practices {
    class Program {
        static void Main (string[] args) {
            int n = int.Parse(Console.ReadLine()); //入力

            if (n < 20) { //もしnが20未満ならば、
                Console.WriteLine("あなたは未成年です");
            } else { //それ以外ならば、
                Console.WriteLine("あなたは成人です");
            }
        }
    }
}