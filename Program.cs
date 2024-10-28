//MathGame Project
// Started 10/26/2024

// The point of the game is to choose a math operator (Add, Subtract, Multiply, Divide), 
// After you choose what operator, you get a random math problem using that operator. 
//

using System;
using MathGame;

var date = DateTime.UtcNow;
var name = MenuMethods.GetName();

MainGame.Menu(name,date);