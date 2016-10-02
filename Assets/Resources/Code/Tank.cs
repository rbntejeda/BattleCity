using UnityEngine;
using System.Collections;

public class Tank : MonoBehaviour {
	public enum _tipo{Basico,Movimiento,Ataque,Velocidad,Defensa,Reforzado,Boss1,Boss2,Boss3,Soldado,Comandante,Kamikase};
	int _HP;
	public int _HP_MAX;
	int _DEF;
	int _ATK;
	int _ATK_MAX;
	int _vATK;
	int _vMOV;

//	void Start () {
//		
//	}
//	void Update () {
//	
//	}


	public int HP{ get { return _HP; } set { _HP = RestMAP (_HP, value, _HP_MAX); } }
	public int DEF{ get { return _DEF; } set { _DEF = RestMAP (_DEF, value, 100); } }
	public int ATK{ get { return _ATK; } set { _ATK = RestMAP (_ATK, value, _ATK_MAX); } }
	public int vATK{ get { return _vATK; } set { _vATK = RestMAP (_vATK, value, 5); } }
	public int vMOV{ get { return _vMOV; } set { _vMOV = RestMAP (_vMOV, value, 5); } }

	public bool Muerto{ get { return (_HP == 0); } }
	public int Heart{ get { return ((_HP / _HP_MAX) * 10); } }

	public Tank(){
		_HP = 100;
		_HP_MAX = 100;
		_DEF = 0;
		_ATK = 10;
		_ATK_MAX = 20;
		_vATK = 1;
		_vMOV = 1;
	}

	public Tank(_tipo tipo){		
		_HP = 100;
		_HP_MAX = 100;
		_DEF = 0;
		_ATK = 10;
		_ATK_MAX = 20;
		_vATK = 1;
		_vMOV = 1;
		switch (tipo) {
		case _tipo.Ataque:
			_ATK = 20;
			_ATK_MAX = 40;
			break;		
		case _tipo.Movimiento:
			_ATK = 15;
			_ATK_MAX = 30;
			vMOV = 2;
			break;		
		case _tipo.Velocidad:
			_ATK = 15;
			_ATK_MAX = 30;
			vATK = 2;
			break;		
		case _tipo.Defensa:
			_HP = 200;
			_HP_MAX = 200;
			_DEF = 100;
			break;		
		case _tipo.Reforzado:
			_HP = 200;
			_HP_MAX = 200;
			_ATK=20;
			_ATK_MAX = 50;
			_vMOV=2;
			_vATK=2;
			_DEF = 50;
			break;		
		case _tipo.Comandante:
			_HP = 200;
			_HP_MAX = 200;
			_ATK=15;
			_ATK_MAX = 15;
			_vMOV=2;
			_DEF = 10;
			break;			
		case _tipo.Kamikase:
			_HP = 50;
			_HP_MAX = 50;
			_ATK=80;
			_ATK_MAX = 80;
			_vMOV=2;
			_DEF = 10;
			break;		
		case _tipo.Boss1:
			_HP = 500;
			_HP_MAX = 500;
			_ATK=25;
			_ATK_MAX = 25;
			_vMOV=2;
			_vATK=2;
			break;		
		case _tipo.Boss2:
			_HP = 1200;
			_HP_MAX = 1200;
			_ATK=30;
			_ATK_MAX = 30;
			_vMOV=2;
			_vATK=3;
			break;
		case _tipo.Boss3:
			_HP = 3000;
			_HP_MAX = 3000;
			_ATK=50;
			_ATK_MAX = 100;
			_vMOV=3;
			_vATK=2;
		break;
	}
			
	}




	public int RestMAP (int item, int sum, int max){
		int suma = item + sum;
		if (suma <= 0)
			return 0;
		if (suma >= max)
			return max;
		return suma;
	}
}
