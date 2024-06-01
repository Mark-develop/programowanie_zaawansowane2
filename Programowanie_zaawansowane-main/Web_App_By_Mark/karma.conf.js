module.exports = function(config){
    config.set({
        frameworks: ['jasmine'],
        files: ['src\app\components\login\login.component.ts', '*.ts', '*.spec.ts'],
        plugins: ['karma-jasmine'],
        reporters: ['dots'],
        color: true,
        singleRun: true
    });
};