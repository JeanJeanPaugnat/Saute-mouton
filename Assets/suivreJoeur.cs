using UnityEngine;

public class suivreJoueur : MonoBehaviour
{
    public Transform Joueur;
    public Vector3 decalage = new Vector3(0f, 10f, -8f);
    public float douceur = 0f;

    void Update()
    {
        if ( Joueur == null){
            return;
        }

        Vector3 voulu = Joueur.TransformPoint(decalage);
        transform.position = Vector3.Lerp(
            transform.position, 
            voulu,
            douceur * Time.deltaTime
        );
        transform.LookAt(Joueur);
    }
}
