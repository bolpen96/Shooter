using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class StaffManager : MonoBehaviour
{
    public GameObject Panel_staff;
    public GameObject hana_on;
    public GameObject Imghana;
    public GameObject ding_on;
    public GameObject Imgding;
    public GameObject bi_on;
    public GameObject Imgbi;
    public GameObject su_on;
    public GameObject Imgsu;

    public Text txt_hanaLv;
    public Text txt_hanaEffect;
    public Text txt_hanaNexteffect; 
    public Text txt_dingLv;
    public Text txt_dingEffect;
    public Text txt_dingNexteffect; 
    public Text txt_biLv;
    public Text txt_biEffect;
    public Text txt_biNexteffect;
    public Text txt_suLv;
    public Text txt_suEffect;
    public Text txt_suNexteffect;


    bool isOpen = false;
    bool isbuyhana = false;
    bool isbuyding = false;
    bool isbuybi = false;
    bool isbuysu = false;

    float[] likehana = { 100, 1200 };
    int lvhana = 0;
    float[] likeding = { 100, 1200 };
    int lvding = 0;
    float[] likebi = { 100, 1200 };
    int lvbi = 0;
    float[] likesu = { 100, 1200 };
    int lvsu = 0;
    public void PanelOpen()
    {
        if(isOpen == false)
        {
            Panel_staff.SetActive(true);
            isOpen = true;
        }else if(isOpen == true)
        {
            Panel_staff.SetActive(false);
            isOpen = false;
        }
    }

    public void buy_hana()
    {
        if(GameManager.I.Like >= likehana[0] && isbuyhana == false)
        {
            hana_on.SetActive(true);
            Imghana.SetActive(true);
            GameManager.I.Like -= likehana[0];
            lvhana += 1;
            isbuyhana = true;
            txt_hanaLv.text = "썸네일러 " + lvhana + " 레벨";
            txt_hanaEffect.text = "탭 당 좋아요 " + " 증가";
            txt_hanaNexteffect.text = "다음효과 : " + " 증가";
        }else if(GameManager.I.Like >= likehana[lvhana] && isbuyhana == true)
        {
            GameManager.I.Like -= likehana[lvhana];
            lvhana += 1;
        }
        else
        {
            GameManager.I.txt_warning.text = "좋아요가 부족합니다 ^0^";
            Instantiate(GameManager.I.txt_warning).transform.SetParent(GameManager.I.MainCanvas);
        }
    }
    public void buy_ding()
    {
        if (GameManager.I.Like >= likeding[0] && isbuyding == false && isbuyhana == true)
        {
            ding_on.SetActive(true);
            Imgding.SetActive(true);
            GameManager.I.Like -= likeding[0];
            lvding += 1;
            isbuyding = true;
        }
        else if (GameManager.I.Like >= likeding[lvding] && isbuyding == true)
        {
            GameManager.I.Like -= likeding[lvding];
            lvding += 1;
        }else if(GameManager.I.Like >= likeding[lvding] && isbuyhana == false)
        {
            GameManager.I.txt_warning.text = "썸네일러를 채용해주세요 ^0^";
            Instantiate(GameManager.I.txt_warning).transform.SetParent(GameManager.I.MainCanvas);
        }
        else
        {
            GameManager.I.txt_warning.text = "좋아요가 부족합니다 ^0^";
            Instantiate(GameManager.I.txt_warning).transform.SetParent(GameManager.I.MainCanvas);
        }
    }
    public void buy_bi()
    {
        if (GameManager.I.Like >= likebi[0] && isbuybi == false && isbuyding == true)
        {
            bi_on.SetActive(true);
            Imgbi.SetActive(true);
            GameManager.I.Like -= likebi[0];
            lvbi += 1;
            isbuybi = true;
        }
        else if (GameManager.I.Like >= likebi[lvbi] && isbuybi == true)
        {
            GameManager.I.Like -= likebi[lvbi];
            lvbi += 1;
        }
        else if (GameManager.I.Like >= likebi[lvbi] && isbuyhana == false)
        {
            GameManager.I.txt_warning.text = "썸네일러를 채용해주세요 ^0^";
            Instantiate(GameManager.I.txt_warning).transform.SetParent(GameManager.I.MainCanvas);
        }
        else if (GameManager.I.Like >= likebi[lvbi] && isbuyhana == true && isbuyding == false)
        {
            GameManager.I.txt_warning.text = "편집자를 채용해주세요 ^0^";
            Instantiate(GameManager.I.txt_warning).transform.SetParent(GameManager.I.MainCanvas);
        }
        else
        {
            Instantiate(GameManager.I.txt_warning).transform.SetParent(GameManager.I.MainCanvas);
        }
    }
    public void buy_su()
    {
        if (GameManager.I.Like >= likesu[0] && isbuysu == false && isbuybi == true)
        {
            su_on.SetActive(true);
            Imgsu.SetActive(true);
            GameManager.I.Like -= likesu[0];
            lvsu += 1;
            isbuysu = true;
        }
        else if (GameManager.I.Like >= likesu[lvsu] && isbuysu == true)
        {
            GameManager.I.Like -= likesu[lvsu];
            lvsu += 1;
        }
        else if (GameManager.I.Like >= likesu[lvsu] && isbuyhana == false)
        {
            GameManager.I.txt_warning.text = "썸네일러를 채용해주세요 ^0^";
            Instantiate(GameManager.I.txt_warning).transform.SetParent(GameManager.I.MainCanvas);
        }
        else if (GameManager.I.Like >= likesu[lvsu] && isbuyhana == true && isbuyding == false)
        {
            GameManager.I.txt_warning.text = "편집자를 채용해주세요 ^0^";
            Instantiate(GameManager.I.txt_warning).transform.SetParent(GameManager.I.MainCanvas);
        }
        else if (GameManager.I.Like >= likesu[lvsu] && isbuyhana == true && isbuyding == true && isbuybi == false)
        {
            GameManager.I.txt_warning.text = "매니저를 채용해주세요 ^0^";
            Instantiate(GameManager.I.txt_warning).transform.SetParent(GameManager.I.MainCanvas);
        }
        else
        {
            Instantiate(GameManager.I.txt_warning).transform.SetParent(GameManager.I.MainCanvas);
        }
    }

}
