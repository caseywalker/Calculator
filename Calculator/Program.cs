using System;

namespace Calculator
{
  class Program
  {
    static void Main(string[] args)
    {
      var userSelection = "";

      Console.WriteLine("Calculator Console");

      Console.WriteLine("Type in an Operator (*, ^2, +, -, /, avg) followed by a space and list of comma separated values");
      var shorthandUserInput = Console.ReadLine();
      var shortSplit = shorthandUserInput.Split(' ');

      switch (shortSplit[0])
      {
        case "*":
          userSelection = "Multiply";
          break;
        case "^2":
          userSelection = "Square";
          break;
        case "+":
          userSelection = "Addition";
          break;
        case "-":
          userSelection = "Subtraction";
          break;
        case "/":
          userSelection = "Division";
          break;
        case "avg":
          userSelection = "Average";
          break;
        default:
          Console.WriteLine("Invalid Operator");
          break;
      }

      Console.WriteLine($"You selected {userSelection}.");

      var userInputs = shortSplit[1];
      var inputArray = userInputs.Split(',');

      switch (userSelection)
      {
        case "Multiply":
          var result = 1;
          foreach (var inp in inputArray)
          {
            var integerCalc = Int32.Parse(inp);
            result = integerCalc * result;
          }
          Console.WriteLine(result);
          break;
        case "Square":
          var sqResult = "";
          foreach (var inp in inputArray)
          {
            var intCalc = Int32.Parse(inp);
            var sq = intCalc * intCalc;
            sqResult += sq.ToString() + ',';
          }
          Console.WriteLine(sqResult.TrimEnd(','));
           break;
        case "Addition":
          var sum = 0;
          foreach (var inp in inputArray)
          {
            var intCalc = Int32.Parse(inp);
            sum += intCalc;
          }
          Console.WriteLine(sum);
          break;
        case "Subtraction":
          var initValue = Int32.Parse(inputArray[0]);
          var diff = initValue * 2;
          foreach (var inp in inputArray)
          {
            var intCalc = Int32.Parse(inp);
            diff -= intCalc;
          }
          Console.WriteLine(diff);
          break;
        case "Division":
          var initialValue = Decimal.Parse(inputArray[0]);
          var quotient = initialValue * initialValue;
          foreach (var inp in inputArray)
          {
            var intCalc = Decimal.Parse(inp);
            quotient /= intCalc;
          }
          Console.WriteLine(quotient);
          break;
        case "Average":
          var start = 0m;
          var counter = 0m;
          foreach (var inp in inputArray)
          {
            var intCalc = Decimal.Parse(inp);
            start += intCalc;
            counter ++;
          }
          var avgResult = start / counter;
          Console.WriteLine(avgResult);
          break;
        default:
          Console.WriteLine("Invalid Input");
          break;
      }

    }
  }
}
