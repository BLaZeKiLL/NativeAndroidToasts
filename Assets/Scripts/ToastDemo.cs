using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToastDemo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        ToastManager.Show("Hello world", ToastManager.Length.LONG);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
