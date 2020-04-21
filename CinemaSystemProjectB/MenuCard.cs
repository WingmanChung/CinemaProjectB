using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinemaSystemProjectB
{
    public partial class MenuCard : Form
    {
        const string path = @"MenuCard.json";
        public MenuCardClass MenuInfo { get; set; }
        public static string popcorn1 = "Zoet";
        public static string popcorn2 = "Zout";
        public static string popcorn3 = "Karamel";
        public static string popcorn4 = "Mix zoet en zout";

        public static string snack1 = "Snickers";
        public static string snack2 = "Maltezers";
        public static string snack3 = "Twix";
        public static string snack4 = "Paprika Chips";
        public static string snack5 = "Naturel Chips";

        public static string drink1 = "Cola";
        public static string drink2 = "7UP";
        public static string drink3 = "Pepsi";
        public static string drink4 = "Water";
        public static string drink5 = "Sprite";

        public static string ijs1 = "Ben and Jerry";
        public static string ijs2 = "Magnum";
        public static string ijs3 = "Cornetto";
        public static string ijs4 = "Calippo";
        public static string ijs5 = "Split";


        public MenuCard()
        {
            InitializeComponent();

            string resultJson = JsonConvert.SerializeObject(MenuInfo);

            Dictionary<string, MenuCardClass> Menu = JsonConvert.DeserializeObject<Dictionary<string, MenuCardClass>>(File.ReadAllText(path));

            ZoetePopcorn.Text = Menu[popcorn1].Name;
            ZoutePopcorn.Text = Menu[popcorn2].Name;
            KaramelPopcorn.Text = Menu[popcorn3].Name;
            MixedPopcorn.Text = Menu[popcorn4].Name;

            Price1.Text = Menu[popcorn1].Price;
            Price2.Text = Menu[popcorn2].Price;
            Price3.Text = Menu[popcorn3].Price;
            Price4.Text = Menu[popcorn4].Price;

            Snack1.Text = Menu[snack1].Name;
            Snack2.Text = Menu[snack2].Name;
            Snack3.Text = Menu[snack3].Name;
            Snack4.Text = Menu[snack4].Name;
            Snack5.Text = Menu[snack5].Name;

            PriceSnack1.Text = Menu[snack1].Price;
            PriceSnack2.Text = Menu[snack2].Price;
            PriceSnack3.Text = Menu[snack3].Price;
            PriceSnack4.Text = Menu[snack4].Price;
            PriceSnack5.Text = Menu[snack5].Price;

            Drink1.Text = Menu[drink1].Name;
            Drink2.Text = Menu[drink2].Name;
            Drink3.Text = Menu[drink3].Name;
            Drink4.Text = Menu[drink4].Name;
            Drink5.Text = Menu[drink5].Name;

            PriceDrink1.Text = Menu[drink1].Price;
            PriceDrink2.Text = Menu[drink2].Price;
            PriceDrink3.Text = Menu[drink3].Price;
            PriceDrink4.Text = Menu[drink4].Price;
            PriceDrink5.Text = Menu[drink5].Price;

            IceCream1.Text = Menu[ijs1].Name;
            IceCream2.Text = Menu[ijs2].Name;
            IceCream3.Text = Menu[ijs3].Name;
            IceCream4.Text = Menu[ijs4].Name;
            IceCream5.Text = Menu[ijs5].Name;

            PriceIceCream1.Text = Menu[ijs1].Price;
            PriceIceCream2.Text = Menu[ijs2].Price;
            PriceIceCream3.Text = Menu[ijs3].Price;
            PriceIceCream4.Text = Menu[ijs4].Price;
            PriceIceCream5.Text = Menu[ijs5].Price;

            MenuInfo = JsonConvert.DeserializeObject<MenuCardClass>(resultJson, new JsonSerializerSettings());
        }
    }
}
