module.exports = class Prime
  primes = [2,3,5,7,11,13,17,19,23,29]
  is_prime: (number) ->
    return false if number is 1
    return true if primes.indexOf(number) >= 0
    max = Math.sqrt(number);
    i = 2
    while i <= max
      return false if number % i is 0
      i++

    primes.push(number)
    return true;
