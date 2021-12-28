using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balthioul_Script : MonoBehaviour

{
    public Dialogue Dialogue2;
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
            string[] dialogue =  {"Balthioul: Greetings young man, it seems like you're needed again to free this land from evildoers.",
                                  "Balthioul: It is a never ending battle isn't it huh ?",
                                  "Balthioul: That is the fate of warriors, many more great fights awaits you on this road you walk.",
                                  "Balthioul: You are strong, but you need to get stronger to be able to overcome the hardships awaiting you.",
                                  "Balthioul: But first lets make sure you got all the basics.",
                                  "Balthioul: When an enemies approaches, you have to be fast and strike them before they can strike you (Press Q ).",
                                  "Balthioul: If you find any obstacle in your way or you find a wide space that you can't reach the otherside ......",
                                  "Balthioul: You can jump over platroms to reach your destination (Press Spacebar).",
                                  "Balthioul: BUT CAREFUL, if the fall is too high, it can hurt you and sometimes kill you",
                                  "Balthioul: Okay now lets test if you were paying attention, go jump over these platforms and attack those dummies."
            };

            Dialogue2.SetSentences(dialogue);
            Dialogue2.StartCoroutine(Dialogue2.TypeDialogue());
        }
    }
}