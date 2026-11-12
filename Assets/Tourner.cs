using UnityEngine;

public class Tourner : MonoBehaviour
{
    float baseY;
    public float amplitude = 0.3f; 
    public float frequence = 2f;
    public float vitesse = 90f;

    void Start()
    {
        baseY = transform.position.y;
    }

    void Update()
    {
        transform.Rotate(0f, vitesse * Time.deltaTime, 0f);
        Vector3 position = transform.position;
        position.y = baseY + Mathf.Sin(Time.time * frequence) * amplitude;
        transform.position = position;
    }
}
