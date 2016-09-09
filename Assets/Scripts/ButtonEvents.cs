using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.EventSystems;

public class ButtonEvents : MonoBehaviour, IPointerDownHandler
{
    public GameLoop GameLoopScript;
    public SnakeDirection Direction;

	// Use this for initialization
	void Start () 
    {
        
	}
	
	// Update is called once per frame
	void Update () 
    {

	}

    public void OnPointerDown(PointerEventData eventData)
    {
        Time.timeScale = 1.0F;
        if (isDirectionLegal())
            GameLoopScript.Direction = Direction;
    }

    private bool isDirectionLegal()
    {
        if (Direction == SnakeDirection.DOWN)
        {
            if (GameLoopScript.Direction == SnakeDirection.UP)
                return false;
            return true;
        }
        if (Direction == SnakeDirection.UP)
        {
            if (GameLoopScript.Direction == SnakeDirection.DOWN)
                return false;
            return true;
        }
        if (Direction == SnakeDirection.RIGHT)
        {
            if (GameLoopScript.Direction == SnakeDirection.LEFT)
                return false;
            return true;
        }
        if (Direction == SnakeDirection.LEFT)
        {
            if (GameLoopScript.Direction == SnakeDirection.RIGHT)
                return false;
            return true;
        }
        return true;
    }
}
