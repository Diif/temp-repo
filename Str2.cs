using Nsu.ColiseumProblem.Contracts.Cards;
using Nsu.ColiseumProblem.Contracts;
public class Str2 : ICardPickStrategy
{
  public Str2()
  {
    
  }
  public int Pick(Card[] cards)
  {
   var a = 15;
    while(a-->0)
    {
      if (cards[a].Color == CardColor.Black)
      {
        return a;
      }
    }
      
    
    return 0;
  }
}
