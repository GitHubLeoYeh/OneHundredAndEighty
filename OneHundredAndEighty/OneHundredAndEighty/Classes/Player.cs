﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Shapes;

namespace OneHundredAndEighty
{
    public class Player //  Класс игрока
    {
        public string Name { get; private set; }    //  Имя игрока
        public string Tag { get; private set; } //  Тэг
        //Матч
        public int SetsWon; //  Количество выигранных сетов
        public int LegsWon; //  Количество выигранных легов в сете
        public int PointsToOut; //  Количество очков на завершение лега
        public Stack<Throw> AllPlayerThrows = new Stack<Throw>();   //  Коллекция бросков игрока в матче
        public Stack<int> LossPoints = new Stack<int>();   //  Коллекция оставшихся очков на момент проигрыша лега
        public Stack<int> LossLegs = new Stack<int>();   //  Коллекция оставшихся очков на момент проигрыша лега

        //Очередной подход
        public int HandPoints;  //  Набранное количестов очков
        public Throw Throw1 = null;  //  Первый бросок
        public Throw Throw2 = null;  //  Второй бросок
        public Throw Throw3 = null;  //  Третий бросок
        public void ClearHand() //  Обнуление очередного подхода
        {
            this.HandPoints = 0;
            this.Throw1 = null;
            this.Throw2 = null;
            this.Throw3 = null;
        }
        //  Инфо-панель
        public Canvas HelpPanel;    //  Панель помощи
        public Label HelpLabel; //  Лейбл помощи
        public Label SetsWonLabel;  //  Лейбл выиграных сетов
        public Label LegsWonLabel;  //  Лейбл выиграных легов
        public Label PointsLabel;   //  Лейбл набраных очнов

        public Player(string Tag, string Name, Canvas HelpPanel, Label HelpLabel, Label SetsWonLabel, Label LegsWonLabel, Label PointsLabel, int PointsToOut) //  Конструктор нового игрока
        {
            this.Tag = Tag;
            this.Name = Name;
            this.HelpPanel = HelpPanel;
            this.HelpLabel = HelpLabel;
            this.SetsWonLabel = SetsWonLabel;
            this.LegsWonLabel = LegsWonLabel;
            this.PointsLabel = PointsLabel;
            this.PointsToOut = PointsToOut;
        }
    }
}
