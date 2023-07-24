using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Furniture : MonoBehaviour
{
    [SerializeField] [TextArea] private string deskripsi;

    public string GetDeskripsi()
    {
        return deskripsi;
    }

}
