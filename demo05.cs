namespace Demo_Session5
{
    internal class Program
    {
        


        
        static void PrintShapes(int count = 10, string shape = "#O_O#")
        {
            for (int i = 1; i <= count; i++)
            {
                Console.WriteLine($"{shape}");
            }
        }
        static void Main(string[] args)
        {
            #region Boxing & UnBoxing 
            // Ref Type => Value Type
            //Value Type => Ref Type 
            // => Behaivors you Should Avoid 
            ///Value Type => Reference Type => Boxing => Save Casting => Implicit
            ///ReferenceType => Value Type =>UnvBoxing => Unsafe Casting => Explicit
            ///
            //Refere
            //object o1 = 5;//Boxing Save Casting 
            ////o1 = true;
            /////Animal = Dog
            //int x = 10;
            //o1 = "Ahmed";
            //x =(int) o1;//UnBoxing Unsafe Casting (Explicit Casting)
            // //Dog =(Dog) Animal 
            #endregion

            #region Nullable-value type
            // NULL is not a valid value for the variables of datatype: ValueType[Struct, Enums]
            // Nullable ValueTypes: ValueTypes + Allow NULL as a Valid Value.
            /// int? Age; // Nullable<int> Age;
            /// 
            /// Age = 22;
            /// Age = null;
            /// 
            /// Console.WriteLine(Age is not null?  Age: 0 );
            /// Console.WriteLine(Age.HasValue?     Age.Value: 0);
            /// 
            /// 
            /// decimal? Salary; // Nullable<decimal> Salary;
            /// 
            /// Salary = 5_000;
            /// Salary = null;
            /// 
            /// Console.WriteLine(Salary is not null? Salary: 0);
            /// Console.WriteLine(Salary.HasValue?    Salary.Value: 0); 
            #endregion

            #region Nullable ReferenceTypes [C# 10.0 (.NET 6.0) in Nov.2021]

            // NULL is a valid Value for the Variables of Datatype: ReferenceType[Interface, Class].


            /// string Message01 = null!; // ! Null Forgivness Operator
            /// Message01 = null!;
            /// 
            /// string? Message02 = null;
            /// 
            /// 
            /// Console.WriteLine(Message01);
            /// Console.WriteLine(Message02);
            #endregion

            #region Function Prototype and Calling
            // PrintShapes(10, "$O_O$"); // Passing Parameters with Same Order
            // PrintShapes(shape: "$O_O$", count: 10); // Passing Parameters with Naming
            // PrintShapes();

            // PrintShapes(15, @"/*\"); 
            #endregion

            #region ValueType Parameters [Passing By Value[Input] Vs Passing By Ref[InputOutput]]
            /// int A = 3, B = 5;
            /// Console.WriteLine($"A = {A}"); // 3
            /// Console.WriteLine($"B = {B}"); // 5
            /// 
            /// // SWAP(A, B); // 1. Passing By Value [Input Parameter]
            ///                //    SWAP(3, 5);
            /// 
            /// 
            /// // SWAP(ref A, ref B); // 2. Passing By Ref [Input Output Parameter]
            ///                        //    SWAP(A, B);
            /// 
            /// Console.WriteLine($"A = {A}"); // 5
            /// Console.WriteLine($"B = {B}"); // 3 
            /// 
            #endregion

            #region ValueType Parameters
            // 1. Passing By Value
            /// static void SWAP(int X, int Y) /SWAP(3, 5)/
            /// {
            ///     Console.WriteLine("====== SWAPING ======");
            ///     int Temp = X; // 3
            ///     X = Y; // 5
            ///     Y = Temp; // 3
            /// }

            // 2. Passing By Ref
            /// static void SWAP(ref int X, ref int Y) /SWAP(A, B)/
            /// {
            ///     Console.WriteLine("====== SWAPING ======");
            ///     int Temp = X; // 3
            ///     X = Y; // 5
            ///     Y = Temp; // 3
            /// }
            /// 
            #endregion


            #region by Ref

            //    public static int SumArray(int[] Arr)
            //{
            //     //Sum+1=1
            //     //1+2=3
            //     //3+3=6
            //        int Sum = 0;
            //        Arr[0] = 160;
            //            for (int i = 0; i < Arr.Length; i++)
            //    {
            //         Sum += Arr[i];
            //    }
            //     return Sum;


            //    int[] Numbers = { 1, 2, 3 };

            //    Console.WriteLine(Sunhrray(NURBEFS));
            //    Console.WriteLine(Numbers[6]);


            #endregion

            #region by Ref

            //    public static int SumArray(int[] Arr)
            //{

            //     //sum+1=1

            //    // 1 + 2 = 3

            //     //3+3=6

            //    int Sum = 0;

            //     //Arr[e] = 100; 1

            //     Arr = new int[] {4,5 6};

            //        for (int i = 0; i < Arr.Length; i++)


            //         Sum += Arr[i];

            //    }

            //         return Sum;

            #endregion

          

        #region Functions - Passing By Out

        //public static void SumMul(int X, int Y, out int Sum, out int Mul)


        //{
        //    Sum = X + Y;

        //    Mul = X * Y;

        //    //return Sum;

        //    //return Mul;

        //}


        //int A = 16; 

        //    int B = 20;

        //int Sum = 0, Mul = 0;

        //SunMul(A, B, ref Sum, ef Mul);
        //Console.WriteLine(Sum);
        //Console.WriteLine(Mul);

#endregion
    }
}