using UnityEngine;

public class Build : MonoBehaviour
{
    [SerializeField] private GameObject m_tower; //tower prefab gameobject

    private void OnMouseUpAsButton()
    {
        Instantiate(m_tower, transform.position + new Vector3(0, .5f, 0), Quaternion.identity); //spawn tower on tile that has been interacted with
    }
}
