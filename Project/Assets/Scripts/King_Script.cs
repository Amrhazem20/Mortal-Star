using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class King_Script : MonoBehaviour
    
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
            string[] dialogue =  {"King: Hello brave warrior! Long ago a war broke out between humans and demons summoned by the dark sorcerers.",
                                  "King: The demons killed many citizens and tore down other cities but warriors arised with 5 magical artifacts.",
                                  "King: They killed the demons with ease but power got to them and 4 of them turned evil.",
                                  "King: It's up to you brave Lambard to stop the other 4 knights and free each side of the kingdom, are you up for this task?",
                                  "Lombard: I'm ready my lord, I must retrieve back the 4 magical artifacts from the corrupted knights!",
                                  "King: Then, let the adventure begin!!!" };
            dialogueManager.SetSentences(dialogue);
            dialogueManager.StartCoroutine(dialogueManager.TypeDialogue());
        }
    }
}
