class Checkout

  def initialize(unit_prices)
    @unit_prices = unit_prices
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
      if sku == 'A'
        discount += count / 3 * 20
      end

      if sku == 'B'
        discount += count / 2 * 15
      end
    end

    @total - discount
  end

end
