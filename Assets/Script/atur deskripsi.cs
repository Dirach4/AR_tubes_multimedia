using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class aturdeskripsi : MonoBehaviour
{
    private bool[] isMarker;
    private GameObject furniture;
    private int hitungMarker;
    [SerializeField] int jmlMarker;
    [SerializeField] private Text txtdeskripsi;


    private void Start()
    {
        isMarker = new bool[jmlMarker];
    }
    public void SetMarkerOn(int indexMarker)
    {
        if (!isMarker[indexMarker])
        {
            isMarker[indexMarker] = true;
            hitungMarker++;
        }
    }

    public void SetMarkerOff(int indexMarker)
    {
        if (isMarker[indexMarker]) // Changed the condition from !isMarker[indexMarker] to isMarker[indexMarker]
        {
            isMarker[indexMarker] = false;
            hitungMarker--;
        }
    }

    public void SetFurniture(GameObject fuurniture)
    {
        this.furniture = fuurniture;
    }

    private void SetUI(bool b)
    {
        txtdeskripsi.transform.gameObject.SetActive(b);
    }

    // Update is called once per frame
    void Update()
    {
        if (furniture == null)
        {
            SetUI(false);
        }
        if (furniture != null)
        {
            SetUI(true);
            for (int i = 0; i < isMarker.Length; i++)
            {

                txtdeskripsi.text = furniture.GetComponent<Furniture>().GetDeskripsi();
            }
        }
    }
}
