using UnityEngine;
using UnityEngine.UI; // Arayüz (UI) işlemleri yapabilmemiz için bu isim uzayını ekledik.

public class score : MonoBehaviour {

    // Player nesnesine erişmek için bu değişkeni tanımlıyoruz.
    public Transform player;
    // score text nesnesine erişmek için bu değişkeni kullanıyoruz.
    public Text gameScore;

	void Update () {

        // oyuncunun z ekseninde aldığı yol ile puanını hesaplamış oluyoruz.
        gameScore.text = player.position.z.ToString("0");

        // Başka bir yöntem
        //GameObject.Find("Score").GetComponent<Text>().text = player.position.z.ToString("0");

    }
}
