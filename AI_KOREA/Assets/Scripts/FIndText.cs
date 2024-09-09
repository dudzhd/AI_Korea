using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class FIndText : MonoBehaviour
{
    public GameObject[] Checks;

    public TextMeshProUGUI findText;
    byte a = 0;

    public void Find0()
    {
        findText.text = ("지팡이를 찾았다.");
        Checks[0].SetActive(true);

        StopAllCoroutines();
        a = 0;

        StartCoroutine(FadeInAndOut());
    }
    
    public void Find1()
    {
        findText.text = ("지갑을 찾았다.");
        Checks[1].SetActive(true);

        StopAllCoroutines();
        a = 0;

        StartCoroutine(FadeInAndOut());
    }
    
    public void Find2()
    {
        findText.text = ("스마트폰을 찾았다.");
        Checks[2].SetActive(true);

        StopAllCoroutines();
        a = 0;

        StartCoroutine(FadeInAndOut());
    }

    IEnumerator FadeInAndOut()
    {
        while (a < 200)
        {
            a += 5;
            findText.color = new Color32(255, 255, 255, a);
            yield return new WaitForSeconds(0.02f);
        }

        yield return new WaitForSeconds(1f);

        while (a > 0)
        {
            a -= 5;
            findText.color = new Color32(255, 255, 255, a);
            yield return new WaitForSeconds(0.02f);
        }

        yield return null;
    }
}
