using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideOnLoad : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
        gameObject.SetActive(false);
    }

    // Update is called once per frame
    private void Update()
    {
    }
}