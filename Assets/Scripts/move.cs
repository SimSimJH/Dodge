
using UnityEngine;


public class move : MonoBehaviour {

    public float speed = 10;
    public DirPad dirPad;
    public HP playerHP;

    void Update()//매 프레임마다 바뀌는것
    {
        if (0<playerHP.hp)
        {
            if (dirPad.dragging)
            {
                var dn = dirPad.dir.normalized * Time.deltaTime * speed;
                transform.Translate(new Vector3(dn.x, 0, dn.y));
            }
            else
            {
                var dx = Input.GetAxis("Horizontal") * Time.deltaTime * speed;//Time.deltaTime * speed는 속도 일정하게 하기위한것 
                var dy = Input.GetAxis("Vertical") * Time.deltaTime * speed;
                transform.Translate(new Vector3(dx, 0, dy));
            }
        }

    }
}

