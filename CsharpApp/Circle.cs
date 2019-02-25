using System;

namespace  com.dev {

    public class Circle {
        public static double Area(double radius) {
            return Math.PI * radius * radius;
        }
        public static double Perimeter(double radius) {
            return 2 * Math.PI * radius;
        }
    }
}