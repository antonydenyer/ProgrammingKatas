class Checkout

  def initialize(unit_prices)
    @unit_prices = unit_prices
    @total = 0
    @items = []
  end

  def scan(sku)
    @items << sku
    @total += @unit_prices[sku]
  end

  def total
    discount = 0
    if @items.count{|item| item == 'A'} == 3
      discount = 20
    end
    @total - discount
  end

end
