using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//https://www.udemy.com/course/csharp-intermediate-classes-interfaces-and-oop/learn/lecture/2243586#content
/* abstract keyword is used to indicate that a method lacks implementation
 * and only derived classes deliver said implementation
 * 
 */
namespace AbstractClass
{
    /* without abstract modifier
    public class Shape
    {
        public virtual void Draw()
        {

        }
    }
    public class Circle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Draw a circle");
        }
    }
    */
    // with abstract modifier:
    public abstract class Shape
    {
        public abstract void Draw();
    }
    public class Circle : Shape
    {
        public override void Draw()
        {
            // implementation for Circle
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var shap = new Shape(); // it's impossible to create an instance of an abstract class
        }
    }
}