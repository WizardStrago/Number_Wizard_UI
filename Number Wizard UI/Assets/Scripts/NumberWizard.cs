using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NumberWizard : MonoBehaviour
{

    [SerializeField] int max;
    [SerializeField] int min;
    [SerializeField] TextMeshProUGUI guessText;
    int guess;

    // Use this for initialization
    void Start()
    {
        StartGame();
    }

    void StartGame()
    {
        NextGuess();
    }

    public void OnPressHigher()
    {
        min = guess + 1;
        NextGuess();
        if (guess == 1000)
        {
            guess = guess - 1;
        }
    }

    public void OnPressLower()
    {
        max = guess - 1;
        NextGuess();
    }

    void NextGuess()
    {
        guess = Random.Range(min, max + 1);
        guessText.text = guess.ToString();
    }
}
