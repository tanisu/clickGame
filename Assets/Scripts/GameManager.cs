using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager I;

    [SerializeField] Text RateText;
    [SerializeField] Slider timerSlider;
    [SerializeField] float playTime;

    [SerializeField] GameObject gameoverPanel;

    float seconds = 0f;

    public int mapChipsCount, turnCount;

    public enum GAMEMODE
    {
        PLAY,
        GAMEOVER
    }

    public GAMEMODE gameMode = GAMEMODE.PLAY;


    private void Awake()
    {
        if(I == null)
        {
            I = this;
        }
    }

    
    void Update()
    {
        timerSlider.value = _updateTimer();
        if(timerSlider.value == 1 && gameMode == GAMEMODE.PLAY)
        {
            gameMode = GAMEMODE.GAMEOVER;
            gameoverPanel.SetActive(true);
        }
    }

    public void UpdateRate()
    {
        RateText.text = ((float)turnCount / mapChipsCount).ToString("P");
    }

    float _updateTimer()
    {
        seconds += Time.deltaTime;
        float timer = seconds / playTime;
        
        return timer;
    }

    public void Retry()
    {
        SceneManager.LoadScene("Main");
    }
}
