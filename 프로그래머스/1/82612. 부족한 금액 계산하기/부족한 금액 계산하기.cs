class Solution
{
    public long solution(int price, int money, int count)
    {
        long countL = count;
        long priceL = price;
        
        long sum = countL * (priceL + (priceL * countL)) / 2;
        return sum > money ? sum - money : 0;
    }
}