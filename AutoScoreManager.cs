using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AutoScoreManager : MonoBehaviour
{
    public Text AutoScore;
    Vector2 position;

    private void Start()
    {
        

        position.x = 327;
        position.y = 30;

        Destroy(this.gameObject, 3);

        StartCoroutine(txtAutoscore());
    }

    IEnumerator txtAutoscore()
    {
        AutoScore.color = new Color(AutoScore.color.r, AutoScore.color.g, AutoScore.color.b, 1);
        AutoScore.transform.localPosition = position;

        while (AutoScore.color.a > 0f)
        {
            AutoScore.text = GameManager.I.Score.ToString();
            AutoScore.transform.Translate(0, Time.deltaTime * 100f, 0);
            AutoScore.color = new Color(AutoScore.color.r, AutoScore.color.g, AutoScore.color.b, AutoScore.color.a - (Time.deltaTime * 2.0f));
            yield return null;
        }
    }

}
