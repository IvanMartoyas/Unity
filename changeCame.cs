using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeCame : MonoBehaviour
{
    private Camera TheCamera;
    public Camera Camera1;
       
    
    // Start is called before the first frame update
    void Start()
    {
        /*
         обращаюсь к компоненту камеры (GetComponent<Camera>), у него есть свойство enable
         */
        TheCamera = GetComponent<Camera>();
        TheCamera = Camera.main;// делаю камеру главной

        // задаю начальные позиции
        TheCamera.enabled = true;
        Camera1.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.V))
        {
            TheCamera.enabled = !TheCamera.enabled;
            Camera1.enabled = !Camera1.enabled;
        }
        
    }
}
