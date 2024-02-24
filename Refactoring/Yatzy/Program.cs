int[] dice = Yatzy.Yatzy.RollDice(5);
Console.WriteLine("Dice rolled: " + string.Join(", ", dice));

Console.WriteLine("Chance: " + Yatzy.Yatzy.Chance(dice[0], dice[1], dice[2], dice[3], dice[4]));
Console.WriteLine("Ones: " + Yatzy.Yatzy.Ones(dice[0], dice[1], dice[2], dice[3], dice[4]));
Console.WriteLine("Twos: " + Yatzy.Yatzy.Twos(dice[0], dice[1], dice[2], dice[3], dice[4]));
Console.WriteLine("Threes: " + Yatzy.Yatzy.Threes(dice[0], dice[1], dice[2], dice[3], dice[4]));
Console.WriteLine("Fours: " + new Yatzy.Yatzy(dice[0], dice[1], dice[2], dice[3], dice[4]).Fours());
Console.WriteLine("Fives: " + new Yatzy.Yatzy(dice[0], dice[1], dice[2], dice[3], dice[4]).Fives());
Console.WriteLine("Sixes: " + new Yatzy.Yatzy(dice[0], dice[1], dice[2], dice[3], dice[4]).sixes());
Console.WriteLine("One Pair: " + Yatzy.Yatzy.ScorePair(dice[0], dice[1], dice[2], dice[3], dice[4]));
Console.WriteLine("Two Pair: " + Yatzy.Yatzy.TwoPair(dice[0], dice[1], dice[2], dice[3], dice[4]));
Console.WriteLine("Three of a Kind: " + Yatzy.Yatzy.ThreeOfAKind(dice[0], dice[1], dice[2], dice[3], dice[4]));
Console.WriteLine("Four of a Kind: " + Yatzy.Yatzy.FourOfAKind(dice[0], dice[1], dice[2], dice[3], dice[4]));
Console.WriteLine("Small Straight: " + Yatzy.Yatzy.SmallStraight(dice[0], dice[1], dice[2], dice[3], dice[4]));
Console.WriteLine("Large Straight: " + Yatzy.Yatzy.LargeStraight(dice[0], dice[1], dice[2], dice[3], dice[4]));
Console.WriteLine("Full House: " + Yatzy.Yatzy.FullHouse(dice[0], dice[1], dice[2], dice[3], dice[4]));
