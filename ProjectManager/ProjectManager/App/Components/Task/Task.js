var Task = function(id, name, description, estimate, priority, status, responseable, Story, message){
    this.id = id;
    this.name = name;
    this.description = description;
    this.estimate = estimate;
    this.priority = priority;
    this.stauts = status;
    this.responseable = responseable;
    this.Story = Story;
    this.createdAt = Date.now();
    this.message = message;
};