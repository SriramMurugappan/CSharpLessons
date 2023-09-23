public enum MovieRating
{
    VeryBad = 0,
    Bad= 1,
    Average = 2,
    Good= 3,
    Excellent = 4
}
public enum CarColor
{
    Black=0,White=1,Red=2,Green=3
}
public enum Desserts
{
    IceCream,Cake,MysorePak
}
class TestEnum
{

    public static void TestMovieRating()
    {
        Type t1 = typeof(MovieRating);
        String[] enumNames = Enum.GetNames(t1);
        String name = String.Empty;
        int len = enumNames.Length;
        for (int i = 0; i < len; i++)
        {
            name = enumNames[i];
            MovieRating movies = (MovieRating)Enum.Parse(t1, name);
            Console.WriteLine(name + " " + (int)movies);
        }
    }

}