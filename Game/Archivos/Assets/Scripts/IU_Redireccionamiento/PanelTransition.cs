using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PanelTransition : MonoBehaviour
{
    [Header("ANIMATORS")]
    public Animator oldAnimator;
    public Animator newAnimator;

    [Header("OBJECTS")]
    public Button animButton;
    public GameObject newPanel;
    public GameObject oldPanel;

    [Header("ANIM NAMES")]
    public string oldAnimText;
    public string newAnimText;

    void Start()
    {
        oldAnimator.GetComponent<Animator>();
        newAnimator.GetComponent<Animator>();
        Button btn = animButton.GetComponent<Button>();
        animButton.onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick()
    {
        newPanel.SetActive(true);
        oldPanel.SetActive(false);
        oldAnimator.Play(oldAnimText);
        newAnimator.Play(newAnimText);
    }
}
