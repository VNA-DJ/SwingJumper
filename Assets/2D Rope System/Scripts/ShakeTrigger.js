#pragma strict

private var camerashake : CameraShake;

function Start () {

	camerashake = GameObject.Find("Main Camera").GetComponent(CameraShake);

}

function OnTriggerEnter2D (Col : Collider2D) {

	if (Col.tag == "Buttons" && "BackGround" && "Text")
	{
		camerashake.CameraShake();
	}
}