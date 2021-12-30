using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class PlayerStats : MonoBehaviour {
	public int health = 20;
	public int lives = 3;
	private float flickerTime = 0f;
	public float flickerDuration = 0.1f;
	private SpriteRenderer spriteRenderer;
	public bool isImmune = false;
	private float immunityTime = 0f;
	public float immunityDuration = 1.5f;
    public int soulsCollected;
    public Text ScoreUI;
    public Text LivesUI;
    public Slider HealthUI;
    // Use this for initialization
    void Start () {
        
		spriteRenderer = this.gameObject.GetComponent<SpriteRenderer>();
	}

    public void CollectSouls(int val)
    {

        soulsCollected += val;
    }

	void SpriteFlicker()
    {
		if(this.flickerTime < this.flickerDuration)
        {
			this.flickerTime = this.flickerTime + Time.deltaTime;
        }
		else if (this.flickerTime >= this.flickerDuration)
        {
			spriteRenderer.enabled = !(spriteRenderer.enabled);
			this.flickerTime = 0;
        }
    }
	public void TakeDamage(int damage)
	{
		{
			if (this.isImmune == false)
			{
				this.health = this.health - damage;
				if (this.health < 0)
				{
					this.health = 0;
				}
				if (this.lives > 0 && this.health == 0)
				{
					FindObjectOfType<LevelManager>().RespawnPlayer();
					this.health = 20;
					this.lives--;
                    LivesUI.text = lives.ToString();
                }
				else if (this.lives == 0 && this.health == 0)
				{
					Debug.Log("Gameover");
					Destroy(this.gameObject);
				}
				Debug.Log("Player Health:" + this.health.ToString());
				Debug.Log("Player Lives:" + this.lives.ToString());
			}
		}
		PlayHitReaction();
	}

    public void SpikesDeath()
    {

                this.lives--;
        LivesUI.text = lives.ToString();
        this.health = 20;

        if (this.lives == 0 )
            {
                Debug.Log("Gameover");
                Destroy(this.gameObject);
            }
            Debug.Log("Player Lives:" + this.lives.ToString());
    }
    

	void PlayHitReaction()
    {
		this.isImmune = true;
		this.immunityTime = 0f;
    }
	// Update is called once per frame
	void Update () {
        HealthUI.value = health;
        ScoreUI.text = "" + soulsCollected;
        if (this.isImmune == true)
        {
			SpriteFlicker();
			immunityTime = immunityTime + Time.deltaTime;
            if (immunityTime >= immunityDuration)
            {
				this.isImmune = false;
				this.spriteRenderer.enabled = true;
            }
        }
	}
}
