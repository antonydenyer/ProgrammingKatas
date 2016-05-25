require 'checkout'

describe Checkout do
  UNIT_PRICES = {'A' => 50, 'B' => 30, 'C' => 20, 'D' => 15}
  DISCOUNTS = {'A' => {3 => 20}, 'B' => {2 => 15}}
  let(:checkout){ Checkout.new(UNIT_PRICES, DISCOUNTS) }

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

  it 'should apply discount for three basket entry A' do
    checkout.scan('A')
    checkout.scan('A')
    checkout.scan('A')
    expect(checkout.total).to be 130
  end

  it 'should apply discount for six basket entry A' do
    checkout.scan('A')
    checkout.scan('A')
    checkout.scan('A')
    checkout.scan('A')
    checkout.scan('A')
    checkout.scan('A')
    expect(checkout.total).to be 260
  end

  it 'should apply discount for two basket entry B' do
    checkout.scan('B')
    checkout.scan('B')
    expect(checkout.total).to be 45
  end

  it 'should apply discount for two mixed basket' do
    checkout.scan('A')
    checkout.scan('A')
    checkout.scan('A')
    checkout.scan('A')
    checkout.scan('B')
    checkout.scan('B')
    checkout.scan('B')
    checkout.scan('C')
    checkout.scan('D')
    expect(checkout.total).to be 290
  end


  it 'should apply discount for two mixed basket in any order' do
    checkout.scan('A')
    checkout.scan('B')
    checkout.scan('A')
    checkout.scan('B')
    checkout.scan('C')
    checkout.scan('D')
    checkout.scan('A')
    checkout.scan('B')
    checkout.scan('A')

    expect(checkout.total).to be 290
  end
end
