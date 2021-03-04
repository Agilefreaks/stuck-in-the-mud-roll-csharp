namespace Core
{
    public class StuckInTheMudRoll
    {
        private int _d1;
        private int _d2;
        private int _d3;
        private int _d4;
        private int _d5;

        public StuckInTheMudRoll(int d1, int d2, int d3, int d4, int d5)
        {
            this._d1 = d1;
            this._d2 = d2;
            this._d3 = d3;
            this._d4 = d4;
            this._d5 = d5;
        }

        public int Score()
        {
            int score = 0;
            if (!(this._d1 == 2 || this._d1 == 5)) score += this._d1;
            if (!(this._d2 == 2 || this._d2 == 5)) score += this._d2;
            if (!(this._d3 == 2 || this._d3 == 5)) score += this._d3;
            if (!(this._d4 == 2 || this._d4 == 5)) score += this._d4;
            if (!(this._d5 == 2 || this._d5 == 5)) score += this._d5;
            return score;
        }

        public bool EndOfTurn()
        {
            if (this._d1 != 2 && this._d1 != 5) return false;
            if (this._d2 != 2 && this._d2 != 5) return false;
            if (this._d3 != 2 && this._d3 != 5) return false;
            if (this._d4 != 2 && this._d4 != 5) return false;
            if (this._d5 != 2 && this._d5 != 5) return false;
            return true;
        }

        public static int dice_available_next_roll(int d1, int d2, int d3, int d4, int d5)
        {
            var dice = new[] { d1, d2, d3, d4, d5 };
            int total_dice = 5;
            for (var i = 0; i < dice.Length; i++)
            {
                int d = dice[i];
                if (d == 2 || d == 5)
                {
                    total_dice -= 1;
                }
            }

            return total_dice;
        }
    }
}
