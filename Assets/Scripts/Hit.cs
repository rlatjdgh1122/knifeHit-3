using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hit : MonoBehaviour
{
    public float rotateSpeed;
    public Vector3 rotateAngle =Vector3.forward;

    private Movement movement;
    private void Awake()
    {
        movement = GetComponent<Movement>();
    }
    private IEnumerator Start()
    {
        while (true)
        {
            int time = Random.Range(1, 5);
            yield return new WaitForSeconds(time);
            int speed = Random.Range(10, 300);
            int dir = Random.Range(0, 2);

            rotateSpeed = speed;
            rotateAngle = new Vector3(0, 0, dir * 2 - 1);
        }
    }
    private void Update()
    {
        transform.Rotate(rotateAngle * rotateSpeed * Time.deltaTime);
    }
}
