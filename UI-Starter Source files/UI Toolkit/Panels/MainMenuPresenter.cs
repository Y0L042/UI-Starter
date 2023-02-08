using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class MainMenuPresenter : MonoBehaviour
{
    [SerializeField]
    SceneOrganizer _sceneOrganizer;

    void Awake()
    {
        VisualElement root = GetComponent<UIDocument>().rootVisualElement;
        root.Q<Button>("Start").clicked += () => StartGame();
        root.Q<Button>("Settings").clicked += () => Debug.Log("Settings");
        root.Q<Button>("Quit").clicked += () => Debug.Log("Quit");
    }

    void Start()
    {
        if (_sceneOrganizer == null){ Debug.Log("SceneOrganizer is empty!  " + gameObject);}
    }

    void StartGame()
    {
        _sceneOrganizer.LoadNextScene();
    }
}
