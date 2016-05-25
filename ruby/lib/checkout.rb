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
    discount_multiple = @items.count{|item| item == 'A'} / 3
    discount = discount_multiple * 20

    discount_multiple = @items.count{|item| item == 'B'} / 2
    discount += discount_multiple * 15


    @total - discount
  end

end
