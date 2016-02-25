var StoryController = function () {
    var self = this;

    self.stories = [new Story(1, "ToDo", 2, 10, "Nicolai", "Marck"), new Story(2, "ToDo", 4, 8, "Marck", "Marck"), new Story(3, "ToDo", 5, 6, "Nicolai", "Nicolai"), new Story(4, "ToDo", 5, 9, "Marck", "Nicolai"), new Story(5, "ToDo", 7, 1, "Nicolai", "Alle")];

    self.addStory = function (story) {
        self.stories.push(story);
    };

    self.printStories = function () {
        var html = "";
        for (i = 0; i < self.stories.length; i++) {
            var item = self.stories[i];
            html = html + '<div ' + 'class="story-item-margin"> <div class="story-item-padding"><p class="sidebar-text">' + item.name + '</p><p>Estimat: ' + item.estimat + '</p><p>Creator: ' + item.creator + '</p> </div> </div>';
        }
        document.getElementById("story-container").innerHTML = html;
    };

}

window.onload = function() {
    var storyCtrl = new StoryController();
    storyCtrl.printStories();
}