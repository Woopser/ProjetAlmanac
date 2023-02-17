using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    //Attrivuts 
    [SerializeField] private float _vitesse = 15;

    // Start is called before the first frame update
    private void Start()
    {
        //Position de depart du joueur
        this.transform.position = new Vector3(-13f,1.01f,-13f); //this. est facultatif, mais on va le laiiser lol
    }


    // Update is called once per frame
    private void Update()
    {
        MouvementJoueur();
    }

    private void MouvementJoueur()
    {
        float positionX = Input.GetAxis("Horizontal");
        float positionZ = Input.GetAxis("Vertical");
        Vector3 direction = new Vector3(positionX, 0f, positionZ);
        this.transform.Translate(direction * Time.deltaTime * _vitesse);
    }
}
