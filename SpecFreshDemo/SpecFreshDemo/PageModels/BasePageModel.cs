using System;
using System.Collections.Generic;
using System.Text;

namespace SpecFreshDemo.PageModels
{
    public class BasePageModel : FreshMvvm.FreshBasePageModel
    {
        public override void Init(object initData)
        {
            base.Init(initData);
        }

        public override void ReverseInit(object returnedData)
        {
            base.ReverseInit(returnedData);
        }
        
    }
}
