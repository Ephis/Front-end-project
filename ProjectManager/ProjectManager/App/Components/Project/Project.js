var Project = function(id, name, memberList, creator, pictureUrl, storyList){
    this.id = id;
    this.name = name;
    this.memberList = memberList;
    this.creator = creator;
    this.pictureUrl = pictureUrl;
    this.storyList = storyList;
    
    this.createdAt = Date.now();
};