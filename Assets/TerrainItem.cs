using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerrainItem : MonoBehaviour
{
      public bool IsDisplayed { get; private set; }

      public void DisplayTerrain()
      {
          IsDisplayed = true;
          gameObject.SetActive(true);
      }
      public void HideTerrain()
      {
          IsDisplayed = false;
          gameObject.SetActive(false);
      }
      void Start()
      {

      }

      // Update is called once per frame
      void Update()
      {

      }
  }