 function Update () {
       for(var i:int = 0; i < Input.touches.Length; i++)//How many touches do we have?
     {
         var touch:Touch = Input.touches[i];//The touch
         var ray:Ray = Camera.main.ScreenPointToRay(touch.position);
         var hit:RaycastHit = new RaycastHit();
 
         if(Physics.Raycast(ray,hit, 1000))
         {
             if(hit.collider.gameObject == this.gameObject)
             {
                 switch(touch.phase)
                 {
                     case TouchPhase.Began://if the touch begins
                       Application.LoadLevel(1);
                     break;
                  }
             }
          }
 
         }
 
 }