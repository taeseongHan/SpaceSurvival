using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerJinho : MonoBehaviour
{
    public static GameManagerJinho instance;
    public SkillManager skills;

    private void Awake()
    {
        instance = this;
    }

}
