using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene : MonoBehaviour
{
    [SerializeField] GameObject enemyPrefab;
    private GameObject enemy;

    // Update is called once per frame
    void Update()
    {
        if(enemy == null)
        {
            enemy = Instantiate(enemyPrefab) as GameObject;
            enemy.transform.position = new Vector3(0, 1, 0);
            float angle = Random.Range(0, 360);
            enemy.transform.Rotate(0, angle, 0);
            float size = Random.Range(0, 5);
            enemy.transform.localScale = new Vector3(2, size, 2);
            GetComponent<MeshRenderer>().material.color = Random.ColorHSV();
        }
    }
}
