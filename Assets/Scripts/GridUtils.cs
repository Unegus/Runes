using System.Numerics;
using Unity.VisualScripting;
using UnityEngine;

public class GridUtils : MonoBehaviour
{
    [SerializeField] bool isGridFixed = true;
    void GridLining()
    {
       transform.position = new UnityEngine.Vector3(Mathf.Round(transform.position.x), Mathf.Round(transform.position.y) + 0.5f, Mathf.Round(transform.position.z));
    }
    void Update()
    {
        if (isGridFixed)
        {
            GridLining();
        }
    }
}
