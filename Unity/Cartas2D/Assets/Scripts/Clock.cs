using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Clock : MonoBehaviour
{
    public Image timeSlider;
    public Text timeText;
    public float time = 120;

    private float totalTime; //(in seconds)
    private bool clockIsPaused = false;
    private float timeRemaining; //(in seconds)
    private float percent;

    void Start()
    {
        totalTime = time;
    }
	
	// Update is called once per frame
	void Update () {
	    if(!clockIsPaused)
        {
            // make sure the timer is not paused
            DoCountdown();
        }
	}

    private void DoCountdown()
    {
        time -= Time.deltaTime;
        percent = time / totalTime;

        if (timeSlider != null)
        {
            timeSlider.fillAmount = percent;
        }
        if(timeText != null)
        {
            timeText.text = ((int)time).ToString();
        }
        /*
        if (time <= 0)
        {
            clockIsPaused = true;
            Game game = GetComponent<Game>();
            game.Lose();
        }
        */
    }

    public void PauseClock()
    {
        clockIsPaused = true;
    }

    public void UnpauseClock()
    {
        clockIsPaused = false;
    }
}
