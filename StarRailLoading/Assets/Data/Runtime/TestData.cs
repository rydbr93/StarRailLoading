using UnityEngine;
using System.Collections;

///
/// !!! Machine generated code !!!
/// !!! DO NOT CHANGE Tabs to Spaces !!!
/// 
[System.Serializable]
public class TestData
{
  [SerializeField]
  int id;
  public int ID { get {return id; } set { this.id = value;} }
  
  [SerializeField]
  string kor;
  public string Kor { get {return kor; } set { this.kor = value;} }
  
  [SerializeField]
  string en;
  public string En { get {return en; } set { this.en = value;} }
  
  [SerializeField]
  string[] image = new string[0];
  public string[] Image { get {return image; } set { this.image = value;} }
  
}