using System.Text.Json;

Queue<int> deckPlayerOne = new Queue<int>(new[] { 9, 2, 6, 3, 1 });
Queue<int> deckPlayerTwo = new Queue<int>(new[] { 5, 8, 4, 7, 10 });

int round = 1;

while (deckPlayerOne.Any() && deckPlayerTwo.Any())
{
    Console.WriteLine($"-- Round {round} --");
    int cardPlayerOne = deckPlayerOne.Dequeue();
    int cardPlayerTwo = deckPlayerTwo.Dequeue();

    if (cardPlayerOne > cardPlayerTwo)
    {
        Console.WriteLine($"Player One Wins! Card {cardPlayerOne} greather than {cardPlayerTwo}");
        AddCardToDeck(deckPlayerOne, cardPlayerOne, cardPlayerTwo);
    }
    else
    {
        Console.WriteLine($"Player Two Wins! Card {cardPlayerTwo} greather than {cardPlayerOne}");
        AddCardToDeck(deckPlayerTwo, cardPlayerTwo, cardPlayerOne);
    }
    Console.WriteLine($"Deck Player One: {JsonSerializer.Serialize(deckPlayerOne)}");
    Console.WriteLine($"Deck Player Two: {JsonSerializer.Serialize(deckPlayerTwo)}");
    Console.WriteLine($"--------------------------------------------\n");
    round++;
}

Console.WriteLine("== Post-game results ==");
Console.WriteLine($"Player One Deck: {JsonSerializer.Serialize(deckPlayerOne)}");
Console.WriteLine($"Player Two Deck: {JsonSerializer.Serialize(deckPlayerTwo)}");

var winnersDeck = !deckPlayerTwo.Any() ? deckPlayerOne : deckPlayerTwo;

var scoreDeck = winnersDeck.Select((card, index) => {
    Console.WriteLine($"{card} * {(winnersDeck.Count() - index)} +");
    return card * (winnersDeck.Count() - index);
});

Console.WriteLine($"= {scoreDeck.Sum()}");


void AddCardToDeck(Queue<int> deck, int cardOne, int cardTwo)
{
    deck.Enqueue(cardOne);
    deck.Enqueue(cardTwo);
}