using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager I = null;

    private void Awake()
    {
        if(I== null)
        {
            I = this;
        }
        else
        {
            Destroy(gameObject);
        }
        DontDestroyOnLoad(gameObject);

        Screen.SetResolution(1080, 1920, true);
    }

    public Transform MainCanvas;
    public float Score;
    public float Coin;
    public float Exp;
    public float Lv = 1f;
    public float Viewer = 0f;
    public float Like;
    public float AutoScore;
    public float Computer;
    public float KeyBoard;
    public float Eyerphone;
    public float Mic;
    public float Camera;
    public Text txt_warning;
    public GameObject Txt_autoScore;


    

}
