using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public enum LocalizeType
{
    Kor = 0,
    En,
}

public class StarRailLoading : MonoBehaviour
{
    int nowWold; // 이동하려고 하는 지역 ID
    LocalizeType nowLocalize;
    StarrailData nowData;

    [SerializeField] Image[] img_BG;
    [SerializeField] Image img_Pom;

    [SerializeField] TextMeshProUGUI txt_Title;
    [SerializeField] TextMeshProUGUI txt_Text;
    [SerializeField] Image img_Icon;
    [SerializeField] Button btn_Click;

    void Start()
    {
        nowWold = 0;
        nowLocalize = LocalizeType.Kor;
        nowData = SData.GetStarrailWorldData(1001);
        RefreshUI();
    }

    public void ChangeWorld()
    {
        nowWold = nowWold == 0 ? 1 : 0; // 삼항연산자
        /* 삼항 연산자 : (조건) ? (true일때 실행) : (false일때 실행)

        if(WorldID == 1)
        {
            WorldID = 2;
        }
        else
        {
            WorldID = 1;
        }
        
        // 위 코드와 동일한 구조입니다.
        */

        Click();
    }

    public void ChangeLocalize()
    {
        nowLocalize = nowLocalize == LocalizeType.Kor ? LocalizeType.En : LocalizeType.Kor;
        RefreshTextUI();
    }

    public void Click()
    {
        nowData = SData.GetStarrailRandomWorld(nowWold);
        RefreshUI();
    }

    public void RefreshUI()
    {
        for (int i = 0; i < img_BG.Length; i++)
        {
            img_BG[i].sprite = Resources.Load<Sprite>($"Img/StarRail/BG/{nowWold}"); // 배경 이미지 변경
        }

        img_Pom.sprite = Resources.Load<Sprite>($"Img/StarRail/Pom/{nowWold}"); // 폼폼 이미지 변경
        
        img_Icon.sprite = Resources.Load<Sprite>($"Img/StarRail/Icon/{nowData.Icon}");

        RefreshTextUI();
    }

    void RefreshTextUI()
    {
        switch (nowLocalize)
        {
            case LocalizeType.Kor:
                {
                    txt_Title.text = nowData.Title_KR;
                    txt_Text.text = nowData.Text_Kr;
                }
                break;
            case LocalizeType.En:
                {
                    txt_Title.text = nowData.Title_En;
                    txt_Text.text = nowData.Text_En;
                }
                break;
            default:
                break;
        }

    }

}
