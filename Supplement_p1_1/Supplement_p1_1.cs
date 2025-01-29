namespace Supplement_p1_1;

public class Supplement_p1_1
{
    /// <summary>
        /// Returns the are of a rectangle. If the length is equal to the width,
        /// the calculation is done as length*length instead.
        /// </summary>
        /// <param name="length">Length of the rectangle.</param>
        /// <param name="width">Width of the rectangle.</param>
        /// <returns>Area of the rectangle.</returns>
             
    public static double AreaOfRectangle(double length, double width){
        if (length == width) {
            return length * length;
        } else {
            return length * width;
        }
        
    }

    /// <summary>
    /// Returns the area of a circle.
    /// </summary>
    /// <param name="radius">Radius of a circle</param>
    /// <returns>The area of a circle with a given radius</returns>
    public static double AreaOfCircle(double radius){
        return double.Pow(radius, 2.0) * double.Pi;
    }

    public static double AreaOfTriangle(double triangleBase, double triangleHeight){
        throw new NotImplementedException();
    }
}
