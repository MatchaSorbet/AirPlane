using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxCollision : MonoBehaviour
{

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Box")
        {
            Debug.Log("����");

            GameObject director = GameObject.Find("GameManager");
            director.GetComponent<GameManager>().IncreaseAirPlane();

        }
    }

    void OnCollisionExit(Collision other)
    {
        if (other.gameObject.tag == "Box")
        {
            Debug.Log("������");

            GameObject director = GameObject.Find("GameManager");
            director.GetComponent<GameManager>().DecreaseAirPlane();
        }
    }
}