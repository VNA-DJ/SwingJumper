#pragma strict

var button_rate : Sprite;
var button_down_rate : Sprite;

function OnMouseEnter () {

	GetComponent(SpriteRenderer).sprite = button_down_rate;
}

function  OnMouseExit() {
	GetComponent(SpriteRenderer).sprite = button_rate;
}

function OnMouseDown (){
	Application.OpenURL ("market://details?id=com.WOLKY.SwingJumper");
}