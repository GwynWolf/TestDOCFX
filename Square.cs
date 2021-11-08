using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLib3
{
    public class Square : Geom_Figure
    {
        /// <summary>
        /// Подкласс абстрактного класса Square
        /// Описывает квадрат по цвету, названию, длине стороны, площади, периметру и центру квадрата
        /// </summary>
        protected double Side;
        protected string ColorSquare = "White";
        protected string NameSquare = "Noname";
        protected double X_Squares;
        protected double Y_Squares;
        protected double Perimetr;
        protected double Squares;

        /// <summary>
        /// Конструктор класса Square
        /// Создает объект через имя и длину стороны
        /// </summary>
        /// <param name="a">Длина стороны квадрата</param>
        /// <param name="name">Имя фигуры</param>
        public Square(double a, string name) : base(name)
        {
            NameSquare = name;
            if (a > 0)
                Side = a;
            else
                Side = 0;
        }
        /// <summary>
        /// Конструктор класса Square
        /// Создает объект без параметров
        /// </summary>
        public Square() : base()
        {
            Side = 0;
        }
        /// <summary>
        /// Конструктор класса Circle
        /// Создает объект через длину стороны квадрата
        /// </summary>
        /// <param name="a">Длина стороны квадрата</param>
        public Square(double a) : base()
        {
            if (a > 0)
                Side = a;
            else
                Side = 0;
        }
        /// <summary>
        /// Конструктор класса Circle
        /// Создает объект через имя фигуры, длину стороны квадрата и цвета квадрата
        /// </summary>
        /// <param name="a">Длина стороны квадрата</param>
        /// <param name="name">Имя фигуры</param>
        /// <param name="color">Цвет фигуры</param>
        public Square(double a, string name, string color) : base(name, color)
        {
            NameSquare = name;
            ColorSquare = color;
            if (a > 0)
                Side = a;
            else
                Side = 0;
        }
        /// <summary>
        /// Конструктор класса Circle
        /// Создает объект через имя фигуры, длину стороны квадрата и цвета квадрата
        /// </summary>
        /// <param name="a">Длина стороны квадрата</param>
        /// <param name="name">Имя фигуры</param>
        /// <param name="color">Цвет фигуры</param>
        /// <param name="x">Абсциса центра квадрата</param>
        /// <param name="y">Одината центра квадрата</param>
        public Square(double a, string name, string color, double x, double y) : base(name, color, x, y)
        {
            NameSquare = name;
            ColorSquare = color;
            X_Squares = x;
            Y_Squares = y;
            if (a > 0)
                Side = a;
            else
                Side = 0;
        }
        /// <summary>
        /// Выводит информацию про квадрат
        /// </summary>
        /// <returns>Возвращает строку с именем фигуры, цветом, длину стороны квадрата, координатами центра, площадью и периметром</returns>
        public override string Print()
        {
            return string.Format("Object {0} is squares\nColor: {1}\nSide: {2}\nCenter: ({3}, {4})Squares: {5}\nPerimetr: {6}", NameSquare, ColorSquare, Side, X_Squares, Y_Squares, Squares, Perimetr);
        }
    }
}