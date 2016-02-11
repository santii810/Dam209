using UnityEngine;
using System.Collections;

public class MainSceneGameManager : MonoBehaviour {


    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	}

    public void empezarUnJugador()
    {
        GameManager.botActivo = true;
        Application.LoadLevel("pong");

    }
    public void empezarDosJugadores()
    {
        GameManager.botActivo = false;
        Application.LoadLevel("pong");
    }
}
