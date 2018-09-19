using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Usable : Item
{
    private int uses;

    public int maxUses;
    public string usetext;
    public string depletedText;

    public void Start()
    {
        uses = maxUses;
    }


    private void OnMouseUpAsButton()
    {
        if (uses > 0)
        {
            Debug.Log(ToString());
            uses--;
        }
        else
            Debug.Log(depletedText);
    }

    public virtual void Use()
    {
        Debug.Log(usetext);
    }

    //public virtual string UseText()
    //{

    //}

    public override string ToString()
    {
        Use();
        return displayName + " has " + uses + " out of " + maxUses + "uses";
    }


}
