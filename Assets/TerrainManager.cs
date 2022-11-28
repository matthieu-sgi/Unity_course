using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerrainManager : MonoBehaviour
{
    private List<TerrainItem> _terrains;
    private TerrainItem lastDisplayed;
    void Start()
    {
        _terrains = new List<TerrainItem>();
        for (var i = 0; i < transform.childCount; i++)
        {
            _terrains.Add(transform.GetChild(i).GetComponent<TerrainItem>());
            _terrains[i].HideTerrain();
            Debug.Log($"{_terrains[0].name}");
        }
        DisplayRandomTerrain();
        DisplayRandomTerrain();
        DisplayRandomTerrain();
        DisplayRandomTerrain();
    }

    private void DisplayRandomTerrain()
    {
        var infiniteLoopLimit = 0;
        var randomNumber = Random.Range(0, transform.childCount - 1);
        while (_terrains[randomNumber].IsDisplayed)
        {
            infiniteLoopLimit++;
            if (infiniteLoopLimit > 1000)
            {
                Debug.LogError("could not display terrain");
                return;
            }
            randomNumber = Random.Range(0, transform.childCount - 1);
        }
        _terrains[randomNumber].DisplayTerrain();
        if (lastDisplayed == null) _terrains[randomNumber].transform.position = new Vector3(0, 0, 0);
        else
        {
            _terrains[randomNumber].transform.position = 
                new Vector3(
                    lastDisplayed.transform.position.x + lastDisplayed.GetComponent<MeshRenderer>().bounds.size.x,
                    0,
                    0
                    );
        }
        lastDisplayed = _terrains[randomNumber];
    }

    // Update is called once per frame
    void Update()
    {
    }
}