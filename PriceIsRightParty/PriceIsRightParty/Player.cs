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
        private DateTime m_playerAddedTime;

        public DateTime PlayerAddedTime
        {
            get { return m_playerAddedTime; }
            set { m_playerAddedTime = value; }
        }

        public Player(string name)
        {
            m_name = name;
        }

        public override string ToString()
        {
            return m_name;
        }

        public string toSaveString(bool saveImage)
        {
            StringBuilder builder = new StringBuilder();
            builder.Append(m_name);
            builder.Append("\t");
            builder.Append(m_initBAC);
            builder.Append("\t");
            builder.Append(m_height);
            builder.Append("\t");
            builder.Append(m_weight);
            builder.Append("\t");
            builder.Append(m_hoursSinceEaten);
            builder.Append("\t");
            builder.Append(m_playerAddedTime.ToLongDateString() + " " + m_playerAddedTime.ToLongTimeString());
            builder.Append("\t");
            builder.Append(m_name + ".bmp");
            builder.Append("\t");
            if(saveImage)
                m_image.Save(m_name + ".bmp", System.Drawing.Imaging.ImageFormat.Bmp);
            return builder.ToString();
        }
        public void loadDataFromSaveString(string saveString)
        {
            string[] tokens = saveString.Split(new char[] { '\t' });
            m_name = tokens[0];
            try { m_initBAC = double.Parse(tokens[1]); } catch (Exception) { }
            try { m_height = double.Parse(tokens[2]); } catch (Exception) { }
            try { m_weight = double.Parse(tokens[3]); } catch (Exception) { }
            try { m_hoursSinceEaten = double.Parse(tokens[4]); } catch (Exception) { }
            try { m_playerAddedTime = DateTime.Parse(tokens[5]); } catch (Exception) { }
            string filename = tokens[6];
            if (System.IO.File.Exists(filename))
                m_image = Image.FromFile(filename);
        }
    }
}
