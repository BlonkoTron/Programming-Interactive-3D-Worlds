using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomLight : MonoBehaviour
{
    [SerializeField] private float blinkTimerMax = 1;
    private float blinkTimer;

    private Light glow;

    private void Start()
    {
        blinkTimer = 0;
        glow = GetComponent<Light>();

    }

    private void FixedUpdate()
    {
        if (blinkTimer < blinkTimerMax)
        {
            blinkTimer += Time.fixedDeltaTime;
        }
        else
        {
            blinkTimer = Random.Range(0, blinkTimerMax);
            if (glow.intensity > 0)
            {   
                if (Random.Range(0,3) == 0)
                {
                    glow.intensity = 0;
                }
                
            }
            else
            {
                glow.intensity = 1;
            }
            
        }

    }

}
