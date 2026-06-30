public class Solution 
{
    public int CarFleet(int target, int[] position, int[] speed) 
    {
        List<(int pos, double time)> cars = new List<(int pos, double time)>();
        
        for(int i = 0; i < position.Length; i++)
        {
            double time = (double)(target - position[i]) / speed[i];
            cars.Add((position[i], time));
        }

        cars.Sort((a, b) => a.pos.CompareTo(b.pos));
        Stack<double> stack = new Stack<double>();

        for(int i = cars.Count - 1; i >= 0; i--)
        {
            if(stack.Count == 0 || cars[i].time > stack.Peek())
                stack.Push(cars[i].time);
        }
        return stack.Count;
    }
}
