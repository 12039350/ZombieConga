using UnityEngine;
using System.Collections;

public class ScreenRelativePosition : MonoBehaviour {

	public enum ScreenEdge {LEFT, RIGHT, TOP, BOTTOM};
	public ScreenEdge screenEdge;
	public float yOffset;
	public float xOffset;

	// Use this for initialization
	void Start () {
		Vector3 newPostion = transform.position;
		Camera camera = Camera.main;

		switch (screenEdge) {
			case ScreenEdge.RIGHT:
				newPostion.x = camera.aspect * camera.orthographicSize + xOffset;
				newPostion.y = yOffset;
				break;

			case ScreenEdge.TOP:
				newPostion.y = camera.orthographicSize + yOffset;
				newPostion.x = xOffset;
				break;

			case ScreenEdge.BOTTOM:
				newPostion.y = -camera.orthographicSize + yOffset;
				newPostion.x = xOffset;
				break;

			case ScreenEdge.LEFT:
				newPostion.x = -camera.aspect * camera.orthographicSize + xOffset;
				newPostion.y = yOffset;
				break;
		}

		transform.position = newPostion;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
