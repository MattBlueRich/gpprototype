using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class KillLevel : MonoBehaviour
{
    public GameObject[] Levels;
    public float spawnHeight = 80;
    public GameObject gridParent;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Level"))
        {
            Debug.Log("Kill Level");
            Destroy(collision.gameObject);
            GameObject level = Instantiate(PickRandomLevel(), gridParent.transform);
            level.transform.position = new Vector3(level.transform.position.x, spawnHeight);
        }
    }

    public GameObject PickRandomLevel()
    {
        return Levels[Random.Range(0, Levels.Length)];
    }
}
