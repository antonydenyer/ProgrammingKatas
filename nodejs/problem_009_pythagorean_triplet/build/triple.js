(function() {
  var Triple;

  module.exports = Triple = (function() {
    function Triple(a, b) {
      this.a = a;
      this.b = b;
      this.c = Math.pow(Math.pow(this.a, 2) + Math.pow(this.b, 2), 0.5);
      this.product = this.a * this.b * this.c;
    }

    Triple.prototype.sum_one_thousand = function() {
      return this.a + this.b + this.c === 1000;
    };

    Triple.prototype.makes_triplet = function() {
      return this.c % 1 === 0;
    };

    Triple.prototype.qualifies = function() {
      return this.sum_one_thousand() && this.makes_triplet();
    };

    return Triple;

  })();

}).call(this);
