using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameManagerYujin : MonoBehaviour
{
    public static gameManagerYujin instance;

    public CharacterData selectedCharacter;

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void SetSelectedCharacter(CharacterData character)
    {
        selectedCharacter = character;
    }
}
