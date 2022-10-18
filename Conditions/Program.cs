// 1. User gives 2 numbers a and b. If a>b then output a+b, if a=b then output a*b, if a<b then output a-b.

/*
Console.WriteLine("Please input two numbers a, b :");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
if (a > b) Console.WriteLine(a + b);
else if (a==b) Console.WriteLine(a * b);
else Console.WriteLine(a - b);
*/

// 2. User gives two numbes x and y. Find out coordinate quater of point with location (x,y).

/*
Console.WriteLine("Please input coordinates x, y :");
int x = Convert.ToInt32(Console.ReadLine());
int y = Convert.ToInt32(Console.ReadLine());
if (x>0 && y>0) Console.WriteLine("Point is in 1 quater");
else if (x < 0 && y > 0) Console.WriteLine("Point is in 2 quater");
else if (x < 0 && y < 0) Console.WriteLine("Point is in 3 quater");
else if (x > 0 && y < 0) Console.WriteLine("Point is in 4 quater");
*/

// 3. User gives 3 numberrs a, b, c. Output them in the ascending order.

/*Console.WriteLine("Please input three numbers a, b, c :");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());
if (a>=b && b>=c) Console.WriteLine( c + "," + b + "," + a);
else if (a>=c && c>=b) Console.WriteLine(b + "," + c + "," + a);
else if (b>=a && a>=c) Console.WriteLine(c + "," + a + "," + b);
else if (b>=c && c>=a) Console.WriteLine(a + "," + c + "," + b);
else if (c>=a && a>=b) Console.WriteLine(b + "," + a + "," + c);
else Console.WriteLine(a + "," + b + "," + c);
*/

// 4. User gives 3 numberrs a, b, c. Find out solution of quadratic equation ax^2+bx+c=0.

/*
Console.WriteLine("Please input three numbers a, b, c :");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());
double d = Math.Sqrt(b * b - 4 * a * c);
double x1 = (-b + d) / 2 * a;
double x2 = (-b - d) / 2 * a;
if (d < 0) Console.WriteLine("This equation doesn't have roots");
else if (d == 0) Console.WriteLine(-b / 2 * a);
else Console.WriteLine("x1=" + x1 + ";" + "x2=" + x2);
*/

// 5. User gives 2-digits number. Output the word according to this number.

/*
Console.WriteLine("Please input 2-digits number:");
int num = Convert.ToInt32(Console.ReadLine());
int a = num / 10;
int b = num % 10;
switch (num)
{
    case 10:
        Console.WriteLine("Ten");
        break;
    case 11:
        Console.WriteLine("Eleven");
        break;
    case 12:
        Console.WriteLine("Twelve");
        break;
    case 13:
        Console.WriteLine("Thirteen");
        break;
    case 14:
        Console.WriteLine("Fourteen");
        break;
    case 15:
        Console.WriteLine("Fifteen");
        break;
    case 16:
        Console.WriteLine("Sixteen");
        break;
    case 17:
        Console.WriteLine("Seventeen");
        break;
    case 18:
        Console.WriteLine("Eighteen");
        break;
    case 19:
        Console.WriteLine("Nineteen");
        break;
}
if (num > 19)
{
    switch (a)
    {
        case 2:
            Console.Write("Twenty ");
            break;
        case 3:
            Console.Write("Thirty ");
            break;
        case 4:
            Console.Write("Forty ");
            break;
        case 5:
            Console.Write("Fifty ");
            break;
        case 6:
            Console.Write("Sixty ");
            break;
        case 7:
            Console.Write("Seventy ");
            break;
        case 8:
            Console.Write("Eighty ");
            break;
        case 9:
            Console.Write("Ninety ");
            break;

    }

    switch (b)
    {
        case 1:
            Console.WriteLine("one");
            break;
        case 2:
            Console.WriteLine("two");
            break;
        case 3:
            Console.WriteLine("three");
            break;
        case 4:
            Console.WriteLine("four");
            break;
        case 5:
            Console.WriteLine("five");
            break;
        case 6:
            Console.WriteLine("six");
            break;
        case 7:
            Console.WriteLine("seven");
            break;
        case 8:
            Console.WriteLine("eight");
            break;
        case 9:
            Console.WriteLine("nine");
            break;

    }
}
*/

// 6. User gives 3 numbers x, y, r. Find out if point with location (x,y) is inside circle with radius r.

/*Console.WriteLine("Please input three numbers x, y, r :");
int x = Convert.ToInt32(Console.ReadLine());
int y = Convert.ToInt32(Console.ReadLine());
int r = Convert.ToInt32(Console.ReadLine());
double c = Math.Sqrt(x * x + y * y);
if (c == r) Console.WriteLine("The point (" + x + "," + y + ") is on circle");
else if (c>r) Console.WriteLine("The Point (" + x + "," + y + ") is outside circle");
else Console.WriteLine("The Point (" + x + "," + y + ") is inside circle");
*/

// 7. Write a program with 4 different options. Below you'll see what should happen if user will choose one of these options:
// a. Take a 3-digit number as input, and say if square of this number equals sum of all its digits to the power of 3.
// b. Take a 4-digit number and say if sum of first two digits equals sum of last 2 digits.
// c. Take a 3-digit number as input. Say if there any 2 similar digits in it.
// d. Take a float number. Say if first 3 digits after comma contains 0.


Console.WriteLine("Please choose one of the options:");
Console.WriteLine("Option 1: input a 3-digit number as input, and say if square of this number equals sum of all its digits to the power of 3.");
Console.WriteLine("Option 2: input 4-digit number and i'll say if sum of first two digits equals sum of last 2 digits.");
Console.WriteLine("Option 3: input a 3-digit number as input. I'll Say if there any 2 similar digits in it.");
Console.WriteLine("Option 4: input a float number. I'll Say if first 3 digits after comma contains 0.");
int option = Convert.ToInt32(Console.ReadLine());
switch (option) {
    case 1:
      Console.WriteLine("Please input 3 digits number");
        int num = Convert.ToInt32(Console.ReadLine());
        int a = num / 100;
        int b = num / 10 % 10;
        int c = num % 10; ;
        if (num * num == Math.Pow((a + b + c), 3)) Console.WriteLine(num + "yes, square of this number equals sum of all its digits to the power of 3");
        else Console.WriteLine(num + "No,square of this number doensn't equal sum of all its digits to the power of 3");
        break;
    case 2:
        Console.WriteLine("Please input 4 digits number");
        int num2 = Convert.ToInt32(Console.ReadLine());
        int n = num2 / 1000;
        int n1 = num2 / 100%10;
        int n2= num2 / 10 % 10;
        int n3 = num2 % 10; ;
        if (n+n1==n2+n3) Console.WriteLine(num2 + "yes, sum of first two digits equals sum of last 2 digits");
        else Console.WriteLine(num2 + "No,sum of first two digits doesn't equal sum of last 2 digits");
        break;
    case 3:
        Console.WriteLine("Please input 3 digits number");
        int num3 = Convert.ToInt32(Console.ReadLine());
        int a1 = num3 / 100;
        int b1 = num3 / 10 % 10;
        int c1 = num3 % 10; ;
        if ((a1 == b1 && a1 != c1) || (a1 == c1 && a1 != b1) || (b1 == c1 && b1 != a1)) Console.WriteLine(num3 + "yes, there any 2 similar digits in num");
        else if (a1 == b1 && a1 == c1) Console.WriteLine(num3 + "There are 3 similar digits");
        else Console.WriteLine("There are not similar digits");
        break;
    case 4:
        Console.WriteLine("Please input float number");
        decimal flt = Convert.ToDecimal(Console.ReadLine());
        decimal s = flt - (int)flt;
        Console.WriteLine(s);
        decimal d1 =(decimal)s * 1000 ;
        int x = (int)d1 / 100;
        int y = (int)d1 / 10 % 10;
        int z = (int)d1 % 10;
        if (x != 0 && y != 0 && z != 0) Console.WriteLine("There is not zero");
        else if (x==0 || y==0 || z==0) Console.WriteLine("There is zero");
        break;

}

