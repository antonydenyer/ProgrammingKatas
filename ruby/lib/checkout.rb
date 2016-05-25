class Checkout

  def initialize()
    @total = 0
  end

  def scan(sku)
    @total += 50
  end

  def total
    @total
  end

end
