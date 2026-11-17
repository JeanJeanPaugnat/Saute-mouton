using UnityEngine;
using UnityEngine.InputSystem;

public class Joueur : MonoBehaviour
{
    public float speed = 5f;

    void Start()
    {
        Debug.Log("Le joueur devrait mtn se déplacer.");
    }

    void Update()
    {
        float x = 0f;
        float z = 0f;

        Keyboard keyboard = Keyboard.current;
        if (keyboard != null)
        {
            x = (keyboard.dKey.isPressed || keyboard.rightArrowKey.isPressed ? 1f : 0f)
                - (keyboard.qKey.isPressed || keyboard.leftArrowKey.isPressed ? 1f : 0f);
            z = (keyboard.zKey.isPressed || keyboard.upArrowKey.isPressed ? 1f : 0f)
                - (keyboard.sKey.isPressed || keyboard.downArrowKey.isPressed ? 1f : 0f);
        }

        Vector2 input = new Vector2(x, z);

        // Jouer avec une manette
        // Gamepad gamepad = Gamepad.current;
        // if (input == Vector2.zero && gamepad != null)
        // {
        //     input = gamepad.leftStick.ReadValue();
        // }

        Vector3 move = new Vector3(input.x, 0, input.y);
        transform.Translate(move * speed * Time.deltaTime);


    }

    public int points = 0;
    public int vies = 3;

    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Bonus"))
        {
            Valeur valeur = other.GetComponent<Valeur>();
            int gain = 1;

            if(valeur != null){
                gain = valeur + points
            }
            points = points + gain;
            Debug.Log("Points: " + points);
            Destroy(other.gameObject);
        }
        if(other.CompareTag("Danger"))
        {
            vies --;
            Debug.Log("Vies: " + vies);
            Destroy(other.gameObject);
        }
    }
}


