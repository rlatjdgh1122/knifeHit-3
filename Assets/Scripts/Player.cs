using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject[] gameObjects = new GameObject[1];
    int i = 0;
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            i++;
            Swappen(i);
        }
    }
    void Swappen(int count)
    {
        if (count % 2 == 0)
        {
            gameObjects[0].SetActive(true);
            gameObjects[1].SetActive(false);
        }
        else
        {
            gameObjects[0].SetActive(false);
            gameObjects[1].SetActive(true);
        }

    }
}
