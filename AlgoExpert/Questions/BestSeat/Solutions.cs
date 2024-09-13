namespace AlgoExpert.BestSeat;

public class Solutions
{
    public static void Run()
    {
        var result = BestSeat(new int[] { 1, 0, 1, 0, 0, 0, 1 });
        Console.WriteLine("Result: " + result);
    }
    public static int BestSeat(int[] seats)
    {
        // O(n) time | O(1) space where n is the length of the seats
        int bestSeatt = -1;
        int bestDistance = 0;

        int left =0;
        while(left < seats.Length){
            int right = left+1;
            while (right < seats.Length && seats[right] == 0){
                right++;
            }
            int availableSeats = right - left - 1;
            if(availableSeats>bestDistance){
                bestDistance = availableSeats;
                bestSeatt = (left + right)/2;
            }
            left = right;
        }
        return bestSeatt;
    }
}
