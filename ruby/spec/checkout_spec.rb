require 'checkout'

describe Checkout do
  let(:checkout){ Checkout.new({'A' => 50, 'B' => 30, 'C' => 20, 'D' => 15}) }

  it 'total is zero when basket is empty' do
    expect(checkout.total).to be 0
  end

  it 'should calculate total for single basket entry A' do
    checkout.scan('A')
    expect(checkout.total).to be 50
  end


  it 'should calculate total for single basket entry B' do
    checkout.scan('B')
    expect(checkout.total).to be 30
  end

  it 'should calculate total for multiple basket entries' do
    checkout.scan('A')
    checkout.scan('B')
    checkout.scan('C')
    checkout.scan('D')
    expect(checkout.total).to be 115
  end

end
