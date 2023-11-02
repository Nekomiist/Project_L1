using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : MonoBehaviour
{
    // Start is called before the first frame update
    public int _points;
    public int Points => _points;

    private void OnCollisionEnter(Collision outher)
    
    {
        if (outher.gameObject.GetComponent<Skeleton>() != null)

        gameObject.SetActive(false);
    }

}
