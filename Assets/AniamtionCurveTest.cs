using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AniamtionCurveTest : MonoBehaviour
{
    public AnimationCurve animationCurve;
    public float speed=1;
    public Slider slider;
    

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            StartCoroutine(Play());
        }
    }
    IEnumerator Play() {

        float curveTime = 0;
        float curveAmount = animationCurve.Evaluate(curveTime);
        while (curveTime<1.0f)
        {
            curveTime += Time.deltaTime * speed;
            curveAmount = animationCurve.Evaluate(curveTime);
            slider.value = curveAmount;
            yield return null;
        }

    }
}
