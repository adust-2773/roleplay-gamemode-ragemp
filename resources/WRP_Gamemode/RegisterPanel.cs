using GTANetworkAPI;

namespace WRP_Gamemode
{
    public class RegisterPanel : Script
    {
        AccountService accounts = new AccountService();

        [RemoteEvent("OnPlayerRegisterAttempt")]
        public void RegisterAccount(Player player, string username, string password, string password2)
        {
            if (accounts.RegisterValidate(username, password, password2))
            {
                player.SendNotification($"~g~Poprawnie stworzono konto {username}!");
                player.TriggerEvent("RegisterSuccessed");
            }
            else
            {
                player.SendNotification("~r~Nieprawidłowe dane rejestracji!");
            }
        }
    }
}
