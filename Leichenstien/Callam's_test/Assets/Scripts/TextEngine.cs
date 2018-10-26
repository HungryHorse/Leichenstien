using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TextEngine : MonoBehaviour
{

    public Scenes[] Chapter;
    public int sceneIndex;
    public Scenes currScene;
    public string lastHoveredLink;

    public Image currImage;
    public TMP_Text currText;
    
	void Start ()
    {
        SceneUpdater();
	}

    private void Update()
    {
        if (Input.GetButtonDown("Fire1") && lastHoveredLink != null)
        {
            sceneIndex = currScene.options[int.Parse(lastHoveredLink)];
            SceneUpdater();
        }
    }

    public void SceneUpdater()
    {
        currScene = Chapter[sceneIndex];
        currImage.sprite = currScene.backDrop;
        currText.text = currScene.textFeild;
        lastHoveredLink = null;
}
}
