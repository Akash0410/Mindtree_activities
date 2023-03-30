using System;
public class Rectangle{
    private int _length;
    private int _width;
	
	public Rectangle()
		{

		}

        public Rectangle(int _length, int _width)
        {
            this._length = _length;
            this._width = _width;
        }
        public int Length
        {
            get { return _length; }
            set { _length = value; }
        }
        public int Width
        {
            get { return _width; }
            set { _width = value; }
        }
	
	public int Area() {
		
		return _length*_width;
	}
	
	public void Display() {
		Console.WriteLine("Rectangle Dimension");
		 Console.WriteLine("Length:" + _length);
         Console.WriteLine("Width:" + _width);
        Console.WriteLine("Area of the Rectangle:"+(_length*_width));
	}
	
	public Rectangle DimensionChange(int d)
        {
            return new Rectangle(_length * d, _width * d);
        }
}
