open System
let mult a b =
    let rec sum a =
        if a < 1 then 0
        else b + sum(a - 1)
    printfn "--->%i x %i = %i" a b (sum a)

[<EntryPoint>]
let main argv =
    printfn "Ingrese el primer numero"
    let x = int(Console.ReadLine());
    printfn "Ingrese el segundo numero"
    let y = int(Console.ReadLine());
    mult x y 
    Console.ReadKey() |> ignore
    0 //devolver un código de salida entero