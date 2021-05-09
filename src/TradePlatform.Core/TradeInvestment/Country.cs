using System.Reflection.Metadata;
using Abp.Domain.Entities;

namespace TradePlatform.Core.TradeInvestment
{
    public class Country : Entity<int>
    {
        public string Name { get; set; }
        public Country(string name)
        {
            Name = name;
        }
          
    }
}