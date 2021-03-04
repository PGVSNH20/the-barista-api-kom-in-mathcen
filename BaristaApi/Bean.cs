using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaristaApi
{
    public class Bean
    {

        //public Beans beanType;
        public BeanTypes beanType;
        public int Amount { get; set; }

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


        //public Bean(Beans beanType)
        //{
        //   this.beanType = beanType;
        //}

        //public Bean(BeanTypes beanType)
        //{
         //   this.beanType = beanType;
        //}
    }
}
