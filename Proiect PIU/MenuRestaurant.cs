public class MenuRestaurant
{
    public string MainCourse { get; set; }
    public string SideDishes { get; set; }
    public string Drink { get; set; }
    public string Dessert { get; set; }

    public MenuRestaurant() { }

    public MenuRestaurant(string mainCourse, string sideDishes, string drink, string dessert)
    {
        MainCourse = mainCourse;
        SideDishes = sideDishes;
        Drink = drink;
        Dessert = dessert;
    }

    // Метод для получения информации о меню
    public string Info()
    {
        return $"Main Course: {MainCourse}, Side Dishes: {SideDishes}, Drink: {Drink}, Dessert: {Dessert}";
    }
}
