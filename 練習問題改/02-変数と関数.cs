/*

変数と関数 - 問題文

整数a,b,cが与えられた時、a,b,cの平均を返す関数を作ってください。
また、その関数を使って、整数a,b,cが与えられた時　、その平均hを表示するプログラムを作成してください。

入力は以下の通りです。
a
b
c

出力は以下の通りです。
h

*/

//解答例

using System;

namespace practices {
    class Program {
        static void Main (string[] args) {
            int a = int.Parse(Console.ReadLine()); //Console.ReadLine()はstring型だから、計算するためにはint.Parse()を使ってint型へ型変換（キャスト）する必要がある
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            double h = Ave(a, b, c); //double型の変数hを宣言し、Ave()関数の結果を代入, ここでの変数の型は、使う関数に合わせるのが無難
            Console.WriteLine(h);
        }

        static double Ave (int a, int b, int c) { //引数として、int型のa,b,cを持つ //平均値は、小数の可能性もあるのでdouble型
            int sum = a + b + c; //int型の変数sumを宣言し、a,b,cを足し合わせる
            double ave = sum / 3; //double型の変数aveを宣言し、a,b,cを足し合わせた変数sumを3で割る
            return ave; //変数aveを返す
        }
    }
}