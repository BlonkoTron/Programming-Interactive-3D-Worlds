using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{

    [SerializeField]
    GameObject objPlayer;

    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        Vector3 currPos = objPlayer.transform.position;
        currPos.x = objPlayer.transform.position.x - 10;
        currPos.y = objPlayer.transform.position.y + 10;
        transform.position = currPos;
    }
}
