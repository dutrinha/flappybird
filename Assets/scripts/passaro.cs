using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class passaro : MonoBehaviour
{
    Rigidbody2D fisica;
    [SerializeField]
    private float velocidadeImpulso = 3f;
    private void Awake(){
        this.fisica = GetComponent<Rigidbody2D>();
    }

    void Update(){
        if (Input.GetMouseButtonDown(0)){
            this.Impulsionar();
        } 
    }

    void Impulsionar(){
        this.fisica.AddForce(Vector2.up * velocidadeImpulso, ForceMode2D.Impulse);
    }
}




