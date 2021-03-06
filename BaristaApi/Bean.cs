
namespace BaristaApi
{
    public class Bean
    {

        //public Beans beanType;
        public BeanTypes beanType;
        public int BeanAmount { get; set; }

        //public int amount;

        public enum BeanTypes
        {
            Zoega,
            Lavazza,
            Rozza,
            DeLuxe,
            Gimoka,
            Starbucks,
            Gevalia,
            IcaBasic
        }

        public Bean(BeanTypes bean)
        {
            beanType = bean;
        }

    }
}
