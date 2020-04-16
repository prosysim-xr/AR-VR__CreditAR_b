using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using MiniJSON;
using UnityEngine.Networking;
using UnityEngine.UI;

public class S2_CamPlayAndToggle2 : MonoBehaviour
{


    //CUSTOM Butotn
    //public Button scan;

    //
    private Text processingText;

    private bool isSnapTaken = false;

    //
    public GameObject playCam_GameObject;

    //
    public byte[] imageData;
    public string base64String;

    void Start()
    {
        Scene currentScene = UnityEngine.SceneManagement.SceneManager.GetActiveScene();
        //currentSceneNo = UnityEngine.SceneManagement.SceneManager.GetActiveScene().buildIndex;
        if (currentScene.name == "S2_Scan")
        {
            processingText = GameObject.FindGameObjectWithTag("processing").GetComponent<Text>();
            processingText.text = "";
        }
        
        PlayCameraStart();
      
        
    }

    private void PlayCameraStart()
    {
        if (!(processingText == null))
        {
            processingText.text = "";//todo
        }
            
        Invoke("DoNothing", 1f);// todo check better solution
        UtilityHelper.InitializeCamera();
        playCam_GameObject.GetComponent<Renderer>().material.mainTexture = UtilityHelper.backCam;
        UtilityHelper.PlayCamera();
        Invoke("DoNothing", 1f);// todo rmove
    }

    private void Update()
    {
        if (UtilityHelper.backCam == null)
        {
            PlayCameraStart();
        }

        //TakeSnapshotButton();
        if (isSnapTaken)
        {
            isSnapTaken = false;
            Conversion();
        }
    }

    //CUSTOM Button
    //public void TakeSnapshotButton()
    //{
    //    Button btn = scan.GetComponent<Button>();
    //    if (btn == scan)
    //    {
    //        btn.onClick.AddListener(TakeSnapshot);
    //    }
    //}

    IEnumerator PostRequest(string url, string json)
    {
        var uwr = new UnityWebRequest(url, "POST");

        byte[] jsonToSend = new System.Text.UTF8Encoding().GetBytes(json);
        uwr.uploadHandler = (UploadHandler)new UploadHandlerRaw(jsonToSend);
        uwr.downloadHandler = (DownloadHandler)new DownloadHandlerBuffer();
        uwr.SetRequestHeader("Content-Type", "application/json");

        //Send the request then wait here until it returns
        yield return uwr.SendWebRequest();

        if (uwr.isNetworkError)
        {
            Debug.Log("Error While Sending: " + uwr.error);
        }
        else
        {
            var response = uwr.downloadHandler.text;
            //Debug.Log("Received: " + response);
            print("Received: " + response);
            print("Length" + response.Length);
            System.IO.File.WriteAllText("C:/Users/Dave_unity/Projects/webcam" + "name"+ ".txt", response);

            //response.
            if(response.Contains("REGALIA")||response.Contains("Regalia")|| response.Contains("regalia"))
            {
                var dict_response = Json.Deserialize(response) as Dictionary<string, object>;
                var text_response = ((List<object>)dict_response["responses"]);

                var text_response1 = ((Dictionary<string, object>)text_response[0]);
                var text_response2 = ((List<object>)text_response1["textAnnotations"]);
                foreach (var v in text_response2)
                {
                    var text_response3 = ((Dictionary<string, object>)v)["description"];
                    print((string)text_response3);
                }

                UtilityHelper.backCam.Stop();
                UnityEngine.SceneManagement.SceneManager.LoadScene(2);
                processingText.text = "REGALIA detected";//todo


            }
            //else if(response == null|| response==!(Contains("REGALIA")))
            else
            {
                print("please scan your card Again");
                processingText.text = "Plese Scan Your Card Again";//todo
            }
            

            //Debug.Log("deserialized: " + dict.GetType());
            //Debug.Log("dict['array'][0]: " + ((List<object>) dict["array"])[0]);
            //Debug.Log("dict['string']: " + (string) dict["string"]);
            //Debug.Log("dict['float']: " + (double) dict["float"]); // floats come out as doubles
            //Debug.Log("dict['int']: " + (long) dict["int"]); // ints come out as longs
            //((List<object>)dict["array"])[0]

        }
    }
    public void TakeSnapshot()
    {
        processingText.text = "Image Captured"; //todo
        Texture2D snap = new Texture2D(UtilityHelper.backCam.width, UtilityHelper.backCam.height);
        snap.SetPixels(UtilityHelper.backCam.GetPixels());
        snap.Apply();
        imageData = snap.EncodeToPNG();
        base64String = Convert.ToBase64String(imageData);
        Debug.Log("time taken");

        isSnapTaken = true;
        
    }

    public void Conversion()
    {
        processingText.text = "Processing"; //todo
        var j = "	{					                                                " +
                "	 \"requests\": 		                                                " +
                "	                [{													" +
                " 	                \"image\": {\"content\": \"" + base64String + "\"},	" +
                "          	        \"features\": [{\"type\": \"TEXT_DETECTION\"}]		" +
                "	                }]													" +
                "  }                                                                    ";

        print(j);
        var dict = Json.Deserialize(j) as Dictionary<string, object>;
        var str1 = Json.Serialize(dict);
        print(str1);
        StartCoroutine(PostRequest("https://vision.googleapis.com/v1/images:annotate?key=AIzaSyCqZ8RFqkD2B5kEfj0I9ISfE5C_Bvj_rfY", str1));
    }


    public void DoNothing()
    {
    }

}
