using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss2_dialogue : MonoBehaviour

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
            string[] dialogue =  {"Boss: You're here after defeating the first knight",
                                  "Boss: And now you are here willing to defeat me right?",
                                  "Lambard: And I will, I am here to protect this universe and you will not stop me",
                                  "Boss: You are dreaming kid, this universe is mine and no one will take my throne",
                                  "Lambard: This throne will turn into your grave, get ready for it",
                                  "King: I doubt you know what you're saying, but I'll punish you for it any way !" };
            dialogueManager.SetSentences(dialogue);
            dialogueManager.StartCoroutine(dialogueManager.TypeDialogue());
        }
    }
}
