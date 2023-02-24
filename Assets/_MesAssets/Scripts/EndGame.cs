using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGame : MonoBehaviour
{

    //Atribut 
    private bool isFinis = false;
    private GestionJeu _gestionJeu;

    // Start is called before the first frame update
    void Start()
    {
        _gestionJeu = FindObjectOfType<GestionJeu>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public bool GetFinis()
    {
        return isFinis;
    }

    public void SetFinis(bool bloop)
    {
        isFinis = bloop;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            SetFinis(true);
            Debug.Log("Game Over votre temps est de " + Time.time + " avec une pénaliter de " + _gestionJeu.GetPoint() + " accrochage, pour un total de " + (_gestionJeu.GetPoint() + Time.time));

        }
    }
}
