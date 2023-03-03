using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Experimental.GraphView.GraphView;

public class ZonePiege : MonoBehaviour
{
    // Start is called before the first frame update

    private bool _estActive = false;
    //[SerializeField] private GameObject _piege = default;
    [SerializeField] private List<GameObject> _listePieges = new List<GameObject>();
    //private Rigidbody _rb;
    private List<Rigidbody> _listeRb = new List<Rigidbody>(); 
    [SerializeField] private float _intensiteForce = 500;


    private void Start()
    {
        foreach(var piege in _listePieges)
        {
            _listeRb.Add(piege.GetComponent<Rigidbody>());
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        if (!_estActive && other.gameObject.tag == "Player")
        {
            _estActive = true;
            Debug.Log("Piege Activer, gotem");
            foreach(var rb in _listeRb)
            {
                rb.useGravity= true;
                rb.AddForce(Vector3.down * _intensiteForce);
            }

        }
        
       

    }
}
