using UnityEngine;

public class InfoBehavior : MonoBehaviour{

    const float SPEED = 6f;

    [SerializeField]
    Transform SectionInfo;

    Vector3 desiredScale = Vector3.zero; //defaults to info being off

    // Update is called once per frame
    void Update()    {
        SectionInfo.localScale = Vector3.Lerp(SectionInfo.localScale, desiredScale, Time.deltaTime * SPEED);
    }

    public void OpenInfo(){
        desiredScale = Vector3.one; //turns all 3 scaling vectors to one
    }

    public void CloseInfo()
    {
        desiredScale = Vector3.zero; //turns all 3 scaling vectors to zero
    }
}
