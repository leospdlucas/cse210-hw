using System.Collections.Generic;
using System.Text;

public class Order {
    private List<Product> _products = new List<Product>();
    private Customer _customer;

    public Order(Customer customer) {
        _customer = customer;
    }

    public void AddProduct(Product product) {
        _products.Add(product);
    }

    public double GetTotalPrice() {
        double total = 0;

        foreach (Product p in _products) {
            total += p.GetTotalCost();
        }

        total += _customer.LivesInUSA() ? 5 : 35;
        return total;
    }

    public string GetPackingLabel() {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine("Packing Label:");

        foreach (Product p in _products) {
            sb.AppendLine(p.GetPackingLabel());
        }
        return sb.ToString();
    }

    public string GetShippingLabel() {
        return $"Shipping Label:\n{_customer.GetShippingLabel()}";
    }
}
