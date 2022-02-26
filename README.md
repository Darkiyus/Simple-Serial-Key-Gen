# Simple-Serial-Key-Gen
A simple code file to add to a project to create a serial key

# How to Use
1. Add the code file to your project (SerialKeyGen.cs)
2. Use the following function to create a serial key (You need the namespace DarkiyusSerialKey).

        SerialKey.Gen(int groups, int inGroupPieces);
The first number defines how many groups there should be, the second how many digits should be in a group.


# Example

<img src="/SL23P-13FZ0-IISP4.png" />

      
      using DarkiyusSerialKey;
      
      class Example
      {

          public static void Main()
          {
              Console.WriteLine(SerialKey.Gen(3, 5));
          }

      }
