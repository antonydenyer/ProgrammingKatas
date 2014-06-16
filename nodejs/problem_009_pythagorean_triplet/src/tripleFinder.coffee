Triple = require('../build/triple')

module.exports = class TripleFinder
  getProductMatching: ->
    for a in [1..1000]
      for b in [1..1000]
        triple = new Triple(a,b)
        if triple.qualifies()
          return triple

