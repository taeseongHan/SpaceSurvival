using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillManager : MonoBehaviour
{
    public GameObject[] skillPrefabs;  //스킬 프리펩들을 보관할 변수
    List<GameObject>[] skill;  // 스킬을 담당하는 리스트

    private void Awake()
    {
        skill = new List<GameObject>[skillPrefabs.Length];  //변수 초기화

        for (int index = 0; index < skill.Length; index++)  //리스트 초기화
        {
            skill[index] = new List<GameObject>();
        }

    }

    public GameObject Get(int index)  //오브젝트 받아오기
    {
        GameObject select = null;

        foreach (GameObject skillList in skill[index])  //선택한 스킬의 오브젝트 접근
        {
            if (!skillList.activeSelf)   //select 변수에 할당
            {
                select = skillList;
                select.SetActive(true);
                break;
            }
        }
        if (!select)   //못 찾으면 새롭게 생성 후 select 변수에 할당
        {
            select = Instantiate(skillPrefabs[index], transform);
            skill[index].Add(select);
        }
        return select;
    }


}
