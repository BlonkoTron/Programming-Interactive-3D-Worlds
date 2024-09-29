using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heatdeath : MonoBehaviour
{
    //[SerializeField] private float boomSpeed = 10f;
    //[SerializeField] private float unBoomSpeed = 8f;
    //[SerializeField] private float deathTimer = 5f;

    private bool alive = true;

    [SerializeField] private KeyCode deathKey = KeyCode.Space;

    [SerializeField] private GameObject planet;
    [SerializeField] private GameObject boomPrefab;
    
    // Update is called once per frame
    void Update()
    {
        if (alive)
        {
            if(Input.GetKeyDown(deathKey))
            {
                Destroy(planet);
                Destroy(gameObject);
                //alive = false;
            }
        }
        //if(transform.localScale.x <= 0)
        //{
        //    Destroy(gameObject);
        //}

    }

    //private void FixedUpdate()
    //{
    //    if (!alive)
    //    {
            

    //        if (deathTimer > 0)
    //        {
    //            transform.localScale += Vector3.one * boomSpeed;
    //            deathTimer -= Time.fixedDeltaTime;
    //        }
    //        else
    //        {   
    //            Destroy(planet);
    //            if (transform.localScale.x != 0)
    //            {
    //                transform.localScale -= Vector3.one * unBoomSpeed;
    //            }   
                
    //        }
    //    }
    //}

    private void OnDestroy()
    {
        Instantiate(boomPrefab);
    }
}
