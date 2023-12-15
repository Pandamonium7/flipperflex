using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour
{
    void Start(){
        meshRenderer = GetComponent<MeshRenderer>();
    }
    [SerializeField] MeshRenderer meshRenderer;
    public void ChangeColor(){
         meshRenderer.material.color = Random.ColorHSV();
   }
}
