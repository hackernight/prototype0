using UnityEngine;
using System.Collections;

namespace Completed{	
	public class Loader : MonoBehaviour {
		public GameObject gameController;
		//public GameObject soundManager;/

		void Awake (){

				Instantiate (gameController);

			
			//if (gameController.instance == null) {
				//Instantiate (soundManager);
			//}
		}
	}
}