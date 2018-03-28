printf "Guess the number!: "
let mutable input = System.Console.ReadLine() |> System.Int32.Parse
let secret = System.Random().Next(1,101)

while input <> secret do
  let diff = input - secret
  if diff > 0 then
    printfn "Try again! The secret number is LOWER than %d" input
    printf "Next guess?: "
    input <- System.Console.ReadLine() |> System.Int32.Parse
  else
    printfn "Try again! The secret number is HIGHER than %d" input
    printf "Next guess?: "
    input <- System.Console.ReadLine() |> System.Int32.Parse
printfn "You guessed it! The secret number was %d" secret
