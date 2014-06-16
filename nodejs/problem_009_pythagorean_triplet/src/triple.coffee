module.exports = class Triple
  constructor: (@a,@b) ->
    @c = (@a**2 + @b**2)**0.5
    @product = @a * @b * @c

  sum_one_thousand: ->
    @a + @b + @c == 1000

  makes_triplet: ->
    @c % 1 == 0

  qualifies: ->
    this.sum_one_thousand() && this.makes_triplet()
