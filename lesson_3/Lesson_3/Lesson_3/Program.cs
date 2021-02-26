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
        private readonly PointClass pointOneClass = new PointClass { X = 0f, Y = 0f };
        private readonly PointClass pointTwoClass = new PointClass { X = 10.52f, Y = 10.52f };

        private readonly PointStructDouble pointOneStructD = new PointStructDouble { X = 0d, Y = 0d };
        private readonly PointStructDouble pointTwoStructD = new PointStructDouble { X = 10.52, Y = 10.52 };

        private readonly PointStructFloat pointOneStructF = new PointStructFloat { X = 0f, Y = 0f };
        private readonly PointStructFloat pointTwoStructF = new PointStructFloat { X = 10.52f, Y = 10.52f };

        public float ClassPointDistanceDouble(PointClass pointOne, PointClass pointTwo)
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
        public void TestClassPointDistanceDouble()
        {
            
            ClassPointDistanceDouble(pointOneClass, pointTwoClass);
        }

        [Benchmark]
        public void TestStructPointDistanceDouble()
        {

            StructPointDistanceDouble(pointOneStructD, pointTwoStructD);
        }

        [Benchmark]
        public void TestStructPointDistanceFloat()
        {
            StructPointDistanceFloat(pointOneStructF, pointTwoStructF);
        }

        [Benchmark]
        public void TestStructPointDistanceFloatNoSqrt()
        {
            StructPointDistanceFloatNoSqrt(pointOneStructF, pointTwoStructF);
        }
    }

   
 }
