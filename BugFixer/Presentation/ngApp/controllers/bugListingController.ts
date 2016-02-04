namespace BugFixer.Controllers {

    export class BugListingController {

        public bugs;

        constructor(private $http: ng.IHttpService) {
            this.$http.get('/api/bug')
                .then((response) => {
                    this.bugs = response.data;
                });
        }
    }
}