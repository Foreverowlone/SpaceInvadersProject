using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    Score score;
    public GameObject bullet;
    public Transform turret;
    public float fireRatep;
    public float fireRatem;
    public float nextFire;
    public int scoreWorth;

    // Start is called before the first frame update
    void Start()
    {
        nextFire = nextFire + Random.Range(fireRatep, fireRatem);
        score = GameObject.Find("SManager").GetComponent<Score>();
    }
    // Update is called once per frame
    void Update()
    {
        if (Time.time > nextFire)
        {
            nextFire = Time.time + Random.Range(fireRatep, fireRatem);
            Instantiate(bullet, turret.position, turret.rotation);
        }
    }
void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
        score.setPlayerScore(score.getPlayerScore() + scoreWorth);
      Debug.Log("Ouch!");
    }
}
