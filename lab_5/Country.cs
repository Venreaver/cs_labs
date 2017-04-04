using System.ComponentModel;

namespace lab_5
{
    public class Country
    {
        string name;
        string capital;
        double population;
        int area;
        string img;

        public Country()
        {

        }

        public Country(string nm, string cap, int pop, int ar, string imgName)
        {
            name = nm;
            capital = cap;
            population = pop;
            area = ar;
        }

        [DisplayName("PicImg"), Category("Прочее")]
        public string Image
        { 
            get { return img; }
            set { img = value; }
        }

        [DisplayName("Страна"), Category("Сводка")]
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        [DisplayName("Численность"), Category("Демография")]
        [Description("Общая численность в млн. чел.")]
        public double Population
        {
            get { return population; }
            set { population = value; }
        }

        [DisplayName("Столица"), Category("Сводка")]
        public string Capital
        {
            get { return capital; }
            set { capital = value; }
        }


        [DisplayName("Размер"), Category("Сводка")]
        [Description("Территория в кв. км.")]
        public int Area
        {
            get { return area; }
            set { area = value; }
        }
    }
}