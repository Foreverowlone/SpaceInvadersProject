using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
  public GameObject bullet;
    public GameObject PlayerOb;
    public float speed = 5f;

  public Transform shottingOffset;

    Rigidbody2D rbp;
    public GameObject player;
    public ForceMode2D forceMode;

    // Start is called before the first frame update
    void Start()
    {
        rbp = player.gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
      if (Input.GetKeyDown(KeyCode.Space))
      {
        GameObject shot = Instantiate(bullet, shottingOffset.position, Quaternion.identity);
        Debug.Log("Bang!");

        Destroy(shot, 3f);

      }
        if (PlayerOb)
        {
            transform.Translate(0f, Input.GetAxis("Player") * 2 * speed * Time.deltaTime, 0f);
        }

        if (Input.GetAxis("PlayerCharacter") > 0)
        {
            Vector3 right = new Vector3(10, 0.0f, 0);
            rbp.AddForce(right, forceMode);
        }

        if (Input.GetAxis("PlayerCharacter") < 0)
        {
            Vector3 left = new Vector3(-10, 0.0f, 0);
            rbp.AddForce(left, forceMode);
        }

        if (Input.GetAxis("PlayerCharacter") == 0)
        {
            rbp.velocity = Vector3.zero;
        }
    }
}
