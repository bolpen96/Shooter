using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ReactionManager : MonoBehaviour
{
    public GameObject btnReactionPanel;
    public Image btnSmile;
    public Image btnCute;
    public Image btnMoved;
    public Image btnDance;

    public GameObject recSmile;
    public GameObject recCuto;
    public GameObject recMoved;
    public GameObject recDance;

    float coolTime = 10.0f;
    bool isClicked_btnsmile = false;

    bool isOpen = false;
    public void onClick()
    {
        if(isOpen == false)
        {
            btnReactionPanel.SetActive(true);
            isOpen = true;
        }
        else
        {
            btnReactionPanel.SetActive(false);
            isOpen = false;
        }
    }

    private void Update()
    {
        if (GameManager.I.Lv == 5)
        {
            btnSmile.gameObject.SetActive(true);
        }else if(GameManager.I.Lv == 10)
        {
            btnCute.gameObject.SetActive(true);
        }else if(GameManager.I.Lv == 20)
        {
            btnMoved.gameObject.SetActive(true);
        }else if(GameManager.I.Lv == 30)
        {
            btnDance.gameObject.SetActive(true);
        }

        if (isClicked_btnsmile)
        {
            coolTime = 0;
            coolTime += Time.deltaTime / 10;

            recSmile.SetActive(true);

            if(btnSmile.fillAmount < 1)
            {

                btnSmile.fillAmount += coolTime;
                if (btnSmile.fillAmount == 1)
                {
                    recSmile.SetActive(false);
                    isClicked_btnsmile = false;
                }
            }

        }
    }

    public void btnsmile()
    {
        if(btnSmile.fillAmount != 1)
        {

        }

        if (isClicked_btnsmile == false)
        {
            btnSmile.fillAmount = 0;
            isClicked_btnsmile = true;
        }
    }


}
