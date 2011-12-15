function PrimeNumberGenerator() {
}


/* Generate prime numbers
 *
 * @return {Array} list of prime numbers
 */
PrimeNumberGenerator.prototype.generate = function generate(numberToGenerate) {
	var list = [2];
	var numberToTest = 3;
	
	while(list.length < numberToGenerate){
		if(this.isPrime(numberToTest)){
			list.push(numberToTest);
		}
		numberToTest += 2;
	}
	
	return list;
};

PrimeNumberGenerator.prototype.isPrime = function isPrime(numberToTest){
	var remainder,
		testRange = Math.floor(Math.sqrt(numberToTest));

	for (var i = testRange; i > 1; i--) {
		remainder = numberToTest % i;
		if (remainder === 0) {
			return false;
		}
	}
	return true;
};


module.exports = PrimeNumberGenerator;