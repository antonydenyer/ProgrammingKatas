Prime = require('../build/prime')

describe 'Prime', ->
  prime = new Prime()
  it '1 is not prime', ->
    expect(prime.is_prime(1)).toBe false

  it '2 is prime', ->
    expect(prime.is_prime(2)).toBe true

  it '3 is prime', ->
    expect(prime.is_prime(3)).toBe true

  it '4 is not prime', ->
    expect(prime.is_prime(4)).toBe false

  it '5 is prime', ->
    expect(prime.is_prime(5)).toBe true


  it 'adds them all up', ->
    total = 0
    for number in [1..2000000] when prime.is_prime(number)
      total += number

    console.log total
