using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotacion : MonoBehaviour
{
    private float _rotacionX;
    private float _rotacionZ;
    private GameObject _nave;
    [SerializeField]
    private float _rotationsepeed =5f;

    void Start()
    {
        _nave = GameObject.Find("Nave");
    }

    // Update is called once per frame
    void Update()
    {
        _rotacionX = transform.localRotation.x;
        _rotacionZ = transform.localRotation.z;
        RotarNave();
    }

    void RotarNave()
    {
        Debug.Log(_rotacionX + "   " + _rotacionZ);
        Vector3 rotacion = new Vector3(-_rotacionX *_rotationsepeed * Time.deltaTime, _rotacionZ * _rotationsepeed * Time.deltaTime, 0);
        _nave.transform.Rotate(rotacion);
        Vector3 eulerRotation = _nave.transform.rotation.eulerAngles;
        _nave.transform.rotation = Quaternion.Euler(eulerRotation.x, eulerRotation.y, 0);
    }
}
