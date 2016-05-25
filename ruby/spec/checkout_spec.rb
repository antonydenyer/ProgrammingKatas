require 'checkout'

describe Checkout do
  let(:checkout){ Checkout.new }

  it 'total is zero when basket is empty' do
    expect(checkout.total).to be 0
  end

end
