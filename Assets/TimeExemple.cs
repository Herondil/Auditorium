using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeExemple : MonoBehaviour
{

    //public float dureeDeVie;
    public float dateDeCollision; //heure de la collision
    public float dateDesactivation;
    public float time;
    public bool desactivationActivée;   

    private void Start()
    {
        Debug.Log("start ! " + Time.time);
        dateDeCollision     = Mathf.Infinity;
        dateDesactivation   = Mathf.Infinity;
        desactivationActivée = false;
    }

    // Update is called once per frame
    void Update()
    {
        time = Time.time;

        //5 secondes après le lancement du jeu, le GameObject se désactive
        if (Time.time > 5f)
        {
            if (Time.time < 6f)
            {
                Debug.Log("stop");
            }
        }

        /* x                    : la date de collision
         * x + 5                : la date à laquelle il faut se désactiver
         * si time > (x + 5)    : la date de désactivation est passéé
         */
        if (Time.time > dateDesactivation)
        {
            //il s'est écoulé au moins 5 secondes depuis la date de collision
            this.gameObject.SetActive(false); //désactiver le GameObject
        }

    }

    //5 secondes après le début collision, le GameObject se désactive
    private void OnCollisionEnter2D(Collision2D collision)
    {
        desactivationActivée = true;
        Debug.Log("Collision");
        dateDeCollision   = Time.time;
        dateDesactivation = dateDeCollision + 5f;
    }
}
