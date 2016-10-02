using UnityEngine;
using System.Collections;

public class tankMotion : MonoBehaviour {
	public enum direccion{arriba,abajo,izquierda,derecha};
	public bool axis=true;
	// Use this for initialization
	public float velocidad=1;
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (axis) {
			axisMove ();
		}
	}
	public void axisMove(){
		float v = Input.GetAxis ("Vertical");
		float h = Input.GetAxis ("Horizontal");
		if (v != h) {
			if (Mathf.Abs(v) > Mathf.Abs(h)) {
				if (v > 0) {
					mueve (direccion.arriba);
				} else {

					mueve (direccion.abajo);
				}
			}else {
				if (h > 0) {
					mueve (direccion.derecha);
				} else {
					mueve (direccion.izquierda);
				}
			}
		} 

	}
	public bool mueve(direccion d){
		switch (d) {
		case direccion.arriba:
			this.transform.position += Vector3.up * Time.deltaTime * velocidad;
			break;
		case direccion.abajo:
			this.transform.position += Vector3.down * Time.deltaTime * velocidad;
			break;
		case direccion.izquierda:
			this.transform.position += Vector3.left * Time.deltaTime * velocidad;
			break;
		case direccion.derecha:
			this.transform.position += Vector3.right * Time.deltaTime * velocidad;
			break;
		}
		return true;
	}
}
