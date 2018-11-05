using UnityEngine;
using UnityEngine.UI;

public class BoxManager : MonoBehaviour
{
    #region DEFAULT STATUS
    public bool check_Item;
    public static string name_Item_Box;
    #endregion

    #region COLLISIONS
    void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.collider.tag == "Item0" || collision.collider.tag == "Item1" || collision.collider.tag == "Item2" || collision.collider.tag == "Item3")
        {
            // name item box receive the sprite name of item
            name_Item_Box = collision.collider.gameObject.GetComponent<Image>().sprite.name;

            // if name item box = name item
            if (name_Item_Box == ItemManager.name_Item)
            {
                gameObject.SetActive(false);
                ItemManager.check_Box = true;
            }
            else
            {
                ItemManager.check_Box = false;
            }
        }
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        name_Item_Box = "";
    }
    #endregion
}