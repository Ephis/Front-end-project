var app = angular.module('myApp');

app.controller('SettingsController', function() {
    
    window.onload = function () {
        var videoPlayer = document.querySelector('.video-container > video');
        var videoPlayPause = document.querySelector('#play');
        var newVideoPlayer = new VideoPlayer(videoPlayer, videoPlayPause);

        videoPlayPause.addEventListener('click', function (evt) {
            newVideoPlayer.playVideo();
        });
    }

    var VideoPlayer = function (videoElement, btnPlayPause) {
        this.videoElement = videoElement;
        this.btnPlayPause = btnPlayPause;
    }

    //VideoPlayer play & pause

    VideoPlayer.prototype.playVideo = function () {
        if (this.videoElement.paused) {
            this.videoElement.play();
            this.btnPlayPause.style.backgroundColor = "#00FF00";
        } else {
            this.videoElement.pause();
            this.btnPlayPause.style.backgroundColor = "#FF0000";
        }
    }

    //Geolocation

    var x = document.getElementById("demo");

    function getLocation() {
        if (navigator.geolocation) {
            navigator.geolocation.getCurrentPosition(showPosition, showError);
        } else {
            x.innerHTML = "Geolocation is not supported by this browser.";
        }
    }

    function showPosition(position) {
        var latlon = position.coords.latitude + "," + position.coords.longitude;

        var img_url = "http://maps.googleapis.com/maps/api/staticmap?center="
        + latlon + "&zoom=14&size=400x300&sensor=false";
        document.getElementById("mapholder").innerHTML = "<img src='" + img_url + "'>";
    }

    function showError(error) {
        switch (error.code) {
            case error.PERMISSION_DENIED:
                x.innerHTML = "User denied the request for Geolocation."
                break;
            case error.POSITION_UNAVAILABLE:
                x.innerHTML = "Location information is unavailable."
                break;
            case error.TIMEOUT:
                x.innerHTML = "The request to get user location timed out."
                break;
            case error.UNKNOWN_ERROR:
                x.innerHTML = "An unknown error occurred."
                break;
        }
    }
});