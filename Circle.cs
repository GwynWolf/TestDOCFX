using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLib3
{
    public class Circle : Geom_Figure
    {
        /// <summary>
        /// Подкласс абстрактного класса Geom_Figure
        /// Описывает круг по цвету, названию, радиусу, площади, периметру и центру окружности
        /// </summary>
        protected double Radius;
        protected string ColorCirc = "White";
        protected string NameCirc = "Noname";
        protected double X_Circle;
        protected double Y_Circle;
        protected double Perimetr;
        protected double Square;
        /// <summary>
        /// Конструктор класса Circle
        /// Создает объект через имя и радиус окружности
        /// </summary>
        /// <param name="R">Радиус окружности</param>
        /// <param name="name">Имя фигуры</param>
        public Circle(double R, string name) : base(name)
        {
            NameCirc = name;
            Radius = R;
        }
        /// <summary>
        /// Конструктор класса Circle
        /// Создает объект без параметров
        /// </summary>
        public Circle() : base()
        {
            Radius = 0;
        }
        /// <summary>
        /// Конструктор класса Circle
        /// Создает объект через радиус окружности
        /// </summary>
        /// <param name="R">Радиус окружности</param>
        public Circle(double R) : base()
        {
            if (R < 0)
                Radius = 0;
            else
                Radius = R;
        }
        /// <summary>
        /// Конструктор класса Circle
        /// Создает объект через имя, радиус окружности и цвет окружности
        /// </summary>
        /// <param name="R">Радиус окружности</param>
        /// <param name="name">Имя фигуры</param>
        /// <param name="color">Цвет фигуры</param>
        public Circle(double R, string name, string color) : base(name, color)
        {
            NameCirc = name;
            ColorCirc = color;
            if (R < 0)
                Radius = 0;
            else
                Radius = R;
        }
        /// <summary>
        /// Конструктор класса Circle
        /// Создает объект через радиус окружности, имя, цвет фигуры и цетра его окружности
        /// </summary>
        /// <param name="R">Радиус окружности</param>
        /// <param name="name">Имя фигуры</param>
        /// <param name="color">Цвет фигуры</param>
        /// <param name="x">Абсциса центра фигуры</param>
        /// <param name="y">Ордината центра фигуры</param>
        public Circle(double R, string name, string color, double x, double y) : base(name, color, x, y)
        {
            Radius = R;
            NameCirc = name;
            ColorCirc = color;
            X_Circle = x;
            Y_Circle = y;
        }
        public override string Print()
        {
            return string.Format("Object {0} is circle\nColor: {1}\nRadius: {2}\nCenter: ({3}, {4})Squares: {5}\nPerimetr: {6}", NameCirc, ColorCirc, Radius, X_Circle, Y_Circle, Square, Perimetr);
        }

    }
}