using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cutscene1 : MonoBehaviour

{
    public Dialogue dialogueManager;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            string[] dialogue =  {"Lombard: I guess I'm really close to the first artifact.",
            "Lombard: This place is full of skeletons too, I should be careful because they're quite powerful!",
            "Skeletons: HOW DARE YOU DEFY THE LORD'S LAND??!!!!",
            "Skeletons: WE'RE GOING TO FINISH YOU OFF!!!!!"};
            dialogueManager.SetSentences(dialogue);
            dialogueManager.StartCoroutine(dialogueManager.TypeDialogue());
        }
    }
}
