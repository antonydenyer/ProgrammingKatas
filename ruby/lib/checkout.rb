class Checkout

  def initialize(unit_prices)
    @unit_prices = unit_prices
    @total = 0
  end

  def scan(sku)
    @total += @unit_prices[sku]
  end

  def total
    @total
  end

end
