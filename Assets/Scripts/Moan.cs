using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class Moan : MonoBehaviour
{
    [SerializeField] private UnityEvent OnHit;

    void Start()
    {

    }

    void Update()
    {

    }

    void OnCollisionEnter(Collision collision) 
    {
        OnHit.Invoke();
    }
}
