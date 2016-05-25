class Checkout

  def initialize()
    @total = 0
  end

  def scan(sku)
    @total += 50 if sku == 'A'
    @total += 30 if sku == 'B'
  end

  def total
    @total
  end

end
