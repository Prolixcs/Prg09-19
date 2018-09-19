using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public string displayName;
    public float Weight;
    public float Cost;

    public virtual void OnMouseEnter()
    {
        Debug.Log(ToString());
    }

    public override string ToString()
    {
        return displayName + " costs " + Cost + " gold " + "per " + Weight + "kg";
    }


}

