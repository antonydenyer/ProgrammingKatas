TripleFinder = require('../build/tripleFinder')

describe 'Triple', ->
  it 'should get 3,4,5 from 2', ->
    tripleFinder = new TripleFinder()
    triple = tripleFinder.getProductMatching()
    console.log(triple)

