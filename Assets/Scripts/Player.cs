using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
  public GameObject bullet;
    public GameObject PlayerOb;
    public float speed = 5f;

  public Transform shottingOffset;
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
    }
}
