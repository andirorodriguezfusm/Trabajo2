using UnityEngine;
using System.Collections;

public class NewBehaviourScript : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
		
		GameObject plane = GameObject.CreatePrimitive(PrimitiveType.Plane);
		GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube); 
		//cubo que representa el cascaron
		cube.transform.localScale = new Vector3 (2.46025f, 0.5311695f, 1.147772f);
		cube.transform.position = new Vector3 (0f,0.5360004f , 0.2141948f);
		cube.transform.eulerAngles = new Vector3 (0f, 0f, 0f);
		//cubo representa el cascaro delantero
		cube = GameObject.CreatePrimitive(PrimitiveType.Cube); 
		cube.transform.localScale = new Vector3 (1f,0.3750001f,1.075f);
		cube.transform.position = new Vector3 (-0.7122843f,	0.7607864f,	0.2174655f);
		cube.transform.eulerAngles = new Vector3 (0f,0f,19.20206f);
		// cubo representa las puertas
		cube = GameObject.CreatePrimitive(PrimitiveType.Cube); 
		cube.transform.localScale = new Vector3 (0.0001f,1f,0.5088474f);
		cube.transform.position = new Vector3 (-0.04161697f,0.908314f,-0.330678f);
		cube.transform.eulerAngles = new Vector3 (0f,90f,0f);
		// cubo representa las puertas
		cube = GameObject.CreatePrimitive(PrimitiveType.Cube); 
		cube.transform.localScale = new Vector3 (0.0001f,1f,0.5088474f);
		cube.transform.position = new Vector3 (-0.04161699f,0.9200523f,0.7020085f);
		cube.transform.eulerAngles = new Vector3 (0f,90f,0f);
		// cubo representa capa arriba 
		cube = GameObject.CreatePrimitive(PrimitiveType.Cube); 
		cube.transform.localScale = new Vector3 (1.551363f,0.6625f,1.103316f);
		cube.transform.position = new Vector3 (0.4580485f,1.097695f,0.2062523f);
		cube.transform.eulerAngles = new Vector3 (0f,0f,0f);
		//cylinder representas las llantas adelante
		GameObject cylinder = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
		cylinder.transform.localScale = new Vector3 (0.8480469f,0.07593405f,1f);
		cylinder.transform.position = new Vector3 (-0.8121944f,0.5081124f,0.8335477f);
		cylinder.transform.eulerAngles = new Vector3 (4.645006f,270.5062f,88.75655f);
		
		//cylinder representas las llantas adelnate
		cylinder = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
		cylinder.transform.localScale = new Vector3 (0.8480469f,0.07593405f,1f);
		cylinder.transform.position = new Vector3 (-0.8252527f,0.5347831f,-0.3991807f);
		cylinder.transform.eulerAngles = new Vector3 (4.645006f,270.5062f,88.75655f);
		
		//cylinder representas las llantas atras
		cylinder = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
		cylinder.transform.localScale = new Vector3 (0.8480469f,0.07593405f,1f);
		cylinder.transform.position = new Vector3 (0.7393813f,0.5858006f,-0.3812524f);
		cylinder.transform.eulerAngles = new Vector3 (4.645006f,270.5062f,88.75655f);
		//cylinder representas las llantas atras
		cylinder = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
		cylinder.transform.localScale = new Vector3 (0.8480469f,0.07593405f,1f);
		cylinder.transform.position = new Vector3 (0.764918f,00.4997466f,0.8026705f);
		cylinder.transform.eulerAngles = new Vector3 (4.645006f,270.5062f,88.75655f);


	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log ("update");
	}
	void FixedUpdate(){
		Debug.Log ("fixedupdate");
	}
}
