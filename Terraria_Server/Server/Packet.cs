﻿namespace Terraria_Server
{
	public enum Packet : int
	{
		CONNECTION_REQUEST = 1,
		DISCONNECT = 2,
		CONNECTION_RESPONSE = 3,
		PLAYER_DATA = 4,
		INVENTORY_DATA = 5,
		WORLD_REQUEST = 6,
		WORLD_DATA = 7,
		REQUEST_TILE_BLOCK = 8,
		SEND_TILE_LOADING = 9,
		SEND_TILE_ROW = 10,
		SEND_TILE_CONFIRM = 11,
		RECEIVING_PLAYER_JOINED = 12,
		PLAYER_STATE_UPDATE = 13,
		SYNCH_BEGIN = 14,
		UPDATE_PLAYERS = 15,
		PLAYER_HEALTH_UPDATE = 16,
		TILE_BREAK = 17,
		TIME_SUN_MOON_UPDATE = 18,
		DOOR_UPDATE = 19,
		TILE_SQUARE = 20,
		ITEM_INFO = 21,
		ITEM_OWNER_INFO = 22,
		NPC_INFO = 23,
		STRIKE_NPC = 24,
		PLAYER_CHAT = 25,
		STRIKE_PLAYER = 26,
		PROJECTILE = 27,
		DAMAGE_NPC = 28,
		KILL_PROJECTILE = 29,
		PLAYER_PVP_CHANGE = 30,
		OPEN_CHEST = 31,
		CHEST_ITEM = 32,
		PLAYER_CHEST_UPDATE = 33,
		KILL_TILE = 34,
		HEAL_PLAYER = 35,
		ENTER_ZONE = 36,
		PASSWORD_REQUEST = 37,
		PASSWORD_RESPONSE = 38,
		ITEM_OWNER_UPDATE = 39,
		NPC_TALK = 40,
		PLAYER_BALLSWING = 41,
		PLAYER_MANA_UPDATE = 42,
		PLAYER_USE_MANA_UPDATE = 43,
		KILL_PLAYER_PVP = 44,
		PLAYER_JOIN_PARTY = 45,
		READ_SIGN = 46,
		WRITE_SIGN = 47,
		FLOW_LIQUID = 48,
		SEND_SPAWN = 49,
		PLAYER_BUFFS = 50,
		SUMMON_SKELETRON = 51,
		
		//1.0.6
		CHEST_UNLOCK = 52,
		NPC_ADD_BUFF = 53,
		NPC_BUFFS = 54,
		PLAYER_ADD_BUFF = 55,
		
		//custom
#if TEST_COMPRESSION
		TILE_ROW_COMPRESSED = 240,
		TILE_SQUARE_COMPRESSED = 241,
#endif
		CLIENT_MOD = 254,
	}
}
