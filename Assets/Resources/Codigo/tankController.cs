using UnityEngine;
using System.Collections;

public class tankController : MonoBehaviour {
	public int _tipo;
	[Range(0,1000)]public int _HP;
	public int _HP_MAX;
	[Range(0,100)]public int _DEF;
	[Range(0,1000)]public int _ATK;
	[Range(0,1000)]public int _ATK_MAX;
	[Range(0,5)]public int _vATK;
	[Range(0,5)]public int _vMOV;
//	void Start () {
//		
//	}
//	void Update () {
//	
//	}
	public int HP{get{return _HP;}set{_HP = RestMAP (_HP, value, _HP_MAX);}}	
	public int DEF{get{return _DEF;}set{_DEF = RestMAP (_DEF, value, 100);}}
	public int ATK{get{return _ATK;}set{_ATK = RestMAP (_ATK, value, _ATK_MAX);}}

	public int RestMAP (int item, int sum, int max){
		int suma = item + sum;
		if (suma <= 0)
			return 0;
		if (suma >= max)
			return max;
		return suma;
	}
}
