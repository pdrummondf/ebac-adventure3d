using Ebac.Core.Singleton;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : Singleton<UIManager>
{
    [SerializeField] private Image _bulletCount;

    public void UpdateBulletCount(float fill)
    {
        _bulletCount.fillAmount = 1f - fill;
    }

    public void UpdateBulletCount(float max, float min)
    {
        _bulletCount.fillAmount = min / max;
    }
}
