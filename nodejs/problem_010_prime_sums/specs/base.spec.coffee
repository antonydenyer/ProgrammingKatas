Base = require('../build/base')

describe 'Base', ->
	it 'has get_name property', ->
		base = new Base()
		result = do base.get_name
		expect(result).toBe 'base'
