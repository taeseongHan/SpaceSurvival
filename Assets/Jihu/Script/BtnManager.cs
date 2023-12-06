using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BtnManager : MonoBehaviour
{
    // retry 버튼을 누르면 현재 씬이 다시 로드되도록 한다
    public void GameStart()
    {
        SceneManager.LoadScene("MainGame");
    }

    // main 버튼을 누르면 메인화면을 부른다
    public void MainTitle()
    {
        SceneManager.LoadScene("FirstTitle");
    }
}
