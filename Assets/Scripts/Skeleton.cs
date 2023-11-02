using System.Collections;
using System.Collections.Generic;
using UnityEditor.VersionControl;
using UnityEngine;

public class Skeleton : MonoBehaviour
{
        // Start is called before the first frame update
    private int _collectedPoints; 
    public float _speed;
    public float _rotationSpeed;

    private void OnCollisionEnter(Collision other)
        {
           Sphere collisionSphere = other.gameObject.GetComponent<Sphere>();
           if (collisionSphere != null)
          {
            _collectedPoints = _collectedPoints + collisionSphere.Points;
            Debug.Log(message:$"Nedostatochno zolota vsego {_collectedPoints} monet");
          }  
        }
        private void Update()
        {
           if (Input.GetKey(KeyCode.W)) 
           {
            var tmp = transform.position;
            tmp.z += _speed * Time.deltaTime;
            transform.position = tmp;
           }
           if (Input.GetKey(KeyCode.S)) 
           {
            var tmp = transform.position;
            tmp.z -= _speed * Time.deltaTime;
            transform.position = tmp;
           }

            if (Input.GetKey(KeyCode.D)) 
           {
            Quaternion tmp = transform.rotation;
            tmp.y += _rotationSpeed * Time.deltaTime;
            transform.rotation = tmp;
           }
           if (Input.GetKey(KeyCode.A)) 
           {
            Quaternion tmp = transform.rotation;
            tmp.y -= _rotationSpeed * Time.deltaTime;
            transform.rotation = tmp;
           }
        }
   }
