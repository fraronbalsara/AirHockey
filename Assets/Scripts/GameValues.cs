public static class GameValues
{

    public enum Difficulties { Easy, Medium, Hard };

    public enum Players { Single, Multi};

    public static bool IsMultiplayer;
    public static Difficulties Difficulty = Difficulties.Easy;
    public static Players player = Players.Single;
}