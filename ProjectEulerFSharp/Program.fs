
let prefix prefixStr baseStr =
    prefixStr + ", " + baseStr
    
let names = ["Ben"; "Sam"; "Tom";]

let prefixWithHello = prefix "Hello"

let exclaim s =
    s + "!"

// evaluates PrefixWithHello first, then exclaim (depending on direction of arrows, can do << for the other way)
let bigHello = prefixWithHello >> exclaim

let hellos =
    names
        |> Seq.map bigHello
        |> Seq.sort
        |> Seq.iter (printfn "%s")

let items = [1..100]
// For more information see https://aka.ms/fsharp-console-apps
printfn "Hello from F#"

List.append [6]