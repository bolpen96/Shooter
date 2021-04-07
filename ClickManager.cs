using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickManager : MonoBehaviour
{
    public GameObject txt_click;

    public Text txt_like;
    public Text txt_viewer;
    public Text txt_exp;
    public Text txt_level;
    public Slider slider_exp;

    public Image btn_skill1;
    public Image btn_skill2;

    bool isClickSkill1 = false;
    bool isClickSkill2 = false;

    float spawnSkill1;
    bool isMul = false;

    float cooltimeSkill1;
    float cooltimeSkill2;


    float exp;
    float autoTime;
    // Update is called once per frame
    void Update()
    {
        autoTime += Time.deltaTime;

        if (Input.GetMouseButtonDown(0))
        {
            if (isClickSkill2 == false)
            {
                Instantiate(txt_click).transform.SetParent(GameManager.I.MainCanvas);
            }else if(isClickSkill2 == true)
            {
                if (isMul == true)
                {
                    GameManager.I.Score *= 10;
                    isMul = false;
                }
                Instantiate(txt_click).transform.SetParent(GameManager.I.MainCanvas);
            }

            ExpManager();
            LikeManager();
        }

        LevelManager();
        ViewerManager();


        if((int)autoTime == 2)
        {
            Instantiate(GameManager.I.Txt_autoScore).transform.SetParent(GameManager.I.MainCanvas);
            GameManager.I.AutoScore = GameManager.I.Score;
            GameManager.I.Like += GameManager.I.AutoScore;
            txt_like.text = "좋아요 " + GameManager.I.Like + " 개";
            ExpManager();
            autoTime = 0;
        }

        if (isClickSkill1)
        {
            cooltimeSkill1 = 0;
            cooltimeSkill1 += Time.deltaTime / 10; //10초 쿨타임


            if (btn_skill1.fillAmount < 1)
            {
                btn_skill1.fillAmount += cooltimeSkill1;

                if (autoTime > 0.2f)
                {
                    Instantiate(GameManager.I.Txt_autoScore).transform.SetParent(GameManager.I.MainCanvas);
                    GameManager.I.AutoScore = GameManager.I.Score;
                    GameManager.I.Like += GameManager.I.AutoScore;
                    txt_like.text = "좋아요 " + GameManager.I.Like + " 개";
                    ExpManager();
                    autoTime = 0;
                }

                if (btn_skill1.fillAmount == 1)
                {
                    isClickSkill1 = false;
                }
            }
        }
        if (isClickSkill2)
        {
            cooltimeSkill2 = 0;
            cooltimeSkill2 += Time.deltaTime / 10; //10초 쿨타임


            if (btn_skill2.fillAmount < 1)
            {
                btn_skill2.fillAmount += cooltimeSkill2;

                if (btn_skill2.fillAmount == 1)
                {
                    GameManager.I.Score = GameManager.I.Score / 10;
                    isClickSkill2 = false;
                }
            }
        }

        

    }
    void LikeManager()
    {
        GameManager.I.Like += GameManager.I.Score;
        txt_like.text = "좋아요 " + GameManager.I.Like +" 개";
    }

    void ExpManager()
    {
        if (slider_exp.value == 1)
        {
            GameManager.I.Lv += 1;
            slider_exp.value = 0;
            exp = 0;

            slider_exp.value += GameManager.I.Score / (GameManager.I.Lv * 100);

            exp += GameManager.I.Score;
        }
        else
        {
            slider_exp.value += GameManager.I.Score / (GameManager.I.Lv * 100);

            exp += GameManager.I.Score;
        }
        txt_exp.text = exp + " / " + (GameManager.I.Lv * 100);

    }

    void LevelManager()
    {
        txt_level.text = GameManager.I.Lv.ToString();
    }

    void ViewerManager()
    {
        GameManager.I.Viewer = (int)(Time.time * 0.2f); // 5초에 1명

        txt_viewer.text = "시청자 " + GameManager.I.Viewer + " 명";
    }
    public void OnclickSkill1()
    {
        if (isClickSkill1 == false)
        {
            btn_skill1.fillAmount = 0;
            isClickSkill1 = true;
        }

    }
    public void OnclickSkill2()
    {
        if(isClickSkill2 == false)
        {
            btn_skill2.fillAmount = 0;
            isClickSkill2 = true;
            isMul = true;
        }
    }
}
