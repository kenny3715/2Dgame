using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletController : MonoBehaviour
{
    public float speed = 0.1f;
    private playerController Player1;
    int dirx = 0;
    // Use this for initialization
    void Start()
    {
        Player1 = FindObjectOfType<playerController>();
        Destroy(this.gameObject, 3.0f);
        //Debug.Log(Player1.dir);
        dirx = Player1.dir;

    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(;

        dirx = Player1.dir;
        //if (dirx * transform.localScale.x < 0)
        //{
        //  this.transform.Translate(new Vector3(-speed, 0, 0));
        //}
        //else
        //{

        this.transform.Translate(new Vector3(dirx * speed, 0, 0));
        //}
        //transform.position += -transform.right * Time.deltaTime * speed;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player2")
        {
            Destroy(this.gameObject);
        }
    }



}