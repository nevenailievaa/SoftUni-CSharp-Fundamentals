//INPUT
List<int> firstPlayerCards = Console.ReadLine().Split().Select(int.Parse).ToList();
List<int> secondPlayerCards = Console.ReadLine().Split().Select(int.Parse).ToList();

//ACTION
while (firstPlayerCards.Count > 0 && secondPlayerCards.Count > 0)
{
	if (firstPlayerCards[0] > secondPlayerCards[0])
	{
        firstPlayerCards.Add(firstPlayerCards[0]);
        firstPlayerCards.Add(secondPlayerCards[0]);

        firstPlayerCards.RemoveAt(0);
		secondPlayerCards.RemoveAt(0);
	}
	else if (firstPlayerCards[0] < secondPlayerCards[0])
    {
        secondPlayerCards.Add(secondPlayerCards[0]);
        secondPlayerCards.Add(firstPlayerCards[0]);

        secondPlayerCards.RemoveAt(0);
        firstPlayerCards.RemoveAt(0);
    }
    else
    {
        firstPlayerCards.RemoveAt(0);
        secondPlayerCards.RemoveAt(0);
    }
}

//Winner
int winnerCardsSum = 0;
if (firstPlayerCards.Count == 0)
{
    for (int j = 0; j < secondPlayerCards.Count; j++)
    {
        winnerCardsSum += secondPlayerCards[j];
    }
    Console.WriteLine($"Second player wins! Sum: {winnerCardsSum}");
}
else if (secondPlayerCards.Count == 0)
{
    for (int k = 0; k < firstPlayerCards.Count; k++)
    {
        winnerCardsSum += firstPlayerCards[k];
    }
    Console.WriteLine($"First player wins! Sum: {winnerCardsSum}");
}
