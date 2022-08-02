module LuciansLusciousLasagna

/// <summary>
/// <see cref="Task1">Task 1: </see>
/// Define the expectedMinutesInOven binding to check how many minutes the lasagna should be in the oven. According to the cooking book, the expected oven time in minutes is 40:
/// </summary>
let expectedMinutesInOven = 40//mins

/// <summary>
/// <see cref="">Task 2</see>
/// Define the remainingMinutesInOven function that takes the actual minutes the lasagna has been in the oven as a parameter and returns how many minutes the lasagna still has to remain in the oven, based on the expected time oven time in minutes from the previous task.
/// </summary>
/// <param name="timePerLayer">Time that the food takes to be prepaired</param>
/// <returns>An integer representing the preporation time.</returns>
let timePerLayer = 2 //mins

/// <summary>
/// <see cref="">Task 2</see>
/// Define the remainingMinutesInOven function that takes the actual minutes the lasagna has been in the oven as a parameter and returns how many minutes the lasagna still has to remain in the oven, based on the expected time oven time in minutes from the previous task.
/// </summary>
/// <param name="remainingMinutesInOven">How much time is left for the food to cook in the oven</param>
/// <returns>A function with a init argument 'elapsedTimeInOven' which is the sum of an init expression 'expectedMinutesInOven' minus another init expression 'elapsedTimeInOven'</returns>
let remainingMinutesInOven elapsedTimeInOven = 
    expectedMinutesInOven - elapsedTimeInOven

/// <summary>
/// <see cref="">Task 3</see>
/// Define the preparationTimeInMinutes function that takes the number of layers you added to the lasagna as a parameter and returns how many minutes you spent preparing the lasagna, assuming each layer takes you 2 minutes to prepare.
/// </summary>
/// <param name="preparationTimeInMinutes">Time that the food has been in the oven</param>
/// <returns>A function with a init argument 'preparationTimeInMinutes' which is the sum of an init expression 'numberOfLayers' times another init expression 'timePerLayer'.</returns>
let preparationTimeInMinutes numberOfLayers = 
    numberOfLayers * timePerLayer




/// If I code above this line im fucking up becuase tasks 1,2,3 are passing their test.





/// <summary>
/// <see cref="">Task 4</see>
/// Define the elapsedTimeInMinutes function that takes two parameters:
/// the first parameter is the number of layers you added to the lasagna,
/// and the second parameter is the number of minutes the lasagna
/// has been in the oven.
/// </summary>
/// <param name="numberOfLayers">Number of layers in the lasagna.</param>
/// <param name="numberOfMinutesInOven">Number of minutes the lasagna has been in the oven.</param>
/// <returns>The function should return how many minutes you've worked on cooking the lasagna, 
/// which is the sum of the preparation time in minutes, and the time in minutes the lasagna 
/// has spent in the oven at the moment.
/// </returns>
let elapsedTimeInMinutes numberOfLayers numberOfMinutesInOven = 
    let prepTime = (preparationTimeInMinutes numberOfLayers)
    printfn "Prep Time: %i" prepTime
    prepTime + numberOfMinutesInOven
    