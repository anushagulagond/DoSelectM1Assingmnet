using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoSelectM1Assingmnet
{
    interface IBroadbandPlan
    {
        int GetBroadbandPlanAmount();
    }
    class Black : IBroadbandPlan
    {
        private readonly bool _isSubscriptionValid;
        private readonly int _discountPercentage;
        private const int PlanAmount = 3000;
        public Black(bool isSubscriptionValid,int discountPercentage)
        {
            if (_discountPercentage<0 || _discountPercentage>50)
            {
                throw new ArgumentOutOfRangeException();
            }
            else
            {
                _isSubscriptionValid = isSubscriptionValid;
                _discountPercentage = discountPercentage;
            }

        }
        public int GetBroadbandPlanAmount()
        {
            if (_isSubscriptionValid)
            {
                return PlanAmount - (PlanAmount * _discountPercentage / 100);
            }
            return PlanAmount;
        }
    }
    class Gold : IBroadbandPlan
    {
        private readonly bool _isSubscriptionValid;
        private readonly int _discountPercentage;
        private const int PlanAmount = 1500;
        public Gold(bool isSubscriptionValid, int discountPercentage)
        {
            if (_discountPercentage < 0 || _discountPercentage > 30)
            {
                throw new ArgumentOutOfRangeException();
            }
            else
            {
                _isSubscriptionValid = isSubscriptionValid;
                _discountPercentage = discountPercentage;
            }
        }
        public int GetBroadbandPlanAmount()
        {
            if (_isSubscriptionValid)
            {
                return PlanAmount - (PlanAmount * _discountPercentage / 100);
            }
            return PlanAmount;
        }
    }
    class SubscribePlan
    {
        private IList<IBroadbandPlan> _broadbandPlans;
    
        public SubscribePlan(IList<IBroadbandPlan> broadbandPlans)
        {
            if (broadbandPlans==null)
            {
                throw new ArgumentNullException();
            }
            else
            {
                _broadbandPlans = broadbandPlans;
            }
           
        }
        public IList<Tuple<string,int>> GetSubscriptionPlan()
        {
            if (_broadbandPlans == null)
            {
                throw new ArgumentNullException();
            }
            IList<Tuple<string,int>> list= new List<Tuple<string,int>>();
            foreach(var item in _broadbandPlans)
            {
                if(item is Black)
                {
                    list.Add(Tuple.Create("Black", item.GetBroadbandPlanAmount()));
                }
                else
                {
                    list.Add(Tuple.Create("Gold", item.GetBroadbandPlanAmount()));
                }
            }
            return list;
        }
    }
    internal class Program4
    {
        public static void Main(string[] args)
        {
            var plans = new List<IBroadbandPlan>
            {
                new Black(true,50),
                new Black(false,10),
                new Gold(true,30),
                new Black(true,20),
                new Gold(false,20)
            };
            var subscriptionPlans = new SubscribePlan(plans);
            var result=subscriptionPlans.GetSubscriptionPlan();
            foreach (var item in result)
            {
                Console.WriteLine(item.Item1+" "+item.Item2);
            }

        }
    }
}
