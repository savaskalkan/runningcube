using UnityEngine;

public class playerCollision : MonoBehaviour {


    //Playerscript komponentine ulaşmak için değişken tanımlıyoruz.
    public playerscript playerscript;

    // Çarpışma olduğunda gereçekleşecek olaylar için
    private void OnCollisionEnter(Collision collisionBilgi)
    {
        // Engel etiketine sahip cisimler ile olan çarpışma gerçekleştiğinde çalışacak kod buloğu
        if (collisionBilgi.collider.tag == "Obstacle")
        {
            Debug.Log("Engel");

            // playerscript komponentini kapatıyoruz.
            // çarpışma gerçekleştikten sonra Player hareket etmeyi sürdürmesin diye bu işlemi yapıyoruz.
            playerscript.enabled = false;

            // çarpışma sonucu oyunun bitmesiyle manage scriptinde bulunan GameOver fonksiyonunu çalıştırıyoruz.
            FindObjectOfType<manage>().GameOver();
        }
    }
}
