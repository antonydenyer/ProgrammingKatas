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

    sku_count = @items.inject(Hash.new(0)) do |hash, sku|
      hash[sku] += 1
      hash
    end


    sku_count.each do | sku, count |
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
