using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    public GameObject gang;
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(gang,
                new Vector3(transform.position.x, transform.position.y + 1f),
                Quaternion.identity);
        }
    }
}
