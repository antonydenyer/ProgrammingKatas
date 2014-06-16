module.exports = (grunt) ->

  grunt.initConfig

    watch:
        files: '**/*.coffee'
        tasks: ['test']

    jasmine:
      src: 'build/*.js'
      options:
        specs: 'specs/*.spec.js'

    jasmine_node:
      options:
        forceExit: true
        match: '.'
        matchall: false
        extensions: 'js'
        specNameMatcher: 'spec'
        jUnit:
          report: true
          savePath : "./build/reports/jasmine/"
          useDotNotation: true
          consolidate: true
      all: ['specs/']

    coffee:
      compile:
        expand: true
        cwd: 'src'
        src: '*.coffee'
        dest: 'build'
        ext: '.js'

      specs:
        expand: true
        cwd: 'specs'
        src: '*.coffee'
        dest: 'specs'
        ext: '.spec.js'

  grunt.loadNpmTasks('grunt-contrib-watch')
  grunt.loadNpmTasks('grunt-contrib-coffee')
  grunt.loadNpmTasks('grunt-contrib-jasmine')
  grunt.loadNpmTasks('grunt-jasmine-node')


  grunt.registerTask('test', ['coffee', 'jasmine_node'])
  grunt.registerTask('default', ['test'])