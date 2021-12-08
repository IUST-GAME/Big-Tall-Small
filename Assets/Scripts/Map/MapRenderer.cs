using System;
using System.IO;
using UnityEngine;


namespace Map
{
    /*
     * Loads and render different kinds of maps
     */
    public class MapRenderer : MonoBehaviour
    {
        private const float Ratio = (float) 4 / 3;
        private const int VerticalBoxes = 18;
        private const int HorizontalBoxes = 24;

        public GameObject BlueTestBlocks;

        public void RenderMap(string mapName)
        {
            var path = Application.dataPath + "/Maps/level_001.json";
            var jsonString = File.ReadAllText(path);
            var mapData = JsonUtility.FromJson<Map>(jsonString);


            var g = Instantiate(
                BlueTestBlocks,
                new Vector3(
                    this.gameObject.transform.position.x,
                    this.gameObject.transform.position.y,
                    this.gameObject.transform.position.z
                ),
                Quaternion.identity,
                this.gameObject.transform);
        }
    }
}