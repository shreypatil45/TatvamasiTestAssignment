using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightMatAnimator : MonoBehaviour
{
    [SerializeField]
    Material mat;
    [SerializeField]
    float minEmission, maxEmission, time, timeMultiplier, intensity;

    bool GoingUp;

    void Start()
    {
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        intensity = Mathf.Lerp(minEmission, maxEmission, time);

        mat.SetFloat("_Immisive", intensity);


        if (time < 1) 
        {
            time += timeMultiplier;
        }
        else
        {
            time = 0;

            float temp = minEmission;

            minEmission = maxEmission;

            maxEmission = temp;

        }

    }
}
