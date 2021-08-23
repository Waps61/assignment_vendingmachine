/* Copyright © 2021 Gain Automation Technology
* This class handles the gripping and releasing of a product.
* This object lives in the device layer.
*/
namespace assigment_vendingmachine
{
  class Gripper
  {
    private enum ACTION { OPEN = 1, CLOSE = 0, RELEASE = 2 };
    private static Motor motorX = new Motor();
    private static Motor motorY = new Motor();
    public Gripper()
    {
    }

    private bool action(ACTION i_action)
    {
      // do whatever the gripper can do here
      switch (i_action)
      {
        case ACTION.OPEN:
          break;
        case ACTION.CLOSE:
          break;
        case ACTION.RELEASE:
          break;
        default:
          break;

      }
      return true;
    }
    public bool fetchProduct(int row, int col)
    {
      action(ACTION.OPEN);
      motorX.move(col);
      motorY.move(row);
      action(ACTION.CLOSE);
      return true;
    }
    public bool releaseProduct(int row, int col)
    {

      motorX.move(col);
      motorY.move(row);
      action(ACTION.RELEASE);
      return true;
    }
  }
}