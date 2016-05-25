require 'checkout'

describe Checkout do
  let(:checkout){ Checkout.new() }

  it 'total is zero when basket is empty' do
    expect(checkout.total).to be 0
  end

  it 'should calculate total for single basket entry A' do
    checkout.scan('A')
    expect(checkout.total).to be 50
  end

end
