using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hit : MonoBehaviour
{
    public float rotate = Random.Range(0,255);
    public float coolTime = Random.Range(1, 4);
    private void Update()
    {
        coolTime -= Time.deltaTime;
        
        gameObject.transform.Rotate(new Vector3(0, 0, rotate)); 
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("bullet"))
        {
            collision.gameObject.GetComponent<Movement>().MoveTo(Vector2.zero); 
            Debug.Log("fuck");
        }
    }
}
