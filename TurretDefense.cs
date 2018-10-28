using System;

public class TurretDefense
{
	public int firstMiss(int[] xs, int[] ys, int[] times)
    {
        //make sure all are the same lenght
        if (xs.Length == ys.Length && xs.Length == times.Length) //by transitiviy b = c
        {
            var currentX = 0;
            var currentY = 0;
            var currentTime = 0;
            for (var i = 0; i<xs.Length; i++)
            {
                //step 1: calculate next coordinate time to move
                var nextTime = (Math.Abs(currentX - xs[i]) + Math.Abs(currentY - ys[i]) + currentTime);
                
                if (nextTime <= times[i])
                {
                    currentTime = times[i];
                    currentX = xs[i];
                    currentY = ys[i];
                }
                else
                {
                    return i;
                }
                
            }
            return -1;
        }
        throw new ArgumentException("Arrays must have the same length."); 
    }
}
