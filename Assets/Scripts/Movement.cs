using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float MoveSpeed;
    [SerializeField]
    private Vector3 Dir = Vector3.up;
    private void Start()
    {
        gameObject.transform.Rotate(new Vector3(0, 0, 180f));
    }
    void Update()
    {
        transform.position += Dir * MoveSpeed * Time.deltaTime;
    }
    public void MoveTo(Vector3 dir)
    {
        Dir = dir;
    }
}
