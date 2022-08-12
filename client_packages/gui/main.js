let browser = mp.browsers.new('package://gui/index.html');

mp.events.add('sendRegisterDataToServer', (username, password, password2) => {
    mp.events.callRemote('OnPlayerRegisterAttempt', username, password, password2);
});

mp.events.add('sendLoginDataToServer', (username, password) => {
    mp.events.callRemote('OnPlayerLoginAttempt', username, password);
});

mp.events.add('LoginSuccessed', () => {
    loginBrowser.destroy();
    mp.gui.chat.show(true);
});

mp.events.add('NavgateToRegister', () => {
    browser = mp.browsers.new('package://gui/register.html');
});

mp.events.add('RegisterSuccessed', () => {
    browser = mp.browsers.new('package://gui/index.html');
});

