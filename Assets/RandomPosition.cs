using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomPosition : MonoBehaviour
{

    public int counter = 0;
    public int rate = 60;
    
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        counter ++;

        //Debug.Log(counter % rate == 0);

        if (counter % rate == 0)
        {



            Debug.Log("message");
        }

        /*
         * 
         * 1) Créer un clone de particule (Instanciate)
         * 
         * 2) Le paramétrer :
         *  Le clone est au endroit, à le bon parent,la bonne trajectoire 
         * 
         * 3) Controle le nombre de particules créés
         * 
         */


    
    }
}
