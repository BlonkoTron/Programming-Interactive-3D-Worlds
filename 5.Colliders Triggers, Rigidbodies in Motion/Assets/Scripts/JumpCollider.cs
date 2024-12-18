using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpCollider : MonoBehaviour
{
    [SerializeField]
    float power = 200f;
    private void OnCollisionExit(Collision collision)
    {
        Vector3 direc = collision.transform.position - transform.position;
        
        collision.gameObject.GetComponent<Rigidbody>().AddForce(direc * power);
    }
}
