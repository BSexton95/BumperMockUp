using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LongboatMovementBehaviour : MonoBehaviour
{
    private Vector3 _startPosition;
    [SerializeField]
    private float _speed;

    public float Speed
    {
        get { return _speed; }
        set { _speed = value; }
    }

    private void Start()
    {
        _startPosition = transform.position;
    }

    private void Update()
    {
        
    }
}
