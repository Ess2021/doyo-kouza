let Ave x y z = (x + y + z) / 3
let a = stdin.ReadLine() |> int
let b = stdin.ReadLine() |> int
let c = stdin.ReadLine() |> int
let res = Ave a b c |> double
printfn "%f" res