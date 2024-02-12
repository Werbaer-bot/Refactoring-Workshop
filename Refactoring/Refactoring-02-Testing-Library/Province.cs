using Refactoring_02_Testing_Library.DTO;

namespace Refactoring_02_Testing_Library
{
    public class Province
    {
        public string Name { get; }
        public int Demand { get; set; }
        public int Price { get; }
        public List<Producer> Producers { get; }
        public int TotalProduction { get; set; }

        public Province(ProvinceData data)
        {
            Name = data.Name;
            Producers = [];
            TotalProduction = 0;
            Demand = data.Demand;
            Price = data.Price;
            data.Producers.ForEach(p => AddProducer(new Producer(this, p)));
        }

        void AddProducer(Producer arg)
        {
            Producers.Add(arg);
        }

        public int Shortfall()
        {
            return Demand - TotalProduction;
        }

        public int Profit()
        {
            return DemandValue() - DemandCost();
        }

        public int DemandCost()
        {
            int remainingDemand = Demand;
            int result = 0;
            Producers.Sort((a, b) => a.Cost - b.Cost);
            Producers.ForEach(p => 
            {
                var contribution = Math.Min(remainingDemand, p.Production);
                remainingDemand -= contribution;
                result += contribution * p.Cost;
            });
            return result;
        }

        public int DemandValue()
        {
            return SatisfiedDemand() * Price;
        }

        public int SatisfiedDemand()
        {
            return Math.Min(Demand, TotalProduction);
        }
    }
}
