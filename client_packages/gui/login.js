function getAccountData() {
    let username = document.querySelector('#username').value;
    let password = document.querySelector('#password').value;
    mp.trigger('sendLoginDataToServer', username, password);
}

function NavgateToRegister() {
    mp.trigger('NavgateToRegister');
}