using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class VideoController : MonoBehaviour {
    public VideoPlayer videoPlayer;
    public GameObject player;
    private bool isChoosing = false;
    public GameObject choiceCanvas;
    void Start() {
        // Subscribe to the loopPointReached event
        videoPlayer.loopPointReached += OnVideoEnd;
        
        // Start playing the video
        videoPlayer.Play();
        Debug.Log("Video started");
    }

    // This method will be called when the video reaches its end
    void OnVideoEnd(VideoPlayer vp) {
        videoPlayer.Stop();
        choiceCanvas.SetActive(true);
        //SceneManager.LoadScene("followupScene");

        // Activate the text object or perform any other actions

    }

    public void ChooseOption1() {
        // Handle the action for option 1
        Debug.Log("Option 1 chosen");
        isChoosing = false;
        SceneManager.LoadScene("followupScene");
    }

    public void ChooseOption2() {
        // Handle the action for option 2
        Debug.Log("Option 2 chosen");
        isChoosing = false;
        SceneManager.LoadScene("followupScene");
        
    }
}
