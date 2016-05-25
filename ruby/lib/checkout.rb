class Checkout

  def initialize(unit_prices, discounts)
    @unit_prices = unit_prices
    @discounts = discounts
    @total = 0
    @sku_count = Hash.new(0)
  end

  def scan(sku)
    @sku_count[sku] += 1
    @total += @unit_prices[sku]
  end

  def total
    discount = 0

    @sku_count.each do | sku, count |
      if @discounts.has_key?(sku)
        discount_quanity = @discounts[sku].first[0]
        discount_amount = @discounts[sku].first[1]

        discount += count / discount_quanity * discount_amount
      end
    end

    @total - discount
  end

end
