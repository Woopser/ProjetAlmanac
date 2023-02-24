using Mono.Reflection;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GestionJeu : MonoBehaviour
{
    // Start is called before the first frame update

    //Atributs 
    private int _pointage;
    private EndGame _endGame;

    void Start()
    {
        Instrucitons();
        _endGame = FindObjectOfType<EndGame>();
    }

    public int GetPoint() { return _pointage; }

    private void Instrucitons()
    {
        _pointage = 0;
        Debug.Log("*** Course a obstacle ***");
        Debug.Log("Atteind la fin du parkour le plus vite possible!");
        Debug.Log("Chaque obstacle touché entraine une pénalité");
    }
    
    //Methodes publique
    public void AugmenterPointage()
    {
        _pointage++;
        Debug.Log("Nombre d'accrochage : " + _pointage); 
    }

    private void Update()
    {
       
    }
}
