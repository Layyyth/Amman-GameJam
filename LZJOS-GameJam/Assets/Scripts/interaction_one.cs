using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;
public class interaction_one : MonoBehaviour
{
    public GameObject choiceCanvas; // Reference to the canvas containing the choices
    private bool isChoosing = false;
    public VideoPlayer videoPlayer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider other) {
       if (other.CompareTag("Player")) {
            ShowChoices();
       }
        
    }

    private void ShowChoices() {
        isChoosing = true;
        choiceCanvas.SetActive(true);
       
    }

    public void ChooseOption1() {
        // Handle the action for option 1
        Debug.Log("Option 1 chosen");
        isChoosing = false;
        SceneManager.LoadScene("floppa");
        //videoPlayer.Play();
        //HideChoices();
        //choiceCanvas.SetActive(false);
    }

    public void ChooseOption2() {
        // Handle the action for option 2
        Debug.Log("Option 2 chosen");
        isChoosing = false;
        SceneManager.LoadScene("floppa");
        //videoPlayer.Play();
        //HideChoices();
        //choiceCanvas.SetActive(false);
    }
    void OnTriggerExit(Collider other) {
            HideChoices();  
    }

    private void HideChoices() {
        isChoosing = false;
        choiceCanvas.SetActive(false);
    }
}
