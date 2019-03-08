using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cubes : MonoBehaviour {

    private Rigidbody _rigid;
    public float MoveSpeed;
    [HideInInspector] public bool _moveRight; //Set this to false to move to the left and visa versa


    private void Start()
    {
        _rigid = GetComponent<Rigidbody>();
    }

    void Update()
    {
        
            _rigid.MovePosition(_rigid.position + new Vector3(0, 0, -MoveSpeed));
            if (_rigid.position.z <= -5)
            {
                Destroy(gameObject);
            }
        
       
    }
}
