using UnityEngine;

public class Food : MonoBehaviour {
  public float location_y;
  private int location_x, location_z;

private void ResetFoodPos() {
    // 通过随机数，生成随机的位置坐标
    System.Random random = new();
    location_x= random.Next(-5, 5);
    location_z= random.Next(-5, 5);

    transform.position= new Vector3(
    location_x, location_y, location_z
 );
  }

  void Start() {
    ResetFoodPos();
  }
}
