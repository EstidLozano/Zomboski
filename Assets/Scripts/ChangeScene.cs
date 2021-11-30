using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    
    void Start()
    {
        StartCoroutine(WaitTillFinish());
    }

    IEnumerator WaitTillFinish(){
        yield return new WaitForSeconds(20);
        ChangeScene1();
    }
    public void ChangeScene1(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
