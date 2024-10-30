namespace Delegate_execise.Delegate_với_Func_và_Action ;


partial class MathOperator
{

    static int Add ( int a , int b ) => a + b ;
    static int Sub ( int a , int b ) => a - b ; 
    static int Mul ( int a , int b ) => a * b ;
    static int Div ( int a , int b ) => a / b ;

    static void Main ( ) {
        Func < int , int , int > add = Add ;
        Func < int , int , int > sub = Sub ;
        Func < int , int , int > mul = Mul ;
        Func < int , int , int > div = Div ;

        Action < string > print = Console . WriteLine ; // delegate khoong trả về giá trị 
        
        print ( $"add : {add ( 1 , 2 )}" ) ;
        print ( $"sub : {sub ( 1 , 2 )}" ) ;
        print ( $"mul : {mul ( 1 , 2 )}" ) ;
        print ( $"div : {div ( 1 , 2 )}" ) ;
        

    }
    
}