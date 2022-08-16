module ProjectEulerFSharp.FizzBuzz
    
// checks if X is divisible by Y
let isDivisible x y =
    x % y = 0

// define the list of numbers    
let numbers = [1..100]

// pattern matches the input to return a fizzbuzz output
let fizzbuzz number =
    match number with
    | x when isDivisible x 15 -> printfn "FizzBuzz"
    | x when isDivisible x 3 -> printfn "Fizz"
    | x when isDivisible x 5 -> printfn "Buzz"
    | x -> printfn "%i" x
    
// Iterate over the list and apply fizzbuzz function to each
numbers
    |> Seq.iter fizzbuzz
