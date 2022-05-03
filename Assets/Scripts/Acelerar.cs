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
        //Aceleracion();
    }

    public float Aceleracion()
    {
        //Debug.Log(_firtsPos);
        if (transform.localPosition.z > _firtsPos)
        {
            //_naveRBD.velocity = transform.forward * _acelerationSpeed * Time.deltaTime;
            float finalAceleration;
            finalAceleration = transform.localPosition.z - _firtsPos * _acelerationSpeed;
            _nave.transform.Translate(Vector3.forward *  finalAceleration * Time.deltaTime);
            //return finalAceleration;
        }
        else
        {
            //return _nave.transform.Translate(Vector3.forward * 0 * Time.deltaTime);
            //_nave.transform.Translate(-Vector3.forward * _acelerationSpeed * Time.deltaTime);
            // _naveRBD.velocity = -transform.forward * _acelerationSpeed * Time.deltaTime;
        }
        return 0;
    }
    
    public float Velocidad()
    {
        float finalAceleration;
        if (transform.localPosition.z > _firtsPos)
        {
            finalAceleration = transform.localPosition.z - _firtsPos * _acelerationSpeed;
            if (finalAceleration < 0)
            {
                finalAceleration= finalAceleration * -1;
            }
            return finalAceleration;
        }

        return 0f;
    }
}
