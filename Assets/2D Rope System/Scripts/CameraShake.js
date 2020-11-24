#pragma strict

var startingShakeDistance : float = 0.8;
var decreasePercentage : float = 0.5;
var shakeSpeed : float = 50;
var numberOfShakes : int = 10;
var cam : Camera;

function CameraShake () {

var hitTime : float = Time.time;
var originalPosition : float = cam.transform.localPosition.y;
var shake = numberOfShakes;
var shakeDistance : float = startingShakeDistance;

	while(shake)
		{
			var timer : float = (Time.time - hitTime) * shakeSpeed;
			cam.transform.localPosition.y = originalPosition + Mathf.Sin(timer) * shakeDistance;
			
			if (timer > Mathf.PI * 2)
				{
					hitTime = Time.time;
					shakeDistance *= decreasePercentage;
					shake--;
				}
				yield;

		}		
	cam.transform.localPosition.y = originalPosition;
}
