module LuciansLusciousLasagna
 

//  https://docs.microsoft.com/en-us/dotnet/fsharp/language-reference/xml-documentation



///<summary>
/// Instructions
/// In this exercise you're going to write some code to help you cook a brilliant lasagna from your favorite cooking book.
/// You have four tasks, all related to the time spent cooking the lasagna.
/// <see cref="Main">Main</see> 
///</summary>

 
///<summary>
/// <see cref="Task1">Task 1</see>
/// Define the expectedMinutesInOven binding to check how many minutes the lasagna should be in the oven. According to the cooking book, the expected oven time in minutes is 40:
/// </summary>
///<remarks></remarks>
/// <mytag>Secret stuff</mytag>
/// <param name="s">Description for s</param>
let expectedMinutesInOven = 40//mins


///<summary>
/// <see cref="">Task 2</see>
/// Define the remainingMinutesInOven function that takes the actual minutes the lasagna has been in the oven as a parameter and returns how many minutes the lasagna still has to remain in the oven, based on the expected time oven time in minutes from the previous task.
/// </summary>
/// <param name="timePerLayer">Time that the food takes to be prepaired</param>
/// <returns>An integer representing the preporation time.</returns>
let timePerLayer = 2 //mins

///<summary>
/// <see cref="">Task 2</see>
/// Define the remainingMinutesInOven function that takes the actual minutes the lasagna has been in the oven as a parameter and returns how many minutes the lasagna still has to remain in the oven, based on the expected time oven time in minutes from the previous task.
/// </summary>
/// <param name="remainingMinutesInOven">How much time is left for the food to cook in the oven</param>
/// <returns>A function with a init argument 'elapsedTimeInOven' which is the sum of an init expression 'expectedMinutesInOven' minus another init expression 'elapsedTimeInOven'</returns>
let remainingMinutesInOven elapsedTimeInOven = expectedMinutesInOven - elapsedTimeInOven


///<summary>
/// <see cref="">Task 3</see>
/// Define the preparationTimeInMinutes function that takes the number of layers you added to the lasagna as a parameter and returns how many minutes you spent preparing the lasagna, assuming each layer takes you 2 minutes to prepare.
/// </summary>
/// <param name="preparationTimeInMinutes">Time that the food has been in the oven</param>
/// <returns>A function with a init argument 'preparationTimeInMinutes' which is the sum of an init expression 'numberOfLayers' times another init expression 'timePerLayer'.</returns>
let preparationTimeInMinutes numberOfLayers = numberOfLayers * timePerLayer


///<summary>
/// <see cref="">Task 4</see>
/// Define the remainingMinutesInOven function that takes the actual minutes the lasagna has been in the oven as a parameter and returns how many minutes the lasagna still has to remain in the oven, based on the expected time oven time in minutes from the previous task.
/// </summary>
/// <param name="elapsedTimeInOven">Time that the food has been in the oven</param>
/// <returns>An integer representing the remaining minutes in the oven.</returns>
let elapsedTimeInOven = 20

///<summary>
/// <see cref="">Task 4</see>
/// Define the elapsedTimeInMinutes function that takes two parameters: the first parameter is the number of layers you added to the lasagna, and the second parameter is the number of minutes the lasagna has been in the oven. The function should return how many minutes you've worked on cooking the lasagna, which is the sum of the preparation time in minutes, and the time in minutes the lasagna has spent in the oven at the moment.
/// </summary>
/// <param name="elapsedTimeInMinutes">Time that the food has been in the oven</param>
/// <returns>A function with two init arguments 'preparationTimeInMinutes' and 'elapsedTimeInOven' which is the sum of an init expression 'preparationTimeInMinutes' plus another init expression 'elapsedTimeInOven'.</returns>
let elapsedTimeInMinutes numberOfLayers  = numberOfLayers * timePerLayer


