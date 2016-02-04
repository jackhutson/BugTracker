namespace BugFixer.Controllers {

    export class BugViewController {

        public bugs;
        public severity;
        public users;
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

        constructor(private $http: ng.IHttpService, private $routeParams) {
            $http.get('/api/users')
                .then((response) => {
                this.users = response.data;
            });

        }

        public addBug(title, assignedUser, description, severity) {
            this.$http.post("/api/bug", {
                title: title,
                assignedUser: assignedUser,
                description: description,
                severity: severity
            })
        }
    }
}