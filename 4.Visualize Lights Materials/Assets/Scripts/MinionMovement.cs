using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinionMovement : MonoBehaviour
{
    [SerializeField] private Transform targetObject;
    [SerializeField] private float speed;
    [SerializeField] private GameObject canvas;

    private void FixedUpdate()
    {
        transform.position = Vector3.MoveTowards(this.transform.position, new Vector3(targetObject.position.x, transform.position.y, targetObject.position.z), speed * Time.fixedDeltaTime);

        Vector3 direction = targetObject.position - transform.position;
        Quaternion rotation = Quaternion.LookRotation(new Vector3 (direction.x, transform.rotation.y, direction.z));
        transform.rotation = rotation;

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            canvas.SetActive(true);
        }
    }


}
