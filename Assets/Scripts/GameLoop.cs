using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;


public class GameLoop : MonoBehaviour 
{
    public Board Board;

    public Text ScoreText;
    private int _score = 0;
    public int Score { get { return _score; } }

    public float StepTime = 0.5F;
    private float _timePassed = 0.0F;
	// Use this for initialization
	void Start () 
    {
	
	}
	
	// Update is called once per frame
	void Update () 
    {
        updateTexts();

        _timePassed -= Time.deltaTime;
        if (_timePassed <= 0.0F)
        {
            _timePassed = StepTime;

            // DO THINGS!

        }
	}

    private void updateTexts()
    {
        ScoreText.text = "Score: " + _score.ToString();
    }
}
