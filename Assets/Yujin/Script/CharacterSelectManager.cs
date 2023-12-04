using System.Collections;
using System.Collections.Generic;
using UnityEditor.U2D.Animation;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class CharacterSelectManager : MonoBehaviour
{
    public CharacterData[] characters; // 유니티 에디터에서 캐릭터 데이터 할당

    // 버튼에 기록되는 정보
    public Image[] displayImages;
    public TextMeshProUGUI[] nameTexts;
    public TextMeshProUGUI[] healthTexts;
    public TextMeshProUGUI[] attackTexts;
    public TextMeshProUGUI[] speedTexts;
    public Slider[] healthSliders;
    public Slider[] attackSliders;
    public Slider[] speedSliders;

    // 팝업창에 뜨는 정보
    public GameObject characterPanel;
    public Image displayImage;
    public TextMeshProUGUI nameText;
    public TextMeshProUGUI healthText;
    public TextMeshProUGUI attackText;
    public TextMeshProUGUI speedText;
    public Slider healthSlider;
    public Slider attackSlider;
    public Slider speedSlider;

    public void Start()
    {
        for(int index = 0; index < characters.Length; index++)
        {
            displayImages[index].sprite = characters[index].image;
            nameTexts[index].text = characters[index].name;
            healthTexts[index].text = characters[index].health.ToString();
            attackTexts[index].text = characters[index].attack.ToString();
            speedTexts[index].text = characters[index].speed.ToString();
            healthSliders[index].value = characters[index].health;
            attackSliders[index].value = characters[index].attack;
            speedSliders[index].value = characters[index].speed;
        }
    }

    public void SelectCharacters(int index)
    {
        characterPanel.SetActive(true);

        if (index >= 0 && index < characters.Length)
        {
            gameManagerYujin.instance.SetSelectedCharacter(characters[index]);
            displayImage.sprite = characters[index].image;
            nameText.text = characters[index].name;
            healthText.text = characters[index].health.ToString();
            attackText.text = characters[index].attack.ToString();
            speedText.text = characters[index].speed.ToString();
            healthSlider.value = characters[index].health;
            attackSlider.value = characters[index].attack;
            speedSlider.value = characters[index].speed;

        }
    }

}
