using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ButtonManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void startGame() {
        Time.timeScale = 1;
        SceneManager.LoadScene("SampleScene");
        
    }
    public void Restart() {
        Time.timeScale = 1;
        SceneManager.LoadScene("Menu");
        
    }
}
