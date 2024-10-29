using System;

namespace Delegate_execise.Delegate_Cơ_Bản ;
delegate int MathOperation(int a, int b);
public class Math
{
    protected static int add ( int a , int b ) => a + b ;
   protected static int Sub ( int a , int b ) => a - b ;
    protected static int Mul ( int a , int b ) => a * b ;
   protected static int Div ( int a , int b ) => a / b ;

    static void Main ( ) {
        MathOperation Add = add ; 
        MathOperation sub = Sub ;
        MathOperation mul = Mul ;
        MathOperation div = Div ;
        Console.WriteLine($"Add: {Add(1,2)}");
        Console.WriteLine($"Sub: {sub(1,2)}");
        Console.WriteLine($"Mul: {mul(1,2)}");
        Console.WriteLine($"Div: {div(1,2)}");
        
        


    }



}