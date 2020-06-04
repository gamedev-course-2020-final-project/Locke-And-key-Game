using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class powerUp : MonoBehaviour
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
        if(other.tag == "Cube")
        {
            System.Console.WriteLine("in OnTriggerEnter");
            cube player = other.transform.GetComponent<cube>();
            if (player != null)
            {
                player.TripleShotActive();
            }
            Destroy(this.gameObject);
        }
    }
}
