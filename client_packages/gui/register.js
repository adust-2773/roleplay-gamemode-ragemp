function getAccountData() {
    let username = document.querySelector('#username').value;
    let password = document.querySelector('#password').value;
    let password2 = document.querySelector('#password2').value;
    mp.trigger('sendRegisterDataToServer', username, password, password2);
}