using Refactoring_02_Testing_Library.DTO;

namespace Refactoring_02_Testing_Library
{
    public class Producer
    {
        private Province _province;
        private int _production;

        public int Cost;

        public int Production
        {
            get
            {
                return _production;
            }
            set
            {

                int amount = value;
                _province.TotalProduction += amount - _production;
                _production = amount;
            }
        }

        public string Name { get; }


        public Producer(Province aProvince, ProducerData data)
        {
            _province = aProvince;

            Production = data.Production;
            Cost = data.Cost;
            Name = data.Name;
        }
    }
}
