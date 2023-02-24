using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    //Attrivuts 
    [SerializeField] private float _vitesse = 10;
    private EndGame _endGame;

    // Start is called before the first frame update
    private void Start()
    {
        //Position de depart du joueur
        this.transform.position = new Vector3(-26f,1.01f,-26f); //this. est facultatif, mais on va le laiiser lol
        _endGame = FindObjectOfType<EndGame>();
    }


    // Update is called once per frame
    private void Update()
    {
        if (!_endGame.GetFinis())
        {
            MouvementJoueur();
        }
        
    }

    private void MouvementJoueur()
    {
        float positionX = Input.GetAxis("Horizontal");
        float positionZ = Input.GetAxis("Vertical");
        Vector3 direction = new Vector3(positionX, 0f, positionZ);
        this.transform.Translate(direction * Time.deltaTime * _vitesse);
    }
}
