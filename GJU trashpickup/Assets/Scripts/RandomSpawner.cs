using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawner : MonoBehaviour { 

   public GameObject ItemPrefab;
    public float Radius = 1;

    [SerializeField] GameObject[] Trash;
    [SerializeField] float secondspawn = 0.5f;
    [SerializeField] float minTras;
    [SerializeField] float maxTras;



    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(TrashSpawn());
    }

    // Update is called once per frame
    void Update()
    {
        

    }

    IEnumerator TrashSpawn() 
    {
        while (true)
        {
            var wanted = Random.Range(minTras, maxTras);
            var position = new Vector2(wanted, transform.position.y);
        }


    }


}


