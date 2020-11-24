 var target : Transform;
 target = GameObject.Find("Main Camera").transform;
 var offset : Vector3;
 
 function LateUpdate () {
 if(target == null)
 {
 	target = GameObject.Find("Main Camera").transform;
 }
 	     transform.position = target.position - offset;
 	     
 }
 