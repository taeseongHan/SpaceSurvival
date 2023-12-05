using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManagerJihu : MonoBehaviour
{
    public TMP_Text timeTxt;
    public TMP_Text currentScoreTxt;
    private float time;
    private bool isRunning = true;
    public GameObject endPanel;

    public static GameManagerJihu I;

    // 싱글톤
    void Awake()
    {
        I = this;
    }

    // 다시 시작되면 시간이 가도록 한다
    void Start()
    {
        Time.timeScale = 1.0f; // 마이너스는 0으로 처리된다
    }

    private void Update()
    {
        if (isRunning) // 게임실행 중에 시간이 간다
        {
            // 타이머 표시
            time += Time.deltaTime;
            int hour = (int)time / 3600;
            int min = (int)time % 3600 / 60;
            int sec = (int)time % 3600 % 60;
            timeTxt.text = string.Format("{0:D2}:{1:D2}:{2:D2}", hour, min, sec);
        }
    }

    // 게임오버 됐을 때 GameManagerJihu.I.gameOver() 호출
    public void gameOver()
    {
        isRunning = false; // 시간 멈추기
        Time.timeScale = 0f;
        endPanel.SetActive(true);

        // 게임오버 시간이 현재 시간에 뜨도록
        currentScoreTxt.text = timeTxt.text;
    }

    

    
}
