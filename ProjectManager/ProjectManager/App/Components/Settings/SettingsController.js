var app = angular.module('maApp');

app.controller('SettingsController', function() {
    
    window.onload = function () {
        var videoPlayer = document.querySelector('.video-container > video');
        var videoPlayPause = document.querySelector('#play');
        var newVideoPlayer = new VideoPlayer(videoPlayer, VideoPlayPause);

        videoPlayPause.addEventListener('click', function (evt) {
            newVideoPlayer.playVideo();
        });
    }

    var VideoPlayer = function (videoElement, btnPlayPause) {
        this.videoElement = videoElement;
        this.btnPlayPause = btnPlayPause;
    }

    //VideoPlayer play & pause

    VideoPlayer.prototype.togglePlay = function () {
        if (this.videoElement.paused) {
            this.videoElement.play();
            this.btnPlayPause.style.backgroundColor = "#00FF00";
        } else {
            this.videoElement.pause();
            this.btnPlayPause.style.backgroundColor = "#FF0000";
        }
    }
});