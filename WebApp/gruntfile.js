/*
This file in the main entry point for defining grunt tasks and using grunt plugins.
Click here to learn more. http://go.microsoft.com/fwlink/?LinkID=513275&clcid=0x409
*/
module.exports = function (grunt) {
    grunt.initConfig({
        pkg: grunt.file.readJSON('package.json'),

        concat: {
            js: {
                options: {
                    separator: ';'
                },
                src: [
                    'Scripts/app.js',
                    'Scripts/services/**/*.js',
                    'Scripts/controllers/**/*.js',
                    'Scripts/components/*/*.js',
                    'Scripts/components/**/*.js',
                ],
                dest: 'dist/<%= pkg.name %>.js'
            },
        },
        uglify: {
            dist: {
                files: {
                    'dist/<%= pkg.name %>.min.js': ['<%= concat.js.dest %>'] // take the output of the concat task and minify it
                }
            }
        },
        watch: {
            dev: {
                files: ['gruntfile.js', 'Scripts/**/*.js'],
                tasks: ['concat:js', 'uglify'],
                options: {
                    atBegin: true
                }
            }
        }
    });

    grunt.loadNpmTasks('grunt-contrib-concat');
    grunt.loadNpmTasks('grunt-contrib-uglify');
    grunt.loadNpmTasks('grunt-contrib-watch');

    grunt.registerTask('dev', ['watch:dev']);
};