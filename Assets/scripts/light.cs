﻿using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Renderer))]
public class light : MonoBehaviour
{
    private Renderer _renderer;

    // Use this for initialization
    void Start()
    {
        _renderer = GetComponent<Renderer>();
        StartCoroutine(BlinkerCoroutine());
    }

    IEnumerator BlinkerCoroutine()
    {
        //こちらは動く例
        //変更前のマテリアルのコピーを保存
        var originalMaterial = new Material(_renderer.material);
        while(true)
        {
            _renderer.material.EnableKeyword("_EMISSION"); //キーワードの有効化を忘れずに
            _renderer.material.SetColor("_EmissionColor", new Color(1, 1, 1)); //赤色に光らせる


            yield return new WaitForSeconds(1.0f); //1秒待って
            _renderer.material = originalMaterial; //元に戻す
            yield return new WaitForSeconds(1.0f); //また1秒待ってくりかえし
        }
    }
}