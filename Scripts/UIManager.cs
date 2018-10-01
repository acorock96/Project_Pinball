using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour {

    public Text scoreText;
    private int score;

    private void Start()
    {
        scoreText.text = PlayerPrefs.GetInt("Score").ToString();
        score = PlayerPrefs.GetInt("Score");    //Definir el player pref
    }

    public void ScoreUpdate()
    {
        score++;
        scoreText.text = score.ToString();
        print("Tienes " + score + " puntos");
        PlayerPrefs.SetInt("Score", score);     //Actualizar el playerpref con el int
    }

    public void ResetScore()
    {
        score = 0;
        scoreText.text = score.ToString();
        print("Tu puntacion es 0");
        PlayerPrefs.SetInt("Score", score);     //Actualizar el playerpref con el int
    }
}
