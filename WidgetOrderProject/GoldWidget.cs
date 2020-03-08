using System;
using System.Collections.Generic;
using System.Text;

namespace WidgetOrderProject {
    public class GoldWidget : Product, IProduct {
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

        public GoldWidget() {
            Product = new Product {
                Code = "GD",
                Name = "Gold Widget",
                Model = ModelType.Gold
            };
        }
    }
}

