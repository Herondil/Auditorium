using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AccesEnfants : MonoBehaviour
{
    public MeshRenderer[] childrenMeshRenderers;
    public List<Component> childrenMeshRenderers2;
    public Material newColor;

    // Start is called before the first frame update
    void Start()
    {
        childrenMeshRenderers = this.GetComponentsInChildren<MeshRenderer>();

        childrenMeshRenderers[7].material = newColor;
    }
}
