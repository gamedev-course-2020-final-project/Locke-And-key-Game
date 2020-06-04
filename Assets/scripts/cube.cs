using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cube : MonoBehaviour
{
    [SerializeField]
    GameObject lazer;
    [SerializeField]
    int life;
    [SerializeField]
    GameObject triple_shot;
    bool _tripleShotActive = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Mathf.Abs(transform.position.y) > 7f)
            transform.position = new Vector3(transform.position.x, transform.position.y * -1, transform.position.z);
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        transform.Translate(new Vector3(horizontal, vertical, 0) * 2 * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (!_tripleShotActive)
            {
                Vector3 lazer_pos = new Vector3(transform.position.x, transform.position.y + 1, 0);
                Instantiate(lazer, lazer_pos, Quaternion.identity);
            }
            else
            {
                Vector3 tripleShot_pos = new Vector3(transform.position.x, transform.position.y + 1, 0);
                Instantiate(triple_shot, tripleShot_pos, Quaternion.identity);
            }
        }
    }

    public void Damage()
    {
        life--;
        if(life < 1)
        {
            Destroy(this.gameObject);
        }
    }

    public void TripleShotActive()
    {
        _tripleShotActive = true;
        StartCoroutine(TripleShotRoutine());
    }

    IEnumerator TripleShotRoutine()
    {
        yield return new WaitForSeconds(15f);
        _tripleShotActive = false;
    }
}
