(function() {
  var Base;

  Base = require('../build/base');

  describe('Base', function() {
    return it('has get_name property', function() {
      var base, result;
      base = new Base();
      result = base.get_name();
      return expect(result).toBe('base');
    });
  });

}).call(this);
