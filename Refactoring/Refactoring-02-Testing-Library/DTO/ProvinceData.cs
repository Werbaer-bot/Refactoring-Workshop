namespace Refactoring_02_Testing_Library.DTO
{
    public class ProvinceData
    {
        public string Name;
        public List<ProducerData> Producers;
        public int Demand;
        public int Price;

        public static ProvinceData SampleProvinceData()
        {
            return new ProvinceData()
            {
                Name = "Europe",
                Demand = 30,
                Price = 20,
                Producers =
                [
                    new ProducerData()
                    {
                        Name = "Cologne",
                        Cost = 10,
                        Production = 9,
                    },
                    new ProducerData()
                    {
                        Name = "Amsterdam",
                        Cost = 12,
                        Production = 10,
                    },
                    new ProducerData()
                    {
                        Name = "Rome",
                        Cost = 10,
                        Production = 6,
                    }
                ]
            };
        }
    }
}
