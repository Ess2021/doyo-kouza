/*

for文 - 問題文

整数nが与えられる。この時、m以上n未満の全ての偶数g1,g2,g3,...,giを表示するプログラムを作成してください(iは添字)。

入力は以下の通りです。
m
n

出力は以下の通りです。
g1
g2
g3
.
.
.
gi

*/

//解答例

using System;

namespace practices {
    class Program {
        static void Main (String[] args) {
            int m = int.Parse(Console.ReadLine()); //入力
            int n = int.Parse(Console.ReadLine());
                        
            for (int i = m; i < n; i++) { //int型のiを宣言し、mを代入(int i = m;)。iがn未満のとき、ブロック内を繰り返し(i < n;)、一回繰り返すごとにiに1を足していく(i++)。
                if (i % 2 == 0) { //もし、iを2で割った時の余り(剰余)が0だったら... (もし、iが2の倍数だったら)...
                    Console.WriteLine(i); //iを出力
                }
            }
            
            /* 別解 (こちらの方が高速だと思われる)
            for (int i = m + (m % 2); i < n; i += 2) {
                Console.WriteLine(i);
            }
            */
        }
    }
}
