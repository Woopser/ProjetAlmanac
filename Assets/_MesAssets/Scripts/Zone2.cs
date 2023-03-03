using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zone2 : MonoBehaviour
{
    // Start is called before the first frame update
    private bool _estActive = false;
    [SerializeField] private GameObject _piege = default;

    private void OnTriggerEnter(Collider other)
    {
        if (!_estActive && other.gameObject.tag == "Player")
        {
            _estActive = true;
            Debug.Log("Piege Activer, gotem");
            _piege.SetActive(true);
        }



    }

}
