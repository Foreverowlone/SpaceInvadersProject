using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    Score score;
    public GameObject bullet;
    public Transform turret;
    float fireTime;
    float fireTimeDif;
    public GameObject[] badGuys;
    //public float fireRatep;
    //public float fireRatem;
    //public float nextFire = 0.9f;
    public int scoreWorth;

    // Start is called before the first frame update
    void Start()
    {
        badGuys = GameObject.FindGameObjectsWithTag("Enemy");
        //nextFire = nextFire + Random.Range(fireRatep, fireRatem);
        score = GameObject.Find("SManager").GetComponent<Score>();
    }
    // Update is called once per frame
    void Update()
    {
        fireTimeDif -= Time.deltaTime;
        if (fireTimeDif < 0)
        {
            int reaper = Random.Range(0, badGuys.Length);
            badGuys[reaper].GetComponent<Enemy>().shootem();
            fireTime = Random.Range(2, 5);
            fireTimeDif = fireTime;
        }
        //if (Time.time > nextFire)
        //{
        //    nextFire = Time.time + Random.Range(fireRatep, fireRatem);
        //    Instantiate(bullet, turret.position, turret.rotation);
        //}
    }
    void OnTriggerEnter2D(Collider2D trig)
    {
        if (trig.gameObject.tag == "Bullet1")
        {
        Destroy(trig.gameObject);
        Destroy(gameObject);
        score.setPlayerScore(score.getPlayerScore() + scoreWorth);
        Debug.Log("Ouch!");
        }
        
    }

    public void shootem()
    {
        GameObject shot = Instantiate(bullet, turret.position, Quaternion.identity);
        Destroy(shot, 3f);
    }
}
