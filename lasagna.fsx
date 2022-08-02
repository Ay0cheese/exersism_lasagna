module LuciansLusciousLasagna

// TODO: define the 'expectedMinutesInOven' binding
// this is a constant value it never changes during the execution of the program. ** Research constants **



///<summary>
/// <see cref="Task1">Task 1: </see>
/// Define the expectedMinutesInOven binding to check how many minutes the lasagna should be in the oven. According to the cooking book, the expected oven time in minutes is 40:
/// </summary>
let expectedMinutesInOven = 40//mins


///<summary>
/// <see cref="">Task 2</see>
/// Define the remainingMinutesInOven function that takes the actual minutes the lasagna has been in the oven as a parameter and returns how many minutes the lasagna still has to remain in the oven, based on the expected time oven time in minutes from the previous task.
/// </summary>
/// <param name="timePerLayer">Time that the food takes to be prepaired</param>
/// <returns>An integer representing the preporation time.</returns>
let timePerLayer = 2 //mins

// TODO: define the 'remainingMinutesInOven' function
// This function takes the elapsed minutes and it substracts that value from the expected minutes
let remainingMinutesInOven elapsedTimeInOven = expectedMinutesInOven - elapsedTimeInOven

// let result = remainingMinutesInOven 40
// printfn "(remainingMinutesInOven 40 30) %i" result

// TODO: define the 'preparationTimeInMinutes' function
let preparationTimeInMinutes numberOfLayers = numberOfLayers * timePerLayer


// TODO: define the 'elapsedTimeInMinutes' function
let elapsedTimeInMinutes a b c = a * b + c
let results = elapsedTimeInMinutes 3 2 20
printfn "(elapsedTimeIn Minutes 3 2 20)%i" results