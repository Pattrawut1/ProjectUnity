using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour{
    public void LoadScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }
     public void ExitGame(){
         Debug.Log ("QUIT");
        Application.Quit ();
    }
    public void SetVolume (float volume)
    {
        Debug.Log (volume);

    }
    public void SetFullscreen (bool isFullscreen)
    {
        Screen.fullScreen = isFullscreen;
    }
    Resolution[] resolutions;
    public Dropdown resolutionsDropdown;
    void Start ()
    {
       resolutions = Screen.resolutions;

       resolutionsDropdown.ClearOptions();
       List<string> options = new List<string>();
       int currentResolutionIndex = 0;
       for (int i = 0; i < resolutions.Length; i++)
       {
        string option = resolutions[i].width + " x " + resolutions[i].height;
        options.Add(option);
        if (resolutions[i].width == Screen.currentResolution.width && 
            resolutions[i].height == Screen.currentResolution.height)
        {
            currentResolutionIndex = i;
        }
       }
       resolutionsDropdown.AddOptions(options);
       resolutionsDropdown.value =currentResolutionIndex;
       resolutionsDropdown.RefreshShownValue();
    }
    public void SetResolution (int resolutionIndex)
    {
        Resolution resolution = resolutions[resolutionIndex];
        Screen.SetResolution(resolution.width, resolution.height, Screen.fullScreen);
    }
    // Start is called before the first frame update

}
