Console.Clear();
// Console.SetCursorPosition(10, 4);
// Console.WriteLine("+");

int XA = 40, YA = 1,
    XB = 1, YB = 25,
    XC = 80, YC = 25;

Console.SetCursorPosition(XA, YA);
Console.WriteLine("+");

Console.SetCursorPosition(XB, YB);
Console.WriteLine("+");

Console.SetCursorPosition(XC, YC);
Console.WriteLine("+");
int X = XA, Y=XB;
int count = 0;

while (count < 10000)
{ int what = new Random().Next(0, 3); // [0,3] 0 1 2
if (what == 0)
   {
      X = (X + XA) /2;
      Y = (Y + YA) /2;
   }
if (what == 1)
   {
    X = (X + XB) /2;
    Y = (Y + YB) /2;  
   }
if (what == 2)
   {
    X = (X + XC) /2;
    Y = (Y + YC) /2;
   }
    Console.SetCursorPosition(X, Y);
    Console.WriteLine("+");
    count ++;

}


