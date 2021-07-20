using UnityEngine;

public class CameraFollows : MonoBehaviour
{
    private GameObject Characters;
    [SerializeField] private Vector3 defaultCamToCharactersPositionDifference;

    private void Awake()
    {
        Characters = GameObject.FindGameObjectWithTag("SplineMoveObject");
        defaultCamToCharactersPositionDifference = transform.position - Characters.transform.position;
    }

    void Update()
    {
        transform.position = Characters.transform.position - defaultCamToCharactersPositionDifference;
    }
}
