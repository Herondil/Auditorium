using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeExemple : MonoBehaviour
{

    //public float dureeDeVie;
    public float dateDeCollision; //heure de la collision
    public float dateDesactivation;
    public float time;
    public bool desactivationActiv�e;   

    private void Start()
    {
        Debug.Log("start ! " + Time.time);
        dateDeCollision     = Mathf.Infinity;
        dateDesactivation   = Mathf.Infinity;
        desactivationActiv�e = false;
    }

    // Update is called once per frame
    void Update()
    {
        time = Time.time;

        //5 secondes apr�s le lancement du jeu, le GameObject se d�sactive
        if (Time.time > 5f)
        {
            if (Time.time < 6f)
            {
                Debug.Log("stop");
            }
        }

        /* x                    : la date de collision
         * x + 5                : la date � laquelle il faut se d�sactiver
         * si time > (x + 5)    : la date de d�sactivation est pass��
         */
        if (Time.time > dateDesactivation)
        {
            //il s'est �coul� au moins 5 secondes depuis la date de collision
            this.gameObject.SetActive(false); //d�sactiver le GameObject
        }

    }

    //5 secondes apr�s le d�but collision, le GameObject se d�sactive
    private void OnCollisionEnter2D(Collision2D collision)
    {
        desactivationActiv�e = true;
        Debug.Log("Collision");
        dateDeCollision   = Time.time;
        dateDesactivation = dateDeCollision + 5f;
    }
}
