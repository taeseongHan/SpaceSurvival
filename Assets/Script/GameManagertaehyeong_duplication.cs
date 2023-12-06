using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManagertaehyeong_duplication : MonoBehaviour
{
    public static GameManagertaehyeong_duplication instance;
    public bool isPlay = false;
    public GameObject startButton;
    public Text scoretext;
    Transform player;
    public void Awake()
    {
        instance = this;
    }
    private void Start()
    {
        player = GameObject.Find("Player").transform;
    }
    public void startgame()
    {
        player.position = Vector2.zero;
        timescore = 0;
        isPlay = true;
        startButton.SetActive(false);
    }

    public float timescore;
    private void Update()
    {
        if(isPlay)
        {
            timescore += Time.deltaTime;
            scoretext.text =  Mathf.RoundToInt(timescore) .ToString();
        }
    }

    
    public void endGame()
    {
        isPlay = false;
        AllDestroy();
        startButton.SetActive(true);
    }
    public Transform bulletParent;
    public List<enemy> enemies = new List<enemy>();
    void AllDestroy()
    {
        enemies.AddRange(bulletParent.GetComponentsInChildren<enemy>());
        for (int i = 0; i < enemies.Count; i++)
        {
            Destroy(enemies[i].gameObject);
        }
        enemies.Clear();
    }
}
