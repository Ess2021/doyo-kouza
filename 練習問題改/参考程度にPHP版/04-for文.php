<?php
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
while ($line = fgets(STDIN)) {
    // 配列を生成する
    $array[] = trim($line);
}
$m = $array[0];
$n = $array[1];
for($i = $m;$i < $n; $i++){
    if($i % 2 == 0){
        echo "$i\n";
    }
}
//(c)2021 coko-go
?>