using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lazer : MonoBehaviour
{
    int maxY = 8;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.up * 6 * Time.deltaTime);
        if (transform.position.y > maxY)
        {
            Destroy(this.gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.GetComponent<enemy>() != null)
        {
            Destroy(this.gameObject);
        }
    }
}
