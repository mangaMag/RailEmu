using System;
namespace RailEmu.Protocol.Enums
{
	public enum ActionsEnum
	{
		ACTION_ENCAPSULATE_BINARY_COMMAND = 993,
		ACTION_ENDS_TURN = -2,
		ACTION_INTERNAL_SEND_ACTION_BUFFER,
		ACTION_NO_OPERATION,
		ACTION_SEQUENCE_START = 83,
		ACTION_SEQUENCE_END = 70,
		ACTION_CHARACTER_MOVEMENT = 1,
		ACTION_CHARACTER_CHANGE_MAP,
		ACTION_CHARACTER_CHANGE_RESPAWN_MAP,
		ACTION_CHARACTER_TELEPORT_ON_SAME_MAP,
		ACTION_CHARACTER_PUSH,
		ACTION_CHARACTER_PULL,
		ACTION_CHARACTER_DIVORCE_WIFE_OR_HUSBAND,
		ACTION_CHARACTER_EXCHANGE_PLACES,
		ACTION_CHARACTER_DODGE_HIT,
		ACTION_CHARACTER_LEARN_EMOTICON,
		ACTION_CHARACTER_SET_DIRECTION,
		ACTION_CHARACTER_CREATE_GUILD,
		ACTION_USE_PUSHPULL_ELEMENT = 14,
		ACTION_AREA_CHANGE_ALIGNMENT,
		ACTION_AREA_GIVE_KAMAS,
		ACTION_SCRIPT_START,
		ACTION_AREA_DUNGEON_ATTACKED = 20,
		ACTION_GAIN_AREA_KAMAS,
		ACTION_AREA_DUNGEON_CITY_OPENED = 23,
		ACTION_AREA_DUNGEON_HEART_OPENED,
		ACTION_AREA_DUNGEON_HEART_CLOSED,
		ACTION_AREA_CHANGE_ALIGNMENT_SUB,
		ACTION_QUEST_OBJECTIVE_VALIDATE = 30,
		ACTION_QUEST_STEP_VALIDATE,
		ACTION_QUEST_QUEST_VALIDATE,
		ACTION_QUEST_STEP_START,
		ACTION_QUEST_START,
		ACTION_QUEST_CHECK_STARTED_OBJECTIVES,
		ACTION_QUEST_RESET,
		ACTION_START_DIALOG_WITH_NPC = 40,
		ACTION_CARRY_CHARACTER = 50,
		ACTION_THROW_CARRIED_CHARACTER,
		ACTION_NO_MORE_CARRIED,
		ACTION_CHARACTER_MOVEMENT_POINTS_STEAL = 77,
		ACTION_CHARACTER_MOVEMENT_POINTS_WIN,
		ACTION_CHARACTER_MULTIPLY_RECEIVED_DAMAGE_OR_GIVE_LIFE_WITH_RATIO,
		ACTION_CHARACTER_LIFE_POINTS_LOST_FROM_PUSH,
		ACTION_CHARACTER_LIFE_POINTS_WIN_WITHOUT_ELEMENT,
		ACTION_CHARACTER_LIFE_POINTS_STEAL_WITHOUT_BOOST,
		ACTION_CHARACTER_ACTION_POINTS_STEAL = 84,
		ACTION_CHARACTER_LIFE_POINTS_LOST_BASED_ON_CASTER_LIFE_FROM_WATER,
		ACTION_CHARACTER_LIFE_POINTS_LOST_BASED_ON_CASTER_LIFE_FROM_EARTH,
		ACTION_CHARACTER_LIFE_POINTS_LOST_BASED_ON_CASTER_LIFE_FROM_AIR,
		ACTION_CHARACTER_LIFE_POINTS_LOST_BASED_ON_CASTER_LIFE_FROM_FIRE,
		ACTION_CHARACTER_LIFE_POINTS_LOST_BASED_ON_CASTER_LIFE,
		ACTION_CHARACTER_DISPATCH_LIFE_POINTS_PERCENT,
		ACTION_CHARACTER_LIFE_POINTS_STEAL_FROM_WATER,
		ACTION_CHARACTER_LIFE_POINTS_STEAL_FROM_EARTH,
		ACTION_CHARACTER_LIFE_POINTS_STEAL_FROM_AIR,
		ACTION_CHARACTER_LIFE_POINTS_STEAL_FROM_FIRE,
		ACTION_CHARACTER_LIFE_POINTS_STEAL,
		ACTION_CHARACTER_LIFE_POINTS_LOST_FROM_WATER,
		ACTION_CHARACTER_LIFE_POINTS_LOST_FROM_EARTH,
		ACTION_CHARACTER_LIFE_POINTS_LOST_FROM_AIR,
		ACTION_CHARACTER_LIFE_POINTS_LOST_FROM_FIRE,
		ACTION_CHARACTER_LIFE_POINTS_MALUS = 1047,
		ACTION_CHARACTER_LIFE_POINTS_MALUS_PERCENT,
		ACTION_CHARACTER_LIFE_POINTS_LOST = 100,
		ACTION_CHARACTER_ACTION_POINTS_LOST,
		ACTION_CHARACTER_ACTION_POINTS_USE,
		ACTION_CHARACTER_DEATH,
		ACTION_CHARACTER_ACTION_TACKLED,
		ACTION_CHARACTER_LIFE_LOST_MODERATOR,
		ACTION_CHARACTER_LIFE_LOST_CASTER_MODERATOR = 265,
		ACTION_CHARACTER_SPELL_REFLECTOR = 106,
		ACTION_CHARACTER_LIFE_LOST_REFLECTOR,
		ACTION_CHARACTER_LIFE_POINTS_WIN,
		ACTION_CHARACTER_LIFE_POINTS_LOST_CASTER,
		ACTION_CHARACTER_BOOST_LIFE_POINTS,
		ACTION_CHARACTER_BOOST_ACTION_POINTS,
		ACTION_CHARACTER_BOOST_DAMAGES,
		ACTION_CHARACTER_MULTIPLY_DAMAGES = 114,
		ACTION_CHARACTER_BOOST_CRITICAL_HIT,
		ACTION_CHARACTER_DEBOOST_RANGE,
		ACTION_CHARACTER_BOOST_RANGE,
		ACTION_CHARACTER_BOOST_STRENGTH,
		ACTION_CHARACTER_BOOST_AGILITY,
		ACTION_CHARACTER_ACTION_POINTS_WIN,
		ACTION_CHARACTER_BOOST_DAMAGES_FOR_ALL_GAME,
		ACTION_CHARACTER_BOOST_CRITICAL_MISS,
		ACTION_CHARACTER_BOOST_CHANCE,
		ACTION_CHARACTER_BOOST_WISDOM,
		ACTION_CHARACTER_BOOST_VITALITY,
		ACTION_CHARACTER_BOOST_INTELLIGENCE,
		ACTION_CHARACTER_MOVEMENT_POINTS_LOST,
		ACTION_CHARACTER_BOOST_MOVEMENT_POINTS,
		ACTION_CHARACTER_MOVEMENT_POINTS_USE,
		ACTION_CHARACTER_STEAL_GOLD,
		ACTION_CHARACTER_MANA_USE_KILL_LIFE,
		ACTION_CHARACTER_REMOVE_ALL_EFFECTS,
		ACTION_CHARACTER_ACTION_POINTS_LOST_CASTER,
		ACTION_CHARACTER_MOVEMEMT_POINTS_LOST_CASTER,
		ACTION_CHARACTER_DEBOOST_RANGE_CASTER,
		ACTION_CHARACTER_BOOST_RANGE_CASTER,
		ACTION_CHARACTER_BOOST_DAMAGES_CASTER,
		ACTION_CHARACTER_BOOST_DAMAGES_PERCENT,
		ACTION_CHARACTER_DEBOOST_DAMAGES_PERCENT = 186,
		ACTION_CHARACTER_ENERGY_POINTS_WIN = 139,
		ACTION_CHARACTER_PASS_NEXT_TURN,
		ACTION_CHARACTER_KILL,
		ACTION_CHARACTER_BOOST_PHYSICAL_DAMAGES,
		ACTION_CHARACTER_LIFE_POINTS_WIN_WITHOUT_BOOST,
		ACTION_CHARACTER_LIFE_POINTS_LOST_WITHOUT_BOOST,
		ACTION_CHARACTER_DEBOOST_DAMAGES,
		ACTION_CHARACTER_CURSE,
		ACTION_CHARACTER_RESURECT_ALLY_IN_FIGHT,
		ACTION_CHARACTER_ADD_FOLLOWING_CHARACTER,
		ACTION_CHARACTER_MAKE_INVISIBLE = 150,
		ACTION_SPELL_INVISIBLE_OBSTACLE,
		ACTION_CHARACTER_CHANGE_COLOR = 333,
		ACTION_CHARACTER_CHANGE_LOOK = 149,
		ACTION_CHARACTER_ADD_APPEARANCE = 335,
		ACTION_CHARACTER_DEBOOST_CHANCE = 152,
		ACTION_CHARACTER_DEBOOST_VITALITY,
		ACTION_CHARACTER_DEBOOST_AGILITY,
		ACTION_CHARACTER_DEBOOST_INTELLIGENCE,
		ACTION_CHARACTER_DEBOOST_WISDOM,
		ACTION_CHARACTER_DEBOOST_STRENGTH,
		ACTION_CHARACTER_BOOST_MAXIMUM_WEIGHT,
		ACTION_CHARACTER_DEBOOST_MAXIMUM_WEIGHT,
		ACTION_CHARACTER_BOOST_ACTION_POINTS_LOST_DODGE,
		ACTION_CHARACTER_BOOST_MOVEMENT_POINTS_LOST_DODGE,
		ACTION_CHARACTER_DEBOOST_ACTION_POINTS_LOST_DODGE,
		ACTION_CHARACTER_DEBOOST_MOVEMENT_POINTS_LOST_DODGE,
		ACTION_CHARACTER_BOOST_DODGE = 752,
		ACTION_CHARACTER_BOOST_TACKLE,
		ACTION_CHARACTER_DEBOOST_DODGE,
		ACTION_CHARACTER_DEBOOST_TACKLE,
		ACTION_CHARACTER_BOOST_WEAPON_DAMAGE_PERCENT = 165,
		ACTION_CHARACTER_DEBOOST_ACTION_POINTS = 168,
		ACTION_CHARACTER_DEBOOST_MOVEMENT_POINTS,
		ACTION_CHARACTER_LIFE_POINTS_WIN_IN_RP,
		ACTION_CHARACTER_DEBOOST_CRITICAL_HIT,
		ACTION_CHARACTER_DEBOOST_MAGICAL_REDUCTION,
		ACTION_CHARACTER_DEBOOST_PHYSICAL_REDUCTION,
		ACTION_CHARACTER_BOOST_INITIATIVE,
		ACTION_CHARACTER_DEBOOST_INITIATIVE,
		ACTION_CHARACTER_BOOST_MAGIC_FIND,
		ACTION_CHARACTER_DEBOOST_MAGIC_FIND,
		ACTION_CHARACTER_BOOST_HEAL_BONUS,
		ACTION_CHARACTER_DEBOOST_HEAL_BONUS,
		ACTION_CHARACTER_ADD_DOUBLE,
		ACTION_SUMMON_CREATURE,
		ACTION_CHARACTER_BOOST_MAXIMUM_SUMMONED_CREATURES,
		ACTION_CHARACTER_BOOST_MAGICAL_REDUCTION,
		ACTION_CHARACTER_BOOST_PHYSICAL_REDUCTION,
		ACTION_SUMMON_STATIC_CREATURE,
		ACTION_CHARACTER_ALIGNMENT_RANK_SET = 187,
		ACTION_CHARACTER_ALIGNMENT_SIDE_SET,
		ACTION_CHARACTER_ALIGNMENT_VALUE_SET,
		ACTION_CHARACTER_ALIGNMENT_VALUE_MODIFICATION,
		ACTION_CHARACTER_INVENTORY_CLEAR,
		ACTION_CHARACTER_INVENTORY_REMOVE_ITEM,
		ACTION_CHARACTER_INVENTORY_ADD_ITEM,
		ACTION_CHARACTER_INVENTORY_ADD_ITEM_NOCHECK = 209,
		ACTION_CHARACTER_INVENTORY_ADD_ITEM_RANDOM_NOCHECK = 221,
		ACTION_CHARACTER_INVENTORY_ADD_ITEM_FROM_RANDOM_DROP,
		ACTION_CHARACTER_INVENTORY_GAIN_KAMAS = 194,
		ACTION_CHARACTER_INVENTORY_LOSE_KAMAS,
		ACTION_CHARACTER_OPEN_MY_STORAGE,
		ACTION_CHARACTER_TRANSFORM,
		ACTION_CHARACTER_CLEAR_ALL_JOB,
		ACTION_CHARACTER_REPAIR_OBJECT,
		ACTION_CHARACTER_INVENTORY_ADD_ITEM_ON_RP_MAP = 232,
		ACTION_CHARACTER_INVENTORY_REMOVE_ITEM_ON_RP_MAP,
		ACTION_DECORS_PLAY_OBJECT_ANIMATION = 200,
		ACTION_DECORS_ADD_OBJECT,
		ACTION_DECORS_REVEAL_UNVISIBLE,
		ACTION_DECORS_OBSTACLE_CLOSE,
		ACTION_DECORS_OBSTACLE_OPEN,
		ACTION_CHARACTER_CHANGE_RESTRICTION,
		ACTION_CHARACTER_RESURRECTION,
		ACTION_COLLECT_RESOURCE,
		ACTION_DECORS_PLAY_ANIMATION,
		ACTION_DECORS_PLAY_ANIMATION_UNLIGHTED = 228,
		ACTION_CHARACTER_BOOST_EARTH_ELEMENT_PERCENT = 210,
		ACTION_CHARACTER_BOOST_WATER_ELEMENT_PERCENT,
		ACTION_CHARACTER_BOOST_AIR_ELEMENT_PERCENT,
		ACTION_CHARACTER_BOOST_FIRE_ELEMENT_PERCENT,
		ACTION_CHARACTER_BOOST_NEUTRAL_ELEMENT_PERCENT,
		ACTION_CHARACTER_DEBOOST_EARTH_ELEMENT_PERCENT,
		ACTION_CHARACTER_DEBOOST_WATER_ELEMENT_PERCENT,
		ACTION_CHARACTER_DEBOOST_AIR_ELEMENT_PERCENT,
		ACTION_CHARACTER_DEBOOST_FIRE_ELEMENT_PERCENT,
		ACTION_CHARACTER_DEBOOST_NEUTRAL_ELEMENT_PERCENT,
		ACTION_CHARACTER_REFLECTOR_UNBOOSTED,
		ACTION_DECORS_OBSTACLE_CLOSE_RANDOM = 223,
		ACTION_DECORS_OBSTACLE_OPEN_RANDOM,
		ACTION_CHARACTER_BOOST_TRAP,
		ACTION_CHARACTER_BOOST_TRAP_PERCENT,
		ACTION_CHARACTER_GAIN_RIDE = 229,
		ACTION_CHARACTER_ENERGY_LOSS_BOOST,
		ACTION_CHARACTER_ENERGY_POINTS_LOOSE,
		ACTION_CHARACTER_BOOST_EARTH_ELEMENT_RESIST = 240,
		ACTION_CHARACTER_BOOST_WATER_ELEMENT_RESIST,
		ACTION_CHARACTER_BOOST_AIR_ELEMENT_RESIST,
		ACTION_CHARACTER_BOOST_FIRE_ELEMENT_RESIST,
		ACTION_CHARACTER_BOOST_NEUTRAL_ELEMENT_RESIST,
		ACTION_CHARACTER_DEBOOST_EARTH_ELEMENT_RESIST,
		ACTION_CHARACTER_DEBOOST_WATER_ELEMENT_RESIST,
		ACTION_CHARACTER_DEBOOST_AIR_ELEMENT_RESIST,
		ACTION_CHARACTER_DEBOOST_FIRE_ELEMENT_RESIST,
		ACTION_CHARACTER_DEBOOST_NEUTRAL_ELEMENT_RESIST,
		ACTION_CHARACTER_BOOST_EARTH_ELEMENT_PVP_PERCENT,
		ACTION_CHARACTER_BOOST_WATER_ELEMENT_PVP_PERCENT,
		ACTION_CHARACTER_BOOST_AIR_ELEMENT_PVP_PERCENT,
		ACTION_CHARACTER_BOOST_FIRE_ELEMENT_PVP_PERCENT,
		ACTION_CHARACTER_BOOST_NEUTRAL_ELEMENT_PVP_PERCENT,
		ACTION_CHARACTER_DEBOOST_EARTH_ELEMENT_PVP_PERCENT,
		ACTION_CHARACTER_DEBOOST_WATER_ELEMENT_PVP_PERCENT,
		ACTION_CHARACTER_DEBOOST_AIR_ELEMENT_PVP_PERCENT,
		ACTION_CHARACTER_DEBOOST_FIRE_ELEMENT_PVP_PERCENT,
		ACTION_CHARACTER_DEBOOST_NEUTRAL_ELEMENT_PVP_PERCENT,
		ACTION_CHARACTER_BOOST_EARTH_ELEMENT_PVP_RESIST,
		ACTION_CHARACTER_BOOST_WATER_ELEMENT_PVP_RESIST,
		ACTION_CHARACTER_BOOST_AIR_ELEMENT_PVP_RESIST,
		ACTION_CHARACTER_BOOST_FIRE_ELEMENT_PVP_RESIST,
		ACTION_CHARACTER_BOOST_NEUTRAL_ELEMENT_PVP_RESIST,
		ACTION_CHARACTER_STEAL_CHANCE = 266,
		ACTION_CHARACTER_STEAL_VITALITY,
		ACTION_CHARACTER_STEAL_AGILITY,
		ACTION_CHARACTER_STEAL_INTELLIGENCE,
		ACTION_CHARACTER_STEAL_WISDOM,
		ACTION_CHARACTER_STEAL_STRENGTH,
		ACTION_CHARACTER_LIFE_POINTS_LOST_BASED_ON_CASTER_LIFE_MISSING_FROM_WATER = 275,
		ACTION_CHARACTER_LIFE_POINTS_LOST_BASED_ON_CASTER_LIFE_MISSING_FROM_EARTH,
		ACTION_CHARACTER_LIFE_POINTS_LOST_BASED_ON_CASTER_LIFE_MISSING_FROM_AIR,
		ACTION_CHARACTER_LIFE_POINTS_LOST_BASED_ON_CASTER_LIFE_MISSING_FROM_FIRE,
		ACTION_CHARACTER_LIFE_POINTS_LOST_BASED_ON_CASTER_LIFE_MISSING,
		ACTION_CHARACTER_BOOST_SHIELD_BASED_ON_CASTER_LIFE = 1039,
		ACTION_CHARACTER_BOOST_SHIELD,
		ACTION_CHARACTER_ADD_SPELL_COOLDOWN = 1035,
		ACTION_CHARACTER_REMOVE_SPELL_COOLDOWN,
		ACTION_CHARACTER_UPDATE_BOOST = 515,
		ACTION_CHARACTER_BOOST_DISPELLED = 514,
		ACTION_BOOST_SPELL_RANGE = 281,
		ACTION_BOOST_SPELL_RANGEABLE,
		ACTION_BOOST_SPELL_DMG,
		ACTION_BOOST_SPELL_HEAL,
		ACTION_BOOST_SPELL_AP_COST,
		ACTION_BOOST_SPELL_CAST_INTVL,
		ACTION_BOOST_SPELL_CC,
		ACTION_BOOST_SPELL_CASTOUTLINE,
		ACTION_BOOST_SPELL_NOLINEOFSIGHT,
		ACTION_BOOST_SPELL_MAXPERTURN,
		ACTION_BOOST_SPELL_MAXPERTARGET,
		ACTION_BOOST_SPELL_CAST_INTVL_SET,
		ACTION_BOOST_SPELL_BASE_DMG,
		ACTION_DEBOOST_SPELL_RANGE,
		ACTION_FIGHT_CAST_SPELL = 300,
		ACTION_FIGHT_CAST_SPELL_CRITICAL_HIT,
		ACTION_FIGHT_CAST_SPELL_CRITICAL_MISS,
		ACTION_FIGHT_CLOSE_COMBAT,
		ACTION_FIGHT_CLOSE_COMBAT_CRITICAL_HIT,
		ACTION_FIGHT_CLOSE_COMBAT_CRITICAL_MISS,
		ACTION_FIGHT_TRIGGER_TRAP,
		ACTION_FIGHT_TRIGGER_GLYPH,
		ACTION_FIGHT_SPELL_DODGED_PA,
		ACTION_FIGHT_SPELL_DODGED_PM,
		ACTION_CHARACTER_STEAL_RANGE = 320,
		ACTION_FIGHT_ADD_TRAP_CASTING_SPELL = 400,
		ACTION_FIGHT_ADD_GLYPH_CASTING_SPELL,
		ACTION_FIGHT_ADD_GLYPH_CASTING_SPELL_ENDTURN,
        ACTION_FIGHT_ADD_WALL_CASTING_SPELL,

        ACTION_FIGHT_KILL_AND_SUMMON = 405,
		ACTION_INTERACTIVE_ELEMENT = 500,
		ACTION_SKILL_ANIMATION,
		ACTION_EXCHANGE_CRAFT_OPEN,
		ACTION_USE_WAYPOINT,
		ACTION_DO_ELEMENT_PARAMETERIZED_OPERATION = 505,
		ACTION_INTERACTIVE_ELEMENT_AT_HOME_INNER_DOOR = 507,
		ACTION_SAVE_WAYPOINT,
		ACTION_CHANGE_COMPASS,
		ACTION_USE_SUBWAY,
		ACTION_EXCHANGE_JOBINDEX_OPEN,
		ACTION_USE_PRISM,
		ACTION_ADD_PRISM,
		ACTION_GOTO_WAYPOINT = 600,
		ACTION_GOTO_MAP,
		ACTION_CHARACTER_LEARN_JOB = 603,
		ACTION_CHARACTER_LEARN_SPELL,
		ACTION_CHARACTER_GAIN_XP,
		ACTION_CHARACTER_GAIN_WISDOM,
		ACTION_CHARACTER_GAIN_STRENGTH,
		ACTION_CHARACTER_GAIN_CHANCE,
		ACTION_CHARACTER_GAIN_AGILITY,
		ACTION_CHARACTER_GAIN_VITALITY,
		ACTION_CHARACTER_GAIN_INTELLIGENCE,
		ACTION_CHARACTER_GAIN_STATS_POINTS,
		ACTION_CHARACTER_GAIN_SPELL_POINTS,
		ACTION_CHARACTER_GAIN_JOB_XP,
		ACTION_CHARACTER_UNLEARN_JOB,
		ACTION_CHARACTER_UNBOOST_SPELL,
		ACTION_CHARACTER_GET_MARRIED,
		ACTION_CHARACTER_GET_MARRIED_ACCEPT,
		ACTION_CHARACTER_GET_MARRIED_DECLINE,
		ACTION_CHARACTER_READ_BOOK,
		ACTION_CHARACTER_SUMMON_MONSTER,
		ACTION_GOTO_HOUSE,
		ACTION_CHARACTER_SUMMON_MONSTER_GROUP,
		ACTION_CHARACTER_SUMMON_MONSTER_GROUP_SET_MAP = 627,
		ACTION_CHARACTER_SUMMON_MONSTER_GROUP_DYNAMIC,
		ACTION_CHARACTER_UNLEARN_GUILDSPELL = 624,
		ACTION_CHARACTER_UNBOOST_CARACS,
		ACTION_CHARACTER_UNBOOST_CARACS_TO_101,
		ACTION_CHARACTER_SEND_INFORMATION_TEXT = 630,
		ACTION_CHARACTER_SEND_DIALOG_ACTION,
		ACTION_CHARACTER_GAIN_HONOUR = 640,
		ACTION_CHARACTER_GAIN_DISHONOUR,
		ACTION_CHARACTER_LOOSE_HONOUR,
		ACTION_CHARACTER_LOOSE_DISHONOUR,
		ACTION_MAP_RESURECTION_ALLIES = 645,
		ACTION_MAP_HEAL_ALLIES,
		ACTION_MAP_FORCE_ENNEMIES_GHOST,
		ACTION_FORCE_ENNEMY_GHOST,
		ACTION_FAKE_ALIGNMENT,
		ACTION_TELEPORT_NOOBY_MAP,
		ACTION_USE_ELEMENT_ACTIONS,
		ACTION_SET_STATED_ELEMENT_STATE,
		ACTION_RESET_STATED_ELEMENT,
		ACTION_HOUSE_LEAVE,
		ACTION_NOOP = 666,
		ACTION_INCARNATION = 669,
		ACTION_CHARACTER_REFERENCEMENT = 699,
		ACTION_ITEM_CHANGE_EFFECT,
		ACTION_ITEM_ADD_EFFECT,
		ACTION_ITEM_ADD_DURABILITY,
		ACTION_CAPTURE_SOUL = 705,
		ACTION_CAPTURE_RIDE,
		ACTION_CHARACTER_ADD_COST_TO_ACTION = 710,
		ACTION_LADDER_SUPERRACE = 715,
		ACTION_LADDER_RACE,
		ACTION_LADDER_ID,
		ACTION_PVP_LADDER = 720,
		ACTION_VICTIM_OF,
		ACTION_GAIN_TEMP_SPELL,
		ACTION_GAIN_AURA,
		ACTION_GAIN_TITLE,
		ACTION_CHARACTER_RENAME_GUILD,
		ACTION_TELEPORT_NEAREST_PRISM = 730,
		ACTION_AUTO_AGGRESS_ENEMY_PLAYER,
		ACTION_SHUSHU_STACK_RUNE = 742,
		ACTION_BOOST_SOUL_CAPTURE_BONUS = 750,
		ACTION_BOOST_RIDE_XP_BONUS,
		ACTION_REMOVE_ON_MOVE = 760,
		ACTION_CHARACTER_SACRIFY = 765,
		ACTION_HOURLY_CONFUSION_DEGREE = 770,
		ACTION_HOURLY_CONFUSION_PI_2,
		ACTION_HOURLY_CONFUSION_PI_4,
		ACTION_UNHOURLY_CONFUSION_DEGREE,
		ACTION_UNHOURLY_CONFUSION_PI_2,
		ACTION_UNHOURLY_CONFUSION_PI_4,
		ACTION_CHARACTER_BOOST_PERMANENT_DAMAGE_PERCENT,
		ACTION_CHARACTER_SUMMON_DEAD_ALLY_IN_FIGHT = 780,
		ACTION_CHARACTER_UNLUCKY,
		ACTION_CHARACTER_MAXIMIZE_ROLL,
		ACTION_CHARACTER_WALK_FOUR_DIR = 785,
		ACTION_FIND_BOUNTY_TARGET = 790,
		ACTION_MARK_TARGET_MERCENARY,
		ACTION_ITEM_CHANGE_PETS_LIFE = 800,
		ACTION_ITEM_CHANGE_DURATION = 805,
		ACTION_ITEM_PETS_SHAPE,
		ACTION_ITEM_PETS_EAT,
		ACTION_PETS_LAST_MEAL,
		ACTION_ITEM_CHANGE_DURABILITY = 812,
		ACTION_ITEM_UPDATE_DATE,
		ACTION_ITEM_CHOOSE_IN_ITEM_LIST = 820,
		ACTION_CLIENT_OPEN_UI = 830,
		PARAM_CLIENT_OPEN_UI_GUILD_TELEPORT_HOUSE = 1,
		PARAM_CLIENT_OPEN_UI_GUILD_TELEPORT_FARM,
		ACTION_CLIENT_OPEN_UI_SPELL_FORGET = 831,
		ACTION_FIGHT_TURN_FINISHED = 899,
		ACTION_FIGHT_CHALLENGE,
		ACTION_FIGHT_CHALLENGE_ACCEPT,
		ACTION_FIGHT_CHALLENGE_DECLINE,
		ACTION_FIGHT_CHALLENGE_JOIN,
		ACTION_FIGHT_CHALLENGE_AGAINST_MONSTER = 905,
		ACTION_FIGHT_AGGRESSION,
		ACTION_FIGHT_AGAINST_TAXCOLLECTOR = 909,
		ACTION_FIGHT_CHALLENGE_AGAINST_MUTANT,
		ACTION_FIGHT_CHALLENGE_MIXED_VERSUS_MONSTER,
		ACTION_FIGHT_AGAINST_PRISM,
		ACTION_TOOLTIP_ACTIVATE_TIP = 915,
		ACTION_PNJ_REMOVE_RIDE = 938,
		ACTION_PET_SET_POWER_BOOST,
		ACTION_FARM_WITHDRAW_ITEM = 947,
		ACTION_FARM_PLACE_ITEM,
		ACTION_MOUNT_RIDE,
		ACTION_FIGHT_SET_STATE,
		ACTION_FIGHT_UNSET_STATE,
		ACTION_CREATED_SINCE = 963,
		ACTION_SHOW_PLAYERNAME,
		ACTION_BOOST_GLOBAL_RESISTS_BONUS = 1076,
		ACTION_BOOST_GLOBAL_RESISTS_MALUS
	}
}
