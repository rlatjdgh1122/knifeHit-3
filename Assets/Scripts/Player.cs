using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject[] gameObjects = new GameObject[1];
    public int i = 0;

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Swappen(i);
            i++;
        }
    }
    public void Start()
    {
        gameObjects[0].SetActive(false);
        gameObjects[1].SetActive(true);
    }
    void Swappen(int count)
    {
        if (count % 2 == 0)
        {
            gameObjects[0].SetActive(true);
            gameObjects[1].SetActive(false);
        }
        else if (count % 2 != 0)
        {
            gameObjects[0].SetActive(false);
            gameObjects[1].SetActive(true);
        }

    }
}
