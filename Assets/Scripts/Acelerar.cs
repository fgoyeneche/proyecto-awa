using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Acelerar : MonoBehaviour
{
    private float _posControl;
    private GameObject _nave;
    private Rigidbody _naveRBD;
    private float _firtsPos;
    [SerializeField]
    private float _acelerationSpeed = 50f;
    void Start()
    {
        _firtsPos = transform.localPosition.z;
        _nave = GameObject.Find("Nave");
        _naveRBD = _nave.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Aceleracion();
    }

    void Aceleracion()
    {
        Debug.Log(_firtsPos);
        if (transform.localPosition.z > _firtsPos)
        {
            //_naveRBD.velocity = transform.forward * _acelerationSpeed * Time.deltaTime;
            _nave.transform.Translate(Vector3.forward * _acelerationSpeed * Time.deltaTime);
        }
        else
        {
            _nave.transform.Translate(-Vector3.forward * _acelerationSpeed * Time.deltaTime);
            // _naveRBD.velocity = -transform.forward * _acelerationSpeed * Time.deltaTime;
        }
        
    }
}
