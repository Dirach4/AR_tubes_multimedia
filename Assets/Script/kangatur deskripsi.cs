using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class kangaturdeskripsi : MonoBehaviour
{
    public Deskripsi[] tr;
    [TextArea]
    public string[] deskripsi;
    
    public Text txtDeskripsi;

    void update()
    {
        for(int i = 0; i < tr.Length;  i++)
        {
            if (tr[i].GetMarker())
            {
                txtDeskripsi.text = deskripsi[i];
            }
        }
    }
}


