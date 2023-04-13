using System.Collections.Generic;
using UnityEngine;

public class PlayerPrefsTest : MonoBehaviour
{
    [SerializeField] CustomEnemy enemy;

    [System.Serializable]
    class CustomEnemy {
        [SerializeField] string type;
		[SerializeField] int hp;
		[SerializeField] int atk;
		[SerializeField] List<string> skills;

		public CustomEnemy (string type, int hp,int atk) {
            this.type = type;
            this.hp = hp;
            this.atk = atk;
        }
    }

    // Start is called before the first frame update
    void Start()
    {

    }

	private void OnEnable () {
        string enemyJson = PlayerPrefs.GetString("enemy");
        enemy = JsonUtility.FromJson<CustomEnemy>(enemyJson);
	}

	private void OnDisable () {
		string enemyJson = JsonUtility.ToJson(enemy);
		PlayerPrefs.SetString("enemy", enemyJson);
	}
}
