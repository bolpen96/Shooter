using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EquipmentManager : MonoBehaviour
{
    public GameObject ImgcomLv2;
    public GameObject ImgcomLv3;
    public GameObject ImgkeyboardLv2;
    public GameObject ImgkeyboardLv3;
    public GameObject ImgearphoneLv2;
    public GameObject ImgearphoneLv3;
    public GameObject ImgmicLv2;
    public GameObject ImgmicLv3;
    public GameObject ImgcameraLv2;
    public GameObject ImgcameraLv3;


    public Text txt_comLv;
    public Text txt_comEffect;
    public Text txt_comNexteffect;
    public Text txt_keyboardLv;
    public Text txt_keyboardEffect;
    public Text txt_keyboardNexteffect;
    public Text txt_earphoneLv;
    public Text txt_earphoneEffect;
    public Text txt_earphoneNexteffect;
    public Text txt_micLv;
    public Text txt_micEffect;
    public Text txt_micNexteffect;
    public Text txt_cameraLv;
    public Text txt_cameraEffect;
    public Text txt_cameraNexteffect;

    public Text txt_buycom;
    public Text txt_buykeyboard;
    public Text txt_buyearphone;
    public Text txt_mic;
    public Text txt_buycamera;

    float[] likecom = {100,200};
    int comLv = 0;
    public void buycom()
    {
        if (comLv != 20)
        {
            if (GameManager.I.Like >= likecom[comLv])
            {
                GameManager.I.Like -= likecom[comLv];
                txt_comLv.text = "낡은 컴퓨터 " + comLv + " 단계";
                txt_comEffect.text = "탭 당 좋아요 " + comLv * 10 + " 증가";
                txt_comNexteffect.text = "다음효과 : " + comLv * 10 + " 증가";

                txt_buycom.text = "좋아요 " + likecom[comLv] + " 개";
            }else if(comLv == 19)
            {

            }
            
        }else if(comLv >=20 && comLv < 40)
        {

        }
        else
        {
            GameManager.I.txt_warning.text = "좋아요가 부족합니다 ^0^";
            Instantiate(GameManager.I.txt_warning);
        }
    }

}
