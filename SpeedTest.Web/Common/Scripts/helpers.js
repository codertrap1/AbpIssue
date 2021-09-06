var App = App || {};
(function () {

    var appLocalizationSource = abp.localization.getSource('SpeedTest');
    App.localize = function () {
        return appLocalizationSource.apply(this, arguments);
    };

})(App);