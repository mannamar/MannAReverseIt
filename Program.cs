// Amardeep Mann
// 10-20-22
// Mini Challenge #7 - Reverse it
// Take a number or string from the user and reverse it. Then take a string from the user and reverse it.

Console.Clear();

string response = "";

while(response.ToLower() != "exit") {

  Console.WriteLine("Welcome to the reverse it game! Enter \"exit\" at any time to quit");
  Console.WriteLine("\nPlease enter a number");

  bool isNumValid = false;
  int num = 0;
  string numString = "";

  while(!isNumValid) {
    response = Console.ReadLine();
    if (response.ToLower() == "exit") {
      break;
    }
    isNumValid = Int32.TryParse(response, out num);
    if(!isNumValid) {
      Console.WriteLine("Please enter a valid number");
    } else {
      numString = response;
    }
  }

  if (response.ToLower() == "exit") {
      break;
    }

  char[] revArr = {};
  Array.Resize(ref revArr, numString.Length);

  for (int i = 0; i < numString.Length; i++) {
    revArr[i] = numString[numString.Length-1-i];
  }

  Console.WriteLine("\nYou entered: ");
  Console.WriteLine(numString);
  Console.WriteLine("The reverse of it is: ");
  Console.WriteLine(revArr);

  Console.WriteLine("\nPlease enter some words");
  response = Console.ReadLine();

  if (response.ToLower() == "exit") {
    break;
  }

  char[] revStringArr = {};
  Array.Resize(ref revStringArr, response.Length);

  for (int i = 0; i < response.Length; i++) {
    revStringArr[i] = response[response.Length-1-i];
  }

  Console.WriteLine("\nYou entered: ");
  Console.WriteLine(response);
  Console.WriteLine("The reverse of it is: ");
  Console.WriteLine(revStringArr);

  Console.WriteLine("\nCool let's play again");
}

Console.WriteLine("\nGotta go? No worries we'll catch you later");