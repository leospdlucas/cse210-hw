public class Fraction {
    private int _top;
    private int _bottom;

    // No parameters - 1/1
    public Fraction() {
        _top = 1;
        _bottom = 1;
    }

    // Whole number - denominator = 1
    public Fraction(int wholeNumber) {
        _top = wholeNumber;
        _bottom = 1;
    }

    // Top and bottom
    public Fraction(int top, int bottom) {
        _top = top;
        _bottom = bottom;
    }

    // Getters
    public int GetTop() {
        return _top;
    }

    public int GetBottom() {
        return _bottom;
    }

    // Setters
    public void SetTop(int top) {
        _top = top;
    }

    public void SetBottom(int bottom) {
        _bottom = bottom;
    }

    // Return the fraction as a string - "3/4"
    public string GetFractionString() {
        return $"{_top}/{_bottom}";
    }

    // Return the decimal value - 0.75
    public double GetDecimalValue() {
        return (double)_top / _bottom;
    }
}