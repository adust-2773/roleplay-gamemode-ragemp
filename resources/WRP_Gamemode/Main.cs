using GTANetworkAPI;
using System;

namespace WRP_Gamemode
{
    public class Main : Script
    {
        [ServerEvent(Event.ResourceStart)]
        public void OnResourceStart()
        {
            NAPI.Util.ConsoleOutput("[RAGE:MP] --> Egine server started...");
        }

        [ServerEvent(Event.PlayerConnected)]
        public void OnPlayerConnected(Player player)
        {
            player.SendNotification("~y~Witaj na serwerze, miłej zabawy!");
            NAPI.ClientEvent.TriggerClientEvent(player, "SetCursorVisibility", true);
        }
    }
}
