using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class SData : SingletonBehabiour<SData>
{
    [SerializeField] Test testDatas; // DataTableÀÇ µ¥ÀÌÅÍ ÅÇ Name
    public static TestData[] TestData { get { return Instance.testDatas.dataArray; } } // µ¥ÀÌÅÍ ÅÇ Name + Data
    public static TestData GetTestData(int _id)
    {
        for (int i = 0; i < TestData.Length; i++)
            if (TestData[i].ID == _id)
                return TestData[i];
        return null;
    }

    [SerializeField] Starrail starrail; // DataTableÀÇ µ¥ÀÌÅÍ ÅÇ Name
    public static StarrailData[] StarrailData { get { return Instance.starrail.dataArray; } } // µ¥ÀÌÅÍ ÅÇ Name + Data
    public static StarrailData GetStarrailWorldData(int _id)
    {
        for (int i = 0; i < StarrailData.Length; i++)
            if (StarrailData[i].ID == _id)
                return StarrailData[i];
        return null;
    }
    public static StarrailData GetStarrailRandomWorld(int _world)
    {
        List<int> worldList = new List<int>();
        for (int i = 0; i < StarrailData.Length; i++)
        {
            if (StarrailData[i].World == _world)
            {
                worldList.Add(i);
            }
        }
        if (worldList.Count == 0) return null;
        int randomValue = UnityEngine.Random.Range(0, worldList.Count);
        return StarrailData[worldList[randomValue]];
    }
}
