/* Copyright © 2021 Gain Automation Technology
* This class handles the product dispence process when a payment is validated.
* This object lives in the control layer.
*/
namespace assigment_vendingmachine
{
  public class Dispencer
  {


    private static Gripper myGripper = new Gripper();
    public Dispencer()
    {


    }


    public bool fetchProduct(int[,] i_position)
    {
      bool status = false;
      if (myGripper.fetchProduct(i_position[0,0], i_position[0,1]))
      {
        if (myGripper.releaseProduct(-1, -1))
        {
          status = true;
        }
      }
      return status;
    }
  }
}