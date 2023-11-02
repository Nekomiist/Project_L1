using System.Collections;
using System.Collections.Generic;
using UnityEditor.VersionControl;
using UnityEngine;

public class HitHandler : MonoBehaviour
{
    public GameObject _initialObject;
    public Transform _position;

    // Start is called before the first frame update
    void Start()
    {
       Debug.Log(message: "Roman here"); 
    }

    // Update is called once per frame
    void Update()
    {
       Debug.Log(message: "Im here"); 
    }
    private void OnCollisionEnter(Collision other) 
    {
        // Debug.Log( message: $"{gameObject.name} collided with {other.gameObject.name}"); 
        // gameObject.SetActive(false);

        // Destroy(gameObject);

        // var go = Instantiate(_initialObject, _position);
        // go.SetActive(true);
        //Instantiate(Resources.Load("sword1"));

    }
    
}
