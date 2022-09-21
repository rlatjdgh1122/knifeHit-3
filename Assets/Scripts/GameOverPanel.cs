using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverPanel : MonoBehaviour
{
    public GameObject panel;
    public int count;
    public Text current;
    public Text best;
    public Text dhshwh;
    int blue;
    int red;
    int c;
    int b;
    int bestScore;
    int currentScore;
    private void Start()
    {
        panel.SetActive(false);
        Time.timeScale = 1;
    }
    private void Update()
    {
        c = PlayerPrefs.GetInt("C", 0);
        b = PlayerPrefs.GetInt("B", 0);
        dhshwh.text = count + " 개";
    }
    public void SetPanel()
    {
        Time.timeScale = 0;
        panel.SetActive(true);
        StartScore();
    }
    public void ReStart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void Exit()
    {
        Application.Quit();
    }
    public void discrimination(string color)
    {
        if (color == "blue")
        {
            blue++;
            Counted();
        }
        if (color == "red")
        {
            red++;
            Counted();
        }
    }
    public void Counted()
    {
        int max = red > blue ? red : blue;
        int min = blue > red ? red : blue;
        
        if (min <= max && min > count)
        {
            count++;
            Score(count);
        }
    }
    public void Score(int value)
    {
        currentScore = value;
        PlayerPrefs.SetInt("C", currentScore);
        if (currentScore > b)
        {
            bestScore = currentScore;
            PlayerPrefs.SetInt("B", bestScore);
        }
    }
    public void StartScore()
    {
        current.text = "현재 점수: " + PlayerPrefs.GetInt("C", 0) + "개";
        best.text = "최고 점수: " + PlayerPrefs.GetInt("B", 0) + "개";
    }
}


