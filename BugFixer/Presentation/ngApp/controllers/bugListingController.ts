namespace BugFixer.Controllers {

    export class BugListingController {

        public bugs;

        constructor(private $http: ng.IHttpService) {
            this.$http.get('/api/bug')
                .then((response) => {
                    this.bugs = response.data;
                });

        }
        public buggyFix(id) {
            this.$http.get(`/api/bug/resolve/${id}`)
                .then((response) => {
                    this.bugs = response.data;
                });

        }
    }
}