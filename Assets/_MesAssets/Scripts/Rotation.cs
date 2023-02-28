using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] private float _vitesseRotY = 0.5f;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, _vitesseRotY, 0); 
    }
}
