using UnityEngine;

using UnityEngine.UI;
//using System.Collections;

public class GameManager : MonoBehaviour
{

    private int player1Score;
    private int player2Score;

    [SerializeField]
    private int pointsToWin = 10;
    [SerializeField]
    AudioSource gol;
    [SerializeField]
    public Text player1ScoreText;
    [SerializeField]
    public Text player2ScoreText;
    [SerializeField]
    public GameObject winPanel;
    [SerializeField]
    public GameObject palaIzda;
    [SerializeField]
    public GameObject bola;
    [SerializeField]
    public Text winText;
    public static bool botActivo { get; set; }

    // Use this for initialization
    void Start()
    {
        restart();
        winPanel.SetActive(false);
    }
    void Awake()
    {
        if (botActivo)
        {
            palaIzda.AddComponent<PlayerBot>();
            palaIzda.GetComponent<PlayerBot>().Bola = bola;
        }
        else
        {
            palaIzda.AddComponent<Player>();
        }

    }
    // Update is called once per frame
    void Update()
    {

    }

    private void restart()
    {
        player1Score = 0;
        player2Score = 0;
    }

    public void PlayerScores(int playerNum)
    {
        if (playerNum == 1)
        {
            player1Score++;
            player1ScoreText.text = "Player1: " + player1Score;
            if (player1Score >= pointsToWin)
            {
                finPartida("Player1");
            }
        }
        else if (playerNum == 2)
        {
            player2Score++;
            player2ScoreText.text = "Player2: " + player2Score;
            if (player2Score >= pointsToWin)
            {
                finPartida("Player2");
            }
        }

        gol.Play();
    }

    private void finPartida(string player)
    {
        winPanel.SetActive(true);
        winText.text = "Ganador: " + player;
        Time.timeScale = 0;

    }
    public void newGame()
    {
        Time.timeScale = 1;
        winPanel.SetActive(false);
    }

}

