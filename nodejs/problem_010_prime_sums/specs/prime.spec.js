(function() {
  var Prime;

  Prime = require('../build/prime');

  describe('Prime', function() {
    var prime;
    prime = new Prime();
    it('1 is not prime', function() {
      return expect(prime.is_prime(1)).toBe(false);
    });
    it('2 is prime', function() {
      return expect(prime.is_prime(2)).toBe(true);
    });
    it('3 is prime', function() {
      return expect(prime.is_prime(3)).toBe(true);
    });
    it('4 is not prime', function() {
      return expect(prime.is_prime(4)).toBe(false);
    });
    it('5 is prime', function() {
      return expect(prime.is_prime(5)).toBe(true);
    });
    return it('adds them all up', function() {
      var number, total, _i;
      total = 0;
      for (number = _i = 1; _i <= 2000000; number = ++_i) {
        if (prime.is_prime(number)) {
          total += number;
        }
      }
      return console.log(total);
    });
  });

}).call(this);
