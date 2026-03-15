using UnityEngine;

public class StartHereManager : MonoBehaviour
{
    private string player_uuid;
    const string STARTHERE_UUID_KEY = "startHereUUID";
    private void Awake()
    {
        if (!PlayerPrefs.HasKey(STARTHERE_UUID_KEY))
        {
            PlayerPrefs.SetString(STARTHERE_UUID_KEY, System.Guid.NewGuid().ToString());
        }

        player_uuid = PlayerPrefs.GetString(STARTHERE_UUID_KEY);
    }

    public string GetUUID()
    {
        return this.player_uuid;
    }
}

