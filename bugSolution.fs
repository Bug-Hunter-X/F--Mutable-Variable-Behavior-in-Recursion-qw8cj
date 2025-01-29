let mutable x = 0
let mutable y = 0

let rec loop1 x y =
    if x = 10 then
        () 
    else
        x <- x + 1; 
        y <- y + 1; 
        loop1 x y

loop1 x y
printf "%d %d" x y //this will print 10 10

let x1 = ref 0
let y1 = ref 0

let rec loop2 x y =
    if x = 10 then
        () 
    else
        x := !x + 1; 
        y := !y + 1; 
        loop2 x y

loop2 x1 y1
printf "%d %d" !x1 !y1 //this will print 10 10