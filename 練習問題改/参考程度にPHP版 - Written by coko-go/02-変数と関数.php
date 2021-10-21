<?php
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
while ($line = fgets(STDIN)) {
    // 配列を生成する
    $array[] = trim($line);
}
$a = $array[0];
$b = $array[1];
$c = $array[2];
$sum = $a + $b + $c;
$h = $sum / 3;
echo $h;
//(c)2021 coko-go
?>