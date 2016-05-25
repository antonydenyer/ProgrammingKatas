class Checkout

  def total
    return 0
  end
end


describe Checkout do
  let(:checkout){ Checkout.new }

  it 'total is zero when basket is empty' do
    expect(checkout.total).to be 0
  end

end
