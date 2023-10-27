using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet2Controller : MonoBehaviour
{
    public float speed = 0.1f;
    private player2Controller Player2;
    int dirx = 0;
    // Use this for initialization
    void Start()
    {
        Player2 = FindObjectOfType<player2Controller>();
        if (Player2 != null)
        {
            Destroy(this.gameObject, 1.0f);
            //Debug.Log(Player1.dir);
            dirx = Player2.dir;
        }

    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(;

        //dirx = Player1.dir;
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

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log(collision.gameObject.tag);
        if (collision.gameObject.tag == "Player")
        {
            Destroy(this.gameObject);
        }
    }



}