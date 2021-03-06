﻿namespace UnityEngine.AdventureGame
{
    public class ClickToWalk : MonoBehaviour
    {
	    void OnMouseUp()
	    {
            Vector2 ray = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        
            Collider2D[] hits = Physics2D.OverlapPointAll(ray);
            if (hits.Length > 0)
	        {
	            if (hits[0].gameObject.GetInstanceID() == gameObject.GetInstanceID())
	            {
                    Debug.LogFormat("Walk Command Triggered!");
	                if (SceneManager.Instance.Character != null)
	                {
	                    SceneManager.Instance.Character.WalkToPosition(ray);
	                }
	            }
	        }
        }
    }
}
