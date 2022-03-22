using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapController : MonoBehaviour
{
    [SerializeField] GameObject WhiteChipPrefab;
    [SerializeField] int w, h;
    float chipSize;

    void Start()
    {
        chipSize = WhiteChipPrefab.GetComponent<SpriteRenderer>().bounds.size.x;
        float xShift = w / 2 * chipSize;
        float yShift = h / 2 * chipSize;
        for(int x = 0;x < w; x++)
        {
            for(int y = 0;y < h; y++)
            {
                Vector2 pos = new Vector2(
                    x * chipSize - xShift,
                    y * chipSize - yShift
                );
                Instantiate(WhiteChipPrefab, pos, Quaternion.identity, transform);
            }
        }
    }

    
    void Update()
    {
        
    }
}
