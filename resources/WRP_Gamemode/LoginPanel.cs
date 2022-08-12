using GTANetworkAPI;

namespace WRP_Gamemode
{
    public class LoginPanel : Script
    {
        AccountService accounts = new AccountService();

        [RemoteEvent("OnPlayerLoginAttempt")]
        public void LoginAccount(Player player, string username, string password)
        {
            if (accounts.CheckAccountData(username, password))
            {
                player.TriggerEvent("LoginSuccessed");
                player.SendNotification($"~g~Poprawnie zalogowano na konto {username}!");
                NAPI.ClientEvent.TriggerClientEvent(player, "SetCursorVisibility", false);
                NAPI.Util.ConsoleOutput($"[W-RP] --> Gracz {username} właśnie zalogował się na serwer");
            }
            else
            {
                player.SendNotification("~r~Nieprawidłowe dane logowania!");
            }
        }
    }
}
