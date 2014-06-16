(function() {
  var TripleFinder;

  TripleFinder = require('../build/tripleFinder');

  describe('Triple', function() {
    return it('should get 3,4,5 from 2', function() {
      var triple, tripleFinder;
      tripleFinder = new TripleFinder();
      triple = tripleFinder.getProductMatching();
      return console.log(triple);
    });
  });

}).call(this);
