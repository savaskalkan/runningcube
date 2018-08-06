using UnityEngine;

public class followPlayer : MonoBehaviour {

	public Transform Player;

    public Vector3 offset;

    void Update()
    {
        //Kamera x,y ve z eksenlerinde takip ediyor.
        transform.position = Player.position + offset;

        //Alternatif olarak Kamera yalnızca z ekseninde takip ediyor.
        //transform.position = new Vector3(transform.position.x,transform.position.y ,Player.position.z+offset.z);
    }
}
