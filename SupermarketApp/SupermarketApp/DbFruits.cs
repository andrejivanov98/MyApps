using System.Collections.Generic;


namespace SupermarketApp
{
    public static class DbFruits
    {
        public static List<Fruit> Domesctic;
        public static List<Fruit> Imported;
        public static double TotalDomesticPrice;
        public static double TotalImportedPrice;
        static DbFruits()
        {
            Domesctic = new List<Fruit>();
            Imported = new List<Fruit>();
        }
    }
}
