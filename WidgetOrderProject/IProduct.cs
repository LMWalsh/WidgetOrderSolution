using System;
using System.Collections.Generic;
using System.Text;

namespace WidgetOrderProject {

    public interface IProduct {

        public double GetPrice();
        public string GetModelName();
        public string GetStateName();
    }
}
