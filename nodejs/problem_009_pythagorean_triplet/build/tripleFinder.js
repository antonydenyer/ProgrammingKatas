(function() {
  var Triple, TripleFinder;

  Triple = require('../build/triple');

  module.exports = TripleFinder = (function() {
    function TripleFinder() {}

    TripleFinder.prototype.getProductMatching = function() {
      var a, b, triple, _i, _j;
      for (a = _i = 1; _i <= 1000; a = ++_i) {
        for (b = _j = 1; _j <= 1000; b = ++_j) {
          triple = new Triple(a, b);
          if (triple.qualifies()) {
            return triple;
          }
        }
      }
    };

    return TripleFinder;

  })();

}).call(this);
