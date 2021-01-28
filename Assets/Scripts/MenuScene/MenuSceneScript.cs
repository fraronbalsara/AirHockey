using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuSceneScript : MonoBehaviour
{
    private bool isQuiting;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(isQuiting == true)
        {
            if(Input.GetKeyDown(KeyCode.Escape))
            {
                Application.Quit();
            }
        }
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            GameObject.Find("SceneManager").GetComponent<ToastMessageScript>().showToastOnUiThread("Press back again to exit");
            isQuiting = true;
            StartCoroutine(QuitingTimer());
        }
    }

    IEnumerator QuitingTimer()
    {
        yield return new WaitForSeconds(2);
        isQuiting = false;
    }
}
