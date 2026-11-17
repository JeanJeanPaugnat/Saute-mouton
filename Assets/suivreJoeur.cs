using UnityEngine;

public class suivreJoueur : MonoBehaviour
{
    public Transform Joueur;
    public Vector3 decalage = new Vector3(0f, 10f, -8f);


    void Update()
    {
        if ( Joueur == null){
            return;
        }

        transform.position = Joueur.position + decalage;
        transform.LookAt(Joueur);
    }
}
