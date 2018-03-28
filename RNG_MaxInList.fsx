type System.Random with
  member this.GetValues(minValue, maxValue) =
    Seq.initInfinite (fun _ -> this.Next(minValue, maxValue))
    
let r = System.Random()
let test = r.GetValues(1,1000) |> Seq.take 10 |> Seq.toList

let biggest = List.max test
printfn "The biggest number is %d" biggest
