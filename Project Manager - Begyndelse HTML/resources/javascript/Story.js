var Story = function (id, name, description, estimat, priority, creator, status, actualTime) {
    this.id = id;
    this.name = name;
    this.description = description;
    this.estimat = estimat;
    this.priority = priority;
    this.creator = creator;
    this.createdAt;
    this.status = status;
    this.actualTime = actualTime;
};