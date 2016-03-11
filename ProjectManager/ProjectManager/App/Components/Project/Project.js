var Project = function(id, name, memberList, creator, pictureUrl, storyList, sprintList){
    this.id = id;
    this.name = name;
    this.memberList = memberList;
    this.creator = creator;
    this.pictureUrl = pictureUrl;
    this.storyList = storyList;
    this.sprints = sprintList;
    
    this.createdAt = Date.now();
};