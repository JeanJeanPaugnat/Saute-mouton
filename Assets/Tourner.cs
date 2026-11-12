using UnityEngine;

public class Tourner : MonoBehaviour
{

    public float vitesse = 90f; 

    void Update()
    {
        transform.Rotate(0f, vitesse * Time.deltaTime, 0f);
    }
}
