using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib3
{
    public abstract class Geom_Figure
    {
        /// <summary>
        /// Абстрактный базовый класс Geom_Figure
        /// Включает в себя базовые функции описания для круга и квадрата
        /// </summary>
        protected double Perimetr;
        protected double Squares;
        protected string Color;
        protected string Name;
        protected double X;
        protected double Y;
        /// <summary>
        /// Свойство, обрабатывающее ввод названия фигуры
        /// Если имя некорректно, то оно Noname
        /// </summary>
        public string NameG
        {
            get
            {
                return Name;
            }
            set
            {
                Name = value;
            }
        }
        /// <summary>
        /// Свойство, обрабатывающее ввод цвета фигуры
        /// Если имя некорректно, то оно White
        /// </summary>
        public string ColorG
        {
            get
            {
                return Color;
            }
            set
            {
                    Color = value;
            }
        }
        /// <summary>
        /// Конструктор класса Geom_Figure
        /// Создает объект без параметров
        /// </summary>
        public Geom_Figure()
        {
            Name = "Noname";
            Color = "White";
            X = 0;
            Y = 0;
        }
        /// <summary>
        /// Конструктор класса Geom_Figure
        /// Создает объект с именем фигуры
        /// </summary>
        /// <param name="name">Имя фигуры</param>
        public Geom_Figure(string name)
        {
            NameG = name;
            Color = "White";
            X = 0;
            Y = 0;
        }
        /// <summary>
        /// Конструктор класса Geom_Figure
        /// Создает объект с именем фигуры и цветом
        /// </summary>
        /// <param name="name">Имя фигуры</param>
        /// <param name="color">Цвет фигуры</param>
        public Geom_Figure(string name, string color)
        {
            NameG = name;
            ColorG = color;
            X = 0;
            Y = 0;
        }
        /// <summary>
        /// Конструктор класса Geom_Figure
        /// Создает объект с именем фигуры, цветом и координатами центра
        /// </summary>
        /// <param name="name">Имя фигуры</param>
        /// <param name="color">Цвет фигуры</param>
        /// <param name="x">Абсциса центра фигуры</param>
        /// <param name="y">Ордината центра фигуры</param>
        public Geom_Figure(string name, string color, double x, double y)
        {

            NameG = name;
            ColorG = color;
            X = x;
            Y = y;
        }
        /// <summary>
        /// Выводит информацию об фигуры
        /// </summary>
        /// <returns>Возвращает строку с параметрами фигуры</returns>
        public abstract string Print();

    }
}

