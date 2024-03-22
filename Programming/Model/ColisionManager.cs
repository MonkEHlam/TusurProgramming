using System;


namespace Programming.Model
{
    internal static class ColisionManager
    {
        public static bool IsColision(Rectangle rectangle1, Rectangle rectangle2)
        {
            bool xColision = Math.Abs(rectangle1.Center.X - rectangle2.Center.X) < Math.Abs(rectangle1.Width - rectangle2.Width) / 2;
            bool yColision = Math.Abs(rectangle1.Center.Y - rectangle2.Center.Y) < Math.Abs(rectangle1.Length - rectangle2.Length) / 2;
            return xColision && yColision;
        }

        public static bool IsColision(Ring ring1, Ring ring2) 
        {
            double c = Math.Pow(Math.Pow
                (
                Math.Abs(ring1.Center.X - ring2.Center.X), 2) +
                Math.Pow(Math.Abs(ring1.Center.Y - ring2.Center.Y), 2
                ), 0.5);
            return c < ring1.ExternalRadius + ring2.ExternalRadius;
        }
    }
}
