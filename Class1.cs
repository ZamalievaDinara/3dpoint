
using point3D;
using System.Diagnostics;
Point pnt1 = new Point();
Point pnt2 = new Point(1, 2, 3);
Point pnt3 = new Point(4, 5, 6);

double dist = pnt1.Dist(pnt2);
Console.WriteLine(dist);
double dist_to_0 = pnt2.Dist();
Console.WriteLine(dist_to_0);

Point sum = pnt2 + pnt3;
sum.Print();

double scalar = pnt2 * pnt3;
Console.WriteLine(scalar);
Point.PrintLineEquation(pnt1, pnt2);
Point.PrintPlaneEquation(pnt1, pnt2, pnt3);