using System;
namespace point3D
{
    class Point
    {
        // Конструктор по умолчанию
        public Point()
        {
            this.x = 0;
            this.y = 0;
            this.z = 0;
        }

        // Конструктор с инициализацией
        public Point(double new_x, double new_y, double new_z)
        {
            this.x = new_x;
            this.y = new_y;
            this.z = new_z;
        }

        // Метод рассчитывает расстояние от текущей точки до точки pnt
        public double Dist(Point pnt)
        {
            double dist = 0;
            dist = Math.Sqrt(Math.Pow(this.x - pnt.X, 2) + (Math.Pow(this.y - pnt.Y, 2) + Math.Pow(this.z - pnt.Z, 2)));
            return dist;
        }

        // Метод рассчитывает расстояние от текущей точки до начала координат
        public double Dist()
        {
            return this.Dist(new Point());
        }

        // Оператор сложения двух точек
        public static Point operator +(Point pnt1, Point pnt2)
        {
            Point result = new Point();

            result.X = (pnt1.X + pnt2.X);
            result.Y = (pnt1.Y + pnt2.Y);
            result.Z = (pnt1.Z + pnt2.Z);

            return result;
        }

        // Оператор скалярного произведения двух точек
        public static double operator *(Point pnt1, Point pnt2)
        {
            return pnt1.X * pnt2.X + pnt1.Y * pnt2.Y+ pnt1.Z * pnt2.Z;
        }

        // Метод выводит уравнение прямой по двум точкам
        public static void PrintLineEquation(Point pnt1, Point pnt2)
        {
            double A = pnt1.Y - pnt2.Y;
            double B = pnt1.X - pnt2.X;
            double C = pnt1.X * pnt2.Y - pnt2.X * pnt1.Y;

            // Ax + By + C = 0
            Console.WriteLine("{0} * x + {1} * y + {2} = 0", A, B, C);
        }

        // Метод выводит уравнение плоскости по трем точкам
        public static void PrintPlaneEquation(Point pnt1, Point pnt2, Point pnt3)
        {
            double A11 = pnt1.X; // X - X1
            double A21 = pnt2.X - pnt1.X;
            double A31 = pnt3.X - pnt1.X;
            double A12 = pnt1.Y; // Y - Y1
            double A22 = pnt2.Y - pnt1.Y;
            double A32 = pnt3.Y - pnt1.Y;
            double A13 = pnt1.Z; // Z - Z1
            double A23 = pnt2.Z - pnt1.Z;
            double A33 = pnt3.Z - pnt1.Z;

            // (X - A11) * (A22 * A33 - A32 * A23) + (Y - A12) * (A23 * A31 - A21 * A33) + (Z - A13) * (A21 * A32 - A22 * A31);
            double A = A22 * A33 - A32 * A23;
            double B = A23 * A31 - A21 * A33;
            double C = A21 * A32 - A22 * A31;
            double D = 0.0 - A11 * A - A12 * B - A13 * C;

            // Ax + By + Cz + D = 0
            Console.WriteLine("{0} * x + {1} * y + {2} * z + {3} = 0", A, B, C, D);
        }

        public void Print()
        {
            Console.WriteLine("({0}, {1}, {2})", this.x, this.y, this.z);
            
        }

        // Аксессоры (геттеры и сеттеры) членов класса
        public double X { get { return x; } set { x = value; } }
        public double Y { get { return y; } set { y = value; } }
        public double Z { get { return z; } set { z = value; } }

        // Члены класса
        private double x;
        private double y;
        private double z;
    }
}