using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace PriceIsRightParty
{
    class Player
    {
        private string m_name;

        public string Name
        {
            get { return m_name; }
            set { m_name = value; }
        }
        private Image m_image;

        public Image Image
        {
            get { return m_image; }
            set { m_image = value; }
        }
        private double m_initBAC;

        public double InitBAC
        {
            get { return m_initBAC; }
            set { m_initBAC = value; }
        }
        private double m_BAC;

        public double BAC
        {
            get { return m_BAC; }
            set { m_BAC = value; }
        }
        private double m_weight;

        public double Weight
        {
            get { return m_weight; }
            set { m_weight = value; }
        }
        private double m_height;

        public double Height
        {
            get { return m_height; }
            set { m_height = value; }
        }
        private double m_hoursSinceEaten;

        public double HoursSinceEaten
        {
            get { return m_hoursSinceEaten; }
            set { m_hoursSinceEaten = value; }
        }

        public Player(string name)
        {
            m_name = name;
        }

        public override string ToString()
        {
            return m_name;
        }
    }
}
