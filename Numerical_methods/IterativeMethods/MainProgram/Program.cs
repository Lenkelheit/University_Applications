using System;
using IterativeMethods;

namespace MainProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            // [0.5,1.4]
            // a = 0.5, b = 1.4, e = 0.0001;
            double a, b, e;
            Console.Write("Input a: ");
            a = double.Parse(Console.ReadLine());
            Console.Write("Input b: ");
            b = double.Parse(Console.ReadLine());
            Console.Write("Input epsylon: ");
            e = double.Parse(Console.ReadLine());

            uint numOfIter;
            OneEquationSolution oneEquationSolution = new OneEquationSolution();

            Console.WriteLine($"\nChord method: {oneEquationSolution.ChordMethod(a, b, e, out numOfIter)}");
            Console.WriteLine($"Number of iterations for chord method: {numOfIter}");

            Console.WriteLine($"\nMethod of tangents(Newton): {oneEquationSolution.MethodOfTangents(a, b, e, out numOfIter)}");
            Console.WriteLine($"Number of iterations for method of tangents(Newton): {numOfIter}");

            var root = oneEquationSolution.CombinedMethod(a, b, e, out numOfIter);
            Console.WriteLine($"\nCombined method:\n root of shortage: {root.Item1}\n root of excess: {root.Item2}");
            Console.WriteLine($"Number of iterations for combined method: {numOfIter}");

            // (1,-1) 
            Console.WriteLine("\nInput x and y: ");
            var point = new Tuple<double, double>(double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()));

            SystemEquationsSolution systemEquationsSolution = new SystemEquationsSolution();

            var rootOfSystemByIterativeProcess = systemEquationsSolution.
                IterativeProcess(point.Item1, point.Item2, e, out numOfIter);
            Console.WriteLine($"\nIteration method:\n x: {rootOfSystemByIterativeProcess.Item1}\n" +
                              $" y: {rootOfSystemByIterativeProcess.Item2}");
            Console.WriteLine($"Number of iterations for iteration method: {numOfIter}");

            var rootOfSystemByNewtonMethod = systemEquationsSolution.
                NewtonMethod(point.Item1, point.Item2, e, out numOfIter);
            Console.WriteLine($"\nNewton method:\n x: {rootOfSystemByNewtonMethod.Item1}\n" +
                              $" y: {rootOfSystemByNewtonMethod.Item2}");
            Console.WriteLine($"Number of iterations for Newton method: {numOfIter}");
            
            Console.ReadLine();
        }
    }
}
