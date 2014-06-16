(function() {
  var Prime;

  module.exports = Prime = (function() {
    var primes;

    function Prime() {}

    primes = [2, 3, 5, 7, 11, 13, 17, 19, 23, 29];

    Prime.prototype.is_prime = function(number) {
      var i, max;
      if (number === 1) {
        return false;
      }
      if (primes.indexOf(number) >= 0) {
        return true;
      }
      max = Math.sqrt(number);
      i = 2;
      while (i <= max) {
        if (number % i === 0) {
          return false;
        }
        i++;
      }
      primes.push(number);
      return true;
    };

    return Prime;

  })();

}).call(this);
