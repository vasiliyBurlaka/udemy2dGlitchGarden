using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoades : MonoBehaviour
{
    [SerializeField] float timeToWait = 3f;
    int currentSceneIndex = 0; 

    // Start is called before the first frame update
    void Start()
    {
        currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        if (currentSceneIndex == 0) 
        {
            StartCoroutine(WaiteForTime());
        }
    }

    IEnumerator WaiteForTime()
    {
        yield return new WaitForSeconds(timeToWait);
        LoadNextSceen();
    }

    public void LoadNextSceen()
    {
        SceneManager.LoadScene(currentSceneIndex+1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
