using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss1_dialogue : MonoBehaviour

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
            string[] dialogue =  {"Boss: Finally, Lambard the great knight is here.",
                                  "Boss: A worthy enemy is here to prove that I am the best in this universe",
                                  "Lambard: It will not be this easy, I am here to fix all what you and the other knight did",
                                  "Boss: You're right, It will not be that easy, but you can say your last words before I smash your head",
                                  "Lambard: This universe is under my protection and it will always be",
                                  "King: So prove it, Lets fight !!" };
            dialogueManager.SetSentences(dialogue);
            dialogueManager.StartCoroutine(dialogueManager.TypeDialogue());
        }
    }
}
