using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public int bulletCount;
    public float bulletFireVel = 1;
    public GameObject bullet;
    public Transform Firepoint;
    public Quaternion newRot;


    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            fire();
        }
    }

    //void fire()
    //{
    //    int i = 0;
    //    foreach(Quaternion quat in bullets)
    //    {
    //        bullets[i] = Random.rotation;
    //        GameObject b = Instantiate(bullet, Firepoint.position, Firepoint.rotation);
    //        b.transform.rotation = Quaternion.RotateTowards(b.transform.rotation, bullets[i], spreadAngle);
    //        b.GetComponent<Rigidbody2D>().AddForce(b.transform.up * bulletFireVel, ForceMode2D.Impulse);
    //        Debug.Log(bullets[i]);
    //        i++;
    //    }
    //}
    void fire()
    {
        for (int i = 0; i < bulletCount; i++)
        {
            Quaternion rotationAmount = Quaternion.Euler(0, 0, 30 * (i - 1));
            newRot = Firepoint.rotation * rotationAmount;
            
            GameObject b = Instantiate(bullet, Firepoint.position, newRot);
            b.GetComponent<Rigidbody2D>().AddForce(b.transform.up * bulletFireVel, ForceMode2D.Impulse);
        }
    }

}
