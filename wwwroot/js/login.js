

const loginForm = document.getElementById("loginForm");
console.log(loginForm);
loginForm?.addEventListener("submit", function (event) {
        event.preventDefault();
        const email = document.getElementById("email");
         const password = document.getElementById("password");
    if (email !== null && password !== null) {
                let input = {
                        email: email.value,
                        password : password.value,
                };

                axios.post('/api/auth/login', input)
                .then(() => window.location.assign('/'))
                .catch(function (error) {
                        console.log(error);
                });
        }
});