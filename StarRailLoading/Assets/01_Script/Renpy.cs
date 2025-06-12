using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Renpy : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI txt_Dialogue;
    [SerializeField] Image[] img_Character;

    int id;
    int language;


    void Start()
    {
        id = 1001;
        language = 0;

        RefreshUI();
    }

    public void ClickLanguageButton()
    {
        if(language == 0)
        {
            language = 1;
        }
        else
        {
            language = 0;
        }

        RefreshUI();
    }

    public void ClickNextButton()
    {
        if(id < 1003)
        {
            id++;
        }
        else
        {
            id = 1001;
        }
        
        RefreshUI();
    }

    public void RefreshUI()
    {
        if(language == 0)
        {
            txt_Dialogue.text = SData.GetTestData(id).Kor;
        }
        else
        {
            txt_Dialogue.text = SData.GetTestData(id).En;
        }

        for(int i = 0; i < img_Character.Length; i++)
        {
            if(SData.GetTestData(id).Image[i] != "")
            {
                img_Character[i].sprite = Resources.Load<Sprite>("Img/Character/" + SData.GetTestData(id).Image[i]);
                img_Character[i].gameObject.SetActive(true);
            }
            else
            {
                img_Character[i].gameObject.SetActive(false);
            }
        }
    }
}

