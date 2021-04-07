using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TxtWarning : MonoBehaviour
{
    public Text txt_warning;
    private void Start()
    {
        StartCoroutine(ClickEvent());
    }

    IEnumerator ClickEvent()
    {
        txt_warning.color = new Color(txt_warning.color.r, txt_warning.color.g, txt_warning.color.b, 1);
        while (txt_warning.color.a > 0f)
        {
            txt_warning.transform.Translate(0, Time.deltaTime * 100f, 0);
            txt_warning.color = new Color(txt_warning.color.r, txt_warning.color.g, txt_warning.color.b, txt_warning.color.a - Time.deltaTime * 2.0f);

            yield return null;
        }
        Destroy(this.gameObject);
    }
}
