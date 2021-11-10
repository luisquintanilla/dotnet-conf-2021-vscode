let numbers = [1..10]

let addOne x = x + 1

let numbersPlusOne = 
    [ for number in numbers do addOne number ]