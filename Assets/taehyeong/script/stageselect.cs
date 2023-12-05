using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class stageselect : MonoBehaviour
{
   //행성 순서는 mercury, venus, mars, jupiter, saturn, urunas, neptune

    //각 행성 씬으로 이동하려면 ui에 나와있는 행성의 숫자번호를 입력




      void Update()
    {

        if (Input.GetKeyUp(KeyCode.Alpha1))
        {
            SceneManager.LoadScene("stage 1");
        }

        if (Input.GetKeyUp(KeyCode.Alpha2))
        {
            SceneManager.LoadScene("stage 2");
        }

        if (Input.GetKeyUp(KeyCode.Alpha3))
        {
            SceneManager.LoadScene("stage 3");
        }

        if (Input.GetKeyUp(KeyCode.Alpha4))
        {
            SceneManager.LoadScene("stage 4");
        }

        if (Input.GetKeyUp(KeyCode.Alpha5))
        {
            SceneManager.LoadScene("stage 5");
        }

        if (Input.GetKeyUp(KeyCode.Alpha6))
        {
            SceneManager.LoadScene("stage 6");
         
        }

        if (Input.GetKeyUp(KeyCode.Alpha7))
        {
            SceneManager.LoadScene("stage 7");
        }

        if (Input.GetKeyUp(KeyCode.Alpha8))
        {
            SceneManager.LoadScene("stage 8");
        }

    }
}
