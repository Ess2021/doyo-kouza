let n = stdin.ReadLine() |> int
if (n < 20) then "あなたは未成年です" else "あなたは成人です"
|> stdout.WriteLine