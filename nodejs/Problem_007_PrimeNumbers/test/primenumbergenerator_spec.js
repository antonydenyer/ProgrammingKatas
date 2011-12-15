var assert = require('assert'),
	PrimeNumberGenerator = require('../lib/primenumbergenerator');

var tests = {

	'first prime should be 2': function() {
		var generator = new PrimeNumberGenerator();
		var result = generator.generate(1);
		
		assert.equal(result[0], 2);
	},
	'second prime should be 3': function() {
		var generator = new PrimeNumberGenerator();
		var result = generator.generate(2);
		
		assert.equal(result[1], 3);
	},
	'10001 prime should be 104743': function() {
		var generator = new PrimeNumberGenerator();
		var result = generator.generate(10001);

		assert.equal(result[10000], 104743);
	},
	'big prime should be 350381': function() {
		var generator = new PrimeNumberGenerator();
		var result = generator.generate(30001);

		assert.equal(result[30000], 350381);
	},
	'really big prime should be 4256249': function() {
		var generator = new PrimeNumberGenerator();
		var result = generator.generate(300001);

		assert.equal(result[300000], 4256249);
	}
	
};

	
function run() {
	for(var name in tests) {
		console.log(name);
		var before = new Date();
		tests[name]();
		console.log('Completed in %s', new Date() - before);
	}
}

run();