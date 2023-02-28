using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Experimental.GraphView.GraphView;

public class ZonePiege : MonoBehaviour
{
    // Start is called before the first frame update

    private bool _estActive = false;
    [SerializeField] private GameObject _piege = default;
    private Rigidbody _rb;
    [SerializeField] private float _intensiteForce = 500;


    private void Start()
    {
        _rb = _piege.GetComponent<Rigidbody>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!_estActive && other.gameObject.tag == "Player")
        {
            _estActive = true;
            Debug.Log("Piege Activer, gotem");
            _rb.useGravity= true;
            _rb.AddForce(Vector3.down * _intensiteForce);

        }
        
       

    }
}
