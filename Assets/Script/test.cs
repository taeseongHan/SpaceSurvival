using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    private gameManagerYujin gameManagerYujin;
    private CharacterData characterData;
    private Sprite characterimage;

    // Start is called before the first frame update
    void Start()
    {
        gameManagerYujin = gameManagerYujin.instance;
        characterData = gameManagerYujin.selectedCharacter;
        characterimage = characterData.image;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
