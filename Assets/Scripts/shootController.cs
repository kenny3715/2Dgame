using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shootController : MonoBehaviour
{
    public GameObject BulletPrefab;

    public GameObject aimLine;
    public float speed = 5f;
    
    float time = 0f;
    public float destroyTime = 3f;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float v = Input.GetAxisRaw("Vertical") * speed * Time.deltaTime;
        aimLine.transform.Rotate(new Vector3(0, 0, v));

        time += Time.deltaTime;

        if (Input.GetKey(KeyCode.F))
        {
            if (time > 0.4f)
            {
                Instantiate(BulletPrefab, this.transform.position, this.transform.rotation);
                time = 0;
            }

        }
    }

}
