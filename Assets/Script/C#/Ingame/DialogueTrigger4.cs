﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueTrigger4 : MonoBehaviour {

    public Dialogue dialog;
    public Dialogue dialogue;
    public Button button;
    public bool isclick;
    public bool pauseclick;
    public bool backpackclick;
    bool check;

    void Start()
    {
        button = GetComponent<Button>();
        button.interactable = true;
    }

    void Update()
    {
        isclick = FindObjectOfType<DialogueManager>().isClickable;
        pauseclick = FindObjectOfType<PauseMenu>().pauseClickable;
        backpackclick = FindObjectOfType<Backpack>().backpackClickable;
        check = FindObjectOfType<Movement>().key3;
        if (!isclick || !pauseclick || !backpackclick)
        {
            button.interactable = false;
        }
        else
        {
            button.interactable = true;
        }
    }

    public void TriggerDialogue()
    {
        if (check == false && FindObjectOfType<Movement>().key2 == true)
        {
            FindObjectOfType<DialogueManager>().StartDialogue(dialog);
            FindObjectOfType<Movement>().key3 = true;
            FindObjectOfType<Movement>().enemy = true;
        }
        if (check == true || FindObjectOfType<Movement>().key2 == false)
        {
            FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
        }
    }
}
