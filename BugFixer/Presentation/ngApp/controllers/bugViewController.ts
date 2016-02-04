namespace BugFixer.Controllers {

    export class BugViewController {

        public bugs;
        public priority;
        public priorityLevels = [
            {
                name: "Critical",
                value: 1
            },
            {
                name: "High",
                value: 2
            },
            {
                name: "Medium",
                value: 3
            },
            {
                name: "Low",
               value: 4
            }
        ];

        constructor(private $http: ng.IHttpService, private $routeParams) { }

        public addBug(title, assignedUser, description, priorityLevel) {
            this.$http.post("/api/bug", {
                title: title,
                assignedUser: assignedUser,
                description: description,
                priorityLevel: priorityLevel
            })
        }
    }
}
}