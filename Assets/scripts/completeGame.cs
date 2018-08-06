using UnityEngine;
public class completeGame : MonoBehaviour {

    // oyun kontrollerini yaptığımız manage scriptine ulaşmak için o türden bir değişken oluşturuyoruz.
    public manage gameManager;

    private void OnTriggerEnter(Collider other)
    {
        // manage scriptinde bulunan CompleteGame fonksiyonu çalıştırıyoruz.
        gameManager.CompleteGame();
    }
}
