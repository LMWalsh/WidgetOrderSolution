using System;
using System.Collections.Generic;
using System.Text;

namespace WidgetOrderProject {
    public class SilverWidget : IProduct {
        private Product Product { get; set; }

        public double GetPrice() {
            return Product.GetPrice();
        }
        public string GetStateName() {
            return Product.GetStateName();
        }
        public string GetModelName() {
            return Product.GetModelName();
        }

        public SilverWidget() {
            Product = new Product {
                Code = "SW",
                Name = "Silver Widget",
                Model = ModelType.Silver
            };

        }
    }

}

