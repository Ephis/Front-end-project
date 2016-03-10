var Story = function (id, name, description, estimat, priority, creator, status, actualTime, Project, taskList) {
    this.id = id;
    this.name = name;
    this.description = description;
    this.estimat = estimat;
    this.priority = priority;
    this.creator = creator;
    this.status = status;
    this.actualTime = actualTime;
    this.Project = Project;
    this.taskList = taskList;
    
    this.createdAt = Date.now();
};