let m = stdin.ReadLine() |> int
let n = stdin.ReadLine() |> int
for i in m .. n - 1 do 
    if (i % 2 = 0) then printfn "%d" i
//別解
//for i in m + (m % 2) .. 2 .. n - 1 do printfn "%d" i