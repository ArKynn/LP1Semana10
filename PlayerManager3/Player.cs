namespace PlayerManager3
{
    public class Player: IComparable<Player>
    {
        public string Name { get; }
        public int Score { get; }

        public Player(string name, int score)
        {
            Name = name;
            Score = score;
        }

        public int CompareTo(Player? other)
        {
            int order = 0;
            if (Score == other!.Score) order = 0;
            else if (Score < other.Score) order = -1;
            else if (Score > other.Score) order = 1;
            return order;
        }
    }
}
