using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.down * Time.deltaTime);
        if (transform.position.y < -8.0f)
        {
            float randomized = Random.Range(-8.0f, 8.0f);
            transform.position = new Vector3(randomized, 7, 0);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.GetComponent<lazer>() != null)
        {
            Destroy(this.gameObject);
        }
        if(other.tag == "Cube")
        {
            cube player = other.transform.GetComponent<cube>();
            player.Damage();
            Destroy(this.gameObject);
        }
    }
}
