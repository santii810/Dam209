using UnityEngine;
using System.Collections.Generic;
using UnityEngine.UI;

public class Game : MonoBehaviour
{
    public List<Image> cardsUI;
    public GameObject winPanel;
    public GameObject losePanel;

    private int totalCards = 16;

    private int matchesNeededToWin;
    private int matchesMade = 0;

    private List<Card> cards = new List<Card>();
    private int cardFlipped1 = -1;
    private int cardFlipped2 = -1;

    private bool playerCanClick = true;

    // Use this for initialization
    void Start()
    {
        matchesNeededToWin = totalCards / 2;
        BuildDeck();
    }

    private void BuildDeck()
    {
        int totalRobots = 4;
        Card card;
        int id = 0;

        for (int i = 0; i < totalRobots; i++)
        {
            List<string> robotParts = new List<string>();
            robotParts.Add("Head");
            robotParts.Add("Arm");
            robotParts.Add("Leg");
            for (int j = 0; j < 2; j++)
            {
                int pos = Random.Range(0, robotParts.Count);
                string theMissingPart = robotParts[pos];

                robotParts.RemoveAt(pos);

                card = new Card("robot" + (i + 1) + "Missing" + theMissingPart, id);
                cards.Add(card);

                card = new Card("robot" + (i + 1) + theMissingPart, id);
                cards.Add(card);
                id++;
            }
        }

        cards.Shuffle();
    }

    public void Win()
    {
        playerCanClick = false;
        Clock clock = GetComponent<Clock>();
        clock.PauseClock();
        winPanel.SetActive(true);
        Image image = winPanel.GetComponent<Image>();
        image.CrossFadeAlpha(0, 0, false);
        image.CrossFadeAlpha(1, 3, false);
    }

    public void Lose()
    {
        playerCanClick = false;
        losePanel.SetActive(true);
        Image image = losePanel.GetComponent<Image>();
        image.CrossFadeAlpha(0, 0, false);
        image.CrossFadeAlpha(1, 3, false);
    }

    public void SelectCard(int num)
    {
        if (playerCanClick)
        {
            FlipCardFaceUp(num);
        }
    }

    private void FlipCardFaceUp(int num)
    {
        Card card = cards[num];

        if (card.isFaceUp)
        {
            return;
        }

        card.isFaceUp = true;
        cardsUI[num].sprite = Resources.Load<Sprite>(cards[num].image);
        if (cardFlipped1 == -1)
        {
            cardFlipped1 = num;
        }
        else
        {
            cardFlipped2 = num;
            playerCanClick = false;

            Invoke("CheckCards", 1);
        }
    }

    private void CheckCards()
    {
        if (cards[cardFlipped1].id == cards[cardFlipped2].id)
        {
            // Match!
            Sprite sprite = Resources.Load<Sprite>("blank");
            cards[cardFlipped1].isMatched = true;
            cardsUI[cardFlipped1].sprite = sprite;
            cards[cardFlipped2].isMatched = true;
            cardsUI[cardFlipped2].sprite = sprite;

            matchesMade++;

            if (matchesMade >= matchesNeededToWin)
            {
                Win();
            }
        }
        else
        {
            Sprite sprite = Resources.Load<Sprite>("wrench");
            cards[cardFlipped1].isFaceUp = false;
            cardsUI[cardFlipped1].sprite = sprite;
            cards[cardFlipped2].isFaceUp = false;
            cardsUI[cardFlipped2].sprite = sprite;
        }

        cardFlipped1 = -1;
        cardFlipped2 = -1;
        playerCanClick = true;
    }

    public void Play()
    {
        Application.LoadLevel("Game");
    }
}
