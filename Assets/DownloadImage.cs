using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class DownloadImage : MonoBehaviour
{
    public RawImage image1;


    void Start()
    {
        //�������� ������� �����������
        string url1 = "http://data.ikppbb.com/test-task-unity-data/pics/1.jpg";
        WWW www1 = new WWW(url1);
        yield return www1;
        image1.texture = www1.texture;


    }
}
// ������� ������ �������, ������� ����� �����������

// ������� ����� ������ �� ����� � ������ ��� �������

// ��������� ����� ������ � �������� ��������