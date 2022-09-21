using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pin : MonoBehaviour
{
    private Movement movement;
    public string color;
    private GameOverPanel GOP;
    private void Start()
    {
        GOP = GameObject.Find("GameOverPanel").GetComponent<GameOverPanel>();
    }
    private void Awake()
    {
        movement = GetComponent<Movement>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("target"))
        {
            movement.MoveTo(Vector3.zero);
            transform.SetParent(collision.transform);
            Destroy(this);
            if(color == "blue")
            {
                GOP.discrimination("blue");
            }
            if (color == "red")
            {
                GOP.discrimination("red");
            }
        }
        else if (collision.gameObject.CompareTag("red"))
        {
            GOP.SetPanel();
        }
        else if (collision.gameObject.CompareTag("blue"))
        {
            GOP.SetPanel();
        }
    }
}
