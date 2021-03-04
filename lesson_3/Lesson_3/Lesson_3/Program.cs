using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using System;

namespace Lesson_3
{
    class Program
    {
        static void Main(string[] args)
        {
            BenchmarkSwitcher.FromAssembly(typeof(Program).Assembly).Run(args);
            
        }

    }

    public class BechmarkClass
    {

        private readonly PointClass[] pointOneClasses;
        private readonly PointClass[] pointTwoClasses;

        private readonly PointStructDouble[] pointOneStructesD;
        private readonly PointStructDouble[] pointTwoStructesD;

        private readonly PointStructFloat[] pointOneStructesF;
        private readonly PointStructFloat[] pointTwoStructesF;
        public BechmarkClass()
        {

            pointOneClasses = PointClassesGenerate(100);
            pointTwoClasses = PointClassesGenerate(100);

            pointOneStructesD = PointStructDoubleGenerate(100);
            pointTwoStructesD = PointStructDoubleGenerate(100);

            pointOneStructesF = PointStructFloatGenerate(100);
            pointTwoStructesF = PointStructFloatGenerate(100);
        }
        public float ClassPointDistanceFloat(PointClass pointOne, PointClass pointTwo)
        {
            float x = pointOne.X - pointTwo.X;
            float y = pointOne.Y - pointTwo.Y;
            return MathF.Sqrt((x * x) + (y * y));
        }

        public double StructPointDistanceDouble(PointStructDouble pointOne, PointStructDouble pointTwo)
        {
            double x = pointOne.X - pointTwo.X;
            double y = pointOne.Y - pointTwo.Y;
            return Math.Sqrt((x * x) + (y * y));
        }

        public float StructPointDistanceFloat(PointStructFloat pointOne, PointStructFloat pointTwo)
        {
            float x = pointOne.X - pointTwo.X;
            float y = pointOne.Y - pointTwo.Y;
            return MathF.Sqrt((x * x) + (y * y));
        }

        public float StructPointDistanceFloatNoSqrt(PointStructFloat pointOne, PointStructFloat pointTwo)
        {
            float x = pointOne.X - pointTwo.X;
            float y = pointOne.Y - pointTwo.Y;
            return (x * x) + (y * y);
        }
      
        [Benchmark]
        public void TestClassPointDistanceFloat()
        {
            for (int i = 0; i < pointOneClasses.Length; i++)
            {
                ClassPointDistanceFloat(pointOneClasses[i], pointTwoClasses[i]);
            }
            
        }

        [Benchmark]
        public void TestStructPointDistanceDouble()
        {
            for (int i = 0; i < pointOneStructesD.Length; i++)
            {
                StructPointDistanceDouble(pointOneStructesD[i], pointTwoStructesD[i]);
            }
            
        }

        [Benchmark]
        public void TestStructPointDistanceFloat()
        {
            for (int i = 0; i < pointOneStructesF.Length; i++)
            {
                StructPointDistanceFloat(pointOneStructesF[i], pointTwoStructesF[i]);
            }
            
        }

        [Benchmark]
        public void TestStructPointDistanceFloatNoSqrt()
        {
            for (int i = 0; i < pointOneStructesF.Length; i++)
            {
                StructPointDistanceFloatNoSqrt(pointOneStructesF[i], pointTwoStructesF[i]);
            }
           
        }

        private PointClass[] PointClassesGenerate(int arrLen)
        {
            PointClass[] arr = new PointClass[arrLen];
            
            for (int i = 0; i < arrLen; i++)
            {
                arr[i] = new PointClass { X = RandomFloatNumber(), Y = RandomFloatNumber() };
            }

            return arr;
        }

        private PointStructDouble[] PointStructDoubleGenerate(int arrLen)
        {
            PointStructDouble[] arr = new PointStructDouble[arrLen];

            for (int i = 0; i < arrLen; i++)
            {
                arr[i] = new PointStructDouble { X = RandomDoubleNumber(), Y = RandomDoubleNumber() };
            }

            return arr;
        }

        private PointStructFloat[] PointStructFloatGenerate(int arrLen)
        {
            PointStructFloat[] arr = new PointStructFloat[arrLen];

            for (int i = 0; i < arrLen; i++)
            {
                arr[i] = new PointStructFloat { X = RandomFloatNumber(), Y = RandomFloatNumber() };
            }

            return arr;
        }

        private  float RandomFloatNumber()
        {
            Random random = new Random();
            float randNumber = (float)(random.Next(1, 101) + random.NextDouble());
            return randNumber;
        }
        private double RandomDoubleNumber()
        {
            Random random = new Random();
            double randNumber = (double)(random.Next(1, 101) + random.NextDouble());
            return randNumber;
        }
    }

   
 }
