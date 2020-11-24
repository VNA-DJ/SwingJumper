#pragma strict

var button_menu : Sprite;
var button_down_menu : Sprite;


var tr : Transform;

function Start () {
    tr = transform;
}

function OnMouseEnter () {
	
	GetComponent(SpriteRenderer).sprite = button_down_menu;
}

function  OnMouseExit() {
	GetComponent(SpriteRenderer).sprite = button_menu;
}

function OnMouseDown (){
	
	Application.LoadLevel (1);
}

function Update(){
    tr.Rotate(0.0, 0.0, -90.0*Time.deltaTime);
	if (Application.platform == RuntimePlatform.Android)
	{
		if (Input.GetKeyDown(KeyCode.Escape)) 
			Application.LoadLevel (0);
	}
}	 
