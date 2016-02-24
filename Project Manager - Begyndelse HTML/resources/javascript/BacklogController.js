var BacklogController = function () {
    var self = this;

    self.backlogItems = [new BacklogItem(1, "ToDo", 2, 10, "Nicolai", "Marck"), new BacklogItem(2, "ToDo", 4, 8, "Marck", "Marck"), new BacklogItem(3, "ToDo", 5, 6, "Nicolai", "Nicolai"), new BacklogItem(4, "ToDo", 5, 9, "Marck", "Nicolai"), new BacklogItem(5, "ToDo", 7, 1, "Nicolai", "Alle")];

    self.addBacklogItem = function (backlogItem) {
        self.backlogItems.push(backlogItem);
    };

    self.printBacklogItems = function () {
        var html = "";
        for (i = 0; i < self.backlogItems.length; i++) {
            var item = self.backlogItems[i];
            html = html + '<div ' + 'class="backlog-item-margin"> <div class="backlog-item-padding"><p class="sidebar-text">' + item.title + '</p> <p>Responseble: '  + item.responseble + '</p> <p>Estimat: ' + item.estimat + '</p><p>Creator: ' + item.creator + '</p> </div> </div>';
        }
        document.getElementById("backlog-container").innerHTML = html;
    };

}

window.onload = function() {
    var backlogCtr = new BacklogController();
    backlogCtr.printBacklogItems();
}