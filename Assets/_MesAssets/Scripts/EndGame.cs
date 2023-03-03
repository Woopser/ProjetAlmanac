using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.SceneManagement;
using UnityEngine.SceneManagement;

public class EndGame : MonoBehaviour
{

    //Atribut 
    private bool isFinis = false;
    private GestionJeu _gestionJeu;
    private Player _player;

    // Start is called before the first frame update
    void Start()
    {
        _gestionJeu = FindObjectOfType<GestionJeu>();
        _player = FindObjectOfType<Player>();
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
        int indexScene = SceneManager.GetActiveScene().buildIndex;
        if (indexScene == 1)
        {
            if (collision.gameObject.tag == "Player")
            {
                SetFinis(true);
                Debug.Log("Game Over votre temps est de " + Time.time + " avec une pénaliter de " + _gestionJeu.GetPoint() + " accrochage, pour un total de " + (_gestionJeu.GetPoint() + Time.time));
                _player.FinPartie();

            }
        }
        else
        {
            //Charger la scene suivante 
            SceneManager.LoadScene(indexScene + 1);
        }
    }

    //Le script de passage d'une zone a l'autre

}
