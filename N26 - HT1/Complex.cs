namespace N26___HT1;

internal class Complex
{
    public double Real { get; set; }
    public double Imaginary { get; set; }

    public Complex(double real, double imaginary)
    {
        Real = real;
        Imaginary = imaginary;
    }

    //+
    public static Complex operator +(Complex a, Complex b)
    {
        double realPart = a.Real + b.Real;
        double imaginePart = a.Imaginary + b.Imaginary;
        return new Complex(realPart, imaginePart);
    }

    //-
    public static Complex operator -(Complex a, Complex b)
    {
        double realPart = a.Real - b.Real;
        double imaginePart = a.Imaginary - b.Imaginary;
        return new Complex(realPart, imaginePart);
    }

    public override string ToString()
    {
        return $"{Real} - {Imaginary}i";
    }

}
